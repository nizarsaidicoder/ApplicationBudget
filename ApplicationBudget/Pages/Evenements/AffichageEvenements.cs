using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget
{
    public partial class AffichageEvenements : UserControl
    {
        private DataTable events;
        public BindingSource bs = new BindingSource();
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
        public AffichageEvenements()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height,radius,radius ));
        }

        private void AffichageEvenements_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
            panelEvent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEvent.Width, panelEvent.Height, 10, 10));
            events = frmMain.localDataSet.Tables["Events"];
            SetupDataBindings();
        }
        private void SetupDataBindings()
        {
            try
            {
                bs.DataSource = events;
                cboEvenement.DataSource = bs;
                cboEvenement.DisplayMember = "titreEvent";
                cboEvenement.ValueMember = "codeEvent";
                // Clear any existing data bindings
                lblTitre.DataBindings.Clear();
                lblOrganisateur.DataBindings.Clear();
                lblDescription.DataBindings.Clear();
                lblDateDebut.DataBindings.Clear();
                lblDateFin.DataBindings.Clear();

                // Add new data bindings
                lblTitre.DataBindings.Add("Text", bs, "titreEvent");
                lblDescription.DataBindings.Add("Text", bs, "description");
                lblOrganisateur.DataBindings.Add("Text", bs, "participant");
                lblDateDebut.DataBindings.Add("Text", bs, "dateDebut");
                lblDateFin.DataBindings.Add("Text", bs, "dateFin");
                bs.PositionChanged += Bs_PositionChanged;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error during data binding: {ex.Message}");
            }
        }
        private void Bs_PositionChanged(object sender, EventArgs e)
        {
            UpdateSoldeVisibility();
        }
        private void UpdateSoldeVisibility()
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                int soldeON = Convert.ToInt32(drv["soldeON"]);
                lblSolde.Visible = soldeON == 1;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }
        public void RefreshEvents()
        {
            // SHOW THE LAST EVENT
            bs.MoveLast();
        }
    }
}
