namespace VetClinicApp
{
    partial class VisitsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridVisits;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox comboPets;
        private System.Windows.Forms.ComboBox comboServices;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridVisits = new DataGridView();
            lblPet = new Label();
            comboPets = new ComboBox();
            lblDate = new Label();
            dateTimePicker = new DateTimePicker();
            lblService = new Label();
            comboServices = new ComboBox();
            lblDiagnosis = new Label();
            txtDiagnosis = new TextBox();
            lblPrice = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridVisits).BeginInit();
            SuspendLayout();
            // 
            // dataGridVisits
            // 
            dataGridVisits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVisits.Location = new Point(20, 20);
            dataGridVisits.Name = "dataGridVisits";
            dataGridVisits.ReadOnly = true;
            dataGridVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVisits.Size = new Size(800, 220);
            dataGridVisits.TabIndex = 0;
            // 
            // lblPet
            // 
            lblPet.Location = new Point(20, 255);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(70, 20);
            lblPet.TabIndex = 1;
            lblPet.Text = "Питомец:";
            // 
            // comboPets
            // 
            comboPets.Location = new Point(95, 252);
            comboPets.Name = "comboPets";
            comboPets.Size = new Size(200, 23);
            comboPets.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(320, 255);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(70, 20);
            lblDate.TabIndex = 3;
            lblDate.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(395, 252);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(150, 23);
            dateTimePicker.TabIndex = 4;
            // 
            // lblService
            // 
            lblService.Location = new Point(20, 290);
            lblService.Name = "lblService";
            lblService.Size = new Size(70, 20);
            lblService.TabIndex = 5;
            lblService.Text = "Услуга:";
            // 
            // comboServices
            // 
            comboServices.Location = new Point(95, 287);
            comboServices.Name = "comboServices";
            comboServices.Size = new Size(200, 23);
            comboServices.TabIndex = 6;
            comboServices.SelectedIndexChanged += comboServices_SelectedIndexChanged;
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.Location = new Point(320, 290);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(70, 20);
            lblDiagnosis.TabIndex = 7;
            lblDiagnosis.Text = "Диагноз:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(395, 287);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(220, 23);
            txtDiagnosis.TabIndex = 8;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(594, 258);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(140, 20);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Стоимость: ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(750, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Добавить";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(750, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Удалить";
            btnDelete.Click += btnDelete_Click;
            // 
            // VisitsForm
            // 
            ClientSize = new Size(850, 340);
            Controls.Add(dataGridVisits);
            Controls.Add(lblPet);
            Controls.Add(comboPets);
            Controls.Add(lblDate);
            Controls.Add(dateTimePicker);
            Controls.Add(lblService);
            Controls.Add(comboServices);
            Controls.Add(lblDiagnosis);
            Controls.Add(txtDiagnosis);
            Controls.Add(lblPrice);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Name = "VisitsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Журнал посещений";
            ((System.ComponentModel.ISupportInitialize)dataGridVisits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
