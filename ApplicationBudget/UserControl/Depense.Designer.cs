namespace ApplicationBudget.Pages.Bilan
{
    partial class Depense
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
            this.lblPersonne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.picCategorie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonne
            // 
            this.lblPersonne.AutoSize = true;
            this.lblPersonne.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonne.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblPersonne.Location = new System.Drawing.Point(70, 28);
            this.lblPersonne.Name = "lblPersonne";
            this.lblPersonne.Size = new System.Drawing.Size(126, 20);
            this.lblPersonne.TabIndex = 9;
            this.lblPersonne.Text = "Veronique Richard";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(331, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 20);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "09/01/2024";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(349, 6);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(67, 20);
            this.lblMontant.TabIndex = 7;
            this.lblMontant.Text = "189.88€";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(70, 6);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(143, 20);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Nom de la depense";
            // 
            // picCategorie
            // 
            this.picCategorie.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCategorie.Image = global::ApplicationBudget.Properties.Resources.Alimentation;
            this.picCategorie.Location = new System.Drawing.Point(0, 0);
            this.picCategorie.Name = "picCategorie";
            this.picCategorie.Size = new System.Drawing.Size(59, 58);
            this.picCategorie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCategorie.TabIndex = 5;
            this.picCategorie.TabStop = false;
            // 
            // Depense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Controls.Add(this.lblPersonne);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.picCategorie);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.Name = "Depense";
            this.Size = new System.Drawing.Size(424, 58);
            ((System.ComponentModel.ISupportInitialize)(this.picCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonne;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox picCategorie;
    }
}
