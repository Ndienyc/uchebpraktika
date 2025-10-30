using System;
using System.Windows.Forms;

namespace VetClinicApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            new OwnersForm().ShowDialog();
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            new PetsForm().ShowDialog();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new ServicesForm().ShowDialog();
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            new VisitsForm().ShowDialog();
        }
    }
}
