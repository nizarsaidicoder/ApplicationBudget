namespace ApplicationBudget
{
    partial class DepensesControl
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
            this.ajouterDepense1 = new ApplicationBudget.AjouterDepense();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajouterDepense1
            // 
            this.ajouterDepense1.BackColor = System.Drawing.Color.White;
            this.ajouterDepense1.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.ajouterDepense1.Location = new System.Drawing.Point(35, 27);
            this.ajouterDepense1.Margin = new System.Windows.Forms.Padding(4);
            this.ajouterDepense1.Name = "ajouterDepense1";
            this.ajouterDepense1.Size = new System.Drawing.Size(480, 623);
            this.ajouterDepense1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationBudget.Properties.Resources.Finances3;
            this.pictureBox1.Location = new System.Drawing.Point(549, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DepensesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ajouterDepense1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepensesControl";
            this.Size = new System.Drawing.Size(1040, 711);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AjouterDepense ajouterDepense1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
