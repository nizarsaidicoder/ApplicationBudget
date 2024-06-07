namespace ApplicationBudget
{
    partial class frmPopup
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
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureInfo
            // 
            this.pictureInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureInfo.Image = global::ApplicationBudget.Properties.Resources.check;
            this.pictureInfo.Location = new System.Drawing.Point(171, 47);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(100, 94);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInfo.TabIndex = 0;
            this.pictureInfo.TabStop = false;
            // 
            // lblFeedback
            // 
            this.lblFeedback.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(36, 144);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(377, 97);
            this.lblFeedback.TabIndex = 1;
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnFermer.Location = new System.Drawing.Point(112, 253);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnFermer.Size = new System.Drawing.Size(208, 42);
            this.btnFermer.TabIndex = 51;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 329);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.pictureInfo);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnFermer;
    }
}