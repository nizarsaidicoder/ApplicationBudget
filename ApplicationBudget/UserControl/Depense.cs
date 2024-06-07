using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ApplicationBudget.Pages.Bilan
{
    public partial class Depense : UserControl
    {
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
        private int radius = 5;
        public Depense(string titre, string personne, string date, string categ ,double montant)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagePath = Path.Combine(projectRoot, "assets", "Icons", "Categories", $"{categ}.png");
            picCategorie.Image = Image.FromFile(imagePath);
            lblTitre.Text = titre;
            lblPersonne.Text = personne;
            lblMontant.Text = montant.ToString() + "€";
            lblDate.Text = date;
        }

    }
}