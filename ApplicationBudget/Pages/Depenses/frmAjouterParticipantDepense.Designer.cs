namespace ApplicationBudget
{
    partial class frmAjouterParticipantDepense
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeselectionnerTout = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouterTout = new System.Windows.Forms.Button();
            this.panelBeneficiaires = new System.Windows.Forms.Panel();
            this.lblBeneficiaires = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeselectionnerTout);
            this.panel2.Controls.Add(this.btnValider);
            this.panel2.Controls.Add(this.btnFermer);
            this.panel2.Controls.Add(this.btnAjouterTout);
            this.panel2.Controls.Add(this.panelBeneficiaires);
            this.panel2.Controls.Add(this.lblBeneficiaires);
            this.panel2.Controls.Add(this.lblTitre);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 604);
            this.panel2.TabIndex = 53;
            // 
            // btnDeselectionnerTout
            // 
            this.btnDeselectionnerTout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeselectionnerTout.FlatAppearance.BorderSize = 0;
            this.btnDeselectionnerTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectionnerTout.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselectionnerTout.ForeColor = System.Drawing.Color.White;
            this.btnDeselectionnerTout.Image = global::ApplicationBudget.Properties.Resources.AnnulerIcon;
            this.btnDeselectionnerTout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeselectionnerTout.Location = new System.Drawing.Point(305, 102);
            this.btnDeselectionnerTout.Name = "btnDeselectionnerTout";
            this.btnDeselectionnerTout.Size = new System.Drawing.Size(111, 36);
            this.btnDeselectionnerTout.TabIndex = 72;
            this.btnDeselectionnerTout.Text = "   Aucune";
            this.btnDeselectionnerTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeselectionnerTout.UseVisualStyleBackColor = false;
            this.btnDeselectionnerTout.Click += new System.EventHandler(this.btnDeselectionnerTout_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Image = global::ApplicationBudget.Properties.Resources.ValidateIcon;
            this.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValider.Location = new System.Drawing.Point(394, 547);
            this.btnValider.Name = "btnValider";
            this.btnValider.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnValider.Size = new System.Drawing.Size(137, 36);
            this.btnValider.TabIndex = 71;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Image = global::ApplicationBudget.Properties.Resources.AnnulerIcon;
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFermer.Location = new System.Drawing.Point(247, 547);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnFermer.Size = new System.Drawing.Size(132, 36);
            this.btnFermer.TabIndex = 70;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouterTout
            // 
            this.btnAjouterTout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAjouterTout.FlatAppearance.BorderSize = 0;
            this.btnAjouterTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterTout.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTout.ForeColor = System.Drawing.Color.White;
            this.btnAjouterTout.Image = global::ApplicationBudget.Properties.Resources.AjouterIcon;
            this.btnAjouterTout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouterTout.Location = new System.Drawing.Point(432, 102);
            this.btnAjouterTout.Name = "btnAjouterTout";
            this.btnAjouterTout.Size = new System.Drawing.Size(99, 36);
            this.btnAjouterTout.TabIndex = 69;
            this.btnAjouterTout.Text = "   Tout";
            this.btnAjouterTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterTout.UseVisualStyleBackColor = false;
            this.btnAjouterTout.Click += new System.EventHandler(this.btnAjouterTout_Click);
            // 
            // panelBeneficiaires
            // 
            this.panelBeneficiaires.AutoScroll = true;
            this.panelBeneficiaires.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBeneficiaires.Location = new System.Drawing.Point(11, 147);
            this.panelBeneficiaires.Name = "panelBeneficiaires";
            this.panelBeneficiaires.Size = new System.Drawing.Size(520, 382);
            this.panelBeneficiaires.TabIndex = 68;
            // 
            // lblBeneficiaires
            // 
            this.lblBeneficiaires.AutoSize = true;
            this.lblBeneficiaires.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaires.Location = new System.Drawing.Point(3, 93);
            this.lblBeneficiaires.Name = "lblBeneficiaires";
            this.lblBeneficiaires.Size = new System.Drawing.Size(209, 45);
            this.lblBeneficiaires.TabIndex = 67;
            this.lblBeneficiaires.Text = "Bénéficiaires";
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(546, 55);
            this.lblTitre.TabIndex = 66;
            this.lblTitre.Text = "Untitled";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAjouterParticipantDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 604);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAjouterParticipantDepense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterParticipant";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeselectionnerTout;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouterTout;
        private System.Windows.Forms.Panel panelBeneficiaires;
        private System.Windows.Forms.Label lblBeneficiaires;
        private System.Windows.Forms.Label lblTitre;
    }
}