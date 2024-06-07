using ApplicationBudget.Pages.Evenements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget
{
    public partial class AjouterDepense : UserControl
    {
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
        HashSet<int> beneficiaires = new HashSet<int>();
        public AjouterDepense()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
            touslesChampsSaisis();
        }

        private void AjouterDepense_Load(object sender, EventArgs e)
        {
            dateDepense.Format = DateTimePickerFormat.Short;
            frmMain.ChargementCboDeco(cboEvenements, "Evenements", "titreEvent", "codeEvent", frmMain.localDataSet);
            frmMain.ChargementCboDeco(cboCategories, "Categories", "nomCateg", "codeCateg", frmMain.localDataSet);
            frmMain.ChargementCboDeco(cboPayant, "Participants", "nomPart", "codeParticipant", frmMain.localDataSet);
            cboEvenements.SelectedIndex = -1;
            cboCategories.SelectedIndex = -1;
            cboPayant.SelectedIndex = -1;
        }

        private void btnBeneficiaires_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboEvenements.SelectedValue.ToString());
            frmAjouterParticipantDepense ajoutParticipants = new frmAjouterParticipantDepense(Convert.ToInt32(cboEvenements.SelectedValue), txtDepense.Text, Convert.ToInt32(cboPayant.SelectedValue), beneficiaires);
            if (ajoutParticipants.ShowDialog() == DialogResult.OK)
            {
                beneficiaires = ajoutParticipants.addedParticipants;
            }

            touslesChampsSaisis();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (touslesChampsSaisis())
            {
                try
                {
                    frmMain.connection.Open();

                    //MessageBox.Show(FrmMain.connec.State.ToString());

                    //requete SQL
                    DateTime time = dateDepense.Value;
                    String formatedDate = $"{time.Year}-{time.Month.ToString().PadLeft(2, '0')}-{time.Day.ToString().PadLeft(2, '0')}";
                    String requete = $"INSERT INTO Depenses(description, montant, dateDepense, commentaire, codeEvent, codePart)" +
                        $" VALUES ('{txtDepense.Text}', {txtMontant.Text}, {formatedDate}, '{txtDescription.Text}', {cboEvenements.SelectedValue}, {cboPayant.SelectedValue})";

                    //paramétrage objet 'Command'
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = frmMain.connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = requete;

                    cmd.ExecuteNonQuery();

                    //récupération numDepense
                    cmd.CommandText = $"SELECT numDepense FROM Depenses" +
                        $" WHERE description = '{txtDepense.Text}' AND codeEvent = {cboEvenements.SelectedValue} AND codePart = {cboPayant.SelectedValue} AND montant = {txtMontant.Text} AND dateDepense = {formatedDate}";
                    int numDepense = Convert.ToInt32(cmd.ExecuteScalar());

                    //maj DataSet
                    DataRow ajoutDepense = frmMain.localDataSet.Tables["Depenses"].NewRow();
                    ajoutDepense["numDepense"] = numDepense;
                    ajoutDepense["description"] = txtDepense.Text;
                    ajoutDepense["dateDepense"] = formatedDate;
                    ajoutDepense["commentaire"] = txtDescription.Text;
                    ajoutDepense["codeEvent"] = cboEvenements.SelectedValue;
                    ajoutDepense["codePart"] = cboPayant.SelectedValue;
                    frmMain.localDataSet.Tables["Depenses"].Rows.Add(ajoutDepense);

                    //ajout catégorie dépenses
                    cmd.CommandText = $"INSERT INTO CategDepense VALUES({numDepense}, {cboCategories.SelectedValue})";
                    cmd.ExecuteNonQuery();

                    //maj DataSet
                    DataRow ajoutCategorie = frmMain.localDataSet.Tables["CategDepense"].NewRow();
                    ajoutCategorie["numDepense"] = numDepense;
                    ajoutCategorie["codeCateg"] = cboCategories.SelectedValue;
                    frmMain.localDataSet.Tables["CategDepense"].Rows.Add(ajoutCategorie);

                    //ajout bénéficiaires 
                    foreach (int part in beneficiaires)
                    {
                        cmd.CommandText = $"INSERT INTO Beneficiaires VALUES({numDepense}, {part})";
                        cmd.ExecuteNonQuery();

                        //maj DataSet
                        DataRow ajoutBeneficiaire = frmMain.localDataSet.Tables["Beneficiaires"].NewRow();
                        ajoutBeneficiaire["numDepense"] = numDepense;
                        ajoutBeneficiaire["codePart"] = part;
                        frmMain.localDataSet.Tables["Beneficiaires"].Rows.Add(ajoutBeneficiaire);
                    }

                    frmPopup confirmation = new frmPopup("La dépense a été ajouter avec succès", MessageType.Done);
                    confirmation.ShowDialog();

                    Clear();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("BtnAjouter_Click : " + ex.ToString());
                    frmPopup confirmation = new frmPopup($"Une erreur est survenue : {ex.Message}", MessageType.Error);
                    confirmation.ShowDialog();
                }
                finally
                {
                    frmMain.connection.Close();

                }

            }

        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

            touslesChampsSaisis();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public bool touslesChampsSaisis()
        {
            if (cboEvenements.SelectedIndex != -1 && cboPayant.SelectedIndex != -1 && cboCategories.SelectedIndex != -1 && txtDepense.Text != String.Empty && txtMontant.Text != String.Empty)
            {
                //117, 139, 253
                btnAjouter.BackColor = Color.FromArgb(117, 139, 253);
                return true;
            }

            btnAjouter.BackColor = Color.FromArgb(224, 224, 224);
            return false;
        }

        public void Clear()
        {
            txtDepense.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtMontant.Text = string.Empty;
            frmMain.ChargementCboDeco(cboEvenements, "Evenements", "titreEvent", "codeEvent", frmMain.localDataSet);
            frmMain.ChargementCboDeco(cboCategories, "Categories", "nomCateg", "codeCateg", frmMain.localDataSet);
            frmMain.ChargementCboDeco(cboPayant, "Participants", "nomPart", "codeParticipant", frmMain.localDataSet);
            cboEvenements.SelectedIndex = -1;
            cboCategories.SelectedIndex = -1;
            cboPayant.SelectedIndex = -1;
            btnAjouter.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void cboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            touslesChampsSaisis();
        }

        private void cboPayant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            touslesChampsSaisis();
        }

        private void txtDepense_KeyPress(object sender, KeyPressEventArgs e)
        {
            touslesChampsSaisis();
        }

        private void cboCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            touslesChampsSaisis();
        }
    }
}