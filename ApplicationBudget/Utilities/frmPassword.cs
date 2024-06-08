using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget.Utilities
{
    public partial class frmPassword : Form
    {
        public string mail
        {
            get;set;
        }
        public string password
        {
            get; set;
        }
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Check if the mail ends with unistra.fr
            if (!txtMail.Text.EndsWith("unistra.fr") )
            {
                MessageBox.Show("Veuillez entrer une adresse mail de l'université de Strasbourg", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if(txtMail.Text == "")
            {
                MessageBox.Show("Veuillez entrer une adresse mail", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mail = txtMail.Text;
                password = txtPassword.Text;
                DialogResult = DialogResult.OK;
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '@')
            {
                if (txtMail.Text.Contains('@'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
