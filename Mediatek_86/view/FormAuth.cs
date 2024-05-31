using Mediatek_86.controller;
using Mediatek_86.model;
using Mediatek_86.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek_86
{
    /// <summary>
    /// Fenêtre d'authentification (seul le responsable peut accéder à l'application)
    /// </summary>
    public partial class FormAuth : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private AuthController controller;
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormAuth()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Initialisation : création du controleur
        /// </summary>
        private void Init()
        { 
            controller = new AuthController();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Demande au controleur de controler l'authentification 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_btn_Click(object sender, EventArgs e)
        {
            String username = textBox_username.Text;
            String password = textBox_password.Text;

            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tous les champs doivent etre remplis");
            }
            else
            {
                Responsable responsable = new Responsable(username, password);
                if (controller.ControlAuth(responsable))
                {
                    FormPersList frm = new FormPersList(this);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte");
                }
            }

        }

        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
