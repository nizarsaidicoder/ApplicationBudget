using ApplicationBudget.Pages.Evenements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget.Pages.Participants
{
    public partial class AjouterParticipant : UserControl
    {
        private DataTable events;
        public BindingSource bs = new BindingSource();
        HashSet<int> newinvites = new HashSet<int>();
        HashSet<int> alreadyInvited = new HashSet<int>();
        HashSet<int> NotInvited = new HashSet<int>();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private int radius = 20;
        public AjouterParticipant()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
            events = frmMain.localDataSet.Tables["Events"];
            SetupDataBindings();
        }

        private void SetupDataBindings()
        {
            try
            {
                bs.DataSource = events;
                cboEvenements.DataSource = bs;
                cboEvenements.DisplayMember = "titreEvent";
                cboEvenements.ValueMember = "codeEvent";
                // Clear any existing data bindings
                lblTitre.DataBindings.Clear();
                lblOrganisateur.DataBindings.Clear();
                lblDateDebut.DataBindings.Clear();
                lblDateFin.DataBindings.Clear();

                // Add new data bindings
                lblTitre.DataBindings.Add("Text", bs, "titreEvent");
                lblOrganisateur.DataBindings.Add("Text", bs, "participant");
                lblDateDebut.DataBindings.Add("Text", bs, "dateDebut");
                lblDateFin.DataBindings.Add("Text", bs, "dateFin");
                bs.PositionChanged += Bs_PositionChanged;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error during data binding: {ex.Message}");
            }
        }
        private void Bs_PositionChanged(object sender, EventArgs e)
        {
            UpdateSoldeVisibility();
        }
        private void UpdateSoldeVisibility()
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                int soldeON = Convert.ToInt32(drv["soldeON"]);
                lblSolde.Visible = soldeON == 1;
            }
        }

        private void btnAjoutParticipant_Click(object sender, EventArgs e)
        {
            alreadyInvited.Clear();
            newinvites.Clear();
            NotInvited.Clear();
            string query = "SELECT codePart From Invites where codeEvent = " + cboEvenements.SelectedValue;

            SQLiteCommand cm = new SQLiteCommand();
            cm.Connection = frmMain.connection;
            cm.CommandText = query;
            try
            {
                frmMain.connection.Open();
                SQLiteDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    alreadyInvited.Add(dr.GetInt32(0));
                    newinvites.Add(dr.GetInt32(0));
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                frmMain.connection.Close();
            }

            bool fermer = true;
            frmAjouterParticipantEvent ajoutParticipants = new frmAjouterParticipantEvent("Evenement", newinvites);
            if (ajoutParticipants.ShowDialog() == DialogResult.OK)
            {
                newinvites = ajoutParticipants.addedParticipants;
                NotInvited = ajoutParticipants.nonAddedPart;
                fermer = false;
            }

            if (fermer)
            {
                return;
            }

            foreach (int var in newinvites)
            {
                if (!alreadyInvited.Contains(var))
                {
                    string loginMdp = generateLoginAndPasswordFromId(var);
                    ajouterInvite(Convert.ToInt32(cboEvenements.SelectedValue), var, loginMdp, loginMdp);
                }
            }

            foreach (int var in NotInvited)
            {
                if (alreadyInvited.Contains(var))
                {
                    supprimerInvite(Convert.ToInt32(cboEvenements.SelectedValue), var);
                }
            }

            //frmMain.ChargementDsLocal(frmMain.connection, frmMain.localDataSet);
            //frmMain.LoadData();
        }

        private void cboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetupDataBindings();
        }

        public string generateLoginAndPasswordFromId(int codePart)
        {
            string login = "";
            string query = "SELECT prenomPart FROM Participants where codeParticipant = '" + codePart + "';";

            SQLiteCommand cm = new SQLiteCommand();
            cm.Connection = frmMain.connection;
            cm.CommandText = query;
            try
            {

                frmMain.connection.Open();
                login = Convert.ToString(cm.ExecuteScalar());

                query = "SELECT nomPart FROM Participants where codeParticipant = '" + codePart + "';";
                login = login[0] + Convert.ToString(cm.ExecuteScalar());
                return login;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                frmMain.connection.Close();
            }
            return null;
        }

        public void ajouterInvite(int codeEvent, int codePart, string login, string mdp)
        {
            SQLiteCommand cm = new SQLiteCommand();

            cm.Connection = frmMain.connection;
            try
            {
                //Recuperation du code Orga
                frmMain.connection.Open();

                string query = "INSERT INTO Invites(codeEvent, codePart, login, mdp) VALUES (";
                query += $"'{codeEvent}', '{codePart}', '{login}', '{mdp}');";
                cm.CommandText = query;
                cm.ExecuteNonQuery();

                //frmMain.ChargementDsLocal(frmMain.connection, frmMain.localDataSet);
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                frmMain.connection.Close();
            }

        }

        public void supprimerInvite(int codeEvent, int codePart)
        {
            SQLiteCommand cm = new SQLiteCommand();

            cm.Connection = frmMain.connection;
            try
            {
                //Recuperation du code Orga
                frmMain.connection.Open();

                string query = "DELETE FROM Invites WHERE ";
                query += $"codeEvent={codeEvent} AND codePart={codePart};";
                cm.CommandText = query;
                cm.ExecuteNonQuery();

                //frmMain.ChargementDsLocal(frmMain.connection, frmMain.localDataSet);
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                frmMain.connection.Close();
            }
            //frmMain.ChargementDsLocal(frmMain.connection, frmMain.localDataSet);
            //frmMain.LoadData();
        }
    }
}