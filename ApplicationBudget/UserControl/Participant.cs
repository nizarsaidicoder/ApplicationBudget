using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget.Pages.Evenements
{
    public partial class Participant : UserControl
    {
        public int id;
        public bool isAdded;
        public Participant(int id, string name, string phone, bool isAdded)
        {
            InitializeComponent();
            this.id = id;
            lblName.Text = name;
            lblPhone.Text = phone;
            try
            {
                picAvatar.Image = Image.FromFile(Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "assets", "Profiles", id.ToString() + ".png"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateStatus(isAdded);
        }
        /// <summary>
        /// Update the status of the participant
        /// </summary>
        /// <param name="isAdded">True if the participant is added to the event, false otherwise</param>
        public void UpdateStatus(bool isAdded)
        {
            this.isAdded = isAdded;
            if (isAdded)
            {
                btnAjouter.Visible = false;
                btnAnnuler.Visible = true;
            }
            else
            {
                btnAjouter.Visible = true;
                btnAnnuler.Visible = false;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            UpdateStatus(false);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            UpdateStatus(true);
        }

        private void Participant_Load(object sender, EventArgs e)
        {

        }
    }
}
