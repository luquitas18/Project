using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aca defino el tamaño maximo que podra tomar el txtCedula
            txtID.MaxLength = 15;
            //Realizo esta accion para que el txtCedula reciva solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar == 13 && txtID.Text != string.Empty)
                {
                    txtID.Text = string.Empty;
                    txtID.Focus();
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            administrativo.Show();
            this.Hide();
            
        }
    }
}
