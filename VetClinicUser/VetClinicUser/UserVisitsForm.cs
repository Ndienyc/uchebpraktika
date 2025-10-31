using System;
using System.Data;
using System.Windows.Forms;

namespace VetClinicUser
{
    public partial class UserVisitsForm : Form
    {
        private int ownerId;

        public UserVisitsForm(int ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
            LoadVisits();
        }

        private void LoadVisits()
        {
            string query = $@"
                SELECT v.VisitID, p.PetName, v.VisitDate, v.Diagnosis, v.TotalCost
                FROM ((Visits v 
                  LEFT JOIN Pets p ON v.PetID = p.PetID)
                  LEFT JOIN Owners o ON p.OwnerID = o.OwnerID)
                WHERE o.OwnerID = {ownerId}
                ORDER BY v.VisitDate DESC";

            var dt = DatabaseHelper.GetData(query);
            dataGridVisits.DataSource = dt;

            if (dataGridVisits.Columns.Contains("VisitDate"))
                dataGridVisits.Columns["VisitDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
    }
}
