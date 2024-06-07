namespace ApplicationBudget
{
    partial class EvenementsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.affichageEvenements1 = new ApplicationBudget.AffichageEvenements();
            this.ajouterEvenement1 = new ApplicationBudget.AjouterEvenement();
            this.SuspendLayout();
            // 
            // affichageEvenements1
            // 
            this.affichageEvenements1.BackColor = System.Drawing.Color.White;
            this.affichageEvenements1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.affichageEvenements1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.affichageEvenements1.Location = new System.Drawing.Point(21, 44);
            this.affichageEvenements1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.affichageEvenements1.Name = "affichageEvenements1";
            this.affichageEvenements1.Size = new System.Drawing.Size(471, 623);
            this.affichageEvenements1.TabIndex = 1;
            // 
            // ajouterEvenement1
            // 
            this.ajouterEvenement1.BackColor = System.Drawing.Color.White;
            this.ajouterEvenement1.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.ajouterEvenement1.Location = new System.Drawing.Point(542, 44);
            this.ajouterEvenement1.Margin = new System.Windows.Forms.Padding(4);
            this.ajouterEvenement1.Name = "ajouterEvenement1";
            this.ajouterEvenement1.Size = new System.Drawing.Size(449, 623);
            this.ajouterEvenement1.TabIndex = 0;
            this.ajouterEvenement1.Load += new System.EventHandler(this.ajouterEvenement1_Load);
            // 
            // EvenementsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.affichageEvenements1);
            this.Controls.Add(this.ajouterEvenement1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvenementsControl";
            this.Size = new System.Drawing.Size(1040, 711);
            this.ResumeLayout(false);

        }

        #endregion

        private AjouterEvenement ajouterEvenement1;
        private AffichageEvenements affichageEvenements1;
    }
}