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
    public partial class FormPersList : Form
    {

        private BindingSource bdgPersonnels = new BindingSource();

        private PersListcontroller controller;

     

        public FormPersList(FormAuth formAuth)
        {
            InitializeComponent();
            if(formAuth != null ) 
            { 
                formAuth.Visible = false;
            }
            Init();
        }

        private void Init() 
        {
            controller = new PersListcontroller();
            this.StartPosition = FormStartPosition.CenterScreen;
            RemplirListePers();

        }

        public void RemplirListePers()
        {
            List<Personnel> lesPers = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPers;
            dgvPers.DataSource = bdgPersonnels;
            dgvPers.Columns["idpersonnel"].Visible = false;
            dgvPers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            FormAddPers frm = new FormAddPers(null, sender, this);
            frm.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (dgvPers.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FormAddPers frm = new FormAddPers(personnel,sender, this);
                frm.ShowDialog();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
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

        private void btn_gestionAbsences_Click(object sender, EventArgs e)
        {
            if(dgvPers.SelectedRows.Count > 0) 
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FormAbs frm = new FormAbs(personnel);
                frm.ShowDialog();
            }
        }

        private void dgvPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
