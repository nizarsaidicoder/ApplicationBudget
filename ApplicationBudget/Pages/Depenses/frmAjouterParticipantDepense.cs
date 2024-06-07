using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SQLite;
using ApplicationBudget.Pages.Evenements;

namespace ApplicationBudget
{
    public partial class frmAjouterParticipantDepense : Form
    {

        private string cnxString = frmMain.cnxString;
        private SQLiteConnection cnx = frmMain.connection;
        public HashSet<int> addedParticipants;
        public int codeEvent;
        public int participant;
        public frmAjouterParticipantDepense(int codeEvent, string nomDepense, int participant, HashSet<int> addedParticipants)
        {
            InitializeComponent();
            this.addedParticipants = addedParticipants;
            lblTitre.Text = nomDepense;
            this.codeEvent = codeEvent;
            this.participant = participant;
            cnx = new SQLiteConnection(cnxString);
            LoadBeneficiares();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Charge les participants de l'événement
        /// </summary>
        private void LoadBeneficiares()
        {
            try
            {
                cnx.Open();
                string query = $@"SELECT p.codeParticipant, p.nomPart || ' ' || p.prenomPart as participant, p.mobile
                              FROM Participants p JOIN Invites i ON p.codeParticipant = i.codePart
                              WHERE codeEvent = {codeEvent} AND codePart != {participant}";
                SQLiteCommand cmd = new SQLiteCommand(query, cnx);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string phone = reader.GetString(2);
                    bool isAdded = false;
                    foreach (int addedId in addedParticipants)
                    {
                        if (id == addedId)
                        {
                            isAdded = true;
                        }
                    }
                    Participant participant = new Participant(id, name, phone, isAdded);
                    participant.Dock = DockStyle.Top;
                    panelBeneficiaires.Controls.Add(participant);

                }
            }
            catch (Exception ex)
            {
                frmPopup frmPopup = new frmPopup("Erreur lors du chargement des participants", MessageType.Error);
                frmPopup.ShowDialog();
            }
            finally
            {
                cnx.Close();
            }
        }

        private void btnAjouterTout_Click(object sender, EventArgs e)
        {
            foreach (Participant participant in panelBeneficiaires.Controls)
            {
                participant.UpdateStatus(true);
            }
        }

        private void btnDeselectionnerTout_Click(object sender, EventArgs e)
        {
            foreach (Participant participant in panelBeneficiaires.Controls)
            {
                participant.UpdateStatus(false);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            foreach (Participant participant in panelBeneficiaires.Controls)
            {
                if (participant.isAdded)
                {
                    this.addedParticipants.Add(participant.id);
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}