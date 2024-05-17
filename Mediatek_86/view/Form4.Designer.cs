namespace Mediatek_86.view
{
    partial class Form4
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.label_debut = new System.Windows.Forms.Label();
            this.label_fin = new System.Windows.Forms.Label();
            this.label_motif = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_supprimer);
            this.panel1.Controls.Add(this.btn_modifier);
            this.panel1.Controls.Add(this.btn_ajouter);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 320);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label_motif);
            this.panel2.Controls.Add(this.label_fin);
            this.panel2.Controls.Add(this.label_debut);
            this.panel2.Controls.Add(this.btn_enregistrer);
            this.panel2.Controls.Add(this.btn_fermer);
            this.panel2.Controls.Add(this.btn_annuler);
            this.panel2.Location = new System.Drawing.Point(12, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 100);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Location = new System.Drawing.Point(415, 258);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(102, 41);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(544, 258);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(102, 41);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(669, 258);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(95, 41);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(272, 55);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(86, 32);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.Location = new System.Drawing.Point(658, 27);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(106, 46);
            this.btn_fermer.TabIndex = 2;
            this.btn_fermer.Text = "fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Location = new System.Drawing.Point(272, 15);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(86, 32);
            this.btn_enregistrer.TabIndex = 6;
            this.btn_enregistrer.Text = "enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // label_debut
            // 
            this.label_debut.AutoSize = true;
            this.label_debut.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_debut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_debut.Location = new System.Drawing.Point(25, 15);
            this.label_debut.Name = "label_debut";
            this.label_debut.Size = new System.Drawing.Size(38, 15);
            this.label_debut.TabIndex = 7;
            this.label_debut.Text = "debut";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_fin.Location = new System.Drawing.Point(25, 41);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(21, 15);
            this.label_fin.TabIndex = 8;
            this.label_fin.Text = "fin";
            // 
            // label_motif
            // 
            this.label_motif.AutoSize = true;
            this.label_motif.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_motif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_motif.Location = new System.Drawing.Point(25, 72);
            this.label_motif.Name = "label_motif";
            this.label_motif.Size = new System.Drawing.Size(35, 15);
            this.label_motif.TabIndex = 9;
            this.label_motif.Text = "motif";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(96, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(96, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Label label_debut;
        private System.Windows.Forms.Label label_motif;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}