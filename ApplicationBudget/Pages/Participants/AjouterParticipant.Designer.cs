namespace ApplicationBudget.Pages.Participants
{
    partial class AjouterParticipant
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.lblEvement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrganisateur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAjoutParticipant = new System.Windows.Forms.Button();
            this.panelEvent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(118, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 28);
            this.label2.TabIndex = 67;
            this.label2.Text = "*";
            // 
            // cboEvenements
            // 
            this.cboEvenements.BackColor = System.Drawing.Color.White;
            this.cboEvenements.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Items.AddRange(new object[] {
            "basically",
            "nothing",
            "for",
            "now"});
            this.cboEvenements.Location = new System.Drawing.Point(141, 102);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(323, 40);
            this.cboEvenements.TabIndex = 53;
            // 
            // lblEvement
            // 
            this.lblEvement.AutoSize = true;
            this.lblEvement.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvement.Location = new System.Drawing.Point(19, 105);
            this.lblEvement.Name = "lblEvement";
            this.lblEvement.Size = new System.Drawing.Size(141, 32);
            this.lblEvement.TabIndex = 52;
            this.lblEvement.Text = "Evènement ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 54);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ajout Participant";
            // 
            // panelEvent
            // 
            this.panelEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelEvent.Controls.Add(this.panel1);
            this.panelEvent.Controls.Add(this.label7);
            this.panelEvent.Controls.Add(this.lblOrganisateur);
            this.panelEvent.Controls.Add(this.label5);
            this.panelEvent.Controls.Add(this.lblDateFin);
            this.panelEvent.Controls.Add(this.pictureBox3);
            this.panelEvent.Controls.Add(this.lblDateDebut);
            this.panelEvent.ForeColor = System.Drawing.Color.White;
            this.panelEvent.Location = new System.Drawing.Point(24, 159);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(440, 325);
            this.panelEvent.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Controls.Add(this.lblSolde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 209);
            this.panel1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 46);
            this.label4.TabIndex = 40;
            this.label4.Text = "Evènement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(0, 46);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(440, 129);
            this.lblTitre.TabIndex = 34;
            this.lblTitre.Text = "We découverte de Paris";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolde
            // 
            this.lblSolde.BackColor = System.Drawing.Color.White;
            this.lblSolde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSolde.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.ForeColor = System.Drawing.Color.Black;
            this.lblSolde.Location = new System.Drawing.Point(0, 175);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(440, 34);
            this.lblSolde.TabIndex = 44;
            this.lblSolde.Text = "Soldé";
            this.lblSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 28);
            this.label7.TabIndex = 43;
            this.label7.Text = "Durée :";
            // 
            // lblOrganisateur
            // 
            this.lblOrganisateur.AutoSize = true;
            this.lblOrganisateur.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganisateur.Location = new System.Drawing.Point(119, 232);
            this.lblOrganisateur.Name = "lblOrganisateur";
            this.lblOrganisateur.Size = new System.Drawing.Size(189, 28);
            this.lblOrganisateur.TabIndex = 42;
            this.lblOrganisateur.Text = "Murielle Torrgerossa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Créateur : ";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(261, 262);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(126, 28);
            this.lblDateFin.TabIndex = 39;
            this.lblDateFin.Text = "09/05/2023";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ApplicationBudget.Properties.Resources.ArrowRight;
            this.pictureBox3.Location = new System.Drawing.Point(221, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(119, 262);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(126, 28);
            this.lblDateDebut.TabIndex = 37;
            this.lblDateDebut.Text = "09/04/2023";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ApplicationBudget.Properties.Resources.AnnulerIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 560);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(160, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(437, 42);
            this.button1.TabIndex = 72;
            this.button1.Text = "         Reset";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAjoutParticipant
            // 
            this.btnAjoutParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnAjoutParticipant.FlatAppearance.BorderSize = 0;
            this.btnAjoutParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutParticipant.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutParticipant.ForeColor = System.Drawing.Color.White;
            this.btnAjoutParticipant.Image = global::ApplicationBudget.Properties.Resources.AjouterParticipantIcon;
            this.btnAjoutParticipant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjoutParticipant.Location = new System.Drawing.Point(24, 501);
            this.btnAjoutParticipant.Name = "btnAjoutParticipant";
            this.btnAjoutParticipant.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnAjoutParticipant.Size = new System.Drawing.Size(437, 42);
            this.btnAjoutParticipant.TabIndex = 66;
            this.btnAjoutParticipant.Text = "          Voir/Ajouter participants";
            this.btnAjoutParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjoutParticipant.UseVisualStyleBackColor = false;
            this.btnAjoutParticipant.Click += new System.EventHandler(this.btnAjoutParticipant_Click);
            // 
            // AjouterParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjoutParticipant);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.lblEvement);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AjouterParticipant";
            this.Size = new System.Drawing.Size(480, 623);
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjoutParticipant;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.Label lblEvement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrganisateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDateDebut;
    }
}
