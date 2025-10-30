namespace VetClinicUser
{
    partial class UserServicesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridServices;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridServices = new System.Windows.Forms.DataGridView();

            dataGridServices.Location = new System.Drawing.Point(20, 20);
            dataGridServices.Size = new System.Drawing.Size(560, 300);
            dataGridServices.ReadOnly = true;
            dataGridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(dataGridServices);
            this.Text = "Доступные услуги";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }
    }
}
