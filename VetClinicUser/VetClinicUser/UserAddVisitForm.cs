using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace VetClinicUser
{
    public partial class UserAddVisitForm : Form
    {
        private int ownerId;

        public UserAddVisitForm(int ownerId)
        {
            this.ownerId = ownerId;
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            var dt = DatabaseHelper.GetData("SELECT ServiceID, ServiceName, Price FROM Services ORDER BY ServiceName");
            comboServices.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboServices.Items.Add(new ComboItem(
                    Convert.ToInt32(row["ServiceID"]),
                    $"{row["ServiceName"]} ({Convert.ToDecimal(row["Price"]):C2})"));
            }
            if (comboServices.Items.Count > 0)
                comboServices.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPetName.Text) ||
                string.IsNullOrWhiteSpace(txtSpecies.Text) ||
                string.IsNullOrWhiteSpace(txtBreed.Text))
            {
                MessageBox.Show("Заполните все данные по питомцу!");
                return;
            }

            if (comboServices.SelectedItem == null)
            {
                MessageBox.Show("Выберите услугу!");
                return;
            }

            var selectedService = (ComboItem)comboServices.SelectedItem;

            // Получаем цену услуги для TotalCost
            decimal servicePrice = 0m;
            var priceDt = DatabaseHelper.GetDataParam(
                "SELECT Price FROM Services WHERE ServiceID=?",
                new OleDbParameter("?", selectedService.Id)
            );
            if (priceDt.Rows.Count > 0)
                servicePrice = Convert.ToDecimal(priceDt.Rows[0][0]);

            var visitDate = dtpDate.Value.Date;

            var findPet = DatabaseHelper.GetDataParam(
                "SELECT PetID FROM Pets WHERE PetName=? AND Species=? AND Breed=? AND OwnerID=?",
                new OleDbParameter("?", txtPetName.Text),
                new OleDbParameter("?", txtSpecies.Text),
                new OleDbParameter("?", txtBreed.Text),
                new OleDbParameter("?", ownerId)
            );
            int petId;
            if (findPet.Rows.Count == 0)
            {
                DatabaseHelper.ExecuteQuery(
                    "INSERT INTO Pets (PetName, Species, Breed, OwnerID) VALUES (?, ?, ?, ?)",
                    new OleDbParameter("?", txtPetName.Text),
                    new OleDbParameter("?", txtSpecies.Text),
                    new OleDbParameter("?", txtBreed.Text),
                    new OleDbParameter("?", ownerId)
                );
                var dt = DatabaseHelper.GetDataParam(
                    "SELECT MAX(PetID) FROM Pets WHERE OwnerID=?",
                    new OleDbParameter("?", ownerId)
                );
                petId = Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                petId = Convert.ToInt32(findPet.Rows[0][0]);
            }

            var check = DatabaseHelper.GetDataParam(
                "SELECT COUNT(*) FROM Visits WHERE PetID=? AND VisitDate=?",
                new OleDbParameter("?", petId),
                new OleDbParameter("?", visitDate)
            );
            if (Convert.ToInt32(check.Rows[0][0]) > 0)
            {
                MessageBox.Show("Этот питомец уже записан на эту дату!");
                return;
            }

            var totalCostParam = new OleDbParameter("?", OleDbType.Currency) { Value = servicePrice };

            DatabaseHelper.ExecuteQuery(
                "INSERT INTO Visits (PetID, VisitDate, Diagnosis, TotalCost, ServiceID) VALUES (?, ?, ?, ?, ?)",
                new OleDbParameter("?", petId),
                new OleDbParameter("?", visitDate),
                new OleDbParameter("?", txtDiagnosis.Text ?? ""),
                totalCostParam,
                new OleDbParameter("?", selectedService.Id)
            );

            MessageBox.Show("Питомец записан на приём!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
