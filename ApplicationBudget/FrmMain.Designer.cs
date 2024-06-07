namespace ApplicationBudget
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavigationItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavAcceuil = new System.Windows.Forms.Button();
            this.btnNavParticipants = new System.Windows.Forms.Button();
            this.btnNavDepenses = new System.Windows.Forms.Button();
            this.btnNavEvent = new System.Windows.Forms.Button();
            this.btnNavBilan = new System.Windows.Forms.Button();
            this.panelMainApp = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNavigationItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelNavigation.Controls.Add(this.pictureBox1);
            this.panelNavigation.Controls.Add(this.panelNavigationItems);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(197, 711);
            this.panelNavigation.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationBudget.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelNavigationItems
            // 
            this.panelNavigationItems.BackColor = System.Drawing.Color.Transparent;
            this.panelNavigationItems.Controls.Add(this.btnNavAcceuil);
            this.panelNavigationItems.Controls.Add(this.btnNavParticipants);
            this.panelNavigationItems.Controls.Add(this.btnNavDepenses);
            this.panelNavigationItems.Controls.Add(this.btnNavEvent);
            this.panelNavigationItems.Controls.Add(this.btnNavBilan);
            this.panelNavigationItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigationItems.Location = new System.Drawing.Point(0, 0);
            this.panelNavigationItems.Name = "panelNavigationItems";
            this.panelNavigationItems.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.panelNavigationItems.Size = new System.Drawing.Size(197, 593);
            this.panelNavigationItems.TabIndex = 6;
            // 
            // btnNavAcceuil
            // 
            this.btnNavAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.btnNavAcceuil.FlatAppearance.BorderSize = 0;
            this.btnNavAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAcceuil.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAcceuil.ForeColor = System.Drawing.Color.White;
            this.btnNavAcceuil.Image = global::ApplicationBudget.Properties.Resources.HomeIcon;
            this.btnNavAcceuil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAcceuil.Location = new System.Drawing.Point(0, 200);
            this.btnNavAcceuil.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavAcceuil.Name = "btnNavAcceuil";
            this.btnNavAcceuil.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavAcceuil.Size = new System.Drawing.Size(247, 49);
            this.btnNavAcceuil.TabIndex = 1;
            this.btnNavAcceuil.Text = "            Acceuil";
            this.btnNavAcceuil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAcceuil.UseVisualStyleBackColor = false;
            this.btnNavAcceuil.Click += new System.EventHandler(this.btnNavAcceuil_Click);
            // 
            // btnNavParticipants
            // 
            this.btnNavParticipants.BackColor = System.Drawing.Color.Transparent;
            this.btnNavParticipants.FlatAppearance.BorderSize = 0;
            this.btnNavParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavParticipants.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavParticipants.ForeColor = System.Drawing.Color.White;
            this.btnNavParticipants.Image = global::ApplicationBudget.Properties.Resources.ParticipantsIcon;
            this.btnNavParticipants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavParticipants.Location = new System.Drawing.Point(0, 249);
            this.btnNavParticipants.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavParticipants.Name = "btnNavParticipants";
            this.btnNavParticipants.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavParticipants.Size = new System.Drawing.Size(247, 49);
            this.btnNavParticipants.TabIndex = 3;
            this.btnNavParticipants.Text = "            Participants";
            this.btnNavParticipants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavParticipants.UseVisualStyleBackColor = false;
            this.btnNavParticipants.Click += new System.EventHandler(this.btnNavParticipants_Click);
            // 
            // btnNavDepenses
            // 
            this.btnNavDepenses.BackColor = System.Drawing.Color.Transparent;
            this.btnNavDepenses.FlatAppearance.BorderSize = 0;
            this.btnNavDepenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDepenses.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDepenses.ForeColor = System.Drawing.Color.White;
            this.btnNavDepenses.Image = global::ApplicationBudget.Properties.Resources.ExpenseIcon;
            this.btnNavDepenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDepenses.Location = new System.Drawing.Point(0, 298);
            this.btnNavDepenses.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavDepenses.Name = "btnNavDepenses";
            this.btnNavDepenses.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavDepenses.Size = new System.Drawing.Size(247, 49);
            this.btnNavDepenses.TabIndex = 4;
            this.btnNavDepenses.Text = "            Depenses";
            this.btnNavDepenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDepenses.UseVisualStyleBackColor = false;
            this.btnNavDepenses.Click += new System.EventHandler(this.btnNavDepenses_Click);
            // 
            // btnNavEvent
            // 
            this.btnNavEvent.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNavEvent.FlatAppearance.BorderSize = 0;
            this.btnNavEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEvent.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavEvent.ForeColor = System.Drawing.Color.White;
            this.btnNavEvent.Image = global::ApplicationBudget.Properties.Resources.EventsIcon;
            this.btnNavEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEvent.Location = new System.Drawing.Point(0, 347);
            this.btnNavEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavEvent.Name = "btnNavEvent";
            this.btnNavEvent.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavEvent.Size = new System.Drawing.Size(247, 49);
            this.btnNavEvent.TabIndex = 2;
            this.btnNavEvent.Text = "            Evènements";
            this.btnNavEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEvent.UseVisualStyleBackColor = false;
            this.btnNavEvent.Click += new System.EventHandler(this.btnNavEvent_Click);
            // 
            // btnNavBilan
            // 
            this.btnNavBilan.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBilan.FlatAppearance.BorderSize = 0;
            this.btnNavBilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBilan.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavBilan.ForeColor = System.Drawing.Color.White;
            this.btnNavBilan.Image = global::ApplicationBudget.Properties.Resources.BilanIcon;
            this.btnNavBilan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBilan.Location = new System.Drawing.Point(0, 396);
            this.btnNavBilan.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavBilan.Name = "btnNavBilan";
            this.btnNavBilan.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavBilan.Size = new System.Drawing.Size(247, 49);
            this.btnNavBilan.TabIndex = 5;
            this.btnNavBilan.Text = "            Bilan";
            this.btnNavBilan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBilan.UseVisualStyleBackColor = false;
            this.btnNavBilan.Click += new System.EventHandler(this.btnNavBilan_Click);
            // 
            // panelMainApp
            // 
            this.panelMainApp.BackColor = System.Drawing.Color.Transparent;
            this.panelMainApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainApp.Location = new System.Drawing.Point(197, 0);
            this.panelMainApp.Name = "panelMainApp";
            this.panelMainApp.Size = new System.Drawing.Size(1040, 711);
            this.panelMainApp.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 711);
            this.Controls.Add(this.panelMainApp);
            this.Controls.Add(this.panelNavigation);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyCut";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNavigationItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnNavAcceuil;
        private System.Windows.Forms.Button btnNavEvent;
        private System.Windows.Forms.Button btnNavParticipants;
        private System.Windows.Forms.Button btnNavDepenses;
        private System.Windows.Forms.Button btnNavBilan;
        private System.Windows.Forms.FlowLayoutPanel panelNavigationItems;
        private System.Windows.Forms.Panel panelMainApp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

