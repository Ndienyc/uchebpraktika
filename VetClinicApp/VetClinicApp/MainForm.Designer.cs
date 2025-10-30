namespace VetClinicApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnOwners;
        private Button btnPets;
        private Button btnServices;
        private Button btnVisits;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnOwners = new Button();
            btnPets = new Button();
            btnServices = new Button();
            btnVisits = new Button();

            // btnOwners
            btnOwners.Location = new System.Drawing.Point(50, 30);
            btnOwners.Size = new System.Drawing.Size(300, 40);
            btnOwners.Text = "📋 Владельцы";
            btnOwners.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnOwners.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnOwners.ForeColor = System.Drawing.Color.White;
            btnOwners.FlatStyle = FlatStyle.Flat;
            btnOwners.Cursor = Cursors.Hand;
            btnOwners.Click += btnOwners_Click;

            // btnPets
            btnPets.Location = new System.Drawing.Point(50, 80);
            btnPets.Size = new System.Drawing.Size(300, 40);
            btnPets.Text = "🐾 Питомцы";
            btnPets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnPets.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnPets.ForeColor = System.Drawing.Color.White;
            btnPets.FlatStyle = FlatStyle.Flat;
            btnPets.Cursor = Cursors.Hand;
            btnPets.Click += btnPets_Click;

            // btnServices
            btnServices.Location = new System.Drawing.Point(50, 130);
            btnServices.Size = new System.Drawing.Size(300, 40);
            btnServices.Text = "💊 Услуги";
            btnServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnServices.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            btnServices.ForeColor = System.Drawing.Color.White;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Cursor = Cursors.Hand;
            btnServices.Click += btnServices_Click;

            // btnVisits
            btnVisits.Location = new System.Drawing.Point(50, 180);
            btnVisits.Size = new System.Drawing.Size(300, 40);
            btnVisits.Text = "📅 Посещения";
            btnVisits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnVisits.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            btnVisits.ForeColor = System.Drawing.Color.White;
            btnVisits.FlatStyle = FlatStyle.Flat;
            btnVisits.Cursor = Cursors.Hand;
            btnVisits.Click += btnVisits_Click;

            // MainForm
            Controls.Add(btnOwners);
            Controls.Add(btnPets);
            Controls.Add(btnServices);
            Controls.Add(btnVisits);
            Text = "Ветеринарная клиника - Администратор";
            ClientSize = new System.Drawing.Size(400, 250);
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
