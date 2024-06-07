namespace ApplicationBudget
{
    partial class BilanControl
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
            this.cboEvents = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.cboParticipants = new System.Windows.Forms.ComboBox();
            this.panelDepenses = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalDepenses = new System.Windows.Forms.Label();
            this.panelDepensesItems = new System.Windows.Forms.Panel();
            this.lblDepenses = new System.Windows.Forms.Label();
            this.panelRemboursements = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.totalRemboursements = new System.Windows.Forms.Label();
            this.panelRemboursementsItems = new System.Windows.Forms.Panel();
            this.lblRembourser = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panelCombos = new System.Windows.Forms.Panel();
            this.panelDepensesContainer = new System.Windows.Forms.Panel();
            this.panelRefundContainer = new System.Windows.Forms.Panel();
            this.panelDepenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRemboursements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCombos.SuspendLayout();
            this.panelDepensesContainer.SuspendLayout();
            this.panelRefundContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEvents
            // 
            this.cboEvents.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvents.FormattingEnabled = true;
            this.cboEvents.Location = new System.Drawing.Point(125, 28);
            this.cboEvents.Name = "cboEvents";
            this.cboEvents.Size = new System.Drawing.Size(312, 33);
            this.cboEvents.TabIndex = 1;
            this.cboEvents.SelectionChangeCommitted += new System.EventHandler(this.cboEvents_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evènement";
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipants.Location = new System.Drawing.Point(508, 31);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(109, 25);
            this.lblParticipants.TabIndex = 5;
            this.lblParticipants.Text = "Participant";
            this.lblParticipants.Visible = false;
            // 
            // cboParticipants
            // 
            this.cboParticipants.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParticipants.FormattingEnabled = true;
            this.cboParticipants.Location = new System.Drawing.Point(623, 28);
            this.cboParticipants.Name = "cboParticipants";
            this.cboParticipants.Size = new System.Drawing.Size(313, 33);
            this.cboParticipants.TabIndex = 4;
            this.cboParticipants.Visible = false;
            this.cboParticipants.SelectionChangeCommitted += new System.EventHandler(this.cboParticipants_SelectionChangeCommitted);
            // 
            // panelDepenses
            // 
            this.panelDepenses.AutoScroll = true;
            this.panelDepenses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDepenses.Controls.Add(this.pictureBox1);
            this.panelDepenses.Controls.Add(this.totalDepenses);
            this.panelDepenses.Controls.Add(this.panelDepensesItems);
            this.panelDepenses.Controls.Add(this.lblDepenses);
            this.panelDepenses.Location = new System.Drawing.Point(21, 23);
            this.panelDepenses.Name = "panelDepenses";
            this.panelDepenses.Size = new System.Drawing.Size(423, 411);
            this.panelDepenses.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Image = global::ApplicationBudget.Properties.Resources.depenses;
            this.pictureBox1.Location = new System.Drawing.Point(113, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // totalDepenses
            // 
            this.totalDepenses.BackColor = System.Drawing.Color.Crimson;
            this.totalDepenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalDepenses.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDepenses.ForeColor = System.Drawing.Color.White;
            this.totalDepenses.Location = new System.Drawing.Point(0, 358);
            this.totalDepenses.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.totalDepenses.Name = "totalDepenses";
            this.totalDepenses.Size = new System.Drawing.Size(423, 53);
            this.totalDepenses.TabIndex = 7;
            this.totalDepenses.Text = "Total : 920.52€";
            this.totalDepenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDepensesItems
            // 
            this.panelDepensesItems.AutoScroll = true;
            this.panelDepensesItems.BackColor = System.Drawing.Color.White;
            this.panelDepensesItems.Location = new System.Drawing.Point(0, 53);
            this.panelDepensesItems.Name = "panelDepensesItems";
            this.panelDepensesItems.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelDepensesItems.Size = new System.Drawing.Size(423, 295);
            this.panelDepensesItems.TabIndex = 6;
            // 
            // lblDepenses
            // 
            this.lblDepenses.BackColor = System.Drawing.Color.Crimson;
            this.lblDepenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepenses.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepenses.ForeColor = System.Drawing.Color.White;
            this.lblDepenses.Location = new System.Drawing.Point(0, 0);
            this.lblDepenses.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblDepenses.Name = "lblDepenses";
            this.lblDepenses.Size = new System.Drawing.Size(423, 53);
            this.lblDepenses.TabIndex = 4;
            this.lblDepenses.Text = "Dépenses";
            this.lblDepenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRemboursements
            // 
            this.panelRemboursements.AutoScroll = true;
            this.panelRemboursements.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelRemboursements.Controls.Add(this.pictureBox2);
            this.panelRemboursements.Controls.Add(this.totalRemboursements);
            this.panelRemboursements.Controls.Add(this.panelRemboursementsItems);
            this.panelRemboursements.Controls.Add(this.lblRembourser);
            this.panelRemboursements.Location = new System.Drawing.Point(16, 23);
            this.panelRemboursements.Name = "panelRemboursements";
            this.panelRemboursements.Size = new System.Drawing.Size(423, 411);
            this.panelRemboursements.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Image = global::ApplicationBudget.Properties.Resources.rembourser;
            this.pictureBox2.Location = new System.Drawing.Point(78, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // totalRemboursements
            // 
            this.totalRemboursements.BackColor = System.Drawing.Color.Gold;
            this.totalRemboursements.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalRemboursements.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRemboursements.ForeColor = System.Drawing.Color.Black;
            this.totalRemboursements.Location = new System.Drawing.Point(0, 358);
            this.totalRemboursements.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.totalRemboursements.Name = "totalRemboursements";
            this.totalRemboursements.Size = new System.Drawing.Size(423, 53);
            this.totalRemboursements.TabIndex = 7;
            this.totalRemboursements.Text = "Total : 20.52€";
            this.totalRemboursements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRemboursementsItems
            // 
            this.panelRemboursementsItems.AutoScroll = true;
            this.panelRemboursementsItems.BackColor = System.Drawing.Color.White;
            this.panelRemboursementsItems.Location = new System.Drawing.Point(0, 53);
            this.panelRemboursementsItems.Name = "panelRemboursementsItems";
            this.panelRemboursementsItems.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelRemboursementsItems.Size = new System.Drawing.Size(423, 295);
            this.panelRemboursementsItems.TabIndex = 6;
            // 
            // lblRembourser
            // 
            this.lblRembourser.BackColor = System.Drawing.Color.Gold;
            this.lblRembourser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRembourser.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRembourser.ForeColor = System.Drawing.Color.Black;
            this.lblRembourser.Location = new System.Drawing.Point(0, 0);
            this.lblRembourser.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblRembourser.Name = "lblRembourser";
            this.lblRembourser.Size = new System.Drawing.Size(423, 53);
            this.lblRembourser.TabIndex = 4;
            this.lblRembourser.Text = "À Rembourser";
            this.lblRembourser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Image = global::ApplicationBudget.Properties.Resources.pdf;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.Location = new System.Drawing.Point(815, 641);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnEnregistrer.Size = new System.Drawing.Size(184, 56);
            this.btnEnregistrer.TabIndex = 48;
            this.btnEnregistrer.Text = "Bilan Global";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Visible = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Image = global::ApplicationBudget.Properties.Resources.AnnulerIcon;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.Location = new System.Drawing.Point(607, 641);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAnnuler.Size = new System.Drawing.Size(184, 56);
            this.btnAnnuler.TabIndex = 49;
            this.btnAnnuler.Text = "Reset";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // panelCombos
            // 
            this.panelCombos.Controls.Add(this.lblParticipants);
            this.panelCombos.Controls.Add(this.cboParticipants);
            this.panelCombos.Controls.Add(this.label2);
            this.panelCombos.Controls.Add(this.cboEvents);
            this.panelCombos.Location = new System.Drawing.Point(36, 42);
            this.panelCombos.Name = "panelCombos";
            this.panelCombos.Size = new System.Drawing.Size(963, 86);
            this.panelCombos.TabIndex = 50;
            // 
            // panelDepensesContainer
            // 
            this.panelDepensesContainer.BackColor = System.Drawing.Color.White;
            this.panelDepensesContainer.BackgroundImage = global::ApplicationBudget.Properties.Resources.blobs2;
            this.panelDepensesContainer.Controls.Add(this.panelDepenses);
            this.panelDepensesContainer.Location = new System.Drawing.Point(43, 144);
            this.panelDepensesContainer.Name = "panelDepensesContainer";
            this.panelDepensesContainer.Size = new System.Drawing.Size(459, 469);
            this.panelDepensesContainer.TabIndex = 51;
            this.panelDepensesContainer.Visible = false;
            // 
            // panelRefundContainer
            // 
            this.panelRefundContainer.BackColor = System.Drawing.Color.White;
            this.panelRefundContainer.BackgroundImage = global::ApplicationBudget.Properties.Resources.blobs1;
            this.panelRefundContainer.Controls.Add(this.panelRemboursements);
            this.panelRefundContainer.Location = new System.Drawing.Point(540, 141);
            this.panelRefundContainer.Name = "panelRefundContainer";
            this.panelRefundContainer.Size = new System.Drawing.Size(459, 472);
            this.panelRefundContainer.TabIndex = 52;
            this.panelRefundContainer.Visible = false;
            // 
            // BilanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ApplicationBudget.Properties.Resources.wallpapersden_com_abstract_neon_circle_shapes_3840x2160;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelRefundContainer);
            this.Controls.Add(this.panelDepensesContainer);
            this.Controls.Add(this.panelCombos);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BilanControl";
            this.Size = new System.Drawing.Size(1040, 711);
            this.Load += new System.EventHandler(this.BilanControl_Load);
            this.panelDepenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRemboursements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCombos.ResumeLayout(false);
            this.panelCombos.PerformLayout();
            this.panelDepensesContainer.ResumeLayout(false);
            this.panelRefundContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.ComboBox cboParticipants;
        private System.Windows.Forms.Panel panelDepenses;
        private System.Windows.Forms.Panel panelDepensesItems;
        private System.Windows.Forms.Label lblDepenses;
        private System.Windows.Forms.Panel panelRemboursements;
        private System.Windows.Forms.Panel panelRemboursementsItems;
        private System.Windows.Forms.Label lblRembourser;
        private System.Windows.Forms.Label totalDepenses;
        private System.Windows.Forms.Label totalRemboursements;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelCombos;
        private System.Windows.Forms.Panel panelDepensesContainer;
        private System.Windows.Forms.Panel panelRefundContainer;
    }
}
