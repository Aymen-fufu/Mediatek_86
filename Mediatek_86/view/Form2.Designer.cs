namespace Mediatek_86.view
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label_liste_personnels = new System.Windows.Forms.Label();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_gestionAbsences = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label_liste_personnels);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 370);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1139, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btn_gestionAbsences);
            this.panel2.Controls.Add(this.btn_supprimer);
            this.panel2.Controls.Add(this.btn_modifier);
            this.panel2.Controls.Add(this.button_ajouter);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 122);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.Location = new System.Drawing.Point(47, 41);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(105, 48);
            this.button_ajouter.TabIndex = 0;
            this.button_ajouter.Text = "ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // label_liste_personnels
            // 
            this.label_liste_personnels.AutoSize = true;
            this.label_liste_personnels.Font = new System.Drawing.Font("Noto Sans Lisu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_liste_personnels.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_liste_personnels.Location = new System.Drawing.Point(16, 17);
            this.label_liste_personnels.Name = "label_liste_personnels";
            this.label_liste_personnels.Size = new System.Drawing.Size(136, 20);
            this.label_liste_personnels.TabIndex = 1;
            this.label_liste_personnels.Text = "Liste du personnel";
            this.label_liste_personnels.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(216, 41);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(105, 48);
            this.btn_modifier.TabIndex = 4;
            this.btn_modifier.Text = "modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(401, 41);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(105, 48);
            this.btn_supprimer.TabIndex = 5;
            this.btn_supprimer.Text = "supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_gestionAbsences
            // 
            this.btn_gestionAbsences.Font = new System.Drawing.Font("Noto Sans Lisu", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestionAbsences.Location = new System.Drawing.Point(1003, 41);
            this.btn_gestionAbsences.Name = "btn_gestionAbsences";
            this.btn_gestionAbsences.Size = new System.Drawing.Size(103, 48);
            this.btn_gestionAbsences.TabIndex = 6;
            this.btn_gestionAbsences.Text = "gestion absences";
            this.btn_gestionAbsences.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label_liste_personnels;
        private System.Windows.Forms.Button btn_gestionAbsences;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
    }
}