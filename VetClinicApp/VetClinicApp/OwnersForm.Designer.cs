namespace VetClinicApp
{
    partial class OwnersForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridOwners;
        private TextBox txtName, txtPhone, txtAddress;
        private Button btnAdd, btnDelete;
        private Label lblName, lblPhone, lblAddress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridOwners = new DataGridView();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();

            ((System.ComponentModel.ISupportInitialize)dataGridOwners).BeginInit();
            SuspendLayout();

            // dataGridOwners
            dataGridOwners.Location = new System.Drawing.Point(20, 20);
            dataGridOwners.Size = new System.Drawing.Size(750, 250);
            dataGridOwners.ReadOnly = true;
            dataGridOwners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // lblName
            lblName.Location = new System.Drawing.Point(20, 290);
            lblName.Size = new System.Drawing.Size(80, 20);
            lblName.Text = "ФИО:";

            // txtName
            txtName.Location = new System.Drawing.Point(110, 290);
            txtName.Size = new System.Drawing.Size(250, 23);

            // lblPhone
            lblPhone.Location = new System.Drawing.Point(20, 325);
            lblPhone.Size = new System.Drawing.Size(80, 20);
            lblPhone.Text = "Телефон:";

            // txtPhone
            txtPhone.Location = new System.Drawing.Point(110, 325);
            txtPhone.Size = new System.Drawing.Size(250, 23);

            // lblAddress
            lblAddress.Location = new System.Drawing.Point(20, 360);
            lblAddress.Size = new System.Drawing.Size(80, 20);
            lblAddress.Text = "Адрес:";

            // txtAddress
            txtAddress.Location = new System.Drawing.Point(110, 360);
            txtAddress.Size = new System.Drawing.Size(250, 23);

            // btnAdd
            btnAdd.Location = new System.Drawing.Point(110, 400);
            btnAdd.Size = new System.Drawing.Size(120, 35);
            btnAdd.Text = "Добавить";
            btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Click += btnAdd_Click;

            // btnDelete
            btnDelete.Location = new System.Drawing.Point(240, 400);
            btnDelete.Size = new System.Drawing.Size(120, 35);
            btnDelete.Text = "Удалить";
            btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Click += btnDelete_Click;

            // OwnersForm
            ClientSize = new System.Drawing.Size(800, 460);
            Controls.Add(dataGridOwners);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Text = "Владельцы";
            StartPosition = FormStartPosition.CenterParent;

            ((System.ComponentModel.ISupportInitialize)dataGridOwners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
