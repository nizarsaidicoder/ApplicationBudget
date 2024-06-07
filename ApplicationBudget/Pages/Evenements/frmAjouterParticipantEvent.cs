using ApplicationBudget.Pages.Bilan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget.Pages.Evenements
{
    public partial class frmAjouterParticipantEvent : Form
    {
        private string cnxString = frmMain.cnxString;
        private SQLiteConnection cnx = frmMain.connection;
        public HashSet<int> addedParticipants;
        public HashSet<int> nonAddedPart = new HashSet<int>();
        public frmAjouterParticipantEvent(string eventName, HashSet<int> addedParticipants)
        {
            InitializeComponent();
            if (eventName.Length > 0) lblTitre.Text = eventName;
            this.addedParticipants = addedParticipants;
            cnx = new SQLiteConnection(cnxString);
            LoadParticipants();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void LoadParticipants()
        {
            try
            {
                cnx.Open();
                string query = @"SELECT codeParticipant, nomPart || ' ' || prenomPart as participant, mobile
                              FROM Participants";
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
                    panelParticipants.Controls.Add(participant);
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
            foreach (Participant participant in panelParticipants.Controls)
            {
                participant.UpdateStatus(true);
            }
        }

        private void btnDeselectionnerTout_Click(object sender, EventArgs e)
        {
            foreach (Participant participant in panelParticipants.Controls)
            {
                participant.UpdateStatus(false);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            foreach (Participant participant in panelParticipants.Controls)
            {
                if (participant.isAdded)
                {
                    this.addedParticipants.Add(participant.id);
                }
                else
                {
                    this.nonAddedPart.Add(participant.id);
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}