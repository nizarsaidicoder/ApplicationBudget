using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget
{
    public partial class frmMain : Form
    {
        public static string databasePath =  Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Database", "Events.sqlite");
        public static String cnxString = $"Data Source= {databasePath}";
        public static SQLiteConnection connection = new SQLiteConnection(cnxString);
        public static DataSet localDataSet = new DataSet();
        public frmMain()
        {
            InitializeComponent();
            panelMainApp.Paint += new PaintEventHandler(set_background);
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, panelMainApp.Width, panelMainApp.Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(10, 12, 42), 10f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ChargementDsLocal(connection, localDataSet);
            LoadData();
            btnNavDepenses_Click(sender, e);
        }
        /// <summary>
        /// Load data from the database
        /// </summary>
        public static void LoadData()
        {
            try
            {
                string query = @"SELECT e.codeEvent,e.description, e.titreEvent, e.dateDebut, e.dateFin, e.soldeON, p.nomPart || ' ' || p.prenomPart as participant
                             FROM Evenements e 
                             JOIN Participants p ON e.codeCreateur = p.codeParticipant
                             ORDER BY e.codeEvent DESC";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(localDataSet, "Events");
            }
            catch (Exception ex)
            {
                frmPopup frmPopup = new frmPopup(ex.ToString(), MessageType.Error);
                frmPopup.ShowDialog();
            }
        }

        // NAVIGATION EVENTS AND UI HANDLING
        /// <summary>
        /// Add a user control to the main panel
        /// </summary>
        /// <param name="userControl"></param>
        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMainApp.Controls.Clear();
            panelMainApp.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnNavAcceuil_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnNavAcceuil.BackColor = Color.White;
            btnNavAcceuil.ForeColor = Color.FromArgb(117, 139, 253);
            btnNavAcceuil.Image = Properties.Resources.HomeIconDark;
            AccueilControl uc = new AccueilControl();
            uc.switchToDepenseEvent += btnNavDepenses_Click;
            uc.switchToEventsEvent += btnNavEvent_Click;
            AddUserControl(uc);
        }

        private void btnNavParticipants_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnNavParticipants.BackColor = Color.White;
            btnNavParticipants.ForeColor = Color.FromArgb(117, 139, 253);
            btnNavParticipants.Image = Properties.Resources.ParticipantsIconDark;
            ParticipantsControl uc = new ParticipantsControl();
            AddUserControl(uc);
        }

        private void btnNavDepenses_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnNavDepenses.BackColor = Color.White;
            btnNavDepenses.ForeColor = Color.FromArgb(117, 139, 253);
            btnNavDepenses.Image = Properties.Resources.ExpenseIconDark;
            DepensesControl uc = new DepensesControl();
            AddUserControl(uc);
        }

        private void btnNavEvent_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnNavEvent.BackColor = Color.White;
            btnNavEvent.ForeColor = Color.FromArgb(117, 139, 253);
            btnNavEvent.Image = Properties.Resources.EventsIconDark;
            EvenementsControl uc = new EvenementsControl();
            AddUserControl(uc);
        }

        private void btnNavBilan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnNavBilan.BackColor = Color.White;
            btnNavBilan.ForeColor = Color.FromArgb(117, 139, 253);
            btnNavBilan.Image = Properties.Resources.BilanIconDark;
            BilanControl uc = new BilanControl();
            AddUserControl(uc);
        }
        private void setBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, panelMainApp.Width, panelMainApp.Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(10, 12, 42), 10f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
        /// <summary>
        /// Reset the colors of the navigation buttons
        /// </summary>
        private void ResetButtonColors()
        {
            foreach (Button btn in panelNavigationItems.Controls)
            {
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
            }
            btnNavAcceuil.Image = Properties.Resources.HomeIcon;
            btnNavDepenses.Image = Properties.Resources.ExpenseIcon;
            btnNavEvent.Image = Properties.Resources.EventsIcon;
            btnNavParticipants.Image = Properties.Resources.ParticipantsIcon;
            btnNavBilan.Image = Properties.Resources.BilanIcon;
        }
        /// <summary>
        /// Charge les données dans un ComboBox en mode déconnecté
        /// </summary>
        /// <param name="cbo">ComboBox</param>
        /// <param name="table">Nom de la table</param>
        /// <param name="champAffichee">Champ à afficher</param>
        /// <param name="valeurRetour">Valeur à retourner</param>
        /// <param name="ds">DataSet</param>

        public static void ChargementCboDeco(ComboBox cbo, String table, String champAffichee, String valeurRetour, DataSet ds)
        {
            try
            {
                cbo.Items.Clear();
                cbo.DataSource = ds.Tables[table];
                cbo.DisplayMember = ds.Tables[table].Columns[champAffichee].ToString();
                cbo.ValueMember = ds.Tables[table].Columns[valeurRetour].ToString();
            }
            catch (Exception ex)
            {
                frmPopup frmPopup = new frmPopup(ex.ToString(), MessageType.Error);
                frmPopup.ShowDialog();
            }
        }
        /// <summary>
        /// Charge toutes les tables de la base de données dans un DataSet local
        /// </summary>
        /// <param name="connec">Connexion à la base de données</param>
        /// <param name="ds">DataSet</param>

        public static void ChargementDsLocal(SQLiteConnection connec, DataSet ds)
        {
            try
            {
                ds.Clear();
                connec.Open();
                DataTable schemaTable = connec.GetSchema("Tables");
                SQLiteDataAdapter da;
                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string nomTable = schemaTable.Rows[i][2].ToString();
                    string req = $"SELECT * FROM {nomTable}";
                    da = new SQLiteDataAdapter(req, connec);
                    da.Fill(ds, nomTable);
                }

                //join tables pour les dépenses
                string requete = "SELECT DISTINCT d.numDepense, d.description, d.montant, d.dateDepense, d.codeEvent, d.codePart, p.nomPart || ' ' || p.prenomPart as 'nomPart'" +
                    " FROM Depenses as d JOIN Participants as p ON d.codePart = p.codeParticipant";
                da = new SQLiteDataAdapter(requete, connec);
                da.Fill(ds, "CategDepensePart");

                //ajout contraintes
                AjoutClesPrimaires(ds);
                AjoutClesEtrangeres(ds);
            }
            catch (Exception ex)
            {
                frmPopup frmPopup = new frmPopup(ex.ToString(), MessageType.Error);
                frmPopup.ShowDialog();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connec.Close();
            }
        }

        public static void AjoutClesPrimaires(DataSet ds)
        {
            //Beneficiaires
            ds.Tables["Beneficiaires"].PrimaryKey = new DataColumn[] { ds.Tables["Beneficiaires"].Columns["numDepense"], ds.Tables["Beneficiaires"].Columns["codePart"] };
            //BilanPart
            ds.Tables["BilanPart"].PrimaryKey = new DataColumn[] { ds.Tables["BilanPart"].Columns["codeEvent"], ds.Tables["BilanPart"].Columns["codeDonneur"], ds.Tables["BilanPart"].Columns["codeReceveur"] };
            //CategDepense
            ds.Tables["CategDepense"].PrimaryKey = new DataColumn[] { ds.Tables["CategDepense"].Columns["numDepense"], ds.Tables["CategDepense"].Columns["codeCateg"] };
            //Categories
            ds.Tables["Categories"].PrimaryKey = new DataColumn[] { ds.Tables["Categories"].Columns["codeCateg"] };
            //Depenses
            ds.Tables["Depenses"].PrimaryKey = new DataColumn[] { ds.Tables["Depenses"].Columns["numDepense"] };
            //Evenements
            ds.Tables["Evenements"].PrimaryKey = new DataColumn[] { ds.Tables["Evenements"].Columns["codeEvent"] };
            //Invites
            ds.Tables["Invites"].PrimaryKey = new DataColumn[] { ds.Tables["Invites"].Columns["codeEvent"], ds.Tables["Invites"].Columns["codePart"] };
            //Participants
            ds.Tables["Participants"].PrimaryKey = new DataColumn[] { ds.Tables["Participants"].Columns["codeParticipant"] };
            //CategDepensePart
            ds.Tables["CategDepensePart"].PrimaryKey = new DataColumn[] { ds.Tables["CategDepensePart"].Columns["numDepense"], ds.Tables["CategDepensePart"].Columns["codeEvent"], ds.Tables["CategDepensePart"].Columns["codePart"], ds.Tables["CategDepensePart"].Columns["nomCateg"] };

        }
        /// <summary>
        /// Ajoute les clés étrangères aux tables du DataSet
        /// </summary>
        /// <param name="ds">DataSet</param>
        public static void AjoutClesEtrangeres(DataSet ds)
        {
            DataColumn parent;
            DataColumn enfant;
            ForeignKeyConstraint fk;

            //Beneficiaires
            parent = ds.Tables["Participants"].Columns["codeParticipant"];
            enfant = ds.Tables["Beneficiaires"].Columns["codePart"];
            fk = new ForeignKeyConstraint("fk_Participants_Beneficiaires", parent, enfant);
            ds.Tables["Beneficiaires"].Constraints.Add(fk);

            parent = ds.Tables["Depenses"].Columns["numDepense"];
            enfant = ds.Tables["Beneficiaires"].Columns["numDepense"];
            fk = new ForeignKeyConstraint("fk_Depenses_Beneficiaires", parent, enfant);
            ds.Tables["Beneficiaires"].Constraints.Add(fk);

            //BilanPart
            parent = ds.Tables["Evenements"].Columns["codeEvent"];
            enfant = ds.Tables["BilanPart"].Columns["codeEvent"];
            fk = new ForeignKeyConstraint("fk_Evenements_BilanPart", parent, enfant);
            ds.Tables["BilanPart"].Constraints.Add(fk);

            parent = ds.Tables["Participants"].Columns["codeParticipant"];
            enfant = ds.Tables["BilanPart"].Columns["codeDonneur"];
            fk = new ForeignKeyConstraint("fk_ParticipantsDonneur_BilanPart", parent, enfant);
            ds.Tables["BilanPart"].Constraints.Add(fk);

            enfant = ds.Tables["BilanPart"].Columns["codeReceveur"];
            fk = new ForeignKeyConstraint("fk_ParticipantsReceveur_BilanPart", parent, enfant);
            ds.Tables["BilanPart"].Constraints.Add(fk);

            //CategDepense
            parent = ds.Tables["Categories"].Columns["codeCateg"];
            enfant = ds.Tables["CategDepense"].Columns["codeCateg"];
            fk = new ForeignKeyConstraint("fk_Categories_CategDepense", parent, enfant);
            ds.Tables["CategDepense"].Constraints.Add(fk);

            parent = ds.Tables["Depenses"].Columns["numDepense"];
            enfant = ds.Tables["CategDepense"].Columns["numDepense"];
            fk = new ForeignKeyConstraint("fk_Depenses_CategDepense", parent, enfant);
            ds.Tables["CategDepense"].Constraints.Add(fk);

            //Depenses
            parent = ds.Tables["Evenements"].Columns["codeEvent"];
            enfant = ds.Tables["Depenses"].Columns["codeEvent"];
            fk = new ForeignKeyConstraint("fk_Evenements_Depenses", parent, enfant);
            ds.Tables["Depenses"].Constraints.Add(fk);

            parent = ds.Tables["Participants"].Columns["codeParticipant"];
            enfant = ds.Tables["Depenses"].Columns["codePart"];
            fk = new ForeignKeyConstraint("fk_Participants_Depenses", parent, enfant);
            ds.Tables["Depenses"].Constraints.Add(fk);


            //Invites
            parent = ds.Tables["Evenements"].Columns["codeEvent"];
            enfant = ds.Tables["Invites"].Columns["codeEvent"];
            fk = new ForeignKeyConstraint("fk_Evenements_Invites", parent, enfant);
            ds.Tables["Invites"].Constraints.Add(fk);

            parent = ds.Tables["Participants"].Columns["codeParticipant"];
            enfant = ds.Tables["Invites"].Columns["codePart"];
            fk = new ForeignKeyConstraint("fk_Participants_Invites", parent, enfant);
            ds.Tables["Invites"].Constraints.Add(fk);

            //CategDepensePart
            parent = ds.Tables["Evenements"].Columns["codeEvent"];
            enfant = ds.Tables["CategDepensePart"].Columns["codeEvent"];
            fk = new ForeignKeyConstraint("fk_Evenements_CategDepensePart", parent, enfant);
            ds.Tables["CategDepensePart"].Constraints.Add(fk);

            parent = ds.Tables["Participants"].Columns["codeParticipant"];
            enfant = ds.Tables["CategDepensePart"].Columns["codePart"];
            fk = new ForeignKeyConstraint("fk_Participants_CategDepensePart", parent, enfant);
            ds.Tables["CategDepensePart"].Constraints.Add(fk);

            parent = ds.Tables["Depenses"].Columns["numDepense"];
            enfant = ds.Tables["CategDepensePart"].Columns["numDepense"];
            fk = new ForeignKeyConstraint("fk_Depenses_CategDepensePart", parent, enfant);
            ds.Tables["CategDepensePart"].Constraints.Add(fk);

        }
    }
}