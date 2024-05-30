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
    public partial class FormAuth : Form
    {
        private AuthController controller;
        public FormAuth()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        { 
            controller = new AuthController();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
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

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
