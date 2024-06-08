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
//Mail
using System.Net.Mail;
using System.Net;
using ApplicationBudget.Utilities;

namespace ApplicationBudget
{
    // delegate the event validation to the parent form to refresh the other form
    public delegate void EventAddedHandler(object sender, EventArgs e);
    public partial class AjouterEvenement : UserControl
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
        HashSet<int> invites = new HashSet<int>();
        public EventAddedHandler EventAdded;
        public AjouterEvenement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
            frmMain.ChargementCboDeco(cboEvenements, "Participants", "nomPart", "codeParticipant", frmMain.localDataSet);
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {

            frmAjouterParticipantEvent ajoutParticipants = new frmAjouterParticipantEvent(txtTitre.Text, invites);
            if (ajoutParticipants.ShowDialog() == DialogResult.OK)
            {
                invites = ajoutParticipants.addedParticipants;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool missingTerm = false;

            if (txtTitre.Text == string.Empty)
            {
                txtTitre.BackColor = Color.LightCoral;
                missingTerm = true;
            }
            if (!missingTerm)
            {
                string dateDebut = getDateFromPicker(dateDebutPicker.Value.Year, dateDebutPicker.Value.Month, dateDebutPicker.Value.Day);
                string dateFin = getDateFromPicker(dateFinPicker.Value.Year, dateFinPicker.Value.Month, dateFinPicker.Value.Day);

                ajouterEvent(txtTitre.Text, cboEvenements.Text, dateDebut, dateFin, txtDescription.Text);
                foreach (int var in invites)
                {
                    string loginMdp = generateLoginAndPasswordFromId(var);
                    ajouterInvite(getEventID(txtTitre.Text), var, loginMdp, loginMdp);
                }

                //Ajouter des parametre pour chaque event plus tard
                SendEmail("Nouvel évènement de " + cboEvenements.Text, dateDebut, dateFin, txtTitre.Text);
                frmPopup modal = new frmPopup("Evénement bien ajouté", MessageType.Done);
                modal.ShowDialog();
            }
            ClearControl();

        }

        public void ajouterEvent(string titre, string organisateur, string dateDebut, string dateFin, string description)
        {
            //To DO:
            //Verification de la saisie


            //Recuperation du code

            int codeCreateur = -1;

            //Ouverture de la commande
            
            try
            {
                //Recuperation du code Orga
                frmMain.connection.Open();
                string query = "SELECT codeParticipant FROM Participants where nomPart = '" + organisateur + "';";
                SQLiteCommand cm = new SQLiteCommand();
                cm.Connection = frmMain.connection;
                cm.CommandText = query;
                codeCreateur = Convert.ToInt32(cm.ExecuteScalar());

                query = "INSERT INTO Evenements(titreEvent, dateDebut, dateFin, description, soldeON, codeCreateur) VALUES (";
                query += $"'{titre}', '{dateDebut}', '{dateFin}',  '{description}', 0, '{codeCreateur}');";
                cm.CommandText = query;
                cm.ExecuteNonQuery();
                
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                frmMain.connection.Close();
            }
            try
            {
                AddEventLocally(titre, codeCreateur, organisateur,dateDebut, dateFin, description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            EventAdded(this, new EventArgs());
            
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
        public int getEventID(string eventID)
        {
            string query = "SELECT codeEvent FROM Evenements where titreEvent = '" + eventID + "';";

            SQLiteCommand cm = new SQLiteCommand();
            cm.Connection = frmMain.connection;
            cm.CommandText = query;
            try
            {
                //Recuperation du code Orga
                frmMain.connection.Open();
                int codeEvent = Convert.ToInt32(cm.ExecuteScalar());
                return codeEvent;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                frmMain.connection.Close();
            }
            return 0;
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

        public void AddEventLocally(string titre, int codeCreateur, string organisateur ,string dateDebut, string dateFin, string description)
        {
            DataRow newRow = frmMain.localDataSet.Tables["Evenements"].NewRow();
            newRow["titreEvent"] = titre;
            newRow["dateDebut"] = dateDebut;
            newRow["dateFin"] = dateFin;
            newRow["description"] = description;
            newRow["soldeON"] = 0;
            newRow["codeCreateur"] = codeCreateur;
            // Find a way to get the last inserted id
            newRow["codeEvent"] = frmMain.localDataSet.Tables["Evenements"].Rows.Count + 1;
            frmMain.localDataSet.Tables["Evenements"].Rows.Add(newRow);
            DataRow newRow2 = frmMain.localDataSet.Tables["Events"].NewRow();
            newRow2["codeEvent"] = frmMain.localDataSet.Tables["Events"].Rows.Count + 1;
            newRow2["soldeON"] = 0;
            newRow2["dateDebut"] = dateDebut;
            newRow2["dateFin"] = dateFin;
            newRow2["description"] = description;
            newRow2["titreEvent"] = titre;
            newRow2["participant"] = organisateur;
            frmMain.localDataSet.Tables["Events"].Rows.Add(newRow2);
        }

        public string getDateFromPicker(int year, int month, int day)
        {
            return $"{year}-{month}-{day}";
        }

        private void ClearControl()
        {
            txtTitre.Clear();
            txtDescription.Clear();
            dateDebutPicker.Value = DateTime.Now;
            dateFinPicker.Value = DateTime.Now;
            txtDescription.BackColor = Color.White;
            txtTitre.BackColor = Color.White;
            invites.Clear();
        }

        //Ajout de la fonction pour envoyer le mail
        //Il faut personaliser le mail pour chaque event + envoyer un mail par invité
        protected void SendEmail(string _subject, string dateDebut, string dateFin, string titreEvent)
        {
            SmtpClient mailClient = new SmtpClient("partage.unistra.fr");
            MailMessage msgMail = new MailMessage();

            string Text = "Vous êtes inviter a participer a l'evenement: \"" + titreEvent + "\" \n l'évenement auras lieu du " + dateDebut + " au " + dateFin;
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            frmPassword frmPassword = new frmPassword();
            if (frmPassword.ShowDialog() == DialogResult.OK)
            {
                MailAddress _from = new MailAddress(frmPassword.mail);
                mailClient.Credentials = new NetworkCredential(_from.Address, frmPassword.password);
                msgMail.From = _from;
            }
            SQLiteConnection connection = new SQLiteConnection(frmMain.cnxString);
            connection.Open();
            for (int i = 0; i < invites.Count + 1; i++)
            {
                if(i == invites.Count)
                {
                    MailAddress _to = new MailAddress("nizar.saidi.coder@gmail.com");
                    msgMail.To.Add(_to);
                    mailClient.Port = 587;
                    mailClient.EnableSsl = true;
                    mailClient.Send(msgMail);
                }
                try
                {
                    string query = $"SELECT adresseMail FROM Participants WHERE codeParticipant = {invites.ElementAt(i)}";
                    SQLiteCommand cm = new SQLiteCommand(query, connection);
                    string mail = Convert.ToString(cm.ExecuteScalar());
                    MailAddress _to = new MailAddress(mail);
                    msgMail.To.Add(_to);
                    mailClient.Port = 587;
                    mailClient.EnableSsl = true;
                    mailClient.Send(msgMail);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            mailClient.Dispose();
            connection.Close();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ClearControl();
        }
    }
}
