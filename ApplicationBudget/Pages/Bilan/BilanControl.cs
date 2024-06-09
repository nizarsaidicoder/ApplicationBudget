using ApplicationBudget.Pages.Bilan;
using ApplicationBudget.Pages.Evenements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget
{
    public partial class BilanControl : UserControl
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
        public double totalDepense;

        public BilanControl()
        {
            InitializeComponent();
            panelDepenses.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDepenses.Width, panelDepenses.Height, radius, radius));
            panelDepensesItems.AutoScroll = true;
            panelRemboursements.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelRemboursements.Width, panelRemboursements.Height, radius, radius));
            panelRemboursementsItems.AutoScroll = true;
        }


        private void BilanControl_Load(object sender, EventArgs e)
        {
            frmMain.ChargementCboDeco(cboEvents, "Evenements", "titreEvent", "codeEvent", frmMain.localDataSet);
            frmMain.ChargementCboDeco(cboParticipants, "Participants", "nomPart", "codeParticipant", frmMain.localDataSet);
            panelCombos.Width = 492;

            panelCombos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCombos.Width, panelCombos.Height, radius, radius));
            panelDepenses.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDepenses.Width, panelDepenses.Height, radius, radius));
            panelRemboursements.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelRemboursements.Width, panelRemboursements.Height, radius, radius));
            panelDepensesContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDepensesContainer.Width, panelDepensesContainer.Height, radius, radius));
            panelRefundContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelRefundContainer.Width, panelRefundContainer.Height, radius, radius));


            cboEvents.SelectedIndex = -1;
            cboParticipants.SelectedIndex = -1;

            //DepensesQuiMeConcernent(frmMain.localDataSet, 1, 4);
        }

        public DataTable MesDepenses(DataSet ds, int participant, int evenement)
        {
            DataTable table = new DataTable();

            try
            {
                DataRow[] dr = ds.Tables["CategDepensePart"].Select($"codeEvent = {evenement} AND codePart = {participant}");
                table = dr.CopyToDataTable();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("ex.Message");
            }
            return table;
        }

        public DataTable RecapDepenses(DataSet ds, int evenement)
        {
            DataTable table = new DataTable();

            try
            {
                DataRow[] dr = ds.Tables["CategDepensePart"].Select($"codeEvent = {evenement}");
                table = dr.CopyToDataTable();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ex.Message");
            }


            return table;
        }

        public DataTable DepensesQuiMeConcernent(int participant, int evenement)
        {
            DataTable table = new DataTable();

            try
            {
                frmMain.connection.Open();

                string req = "SELECT d.codeEvent, d.codePart, d.numDepense, d.montant, SUM(p.nbParts) AS SommeNbParts" +
                    $" FROM Depenses AS d" +
                    $" JOIN Beneficiaires AS b ON d.numDepense = b.numDepense" +
                    $" JOIN Participants AS p ON b.codePart = p.codeParticipant" +
                    $" WHERE d.numDepense IN (SELECT d1.numDepense " +
                                            $"FROM Beneficiaires AS b1 JOIN Depenses d1 ON b1.numDepense = d1.numDepense " +
                                            $"WHERE d1.codeEvent = {evenement} AND b1.codePart = {participant})" +
                    $" GROUP BY d.numDepense, d.montant";
                SQLiteDataAdapter da = new SQLiteDataAdapter(req, frmMain.connection);
                da.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                frmMain.connection.Close();
            }

            return table;
        }

        public void MajDepenses(DataTable dt)
        {
            panelDepensesItems.Controls.Clear();

            Depense depense;
            totalDepense = 0;

            foreach (DataRow row in dt.Rows)
            {
                depense = new Depense(row["description"].ToString(), row["nomPart"].ToString(), row["dateDepense"].ToString(), "Divers" ,Convert.ToDouble(row["montant"]));
                depense.Dock = DockStyle.Top;
                panelDepensesItems.Controls.Add(depense);

                //total
                totalDepense += Convert.ToDouble(row["montant"]);
            }

            totalDepenses.Text = $"Total : {totalDepense} €";
        }

        public DataTable CalculRemboursement(int evenement)
        {
            DataTable dtBilan = new DataTable();

            dtBilan.Columns.Add("CodeParticipant");
            dtBilan.Columns.Add("Personne");
            dtBilan.Columns.Add("Plus");
            dtBilan.Columns.Add("Moins");
            dtBilan.Columns.Add("Solde");

            dtBilan.PrimaryKey = new DataColumn[] { dtBilan.Columns["codeParticipant"] };


            DataSet ds = frmMain.localDataSet;

            //récupération de tous les participants de l'événement
            DataRow[] dr = ds.Tables["Invites"].Select($"codeEvent = {evenement}");
            try
            {
                DataTable tableParticipants = dr.CopyToDataTable();

                foreach (DataRow row in tableParticipants.Rows)
                {
                    if (!dtBilan.Rows.Contains(row["CodePart"]))
                    {
                        DataRow ajoutPart = dtBilan.NewRow();
                        ajoutPart["CodeParticipant"] = row["CodePart"];
                        //ajoutPart["Personne"] = row["nomPart"];
                        ajoutPart["Plus"] = 0;
                        ajoutPart["Moins"] = 0;
                        ajoutPart["Solde"] = 0;
                        dtBilan.Rows.Add(ajoutPart);
                    }
                    DepensesCredit(evenement, Convert.ToInt32(row["codePart"]), dtBilan);
                    DepensesDebit(evenement, Convert.ToInt32(row["codePart"]), dtBilan);
                }

                foreach (DataRow row in dtBilan.Rows)
                {
                    row["Solde"] = Convert.ToDouble(row["Plus"]) - Convert.ToDouble(row["Moins"]);
                }

                for (int i = 0; i < dtBilan.Rows.Count; i++)
                {
                    int donneur = IndexMin(dtBilan);
                    int receveur = IndexMax(dtBilan);

                    double montantMin = Convert.ToDouble(dtBilan.Rows[donneur]["Solde"]);
                    double montantMax = Convert.ToDouble(dtBilan.Rows[receveur]["Solde"]);

                    int codeDonneur = Convert.ToInt32(dtBilan.Rows[donneur]["CodeParticipant"]);
                    int codeReceveur = Convert.ToInt32(dtBilan.Rows[receveur]["CodeParticipant"]);

                    if (Math.Abs(montantMin) > montantMax)
                    {
                        dtBilan.Rows[donneur]["Solde"] = montantMin + montantMax;
                        dtBilan.Rows[receveur]["Solde"] = 0;
                        if (montantMax != 0.0)
                        {
                            if (!RemboursementEffectuer(evenement, codeDonneur, codeReceveur))
                            {
                                MajBilanPart(evenement, codeDonneur, codeReceveur, Math.Abs(montantMax));
                            }
                        }
                    }
                    else
                    {
                        dtBilan.Rows[receveur]["Solde"] = montantMin + montantMax;
                        dtBilan.Rows[donneur]["Solde"] = 0;
                        if (montantMin != 0.0)
                        {
                            if (!RemboursementEffectuer(evenement, codeDonneur, codeReceveur))
                            {
                                MajBilanPart(evenement, codeDonneur, codeReceveur, Math.Abs(montantMin));
                            }
                        }
                    }

                    //dgvTest.DataSource = dtBilan;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("CalculRemboursement : " + ex.ToString());
                frmPopup confirmation = new frmPopup("Une erreur est survenue", MessageType.Error);
                confirmation.ShowDialog();
            }
            return dtBilan;
        }

        public bool RemboursementEffectuer(int evenement, int codeDonneur, int codeReceveur)
        {
            foreach (DataRow row in frmMain.localDataSet.Tables["BilanPart"].Rows)
            {
                if (Convert.ToInt32(row["codeEvent"]) == evenement && Convert.ToInt32(row["codeDonneur"]) == codeDonneur && Convert.ToInt32(row["codeReceveur"]) == codeReceveur)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexMin(DataTable dt)
        {
            double montantMin = Convert.ToDouble(dt.Rows[0]["Solde"]);
            double montant;
            int index = 0;
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                montant = Convert.ToDouble(dt.Rows[i]["Solde"]);
                if (montant < montantMin)
                {
                    montantMin = montant;
                    index = i;
                }
            }

            return index;
        }

        public int IndexMax(DataTable dt)
        {
            double montantMax = Convert.ToDouble(dt.Rows[0]["Solde"]);
            double montant;
            int index = 0;
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                montant = Convert.ToDouble(dt.Rows[i]["Solde"]);
                if (montant > montantMax)
                {
                    montantMax = montant;
                    index = i;
                }
            }

            return index;
        }

        public void MajBilanPart(int codeEvent, int donneur, int receveur, double montant)
        {
            try
            {
                frmMain.connection.Open();

                //requete SQL
                String requete = $"INSERT INTO BilanPart VALUES ({codeEvent}, {donneur}, {receveur}, {montant.ToString("F", CultureInfo.InvariantCulture)})";
                //paramétrage objet 'Command'
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = frmMain.connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = requete;

                cmd.ExecuteNonQuery();

                //maj DataSet
                DataRow ajoutRemboursement = frmMain.localDataSet.Tables["BilanPart"].NewRow();
                ajoutRemboursement["codeEvent"] = codeEvent;
                ajoutRemboursement["codeDonneur"] = donneur;
                ajoutRemboursement["codeReceveur"] = receveur;
                ajoutRemboursement["montant"] = montant;
                frmMain.localDataSet.Tables["BilanPart"].Rows.Add(ajoutRemboursement);

            }
            catch (Exception ex)
            {
                //MessageBox.Show("BtnAjouter_Click : " + ex.ToString());
                frmPopup confirmation = new frmPopup("Une erreur est survenue", MessageType.Error);
                confirmation.ShowDialog();
            }
            finally
            {
                frmMain.connection.Close();
            }
        }

        public void DepensesCredit(int evenement, int participant, DataTable bilan)
        {
            DataTable dt = MesDepenses(frmMain.localDataSet, participant, evenement);

            foreach (DataRow row in dt.Rows)
            {
                double montant = Convert.ToDouble(row["montant"]);
                int part = Convert.ToInt32(row["codePart"]);

                for (int i = 0; i < bilan.Rows.Count; i++)
                {
                    if (Convert.ToInt32(bilan.Rows[i]["codeParticipant"]) == part)
                    {
                        double ancienmontant = Convert.ToDouble(bilan.Rows[i]["Plus"]);
                        //on ajoute la dépense
                        bilan.Rows[i]["Plus"] = ancienmontant + montant;
                    }
                }
            }

        }

        public void DepensesDebit(int evenement, int participant, DataTable bilan)
        {
            DataTable dt = DepensesQuiMeConcernent(participant, evenement);

            //dgvTest.DataSource = dt;

            foreach (DataRow row in dt.Rows)
            {
                double montant = Convert.ToDouble(row["montant"]);
                int nbPartsTotal = Convert.ToInt32(row["SommeNbParts"]);
                int nbPart = Convert.ToInt32(frmMain.localDataSet.Tables["Participants"].Rows[participant - 1]["nbParts"]);


                for (int i = 0; i < bilan.Rows.Count; i++)
                {
                    if (Convert.ToInt32(bilan.Rows[i]["codeParticipant"]) == participant && bilan.Rows[i]["codeParticipant"] != row["codePart"])
                    {
                        double ancienmontant = Convert.ToDouble(bilan.Rows[i]["Moins"]);
                        montant = (montant / (double)nbPartsTotal) * nbPart;
                        bilan.Rows[i]["Moins"] = ancienmontant + montant;
                    }
                }

            }
        }

        public void MajRemboursement(DataTable dt, int evenement, int participant)
        {
            panelRemboursementsItems.Controls.Clear();

            Depense depense;
            totalDepense = 0;

            foreach (DataRow row in dt.Rows)
            {
                int codeEvenement = Convert.ToInt32(row["CodeEvent"]);
                int codeDonneur = Convert.ToInt32(row["CodeDonneur"]);
                int codeReceveur = Convert.ToInt32(row["CodeReceveur"]);

                if (codeEvenement == evenement)
                {
                    if (codeDonneur == participant)
                    {
                        String nomParticipant = RecupNomParticipant(codeReceveur);
                        depense = new Depense("Remboursement à ", nomParticipant, "", "Divers" ,Math.Abs(Convert.ToDouble(row["montant"])));

                        depense.Dock = DockStyle.Top;
                        panelRemboursementsItems.Controls.Add(depense);
                        //total
                        totalDepense += Math.Abs(Convert.ToDouble(row["montant"]));
                    }

                }
            }

            totalRemboursements.Text = $"Total : {totalDepense} €";
        }

        public String RecupNomParticipant(int participant)
        {
            foreach (DataRow row in frmMain.localDataSet.Tables["Participants"].Rows)
            {
                if (Convert.ToInt32(row["codeParticipant"]) == participant)
                {
                    return $"{row["nomPart"]} {row["prenomPart"]}";
                }
            }

            return "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ClearControls();
            btnEnregistrer.Visible = false;
            btnAnnuler.Visible = false;
            UpdateContainersVisibility();
        }

        private void cboEvents_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboParticipants.SelectedIndex == -1 && cboEvents.SelectedIndex != -1)
            {
                DataTable table = RecapDepenses(frmMain.localDataSet, Convert.ToInt32(cboEvents.SelectedValue));
                MajDepenses(table);

            }
            else if (cboParticipants.SelectedIndex != -1 && cboEvents.SelectedIndex != -1)
            {
                DataTable table = MesDepenses(frmMain.localDataSet, Convert.ToInt32(cboParticipants.SelectedValue), Convert.ToInt32(cboEvents.SelectedValue));
                MajDepenses(table);
            }

            panelRemboursementsItems.Controls.Clear();
            UpdateContainersVisibility();
        }

    private void cboParticipants_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboParticipants.SelectedIndex != -1 && cboEvents.SelectedIndex != -1)
            {
                DataTable table = MesDepenses(frmMain.localDataSet, Convert.ToInt32(cboParticipants.SelectedValue), Convert.ToInt32(cboEvents.SelectedValue));
                MajDepenses(table);

                CalculRemboursement(Convert.ToInt32(cboEvents.SelectedValue));
                MajRemboursement(frmMain.localDataSet.Tables["BilanPart"], Convert.ToInt32(cboEvents.SelectedValue), Convert.ToInt32(cboParticipants.SelectedValue));
            }
            UpdateContainersVisibility();
        }

    private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            PDFGenerator PDFGenerator = new PDFGenerator(Convert.ToInt16(cboEvents.SelectedValue));
            string path = PDFGenerator.GeneratePDFs();
            if(path == null)
            {
                frmPopup confirmation = new frmPopup("Une erreur est survenue lors de la génération des PDFs", MessageType.Error);
                confirmation.ShowDialog();
                return;
            }
            else
            {
                frmPopup confirmation = new frmPopup("Les bilans ont bien été générer", MessageType.Done);
                if(confirmation.ShowDialog() == DialogResult.OK) System.Diagnostics.Process.Start("explorer.exe", path);
            }
            ClearControls();
            UpdateContainersVisibility();
            btnEnregistrer.Visible = false;
            btnAnnuler.Visible = false;
        }
        /// <summary>
        /// Update the visibility of the containers
        /// </summary>
        private void UpdateContainersVisibility()
        {
            if (cboEvents.SelectedIndex != -1 && cboParticipants.SelectedIndex != -1)
            {
                panelDepensesContainer.Visible = true;
                panelRefundContainer.Visible = true;
                btnAnnuler.Visible = true;
                btnEnregistrer.Visible = true;
            }
            else
            {
                panelDepensesContainer.Visible = false;
                panelRefundContainer.Visible = false;
            }

            if (cboEvents.SelectedIndex != -1)
            {
                panelDepensesContainer.Visible = true;
                panelCombos.Width = 963;
                panelCombos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCombos.Width, panelCombos.Height, radius, radius));
                lblParticipants.Visible = true;
                cboParticipants.Visible = true;
                btnAnnuler.Visible = true;
                btnEnregistrer.Visible = true;
            }
            else
            {
                panelDepensesContainer.Visible = false;
                panelCombos.Width = 492;
                lblParticipants.Visible = false;
                cboParticipants.Visible = false;
            }
        }
        /// <summary>
        /// Clear the controls
        /// </summary>
        private void ClearControls()
        {
            panelDepensesItems.Controls.Clear();
            panelRemboursementsItems.Controls.Clear();
            cboEvents.SelectedIndex = -1;
            cboParticipants.SelectedIndex = -1;
        }
    }
}