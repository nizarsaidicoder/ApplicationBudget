﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.UninterpretedOption.Types;
using System.Data.SQLite;
using System.Web.UI;
using System.Collections;


namespace ApplicationBudget
{
    internal class PDFGenerator
    {
        public string fileName;
        public int numEvent;
        public string eventTitle;
        public string eventStartDate;
        public string eventEndDate;
        public string eventDescription;
        public string eventOrganizer;
        public List<int> codeParticipants;
        public string currentParticipant;
        public double xPoint = 20;
        public double yPoint = 20;
        public double space = 25;
        public XFont font = new XFont("Verdana", 14, XFontStyleEx.Regular);
        public XFont titleFont = new XFont("Verdana", 24, XFontStyleEx.Bold);
        public XFont italicFont = new XFont("Verdana", 14, XFontStyleEx.Italic);
        public XFont boldFont = new XFont("Verdana", 16, XFontStyleEx.Bold);
        private SQLiteConnection connection = new SQLiteConnection("Data Source= Events.sqlite");


        public PDFGenerator(int numEvent)
        {
            this.numEvent = numEvent;
            FetchEventData();
            FetchParticipants();
        }
        /// <summary>
        /// Generate PDFs for all participants
        /// </summary>
        /// <returns>Path to the folder containing all the PDFs</returns>
        public string GeneratePDFs()
        {
            
            foreach (int codePart in codeParticipants) GeneratePDFParticipant(codePart);
            if(eventTitle == null)
            {
                return null;
            }
            return Environment.CurrentDirectory + "\\Bilans\\" + eventTitle.Replace(" ", "_").Replace("-", "_");
        }
        /// <summary>
        /// Generate PDF for a single participant
        /// </summary>
        /// <param name="codePart">Participant code</param>
        public void GeneratePDFParticipant(int codePart)
        {
            xPoint = 20;
            yPoint = 20;
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Height = 1400;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            WriteEventsInfo(gfx, page);
            currentParticipant =  WriteParticipantInfo(codePart, gfx, page);
            gfx.DrawRectangle(XBrushes.Gold, xPoint, yPoint, page.Width - 2 * xPoint, 20);
            yPoint += 40;
            gfx.DrawString("Generated by MoneyCut", titleFont, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            string logo = Environment.CurrentDirectory + "\\logo2.png";
            XImage image = XImage.FromFile(logo);
            gfx.DrawImage(image, page.Width - 150, yPoint + 30, 100, 100);
            string currentDirectory = Environment.CurrentDirectory;
            string path = currentDirectory + "\\Bilans\\" + eventTitle.Replace(" ", "_").Replace("-", "_");
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            fileName = path + "\\" + eventTitle.Replace(" ","_").Replace("-","_") + "_" + currentParticipant + ".pdf";
            document.Save(fileName);
        }
        /// <summary>
        /// Write the event information to the PDF
        /// </summary>
        /// <param name="gfx">Graphics object</param>
        /// <param name="page">Page object</param>
        public void WriteEventsInfo(XGraphics gfx, PdfPage page)
        {
            gfx.DrawString($"Evénement : {eventTitle}", titleFont, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += 55;
            gfx.DrawString("Organisateur: " + eventOrganizer, font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawString("Date début: " + eventStartDate, font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawString("Date fin: " + eventEndDate, font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawString("Description: " + eventDescription, font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawLine(XPens.Gold, xPoint, yPoint, page.Width - xPoint, yPoint);
            yPoint += space - 10;
            string logo = Environment.CurrentDirectory + "\\logo.png";
            XImage image = XImage.FromFile(logo);
            gfx.DrawImage(image, page.Width - 100, 80, 80, 80);
        }
        /// <summary>
        /// Write the participant information to the PDF
        /// </summary>
        /// <param name="codePart">Participant code</param>
        /// <param name="gfx">Graphics object</param>
        /// <param name="page">Page object</param>
        /// <returns>Participant name</returns>

        public string WriteParticipantInfo(int codePart, XGraphics gfx, PdfPage page)
        {
            List<string> participantInfo = FetchParticipantInfo(codePart);
            gfx.DrawString($"Nom: {participantInfo[0]}", font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawString($"Prénom: {participantInfo[1]}", font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawString($"Nombre de parts: {participantInfo[2]}", italicFont, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawString($"Adresse mail: {participantInfo[3]}", italicFont, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space;
            gfx.DrawString($"Mobile: {participantInfo[4]}", italicFont, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);

            yPoint += space;
            gfx.DrawLine(XPens.Gold, xPoint, yPoint, page.Width - xPoint, yPoint);
            yPoint += space;
            List<List<string>> depenses = FetchDepenses(codePart);
            // DEPENSES EFFECTUEES PAR LE PARTICIPANT
            if (printDepensesTable(codePart, "Depenses effectué par " + participantInfo[0] + " " + participantInfo[1], depenses, gfx, page))
            {
                gfx.DrawLine(XPens.Gold, xPoint, yPoint, page.Width - xPoint, yPoint);
            }
            else
            {
                gfx.DrawRectangle(XBrushes.Crimson, xPoint, yPoint, page.Width - 2 * xPoint, 20);
                gfx.DrawString("Aucune depense effectuée par " + participantInfo[0] + " " + participantInfo[1], boldFont, XBrushes.White, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopCenter);
            }
            yPoint += space + 10;
            // DEPENSES QUI ME CONCERNENT
            List<List<string>> depensesMeConcerne = FetchDepensesMeConcernet(codePart);
            if (printDepensesTable(codePart, "Les depenses dont a bénéficiées " + participantInfo[0] + " " + participantInfo[1], depensesMeConcerne, gfx, page))
            {
                gfx.DrawLine(XPens.Gold, xPoint, yPoint, page.Width - xPoint, yPoint);
            }
            else
            {
                gfx.DrawRectangle(XBrushes.Crimson, xPoint, yPoint, page.Width - 2 * xPoint, 20);
                gfx.DrawString("Aucune depense dont a bénéficiées " + participantInfo[0] + " " + participantInfo[1], boldFont, XBrushes.White, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopCenter);
            }
            yPoint += space + 10;
            // DEPENSES A DONNER
            List<List<string>> depensesDonner = FetchDepensePayback(codePart);
            if (printDepensesTable(codePart, participantInfo[0] + " " + participantInfo[1] + " Doit payer à ", depensesDonner, gfx, page))
            {
                gfx.DrawLine(XPens.Gold, xPoint, yPoint, page.Width - xPoint, yPoint);
            }
            else
            {
                gfx.DrawRectangle(XBrushes.Crimson, xPoint, yPoint, page.Width - 2 * xPoint, 20);

                gfx.DrawString(participantInfo[0] + " " + participantInfo[1] + " ne doit rien à personne", boldFont, XBrushes.White, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopCenter);
            }
            yPoint += space + 10;
            // DEPENSES A RECEVOIR
            List<List<string>> depensesRecevoir = FetchDepenseRecieve(codePart);
            if (printDepensesTable(codePart, participantInfo[0] + " " + participantInfo[1] + " Doit recevoir de ", depensesRecevoir, gfx, page))
            {
                gfx.DrawLine(XPens.Gold, xPoint, yPoint, page.Width - xPoint, yPoint);
            }
            else
            {
                gfx.DrawRectangle(XBrushes.Crimson, xPoint, yPoint, page.Width - 2 * xPoint, 20);

                gfx.DrawString(participantInfo[0] + " " + participantInfo[1] + " ne doit rien à personne", boldFont, XBrushes.White, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopCenter);
            }
            yPoint += space + 10;
            return participantInfo[0] + "_" + participantInfo[1];
        }
        /// <summary>
        /// Fetch event data from the database
        /// </summary>
        public void FetchEventData()
        {
            try
            {
                connection.Open();
                string query = $@"SELECT e.titreEvent, e.dateDebut, e.dateFin, e.description, p.nomPart || ' ' || p.prenomPart AS 'Organizer' 
                                FROM Evenements e JOIN Participants p ON e.codeCreateur = p.codeParticipant 
                                WHERE e.codeEvent = {numEvent}";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    eventTitle = reader["titreEvent"].ToString();
                    eventStartDate = reader["dateDebut"].ToString();
                    eventEndDate = reader["dateFin"].ToString();
                    eventDescription = reader["description"].ToString();
                    eventOrganizer = reader["Organizer"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Fetch participants of the current event from the database
        /// </summary>
        public void FetchParticipants()
        {
            codeParticipants = new List<int>();
            try
            {
                connection.Open();
                string query = $@"SELECT codePart
                            FROM Invites
                            WHERE codeEvent = {numEvent}";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    codeParticipants.Add(Convert.ToInt32(reader["codePart"]));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Fetch participant information from the database
        /// </summary>
        /// <param name="codePart">Participant code</param>
        /// <returns>List of participant information</returns>
        public List<string> FetchParticipantInfo(int codePart)
        {
            List<string> participantInfo = new List<string>();
            try
            {
                connection.Open();
                string query = $@"SELECT *
                            FROM Participants
                            WHERE codeParticipant = {codePart}";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    participantInfo.Add(reader["nomPart"].ToString());
                    participantInfo.Add(reader["prenomPart"].ToString());
                    participantInfo.Add(reader["nbParts"].ToString());
                    participantInfo.Add(reader["adresseMail"].ToString());
                    participantInfo.Add(reader["mobile"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return participantInfo;
        }
        /// <summary>
        /// Fetch expenses of the current event from the database
        /// </summary>
        /// <param name="codePart">Participant code</param>
        /// <returns>List of expenses</returns>
        public List<List<string>> FetchDepenses(int codePart)
        {
            List<List<string>> depenses = new List<List<string>>();
            try
            {
                connection.Open();
                string query = $@"SELECT d.description, d.montant
                            FROM Depenses d
                            WHERE d.codePart = {codePart}
                            AND d.codeEvent = {numEvent}";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<string> depense = new List<string>
                    {
                        reader["description"].ToString(),
                        reader["montant"].ToString()
                    };
                    depenses.Add(depense);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return depenses;
        }
        /// <summary>
        /// Fetch expenses that concern the current participant from the database
        /// </summary>
        /// <param name="codePart">Participant code</param>
        /// <returns>List of expenses</returns>
        public List<List<string>> FetchDepensesMeConcernet(int codePart)
        {
            List<List<string>> depenses = new List<List<string>>();
            try
            {
                connection.Open();
                string query = $@"SELECT d.description, d.montant
                            FROM Depenses AS d
                            JOIN Beneficiaires AS b ON d.numDepense = b.numDepense
                            JOIN Participants AS p ON b.codePart = p.codeParticipant
                            WHERE d.numDepense IN(SELECT d1.numDepense
                                                    FROM Beneficiaires b1
                                                    JOIN Depenses d1 ON b1.numDepense = d1.numDepense
                                                    WHERE d1.codeEvent = {numEvent}
                                                    AND b1.codePart = {codePart})
                            GROUP BY d.numDepense, d.montant";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<string> depense = new List<string>
                    {
                        reader["description"].ToString(),
                        reader["montant"].ToString(),
                    };
                    depenses.Add(depense);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return depenses;
        }
        /// <summary>
        /// Fetch expenses that the current participant has to pay back from the database
        /// </summary>
        /// <param name="codePart">Participant code</param>
        /// <returns>List of expenses to payback</returns>
        public List<List<string>> FetchDepensePayback(int codePart)
        {
            List<List<string>> depenses = new List<List<string>>();
            try
            {
                connection.Open();
                string query = $@"SELECT p.nomPart || ' ' || p.prenomPart AS 'Nom', b.montant
                            FROM BilanPart b
                            JOIN Participants p ON p.codeParticipant = b.codeReceveur
                            WHERE b.codeEvent = {numEvent}
                            AND b.codeDonneur = {codePart}";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<string> depense = new List<string>
                    {
                        reader["Nom"].ToString(),
                        reader["montant"].ToString()
                    };
                    depenses.Add(depense);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return depenses;
        }
        /// <summary>
        /// Fetch expenses that the current participant has to receive from the database
        /// </summary>
        /// <param name="codePart">Participant code</param>
        /// <returns>List of expenses to receive</returns>
        public List<List<string>> FetchDepenseRecieve(int codePart)
        {
            List<List<string>> depenses = new List<List<string>>();
            try
            {
                connection.Open();
                string query = $@"SELECT p.nomPart || ' ' || p.prenomPart AS 'Nom', b.montant
                            FROM BilanPart b
                            JOIN Participants p ON p.codeParticipant = b.codeDonneur
                            WHERE b.codeEvent = {numEvent}
                            AND b.codeReceveur = {codePart}";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<string> depense = new List<string>
                    {
                        reader["Nom"].ToString(),
                        reader["montant"].ToString()
                    };
                    depenses.Add(depense);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return depenses;
        }
        /// <summary>
        /// Print the expenses table to the PDF
        /// </summary>
        /// <param name="codePart">Participant code</param>
        /// <param name="header">Table header</param>
        /// <param name="depenses">List of expenses</param>
        /// <param name="gfx">Graphics object</param>
        /// <param name="page">Page object</param>
        /// <returns>True if the table is not empty, false otherwise</returns>
        public bool printDepensesTable(int codePart, string header, List<List<string>> depenses, XGraphics gfx, PdfPage page)
        {
            if(depenses.Count == 0)
            {
                return false;
            }
            gfx.DrawString(header, boldFont, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += space + 10 ;
            // TABLE HEADER use draw rectangle with borders Headers are horizontal and golden back
            gfx.DrawLine(XPens.Black, xPoint, yPoint, page.Width - xPoint, yPoint);
            gfx.DrawRectangle(XBrushes.Gold, xPoint, yPoint, page.Width - 2 * xPoint, 20);
            gfx.DrawString("Description", font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString("Montant", font, XBrushes.Black, new XRect(xPoint + 200, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += 20;
            gfx.DrawLine(XPens.Black, xPoint, yPoint, page.Width - xPoint, yPoint);
            yPoint += 5;
            foreach (List<string> depense in depenses)
            {
                gfx.DrawString(depense[0], font, XBrushes.Black, new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString(depense[1], font, XBrushes.Black, new XRect(xPoint + 200, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                yPoint += space;
            }
            // END OF TABLE
            gfx.DrawLine(XPens.Black, xPoint, yPoint, page.Width - xPoint, yPoint);
            return true;
        }

    }

}