using System.Windows.Forms;
namespace ClientHotel
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button btnInscription;
        private Button btnConnexion;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.lblServeur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(674, 12);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(131, 39);
            this.btnInscription.TabIndex = 0;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(811, 12);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(131, 39);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // txtServeur
            // 
            this.txtServeur.Location = new System.Drawing.Point(228, 29);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.Size = new System.Drawing.Size(351, 22);
            this.txtServeur.TabIndex = 2;
            // 
            // lblServeur
            // 
            this.lblServeur.AutoSize = true;
            this.lblServeur.Location = new System.Drawing.Point(86, 32);
            this.lblServeur.Name = "lblServeur";
            this.lblServeur.Size = new System.Drawing.Size(98, 17);
            this.lblServeur.TabIndex = 3;
            this.lblServeur.Text = "Url du serveur";
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(954, 514);
            this.Controls.Add(this.lblServeur);
            this.Controls.Add(this.txtServeur);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.btnInscription);
            this.Name = "Home";
            this.Text = "ClientHotel";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServeur;
        private System.Windows.Forms.Label lblServeur;
    }
}

