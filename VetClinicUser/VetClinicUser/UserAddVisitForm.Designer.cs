namespace VetClinicUser
{
    partial class UserAddVisitForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPetName, lblSpecies, lblBreed, lblDate, lblDiagnosis, lblService;
        private System.Windows.Forms.TextBox txtPetName, txtSpecies, txtBreed, txtDiagnosis;
        private System.Windows.Forms.ComboBox comboServices;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblPetName = new System.Windows.Forms.Label();
            txtPetName = new System.Windows.Forms.TextBox();
            lblSpecies = new System.Windows.Forms.Label();
            txtSpecies = new System.Windows.Forms.TextBox();
            lblBreed = new System.Windows.Forms.Label();
            txtBreed = new System.Windows.Forms.TextBox();
            lblDate = new System.Windows.Forms.Label();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            lblService = new System.Windows.Forms.Label();
            comboServices = new System.Windows.Forms.ComboBox();
            lblDiagnosis = new System.Windows.Forms.Label();
            txtDiagnosis = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();

            lblPetName.Location = new System.Drawing.Point(20, 15);
            lblPetName.Size = new System.Drawing.Size(130, 20);
            lblPetName.Text = "Кличка питомца:";
            txtPetName.Location = new System.Drawing.Point(160, 15);
            txtPetName.Size = new System.Drawing.Size(200, 23);

            lblSpecies.Location = new System.Drawing.Point(20, 45);
            lblSpecies.Size = new System.Drawing.Size(130, 20);
            lblSpecies.Text = "Вид:";
            txtSpecies.Location = new System.Drawing.Point(160, 45);
            txtSpecies.Size = new System.Drawing.Size(200, 23);

            lblBreed.Location = new System.Drawing.Point(20, 75);
            lblBreed.Size = new System.Drawing.Size(130, 20);
            lblBreed.Text = "Порода:";
            txtBreed.Location = new System.Drawing.Point(160, 75);
            txtBreed.Size = new System.Drawing.Size(200, 23);

            lblDate.Location = new System.Drawing.Point(20, 105);
            lblDate.Size = new System.Drawing.Size(130, 20);
            lblDate.Text = "Дата приёма:";
            dtpDate.Location = new System.Drawing.Point(160, 105);
            dtpDate.Size = new System.Drawing.Size(200, 23);
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            lblService.Location = new System.Drawing.Point(20, 135);
            lblService.Size = new System.Drawing.Size(130, 20);
            lblService.Text = "Услуга:";
            comboServices.Location = new System.Drawing.Point(160, 135);
            comboServices.Size = new System.Drawing.Size(200, 23);

            lblDiagnosis.Location = new System.Drawing.Point(20, 165);
            lblDiagnosis.Size = new System.Drawing.Size(130, 20);
            lblDiagnosis.Text = "Диагноз:";
            txtDiagnosis.Location = new System.Drawing.Point(160, 165);
            txtDiagnosis.Size = new System.Drawing.Size(200, 23);

            btnAdd.Location = new System.Drawing.Point(160, 205);
            btnAdd.Size = new System.Drawing.Size(120, 35);
            btnAdd.Text = "Записать";
            btnAdd.Click += btnAdd_Click;

            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(lblPetName);
            this.Controls.Add(txtPetName);
            this.Controls.Add(lblSpecies);
            this.Controls.Add(txtSpecies);
            this.Controls.Add(lblBreed);
            this.Controls.Add(txtBreed);
            this.Controls.Add(lblDate);
            this.Controls.Add(dtpDate);
            this.Controls.Add(lblService);
            this.Controls.Add(comboServices);
            this.Controls.Add(lblDiagnosis);
            this.Controls.Add(txtDiagnosis);
            this.Controls.Add(btnAdd);
            this.Text = "Записать питомца на приём";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }
    }
}
