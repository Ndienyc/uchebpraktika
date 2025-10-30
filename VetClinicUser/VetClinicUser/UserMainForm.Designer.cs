namespace VetClinicUser
{
    partial class UserMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMyVisits;
        private System.Windows.Forms.Button btnAddVisit;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnMyVisits = new System.Windows.Forms.Button();
            this.btnAddVisit = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // btnMyVisits
            this.btnMyVisits.BackColor = System.Drawing.Color.FromArgb(52, 152, 219); // синий
            this.btnMyVisits.FlatAppearance.BorderSize = 0;
            this.btnMyVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyVisits.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMyVisits.ForeColor = System.Drawing.Color.White;
            this.btnMyVisits.Location = new System.Drawing.Point(70, 30);
            this.btnMyVisits.Name = "btnMyVisits";
            this.btnMyVisits.Size = new System.Drawing.Size(330, 55);
            this.btnMyVisits.TabIndex = 1;
            this.btnMyVisits.Text = "📅 Мои приёмы";
            this.btnMyVisits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyVisits.Click += new System.EventHandler(this.btnMyVisits_Click);

            // btnAddVisit
            this.btnAddVisit.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // зелёный
            this.btnAddVisit.FlatAppearance.BorderSize = 0;
            this.btnAddVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVisit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddVisit.ForeColor = System.Drawing.Color.White;
            this.btnAddVisit.Location = new System.Drawing.Point(70, 100);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(330, 55);
            this.btnAddVisit.TabIndex = 2;
            this.btnAddVisit.Text = "➕ Записать питомца";
            this.btnAddVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVisit.Click += new System.EventHandler(this.btnAddVisit_Click);

            // btnServices
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(155, 89, 182); // сиреневый
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Location = new System.Drawing.Point(70, 170);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(330, 55);
            this.btnServices.TabIndex = 4;
            this.btnServices.Text = "💊 Услуги";
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);

            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(140, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // UserMainForm
            this.ClientSize = new System.Drawing.Size(480, 310);
            this.Controls.Add(this.btnMyVisits);
            this.Controls.Add(this.btnAddVisit);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserMainForm";
            this.Text = "Ветеринарная клиника — Пользователь";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }
    }
}
