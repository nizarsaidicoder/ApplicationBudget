using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget
{
    public partial class frmPopup : Form
    {
        public frmPopup(String message, MessageType type)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
            switch (type)
            {
                case MessageType.Error:
                    pictureInfo.Image = Properties.Resources.close;
                    break;
                case MessageType.Done:
                    pictureInfo.Image = Properties.Resources.check;
                    break;
                default:
                    pictureInfo.Image = Properties.Resources.exclamation;
                    break;
            }
            lblFeedback.Text = message;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );
        private int radius = 15;

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
    }
}
