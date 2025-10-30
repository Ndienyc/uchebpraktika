using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VetClinicApp
{
    public partial class PetsForm : Form
    {
        public PetsForm()
        {
            InitializeComponent();
            LoadOwners();
            LoadData();
        }

        private void LoadOwners()
        {
            var dt = DatabaseHelper.GetData("SELECT OwnerID, FullName FROM Owners");
            comboOwners.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboOwners.Items.Add(new ComboItem(
                    Convert.ToInt32(row["OwnerID"]),
                    row["FullName"].ToString()));
            }
            if (comboOwners.Items.Count > 0)
                comboOwners.SelectedIndex = 0;
        }

        private void LoadData()
        {
            var query = @"SELECT p.PetID, p.PetName, p.Species, p.Breed, o.FullName AS OwnerName
                         FROM Pets p LEFT JOIN Owners o ON p.OwnerID = o.OwnerID";
            var dt = DatabaseHelper.GetData(query);
            dataGridPets.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboOwners.SelectedItem == null) return;
            var owner = (ComboItem)comboOwners.SelectedItem;

            DatabaseHelper.ExecuteQuery(
                "INSERT INTO Pets (PetName, Species, Breed, OwnerID) VALUES (?, ?, ?, ?)",
                new OleDbParameter("?", txtName.Text),
                new OleDbParameter("?", txtSpecies.Text),
                new OleDbParameter("?", txtBreed.Text),
                new OleDbParameter("?", owner.Id)
            );
            LoadData();
            txtName.Clear();
            txtSpecies.Clear();
            txtBreed.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridPets.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridPets.CurrentRow.Cells["PetID"].Value);
            DatabaseHelper.ExecuteQuery("DELETE FROM Pets WHERE PetID = ?",
                new OleDbParameter("?", id));
            LoadData();
        }
    }
}

