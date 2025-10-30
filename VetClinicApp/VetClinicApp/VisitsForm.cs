using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace VetClinicApp
{
    public partial class VisitsForm : Form
    {
        public VisitsForm()
        {
            InitializeComponent();
            LoadPets();
            LoadServices();
            LoadVisits();
        }

        private void LoadPets()
        {
            var dt = DatabaseHelper.GetData("SELECT PetID, PetName FROM Pets ORDER BY PetName");
            comboPets.Items.Clear();
            foreach (DataRow row in dt.Rows)
                comboPets.Items.Add(new ComboItem(Convert.ToInt32(row["PetID"]), row["PetName"].ToString()));
            if (comboPets.Items.Count > 0)
                comboPets.SelectedIndex = 0;
        }

        private void LoadServices()
        {
            var dt = DatabaseHelper.GetData("SELECT ServiceID, ServiceName, Price FROM Services ORDER BY ServiceName");
            comboServices.Items.Clear();
            foreach (DataRow row in dt.Rows)
                comboServices.Items.Add(new ComboItem(
                    Convert.ToInt32(row["ServiceID"]),
                    $"{row["ServiceName"]} ({Convert.ToDecimal(row["Price"]):C2})"
                ));
            if (comboServices.Items.Count > 0)
                comboServices.SelectedIndex = 0;
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            if (comboServices.SelectedItem is ComboItem item)
            {
                var dt = DatabaseHelper.GetDataParam(
                    "SELECT Price FROM Services WHERE ServiceID = ?",
                    new OleDbParameter("?", item.Id)
                );
                if (dt.Rows.Count > 0)
                    lblPrice.Text = $"Стоимость: {Convert.ToDecimal(dt.Rows[0][0]):C2}";
            }
        }

        private void comboServices_SelectedIndexChanged(object sender, EventArgs e) => UpdatePrice();

        private void LoadVisits()
        {
            var query = @"SELECT v.VisitID, p.PetName, v.VisitDate, v.Diagnosis, v.TotalCost, s.ServiceName
                          FROM ((Visits v
                              LEFT JOIN Pets p ON v.PetID = p.PetID)
                              LEFT JOIN Services s ON v.ServiceID = s.ServiceID)
                          ORDER BY v.VisitDate DESC";
            var dt = DatabaseHelper.GetData(query);
            dataGridVisits.DataSource = dt;
            if (dataGridVisits.Columns.Contains("VisitDate"))
                dataGridVisits.Columns["VisitDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboPets.SelectedItem == null || comboServices.SelectedItem == null)
            {
                MessageBox.Show("Выберите питомца и услугу.");
                return;
            }

            var pet = (ComboItem)comboPets.SelectedItem;
            var service = (ComboItem)comboServices.SelectedItem;
            var visitDate = dateTimePicker.Value.Date;
            var diagnosis = txtDiagnosis.Text;

            var dtPrice = DatabaseHelper.GetDataParam(
                "SELECT Price FROM Services WHERE ServiceID = ?",
                new OleDbParameter("?", service.Id)
            );
            decimal price = dtPrice.Rows.Count > 0 ? Convert.ToDecimal(dtPrice.Rows[0][0]) : 0m;

            var check = DatabaseHelper.GetDataParam(
                "SELECT COUNT(*) FROM Visits WHERE PetID = ? AND VisitDate = ?",
                new OleDbParameter("?", pet.Id),
                new OleDbParameter("?", visitDate)
            );
            if (Convert.ToInt32(check.Rows[0][0]) > 0)
            {
                MessageBox.Show("Питомец уже записан на эту дату!");
                return;
            }

            var costParam = new OleDbParameter("?", OleDbType.Currency) { Value = price };

            DatabaseHelper.ExecuteQuery(
                "INSERT INTO Visits (PetID, VisitDate, Diagnosis, TotalCost, ServiceID) VALUES (?, ?, ?, ?, ?)",
                new OleDbParameter("?", pet.Id),
                new OleDbParameter("?", visitDate),
                new OleDbParameter("?", diagnosis ?? ""),
                costParam,
                new OleDbParameter("?", service.Id)
            );

            LoadVisits();
            txtDiagnosis.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridVisits.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridVisits.CurrentRow.Cells["VisitID"].Value);
            DatabaseHelper.ExecuteQuery("DELETE FROM Visits WHERE VisitID = ?", new OleDbParameter("?", id));
            LoadVisits();
        }
    }
}
