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
using MySql.Data.MySqlClient;

namespace Mediatek_86.view
{
    /// <summary>
    /// Fenêtre de gestion des absences du personnel selectionné
    /// </summary>
    public partial class FormAbs : Form
    {
        /// <summary>
        /// Date de début originelle de l'absence à modifier
        /// </summary>
        private DateTime dateDebut;
        /// <summary>
        /// Personnel concerné par les absences
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursModif = false;
        /// <summary>
        /// Booléen poue savoir si un ajout est demandé
        /// </summary>
        private Boolean enCoursAjoutAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private AbsController controller;



        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormAbs(Personnel personnel)
        {
            InitializeComponent();
            Init(personnel);
        }
        /// <summary>
        /// Initialisations : création du controleur et remplissage de la liste des absences
        /// </summary>
        private void Init(Personnel personnel)
        {
            controller = new AbsController();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.personnel = personnel;
            RemplirListeAbsences(personnel);
            RemplirListeMotifs();
            InitialisationActionAbsence();
        }
        /// <summary>
        /// Affiche les absences
        /// </summary>
        /// <param name="personnel"></param>
        private void RemplirListeAbsences(Personnel personnel) 
        { 
            List<Absence> lesAbsences = controller.GetLesAbsences(personnel);
            bdgAbsences.DataSource = lesAbsences;
            dgv_Absences.DataSource = bdgAbsences;
            dgv_Absences.Columns["idpersonnel"].Visible = false;
            dgv_Absences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs() 
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            comboBox_motif.DataSource = bdgMotifs;
        }
        /// <summary>
        /// Initialise et rend inaccessible la zone d'ajout/modification 
        /// </summary>
        private void InitialisationActionAbsence()
        {
            dateTimePicker_debut.Value = DateTime.Today;
            dateTimePicker_fin.Value = DateTime.Today;
            comboBox_motif.SelectedItem = comboBox_motif.Items[0];
        }
        /// <summary>
        /// Modification d'affichage si on est en cours de modif 
        /// </summary>
        /// <param name="modif"></param>
        private void EncoursModifAbsence(Boolean modif)
        {
            enCoursModif = modif;
        }


        /// <summary>
        ///  Demande d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ajouter_Click(object sender, EventArgs e)
        {
            EnCoursAjoutAbsence(true);
        }
        /// <summary>
        /// Demande d'enregistrement de l'ajout d'un absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (comboBox_motif.SelectedIndex != -1) 
            {
                if (dateTimePicker_fin.Value >= dateTimePicker_debut.Value) 
                {
                    if (!ControleAbsencesSimultanees()) 
                    {
                        Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                        if(enCoursModif)
                        {
                            if (MessageBox.Show("Voulez-vous vraiment modifier : " + dgv_Absences.SelectedRows[0].Cells[3].Value + " du " + ((DateTime)(dgv_Absences.SelectedRows[0].Cells[1].Value)).ToString("dd/MM/yyyy") + " au " + ((DateTime)(dgv_Absences.SelectedRows[0].Cells[2].Value)).ToString("dd/MM/yyyy") + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                                absence.Datedebut = dateTimePicker_debut.Value;
                                absence.Datefin = dateTimePicker_fin.Value;
                                absence.Motif = motif;
                                controller.UpdateAbsence(absence, personnel, dateDebut);
                                EncoursModifAbsence(false);
                            }
                        }
                        else if (enCoursAjoutAbsence)
                        {
                            Absence absence = new Absence(personnel.Idpersonnel, dateTimePicker_debut.Value, dateTimePicker_fin.Value , motif );
                            controller.AddAbsence(absence);
                            EnCoursAjoutAbsence(false);
                        }
                        RemplirListeAbsences(personnel);
                        InitialisationActionAbsence();
                    }
                    else 
                    {
                        MessageBox.Show("Une absence est deja enregistre sur cette periode.");
                    }
                }
                else
                {
                    MessageBox.Show("La date de fin doit être ultérieure à la date de début");
                }
            }
            else
            {
                MessageBox.Show("Un motif doit être sélectionné.");
            }
        }
        /// <summary>
        /// Annuler la demande d'ajout d'une absence
        /// Réinitialise les zones de saisie de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                InitialisationActionAbsence();
            }
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dgv_Absences.Rows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer : " + dgv_Absences.SelectedRows[0].Cells[3].Value + " du " + ((DateTime)(dgv_Absences.SelectedRows[0].Cells[1].Value)).ToString("dd/MM/yyyy") + " au " + ((DateTime)(dgv_Absences.SelectedRows[0].Cells[2].Value)).ToString("dd/MM/yyyy") + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences(personnel);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }

        }
        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_modifier_Click(object sender, EventArgs e)
        {
            if (dgv_Absences.SelectedRows.Count > 0) 
            {
                EncoursModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dateTimePicker_debut.Value = (DateTime)dgv_Absences.SelectedRows[0].Cells[1].Value;
                dateDebut = (DateTime)dgv_Absences.SelectedRows[0].Cells[1].Value;
                dateTimePicker_fin.Value = (DateTime)dgv_Absences.SelectedRows[0].Cells[2].Value;
                comboBox_motif.SelectedIndex = comboBox_motif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être selectionnée.");
            }
        }
        /// <summary>
        /// Modification d'affichage si on est en cours d'ajout
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursAjoutAbsence(Boolean modif) 
        {
            enCoursAjoutAbsence = modif;
        }
        /// <summary>
        /// Controle d'absences simultanées
        /// </summary>
        /// <returns></returns>
        private Boolean ControleAbsencesSimultanees() 
        { 
            Boolean test = false;
            if (enCoursModif)
            {
                foreach (DataGridViewRow row in dgv_Absences.Rows) 
                {
                    if (!row.Selected && (dateTimePicker_debut.Value <= (DateTime)row.Cells[2].Value && dateTimePicker_fin.Value >= (DateTime)row.Cells[1].Value)) 
                    { 
                        test = true;
                    }
                }
                return test;
            }
            else if(enCoursAjoutAbsence) 
            { 
                foreach(DataGridViewRow row in dgv_Absences.Rows)
                {
                    if((dateTimePicker_debut.Value <= (DateTime)row.Cells[2].Value && dateTimePicker_fin.Value >= (DateTime)row.Cells[1].Value) || dateTimePicker_debut.Value == (DateTime)row.Cells[1].Value) 
                    { 
                        test = true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Fermeture de la fenêtre de gestion des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
