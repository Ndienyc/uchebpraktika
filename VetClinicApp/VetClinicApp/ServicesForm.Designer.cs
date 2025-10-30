namespace VetClinicApp
{
    partial class ServicesForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridServices;
        private TextBox txtName, txtPrice;
        private Button btnAdd, btnDelete;
        private Label lblName, lblPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridServices = new DataGridView();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblPrice = new Label();

            ((System.ComponentModel.ISupportInitialize)dataGridServices).BeginInit();
            SuspendLayout();

            // dataGridServices
            dataGridServices.Location = new System.Drawing.Point(20, 20);
            dataGridServices.Size = new System.Drawing.Size(750, 250);
            dataGridServices.ReadOnly = true;
            dataGridServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // lblName
            lblName.Location = new System.Drawing.Point(20, 290);
            lblName.Size = new System.Drawing.Size(100, 20);
            lblName.Text = "Название:";

            // txtName
            txtName.Location = new System.Drawing.Point(130, 290);
            txtName.Size = new System.Drawing.Size(250, 23);

            // lblPrice
            lblPrice.Location = new System.Drawing.Point(20, 325);
            lblPrice.Size = new System.Drawing.Size(100, 20);
            lblPrice.Text = "Цена:";

            // txtPrice
            txtPrice.Location = new System.Drawing.Point(130, 325);
            txtPrice.Size = new System.Drawing.Size(250, 23);

            // btnAdd
            btnAdd.Location = new System.Drawing.Point(130, 370);
            btnAdd.Size = new System.Drawing.Size(120, 35);
            btnAdd.Text = "Добавить";
            btnAdd.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.Click += btnAdd_Click;

            // btnDelete
            btnDelete.Location = new System.Drawing.Point(260, 370);
            btnDelete.Size = new System.Drawing.Size(120, 35);
            btnDelete.Text = "Удалить";
            btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDelete.Click += btnDelete_Click;

            // ServicesForm
            ClientSize = new System.Drawing.Size(800, 430);
            Controls.Add(dataGridServices);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Text = "Услуги клиники";
            StartPosition = FormStartPosition.CenterParent;
            BackColor = System.Drawing.Color.White;

            ((System.ComponentModel.ISupportInitialize)dataGridServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
