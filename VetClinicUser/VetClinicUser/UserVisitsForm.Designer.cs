namespace VetClinicUser
{
    partial class UserVisitsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridVisits;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridVisits = new System.Windows.Forms.DataGridView();
            dataGridVisits.Location = new System.Drawing.Point(20, 20);
            dataGridVisits.Size = new System.Drawing.Size(800, 300);
            dataGridVisits.ReadOnly = true;
            dataGridVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.ClientSize = new System.Drawing.Size(850, 350);
            this.Controls.Add(dataGridVisits);
            this.Text = "Журнал посещений";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }
    }
}
