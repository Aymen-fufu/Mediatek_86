using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek_86.controller;
using Mediatek_86.dal;
using Mediatek_86.model;

namespace Mediatek_86.view
{
    public partial class FormAddPers : Form
    {

        private Boolean enCoursModif = false;

        private AddPersController controller;
        private FormPersList frmPersList;
        private Personnel personnel;

        private BindingSource bdgServices = new BindingSource();

        public FormAddPers(Personnel personnel, Object sender, FormPersList frm)
        {
            InitializeComponent();
            Init(personnel, sender, frm);
        }

        
        private void Init(Personnel personnel, object sender, FormPersList frm)
        {
            controller = new AddPersController();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.frmPersList = frm;
            this.personnel = personnel;
            RemplirListServices();
            if ((Button)sender == frm.btn_modifier)
            {
                textBox_nom.Text = personnel.Nom;
                textBox_prenom.Text = personnel.Prenom;
                textBox_tel.Text = personnel.Tel;
                textBox_tel.Text = personnel.Mail;
                comboBox_service.SelectedIndex = comboBox_service.FindStringExact(personnel.Service.Nom);
                enCoursModif = true;

            }
            else
            {
                textBox_nom.Text = "";
                textBox_prenom.Text = "";
                textBox_tel.Text = "";
                textBox_mail.Text = "";

            }
            
        }

        private void RemplirListServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            comboBox_service.DataSource = bdgServices;
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_tel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (!textBox_nom.Text.Equals("") && !textBox_prenom.Text.Equals("") && !textBox_tel.Text.Equals("") && !textBox_mail.Text.Equals("") && comboBox_service.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursModif)
                {
                    if (MessageBox.Show("Voulez-vous vraiment modifier " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        personnel.Nom = textBox_nom.Text;
                        personnel.Prenom = textBox_prenom.Text;
                        personnel.Tel = textBox_prenom.Text;
                        personnel.Mail = textBox_mail.Text;
                        personnel.Service = service;
                        controller.UpdatePersonnel(personnel);
                    }
                }
                else
                {
                    Personnel personnel = new Personnel(0, textBox_nom.Text, textBox_prenom.Text, textBox_tel.Text, textBox_mail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                frmPersList.RemplirListePers();
                enCoursModif = false;
                this.Close();
                
            }
            else 
            {
                MessageBox.Show("Tous les champs doivent etre remplis.");
            }
        }

        private void btn_anuler_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
