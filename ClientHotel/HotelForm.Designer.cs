namespace ClientHotel
{
    partial class HotelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HOT_Nom = new System.Windows.Forms.TextBox();
            this.HOT_NomLab = new System.Windows.Forms.Label();
            this.HOT_DescriptionLab = new System.Windows.Forms.Label();
            this.HOT_Description = new System.Windows.Forms.TextBox();
            this.HOT_Prix = new System.Windows.Forms.ListBox();
            this.HOT_PrixLab = new System.Windows.Forms.Label();
            this.HOT_AdrLigne1Lab = new System.Windows.Forms.Label();
            this.HOT_AdrLigne1 = new System.Windows.Forms.TextBox();
            this.HOT_AdrLigne2Lab = new System.Windows.Forms.Label();
            this.HOT_AdrLigne2 = new System.Windows.Forms.TextBox();
            this.HOT_CPLab = new System.Windows.Forms.Label();
            this.HOT_CP = new System.Windows.Forms.TextBox();
            this.HOT_VilleLab = new System.Windows.Forms.Label();
            this.HOT_Ville = new System.Windows.Forms.TextBox();
            this.HOT_EtatLab = new System.Windows.Forms.Label();
            this.HOT_Etat = new System.Windows.Forms.TextBox();
            this.HOT_PaysLab = new System.Windows.Forms.Label();
            this.HOT_Pays = new System.Windows.Forms.ListBox();
            this.HOT_LatitudeLab = new System.Windows.Forms.Label();
            this.HOT_Latitude = new System.Windows.Forms.TextBox();
            this.HOT_LongitudeLab = new System.Windows.Forms.Label();
            this.HOT_Longitude = new System.Windows.Forms.TextBox();
            this.HOT_TelephoneLab = new System.Windows.Forms.Label();
            this.HOT_Telephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HOT_Nom
            // 
            this.HOT_Nom.Location = new System.Drawing.Point(111, 12);
            this.HOT_Nom.Name = "HOT_Nom";
            this.HOT_Nom.Size = new System.Drawing.Size(223, 20);
            this.HOT_Nom.TabIndex = 0;
            this.HOT_Nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HOT_NomLab
            // 
            this.HOT_NomLab.AutoSize = true;
            this.HOT_NomLab.Location = new System.Drawing.Point(12, 15);
            this.HOT_NomLab.Name = "HOT_NomLab";
            this.HOT_NomLab.Size = new System.Drawing.Size(29, 13);
            this.HOT_NomLab.TabIndex = 1;
            this.HOT_NomLab.Text = "Nom";
            this.HOT_NomLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // HOT_DescriptionLab
            // 
            this.HOT_DescriptionLab.AutoSize = true;
            this.HOT_DescriptionLab.Location = new System.Drawing.Point(12, 41);
            this.HOT_DescriptionLab.Name = "HOT_DescriptionLab";
            this.HOT_DescriptionLab.Size = new System.Drawing.Size(60, 13);
            this.HOT_DescriptionLab.TabIndex = 3;
            this.HOT_DescriptionLab.Text = "Description";
            // 
            // HOT_Description
            // 
            this.HOT_Description.AcceptsReturn = true;
            this.HOT_Description.Location = new System.Drawing.Point(111, 38);
            this.HOT_Description.Multiline = true;
            this.HOT_Description.Name = "HOT_Description";
            this.HOT_Description.Size = new System.Drawing.Size(526, 63);
            this.HOT_Description.TabIndex = 2;
            // 
            // HOT_Prix
            // 
            this.HOT_Prix.FormattingEnabled = true;
            this.HOT_Prix.Location = new System.Drawing.Point(444, 14);
            this.HOT_Prix.Name = "HOT_Prix";
            this.HOT_Prix.Size = new System.Drawing.Size(193, 17);
            this.HOT_Prix.TabIndex = 4;
            // 
            // HOT_PrixLab
            // 
            this.HOT_PrixLab.AutoSize = true;
            this.HOT_PrixLab.Location = new System.Drawing.Point(383, 15);
            this.HOT_PrixLab.Name = "HOT_PrixLab";
            this.HOT_PrixLab.Size = new System.Drawing.Size(24, 13);
            this.HOT_PrixLab.TabIndex = 5;
            this.HOT_PrixLab.Text = "Prix";
            this.HOT_PrixLab.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HOT_AdrLigne1Lab
            // 
            this.HOT_AdrLigne1Lab.AutoSize = true;
            this.HOT_AdrLigne1Lab.Location = new System.Drawing.Point(12, 110);
            this.HOT_AdrLigne1Lab.Name = "HOT_AdrLigne1Lab";
            this.HOT_AdrLigne1Lab.Size = new System.Drawing.Size(79, 13);
            this.HOT_AdrLigne1Lab.TabIndex = 7;
            this.HOT_AdrLigne1Lab.Text = "Adresse ligne 1";
            // 
            // HOT_AdrLigne1
            // 
            this.HOT_AdrLigne1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.HOT_AdrLigne1.Location = new System.Drawing.Point(111, 107);
            this.HOT_AdrLigne1.Name = "HOT_AdrLigne1";
            this.HOT_AdrLigne1.Size = new System.Drawing.Size(334, 20);
            this.HOT_AdrLigne1.TabIndex = 6;
            // 
            // HOT_AdrLigne2Lab
            // 
            this.HOT_AdrLigne2Lab.AutoSize = true;
            this.HOT_AdrLigne2Lab.Location = new System.Drawing.Point(12, 136);
            this.HOT_AdrLigne2Lab.Name = "HOT_AdrLigne2Lab";
            this.HOT_AdrLigne2Lab.Size = new System.Drawing.Size(79, 13);
            this.HOT_AdrLigne2Lab.TabIndex = 9;
            this.HOT_AdrLigne2Lab.Text = "Adresse ligne 2";
            // 
            // HOT_AdrLigne2
            // 
            this.HOT_AdrLigne2.Location = new System.Drawing.Point(111, 133);
            this.HOT_AdrLigne2.Name = "HOT_AdrLigne2";
            this.HOT_AdrLigne2.Size = new System.Drawing.Size(334, 20);
            this.HOT_AdrLigne2.TabIndex = 8;
            // 
            // HOT_CPLab
            // 
            this.HOT_CPLab.AutoSize = true;
            this.HOT_CPLab.Location = new System.Drawing.Point(12, 162);
            this.HOT_CPLab.Name = "HOT_CPLab";
            this.HOT_CPLab.Size = new System.Drawing.Size(63, 13);
            this.HOT_CPLab.TabIndex = 11;
            this.HOT_CPLab.Text = "Code postal";
            // 
            // HOT_CP
            // 
            this.HOT_CP.Location = new System.Drawing.Point(111, 159);
            this.HOT_CP.Name = "HOT_CP";
            this.HOT_CP.Size = new System.Drawing.Size(103, 20);
            this.HOT_CP.TabIndex = 10;
            // 
            // HOT_VilleLab
            // 
            this.HOT_VilleLab.AutoSize = true;
            this.HOT_VilleLab.Location = new System.Drawing.Point(322, 166);
            this.HOT_VilleLab.Name = "HOT_VilleLab";
            this.HOT_VilleLab.Size = new System.Drawing.Size(26, 13);
            this.HOT_VilleLab.TabIndex = 13;
            this.HOT_VilleLab.Text = "Ville";
            // 
            // HOT_Ville
            // 
            this.HOT_Ville.Location = new System.Drawing.Point(386, 159);
            this.HOT_Ville.Name = "HOT_Ville";
            this.HOT_Ville.Size = new System.Drawing.Size(251, 20);
            this.HOT_Ville.TabIndex = 12;
            // 
            // HOT_EtatLab
            // 
            this.HOT_EtatLab.AutoSize = true;
            this.HOT_EtatLab.Location = new System.Drawing.Point(12, 188);
            this.HOT_EtatLab.Name = "HOT_EtatLab";
            this.HOT_EtatLab.Size = new System.Drawing.Size(26, 13);
            this.HOT_EtatLab.TabIndex = 15;
            this.HOT_EtatLab.Text = "Etat";
            // 
            // HOT_Etat
            // 
            this.HOT_Etat.Location = new System.Drawing.Point(111, 185);
            this.HOT_Etat.Name = "HOT_Etat";
            this.HOT_Etat.Size = new System.Drawing.Size(198, 20);
            this.HOT_Etat.TabIndex = 14;
            // 
            // HOT_PaysLab
            // 
            this.HOT_PaysLab.AutoSize = true;
            this.HOT_PaysLab.Location = new System.Drawing.Point(340, 188);
            this.HOT_PaysLab.Name = "HOT_PaysLab";
            this.HOT_PaysLab.Size = new System.Drawing.Size(30, 13);
            this.HOT_PaysLab.TabIndex = 17;
            this.HOT_PaysLab.Text = "Pays";
            // 
            // HOT_Pays
            // 
            this.HOT_Pays.FormattingEnabled = true;
            this.HOT_Pays.Location = new System.Drawing.Point(444, 188);
            this.HOT_Pays.Name = "HOT_Pays";
            this.HOT_Pays.Size = new System.Drawing.Size(193, 17);
            this.HOT_Pays.TabIndex = 18;
            // 
            // HOT_LatitudeLab
            // 
            this.HOT_LatitudeLab.AutoSize = true;
            this.HOT_LatitudeLab.Location = new System.Drawing.Point(12, 238);
            this.HOT_LatitudeLab.Name = "HOT_LatitudeLab";
            this.HOT_LatitudeLab.Size = new System.Drawing.Size(45, 13);
            this.HOT_LatitudeLab.TabIndex = 20;
            this.HOT_LatitudeLab.Text = "Latitude";
            // 
            // HOT_Latitude
            // 
            this.HOT_Latitude.Location = new System.Drawing.Point(111, 235);
            this.HOT_Latitude.Name = "HOT_Latitude";
            this.HOT_Latitude.Size = new System.Drawing.Size(198, 20);
            this.HOT_Latitude.TabIndex = 19;
            // 
            // HOT_LongitudeLab
            // 
            this.HOT_LongitudeLab.AutoSize = true;
            this.HOT_LongitudeLab.Location = new System.Drawing.Point(340, 238);
            this.HOT_LongitudeLab.Name = "HOT_LongitudeLab";
            this.HOT_LongitudeLab.Size = new System.Drawing.Size(54, 13);
            this.HOT_LongitudeLab.TabIndex = 22;
            this.HOT_LongitudeLab.Text = "Longitude";
            this.HOT_LongitudeLab.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // HOT_Longitude
            // 
            this.HOT_Longitude.Location = new System.Drawing.Point(439, 235);
            this.HOT_Longitude.Name = "HOT_Longitude";
            this.HOT_Longitude.Size = new System.Drawing.Size(198, 20);
            this.HOT_Longitude.TabIndex = 21;
            this.HOT_Longitude.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // HOT_TelephoneLab
            // 
            this.HOT_TelephoneLab.AutoSize = true;
            this.HOT_TelephoneLab.Location = new System.Drawing.Point(12, 291);
            this.HOT_TelephoneLab.Name = "HOT_TelephoneLab";
            this.HOT_TelephoneLab.Size = new System.Drawing.Size(45, 13);
            this.HOT_TelephoneLab.TabIndex = 24;
            this.HOT_TelephoneLab.Text = "Latitude";
            // 
            // HOT_Telephone
            // 
            this.HOT_Telephone.Location = new System.Drawing.Point(111, 288);
            this.HOT_Telephone.Name = "HOT_Telephone";
            this.HOT_Telephone.Size = new System.Drawing.Size(198, 20);
            this.HOT_Telephone.TabIndex = 23;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 494);
            this.Controls.Add(this.HOT_TelephoneLab);
            this.Controls.Add(this.HOT_Telephone);
            this.Controls.Add(this.HOT_LongitudeLab);
            this.Controls.Add(this.HOT_Longitude);
            this.Controls.Add(this.HOT_LatitudeLab);
            this.Controls.Add(this.HOT_Latitude);
            this.Controls.Add(this.HOT_Pays);
            this.Controls.Add(this.HOT_PaysLab);
            this.Controls.Add(this.HOT_EtatLab);
            this.Controls.Add(this.HOT_Etat);
            this.Controls.Add(this.HOT_VilleLab);
            this.Controls.Add(this.HOT_Ville);
            this.Controls.Add(this.HOT_CPLab);
            this.Controls.Add(this.HOT_CP);
            this.Controls.Add(this.HOT_AdrLigne2Lab);
            this.Controls.Add(this.HOT_AdrLigne2);
            this.Controls.Add(this.HOT_AdrLigne1Lab);
            this.Controls.Add(this.HOT_AdrLigne1);
            this.Controls.Add(this.HOT_PrixLab);
            this.Controls.Add(this.HOT_Prix);
            this.Controls.Add(this.HOT_DescriptionLab);
            this.Controls.Add(this.HOT_Description);
            this.Controls.Add(this.HOT_NomLab);
            this.Controls.Add(this.HOT_Nom);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HOT_Nom;
        private System.Windows.Forms.Label HOT_NomLab;
        private System.Windows.Forms.Label HOT_DescriptionLab;
        private System.Windows.Forms.TextBox HOT_Description;
        private System.Windows.Forms.ListBox HOT_Prix;
        private System.Windows.Forms.Label HOT_PrixLab;
        private System.Windows.Forms.Label HOT_AdrLigne1Lab;
        private System.Windows.Forms.TextBox HOT_AdrLigne1;
        private System.Windows.Forms.Label HOT_AdrLigne2Lab;
        private System.Windows.Forms.TextBox HOT_AdrLigne2;
        private System.Windows.Forms.Label HOT_CPLab;
        private System.Windows.Forms.TextBox HOT_CP;
        private System.Windows.Forms.Label HOT_VilleLab;
        private System.Windows.Forms.TextBox HOT_Ville;
        private System.Windows.Forms.Label HOT_EtatLab;
        private System.Windows.Forms.TextBox HOT_Etat;
        private System.Windows.Forms.Label HOT_PaysLab;
        private System.Windows.Forms.ListBox HOT_Pays;
        private System.Windows.Forms.Label HOT_LatitudeLab;
        private System.Windows.Forms.TextBox HOT_Latitude;
        private System.Windows.Forms.Label HOT_LongitudeLab;
        private System.Windows.Forms.TextBox HOT_Longitude;
        private System.Windows.Forms.Label HOT_TelephoneLab;
        private System.Windows.Forms.TextBox HOT_Telephone;
    }
}