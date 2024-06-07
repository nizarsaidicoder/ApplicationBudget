namespace ApplicationBudget
{
    partial class ParticipantsControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ajouterParticipant1 = new ApplicationBudget.Pages.Participants.AjouterParticipant();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationBudget.Properties.Resources.Participant;
            this.pictureBox1.Location = new System.Drawing.Point(539, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.ajouterParticipant1);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Location = new System.Drawing.Point(15, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1010, 660);
            this.panelContainer.TabIndex = 2;
            // 
            // ajouterParticipant1
            // 
            this.ajouterParticipant1.BackColor = System.Drawing.SystemColors.MenuText;
            this.ajouterParticipant1.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.ajouterParticipant1.ForeColor = System.Drawing.Color.White;
            this.ajouterParticipant1.Location = new System.Drawing.Point(18, 16);
            this.ajouterParticipant1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ajouterParticipant1.Name = "ajouterParticipant1";
            this.ajouterParticipant1.Size = new System.Drawing.Size(480, 623);
            this.ajouterParticipant1.TabIndex = 2;
            // 
            // ParticipantsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParticipantsControl";
            this.Size = new System.Drawing.Size(1040, 711);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private Pages.Participants.AjouterParticipant ajouterParticipant1;
    }
}
