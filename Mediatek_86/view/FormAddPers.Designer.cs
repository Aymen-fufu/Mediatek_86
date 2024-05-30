namespace Mediatek_86.view
{
    partial class FormAddPers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_service = new System.Windows.Forms.Label();
            this.comboBox_service = new System.Windows.Forms.ComboBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_anuler = new System.Windows.Forms.Button();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_ajouterPersonnel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label_service);
            this.panel1.Controls.Add(this.comboBox_service);
            this.panel1.Controls.Add(this.btn_enregistrer);
            this.panel1.Controls.Add(this.btn_anuler);
            this.panel1.Controls.Add(this.textBox_mail);
            this.panel1.Controls.Add(this.textBox_tel);
            this.panel1.Controls.Add(this.textBox_prenom);
            this.panel1.Controls.Add(this.textBox_nom);
            this.panel1.Controls.Add(this.label_mail);
            this.panel1.Controls.Add(this.label_prenom);
            this.panel1.Controls.Add(this.label_tel);
            this.panel1.Controls.Add(this.label_nom);
            this.panel1.Controls.Add(this.label_ajouterPersonnel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 364);
            this.panel1.TabIndex = 0;
            // 
            // label_service
            // 
            this.label_service.AutoSize = true;
            this.label_service.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_service.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_service.Location = new System.Drawing.Point(37, 255);
            this.label_service.Name = "label_service";
            this.label_service.Size = new System.Drawing.Size(43, 15);
            this.label_service.TabIndex = 13;
            this.label_service.Text = "service";
            this.label_service.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_service
            // 
            this.comboBox_service.FormattingEnabled = true;
            this.comboBox_service.Location = new System.Drawing.Point(143, 249);
            this.comboBox_service.Name = "comboBox_service";
            this.comboBox_service.Size = new System.Drawing.Size(169, 21);
            this.comboBox_service.TabIndex = 12;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Location = new System.Drawing.Point(247, 304);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(82, 40);
            this.btn_enregistrer.TabIndex = 11;
            this.btn_enregistrer.Text = "enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_anuler
            // 
            this.btn_anuler.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anuler.Location = new System.Drawing.Point(350, 304);
            this.btn_anuler.Name = "btn_anuler";
            this.btn_anuler.Size = new System.Drawing.Size(78, 40);
            this.btn_anuler.TabIndex = 10;
            this.btn_anuler.Text = "annuler";
            this.btn_anuler.UseVisualStyleBackColor = true;
            this.btn_anuler.Click += new System.EventHandler(this.btn_anuler_Click);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(143, 205);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(169, 20);
            this.textBox_mail.TabIndex = 9;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(143, 155);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(169, 20);
            this.textBox_tel.TabIndex = 8;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(143, 112);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(169, 20);
            this.textBox_prenom.TabIndex = 7;
            this.textBox_prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(143, 64);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(169, 20);
            this.textBox_nom.TabIndex = 6;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_mail.Location = new System.Drawing.Point(37, 205);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(29, 15);
            this.label_mail.TabIndex = 4;
            this.label_mail.Text = "mail";
            this.label_mail.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_prenom.Location = new System.Drawing.Point(35, 112);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(49, 15);
            this.label_prenom.TabIndex = 3;
            this.label_prenom.Text = "prenom";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_tel.Location = new System.Drawing.Point(35, 155);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(20, 15);
            this.label_tel.TabIndex = 2;
            this.label_tel.Text = "tel";
            this.label_tel.Click += new System.EventHandler(this.label_tel_Click);
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_nom.Location = new System.Drawing.Point(37, 64);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(31, 15);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "nom";
            // 
            // label_ajouterPersonnel
            // 
            this.label_ajouterPersonnel.AutoSize = true;
            this.label_ajouterPersonnel.Font = new System.Drawing.Font("Noto Sans Lisu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ajouterPersonnel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_ajouterPersonnel.Location = new System.Drawing.Point(12, 9);
            this.label_ajouterPersonnel.Name = "label_ajouterPersonnel";
            this.label_ajouterPersonnel.Size = new System.Drawing.Size(176, 26);
            this.label_ajouterPersonnel.TabIndex = 0;
            this.label_ajouterPersonnel.Text = "Ajouter personnel";
            // 
            // FormAddPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 388);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddPers";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ajouterPersonnel;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Button btn_anuler;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.ComboBox comboBox_service;
        private System.Windows.Forms.Label label_service;
    }
}