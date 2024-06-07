namespace ApplicationBudget
{
    partial class AccueilControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNavAjoutEvent = new System.Windows.Forms.Button();
            this.btnNavAjoutDepense = new System.Windows.Forms.Button();
            this.picIllustration = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIllustration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 162);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gérez facilement les finances de vos ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.label2.Location = new System.Drawing.Point(18, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 57);
            this.label2.TabIndex = 11;
            this.label2.Text = "évènements entre proches";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 110);
            this.label3.TabIndex = 12;
            this.label3.Text = "Organisez vos événements en toute simplicité. Ajoutez des dépenses, partagez les " +
    "frais et obtenez un bilan financier instantané.";
            // 
            // btnNavAjoutEvent
            // 
            this.btnNavAjoutEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnNavAjoutEvent.FlatAppearance.BorderSize = 3;
            this.btnNavAjoutEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAjoutEvent.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAjoutEvent.ForeColor = System.Drawing.Color.White;
            this.btnNavAjoutEvent.Image = global::ApplicationBudget.Properties.Resources.EventsIcon;
            this.btnNavAjoutEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAjoutEvent.Location = new System.Drawing.Point(26, 535);
            this.btnNavAjoutEvent.Name = "btnNavAjoutEvent";
            this.btnNavAjoutEvent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavAjoutEvent.Size = new System.Drawing.Size(345, 49);
            this.btnNavAjoutEvent.TabIndex = 14;
            this.btnNavAjoutEvent.Text = "Ajouter un évènement";
            this.btnNavAjoutEvent.UseVisualStyleBackColor = false;
            this.btnNavAjoutEvent.Click += new System.EventHandler(this.btnNavAjoutEvent_Click);
            // 
            // btnNavAjoutDepense
            // 
            this.btnNavAjoutDepense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnNavAjoutDepense.FlatAppearance.BorderSize = 0;
            this.btnNavAjoutDepense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAjoutDepense.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAjoutDepense.ForeColor = System.Drawing.Color.White;
            this.btnNavAjoutDepense.Image = global::ApplicationBudget.Properties.Resources.ExpenseIcon;
            this.btnNavAjoutDepense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAjoutDepense.Location = new System.Drawing.Point(26, 458);
            this.btnNavAjoutDepense.Name = "btnNavAjoutDepense";
            this.btnNavAjoutDepense.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavAjoutDepense.Size = new System.Drawing.Size(345, 49);
            this.btnNavAjoutDepense.TabIndex = 13;
            this.btnNavAjoutDepense.Text = "Ajouter une dépense";
            this.btnNavAjoutDepense.UseVisualStyleBackColor = false;
            this.btnNavAjoutDepense.Click += new System.EventHandler(this.btnNavAjoutDepense_Click);
            // 
            // picIllustration
            // 
            this.picIllustration.BackColor = System.Drawing.Color.Transparent;
            this.picIllustration.Image = global::ApplicationBudget.Properties.Resources.accueil;
            this.picIllustration.Location = new System.Drawing.Point(116, -19);
            this.picIllustration.Name = "picIllustration";
            this.picIllustration.Size = new System.Drawing.Size(1180, 755);
            this.picIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIllustration.TabIndex = 15;
            this.picIllustration.TabStop = false;
            // 
            // AccueilControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.btnNavAjoutEvent);
            this.Controls.Add(this.btnNavAjoutDepense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picIllustration);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AccueilControl";
            this.Size = new System.Drawing.Size(1040, 711);
            ((System.ComponentModel.ISupportInitialize)(this.picIllustration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNavAjoutDepense;
        private System.Windows.Forms.Button btnNavAjoutEvent;
        private System.Windows.Forms.PictureBox picIllustration;
    }
}
