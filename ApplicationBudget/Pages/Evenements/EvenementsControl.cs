using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBudget
{
    public partial class EvenementsControl : UserControl
    {
        public EvenementsControl()
        {
            InitializeComponent();
            ajouterEvenement1.EventAdded += new EventAddedHandler(RefreshEvents);
        }

        private void ajouterEvenement1_Load(object sender, EventArgs e)
        {

        }
        public void RefreshEvents(object sender, EventArgs e)
        {
            affichageEvenements1.RefreshEvents();
        }
    }
}
