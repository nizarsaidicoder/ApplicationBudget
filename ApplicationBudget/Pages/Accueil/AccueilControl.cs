using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget
{
    // Delegate to switch page event to the main form
    public delegate void switchPage(object sender, EventArgs e);

    public partial class AccueilControl : UserControl
    {
        public switchPage switchToDepenseEvent;
        public switchPage switchToEventsEvent;

        public AccueilControl()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(5, 5, 5);
        }

        private void btnNavAjoutDepense_Click(object sender, EventArgs e)
        {
            switchToDepenseEvent(sender, e);
        }

        private void btnNavAjoutEvent_Click(object sender, EventArgs e)
        {
            switchToEventsEvent(sender, e);
        }
    }
}
