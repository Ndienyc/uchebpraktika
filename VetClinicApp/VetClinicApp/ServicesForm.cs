using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VetClinicApp
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var dt = DatabaseHelper.GetData("SELECT * FROM Services");
            dataGridServices.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);

            DatabaseHelper.ExecuteQuery(
                "INSERT INTO Services (ServiceName, Price) VALUES (?, ?)",
                new OleDbParameter("?", txtName.Text),
                new OleDbParameter("?", price)
            );
            LoadData();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridServices.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridServices.CurrentRow.Cells["ServiceID"].Value);
            DatabaseHelper.ExecuteQuery("DELETE FROM Services WHERE ServiceID = ?",
                new OleDbParameter("?", id));
            LoadData();
        }
    }
}
