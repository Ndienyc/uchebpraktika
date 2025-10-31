using System;
using System.Windows.Forms;

namespace VetClinicUser
{
    public partial class UserMainForm : Form
    {
        private int ownerId;

        public UserMainForm(int ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
        }

        private void btnMyVisits_Click(object sender, EventArgs e)
        {
            UserVisitsForm visitsForm = new UserVisitsForm(ownerId);
            visitsForm.ShowDialog();
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            UserAddVisitForm addVisitForm = new UserAddVisitForm(ownerId);
            addVisitForm.ShowDialog();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            UserServicesForm servicesForm = new UserServicesForm();
            servicesForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
