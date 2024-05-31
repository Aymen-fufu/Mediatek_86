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
    /// <summary>
    /// Fenêtre d'ajout ou de modification de personnel
    /// </summary>
    public partial class FormAddPers : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursModif = false;
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private AddPersController controller;
        private FormPersList frmPersList;
        private Personnel personnel;
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        public FormAddPers(Personnel personnel, Object sender, FormPersList frm)
        {
            InitializeComponent();
            Init(personnel, sender, frm);
        }

        /// <summary>
        /// Initialisations : création du controller
        /// </summary>
        /// <param name="personnel">personnel de la ligne selectionnée</param>
        /// <param name="sender">bouton ayant déclenché l'ouverture de la frame (ajouter ou modifier)</param>
        /// <param name="frm"></param>
        private void Init(Personnel personnel, object sender, FormPersList frm)
        {
            controller = new AddPersController();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.frmPersList = frm;
            this.personnel = personnel;
            RemplirListServices();
            if ((Button)sender == frm.Btn_modifier)
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
        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            comboBox_service.DataSource = bdgServices;
        }



        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label_tel_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_enregistrer_Click(object sender, EventArgs e)
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
        /// <summary>
        /// annuler la demande d'ajout ou de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_anuler_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
