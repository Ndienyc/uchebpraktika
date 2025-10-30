using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VetClinicApp
{
    public partial class OwnersForm : Form
    {
        public OwnersForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var dt = DatabaseHelper.GetData("SELECT * FROM Owners");
            dataGridOwners.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DatabaseHelper.ExecuteQuery(
                "INSERT INTO Owners (FullName, Phone, Address) VALUES (?, ?, ?)",
                new OleDbParameter("?", txtName.Text),
                new OleDbParameter("?", txtPhone.Text),
                new OleDbParameter("?", txtAddress.Text)
            );
            LoadData();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridOwners.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridOwners.CurrentRow.Cells["OwnerID"].Value);
            DatabaseHelper.ExecuteQuery("DELETE FROM Owners WHERE OwnerID = ?",
                new OleDbParameter("?", id));
            LoadData();
        }
    }
}
