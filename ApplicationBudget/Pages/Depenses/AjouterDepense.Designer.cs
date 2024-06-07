namespace ApplicationBudget
{
    partial class AjouterDepense
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
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtDepense = new System.Windows.Forms.TextBox();
            this.lblDepense = new System.Windows.Forms.Label();
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.lblEvement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateDepense = new System.Windows.Forms.DateTimePicker();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBeneficiaires = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPayant = new System.Windows.Forms.ComboBox();
            this.lblQuiPaye = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMontant
            // 
            this.txtMontant.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.Location = new System.Drawing.Point(138, 288);
            this.txtMontant.Multiline = true;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(98, 38);
            this.txtMontant.TabIndex = 16;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(23, 291);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(106, 32);
            this.lblMontant.TabIndex = 15;
            this.lblMontant.Text = "Montant";
            // 
            // txtDepense
            // 
            this.txtDepense.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepense.Location = new System.Drawing.Point(138, 225);
            this.txtDepense.Multiline = true;
            this.txtDepense.Name = "txtDepense";
            this.txtDepense.Size = new System.Drawing.Size(324, 38);
            this.txtDepense.TabIndex = 13;
            // 
            // lblDepense
            // 
            this.lblDepense.AutoSize = true;
            this.lblDepense.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepense.Location = new System.Drawing.Point(21, 228);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(108, 32);
            this.lblDepense.TabIndex = 12;
            this.lblDepense.Text = "Dépense";
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
            this.cboEvenements.Location = new System.Drawing.Point(138, 118);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(323, 40);
            this.cboEvenements.TabIndex = 11;
            // 
            // lblEvement
            // 
            this.lblEvement.AutoSize = true;
            this.lblEvement.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvement.Location = new System.Drawing.Point(19, 121);
            this.lblEvement.Name = "lblEvement";
            this.lblEvement.Size = new System.Drawing.Size(141, 32);
            this.lblEvement.TabIndex = 10;
            this.lblEvement.Text = "Evènement ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nouvelle Dépense";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(274, 290);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 32);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date";
            // 
            // dateDepense
            // 
            this.dateDepense.Location = new System.Drawing.Point(341, 288);
            this.dateDepense.MinimumSize = new System.Drawing.Size(98, 38);
            this.dateDepense.Name = "dateDepense";
            this.dateDepense.Size = new System.Drawing.Size(121, 38);
            this.dateDepense.TabIndex = 18;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(23, 360);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(117, 32);
            this.lblCategorie.TabIndex = 19;
            this.lblCategorie.Text = "Catégorie";
            // 
            // cboCategories
            // 
            this.cboCategories.BackColor = System.Drawing.Color.White;
            this.cboCategories.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Items.AddRange(new object[] {
            "basically",
            "nothing",
            "for",
            "now"});
            this.cboCategories.Location = new System.Drawing.Point(138, 357);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(323, 40);
            this.cboCategories.TabIndex = 20;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(23, 416);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 32);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(138, 416);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(322, 76);
            this.txtDescription.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(118, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(100, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(100, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(112, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "*";
            // 
            // btnBeneficiaires
            // 
            this.btnBeneficiaires.BackColor = System.Drawing.Color.Black;
            this.btnBeneficiaires.FlatAppearance.BorderSize = 0;
            this.btnBeneficiaires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeneficiaires.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeneficiaires.ForeColor = System.Drawing.Color.White;
            this.btnBeneficiaires.Image = global::ApplicationBudget.Properties.Resources.AjouterParticipantIcon;
            this.btnBeneficiaires.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeneficiaires.Location = new System.Drawing.Point(29, 510);
            this.btnBeneficiaires.Name = "btnBeneficiaires";
            this.btnBeneficiaires.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnBeneficiaires.Size = new System.Drawing.Size(432, 42);
            this.btnBeneficiaires.TabIndex = 24;
            this.btnBeneficiaires.Text = "         Voir/Ajouter bénéficiaires";
            this.btnBeneficiaires.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeneficiaires.UseVisualStyleBackColor = false;
            this.btnBeneficiaires.Click += new System.EventHandler(this.btnBeneficiaires_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ApplicationBudget.Properties.Resources.MoneyIcon1;
            this.pictureBox2.Location = new System.Drawing.Point(242, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationBudget.Properties.Resources.Coin;
            this.pictureBox1.Location = new System.Drawing.Point(389, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ApplicationBudget.Properties.Resources.AnnulerIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(28, 558);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(208, 42);
            this.button1.TabIndex = 50;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::ApplicationBudget.Properties.Resources.AjouterIcon;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.Location = new System.Drawing.Point(252, 558);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAjouter.Size = new System.Drawing.Size(208, 42);
            this.btnAjouter.TabIndex = 49;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(318, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(119, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 28);
            this.label7.TabIndex = 54;
            this.label7.Text = "*";
            // 
            // cboPayant
            // 
            this.cboPayant.BackColor = System.Drawing.Color.White;
            this.cboPayant.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayant.FormattingEnabled = true;
            this.cboPayant.Items.AddRange(new object[] {
            "basically",
            "nothing",
            "for",
            "now"});
            this.cboPayant.Location = new System.Drawing.Point(139, 169);
            this.cboPayant.Name = "cboPayant";
            this.cboPayant.Size = new System.Drawing.Size(323, 40);
            this.cboPayant.TabIndex = 53;
            // 
            // lblQuiPaye
            // 
            this.lblQuiPaye.AutoSize = true;
            this.lblQuiPaye.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiPaye.Location = new System.Drawing.Point(20, 172);
            this.lblQuiPaye.Name = "lblQuiPaye";
            this.lblQuiPaye.Size = new System.Drawing.Size(110, 32);
            this.lblQuiPaye.TabIndex = 52;
            this.lblQuiPaye.Text = "Qui paye";
            // 
            // AjouterDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboPayant);
            this.Controls.Add(this.lblQuiPaye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBeneficiaires);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.dateDepense);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDepense);
            this.Controls.Add(this.lblDepense);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.lblEvement);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjouterDepense";
            this.Size = new System.Drawing.Size(480, 623);
            this.Load += new System.EventHandler(this.AjouterDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDepense;
        private System.Windows.Forms.Label lblDepense;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.Label lblEvement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateDepense;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnBeneficiaires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPayant;
        private System.Windows.Forms.Label lblQuiPaye;
    }
}
