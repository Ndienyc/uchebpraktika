namespace VetClinicApp
{
    partial class PetsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridPets;
        private TextBox txtName, txtSpecies, txtBreed;
        private ComboBox comboOwners;
        private Button btnAdd, btnDelete;
        private Label lblName, lblSpecies, lblBreed, lblOwner;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridPets = new DataGridView();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtBreed = new TextBox();
            comboOwners = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblSpecies = new Label();
            lblBreed = new Label();
            lblOwner = new Label();

            // dataGridPets
            dataGridPets.Location = new System.Drawing.Point(20, 20);
            dataGridPets.Size = new System.Drawing.Size(750, 250);
            dataGridPets.ReadOnly = true;

            // lblName
            lblName.Location = new System.Drawing.Point(20, 290);
            lblName.Text = "Кличка:";
            lblName.Size = new System.Drawing.Size(80, 20);

            // txtName
            txtName.Location = new System.Drawing.Point(110, 290);
            txtName.Size = new System.Drawing.Size(200, 23);

            // lblSpecies
            lblSpecies.Location = new System.Drawing.Point(20, 325);
            lblSpecies.Text = "Вид:";
            lblSpecies.Size = new System.Drawing.Size(80, 20);

            // txtSpecies
            txtSpecies.Location = new System.Drawing.Point(110, 325);
            txtSpecies.Size = new System.Drawing.Size(200, 23);

            // lblBreed
            lblBreed.Location = new System.Drawing.Point(20, 360);
            lblBreed.Text = "Порода:";
            lblBreed.Size = new System.Drawing.Size(80, 20);

            // txtBreed
            txtBreed.Location = new System.Drawing.Point(110, 360);
            txtBreed.Size = new System.Drawing.Size(200, 23);

            // lblOwner
            lblOwner.Location = new System.Drawing.Point(340, 290);
            lblOwner.Text = "Владелец:";
            lblOwner.Size = new System.Drawing.Size(80, 20);

            // comboOwners
            comboOwners.Location = new System.Drawing.Point(430, 290);
            comboOwners.Size = new System.Drawing.Size(200, 23);
            comboOwners.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnAdd
            btnAdd.Location = new System.Drawing.Point(110, 400);
            btnAdd.Size = new System.Drawing.Size(120, 35);
            btnAdd.Text = "Добавить";
            btnAdd.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
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

            // PetsForm
            ClientSize = new System.Drawing.Size(800, 460);
            Controls.Add(dataGridPets);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblSpecies);
            Controls.Add(txtSpecies);
            Controls.Add(lblBreed);
            Controls.Add(txtBreed);
            Controls.Add(lblOwner);
            Controls.Add(comboOwners);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Text = "Питомцы";
            StartPosition = FormStartPosition.CenterParent;
        }
    }
}
