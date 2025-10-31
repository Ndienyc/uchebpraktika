using System.Data;
using System.Windows.Forms;

namespace VetClinicUser
{
    public partial class UserServicesForm : Form
    {
        public UserServicesForm()
        {
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            var dt = DatabaseHelper.GetData("SELECT ServiceName AS [Название], Price AS [Цена] FROM Services ORDER BY ServiceName");
            dataGridServices.DataSource = dt;
            if (dataGridServices.Columns.Contains("Цена"))
                dataGridServices.Columns["Цена"].DefaultCellStyle.Format = "C2";
        }
    }
}
