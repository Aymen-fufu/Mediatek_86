using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek_86.controller;
using Mediatek_86.model;

namespace Mediatek_86.view
{
    /// <summary>
    /// Fentre d'affichage des personnels et de leurs infos
    /// </summary>
    public partial class FormPersList : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private readonly BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private PersListcontroller controller;

        /// <summary>
        /// Demande de modification de personnel
        /// </summary>
        public Button Btn_modifier
        {
            get { return btn_modifier; }
        }

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        /// <param name="formAuth">Instance de la fenêtre d'authentification</param>
        public FormPersList(FormAuth formAuth)
        {
            InitializeComponent();
            if(formAuth != null ) 
            { 
                formAuth.Visible = false;
            }
            Init();
        }
        /// <summary>
        /// Initialisations : création du controleur et remplissage de la liste
        /// </summary>
        private void Init() 
        {
            controller = new PersListcontroller();
            this.StartPosition = FormStartPosition.CenterScreen;
            RemplirListePers();

        }
        /// <summary>
        /// Affiche les personnels
        /// </summary>
        public void RemplirListePers()
        {
            List<Personnel> lesPers = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPers;
            dgvPers.DataSource = bdgPersonnels;
            dgvPers.Columns["idpersonnel"].Visible = false;
            dgvPers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Demande de création d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ajouter_Click(object sender, EventArgs e)
        {
            FormAddPers frm = new FormAddPers(null, sender, this);
            frm.ShowDialog();
        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_modifier_Click(object sender, EventArgs e)
        {
            if (dgvPers.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FormAddPers frm = new FormAddPers(personnel,sender, this);
                frm.ShowDialog();
            }
        }
        /// <summary>
        /// Demande de suppresion d'un personnel (et préalablement, de toutes ces absences)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_supprimer_Click(object sender, EventArgs e)
        {
            if(dgvPers.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if(MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAllAbsence(personnel);
                    controller.DelPersonnel(personnel);
                    RemplirListePers();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }
        }
        /// <summary>
        /// Demande d'affichage des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_gestionAbsences_Click(object sender, EventArgs e)
        {
            if(dgvPers.SelectedRows.Count > 0) 
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FormAbs frm = new FormAbs(personnel);
                frm.ShowDialog();
            }
        }

        private void DgvPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
