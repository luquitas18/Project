using Project.Administrativo.Gestion;
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
    public partial class AdministrativoApp : Form
    {
        public AdministrativoApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Altas altas = new Altas();
            altas.Show();
            this.Hide();
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bajas bajas = new Bajas();
            bajas.Show();
            
        }

        private void datosPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModDatosPersona modDatosPersona = new ModDatosPersona();
            modDatosPersona.Show();
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTelefono agregarTelefono = new AgregarTelefono();
            agregarTelefono.Show();
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarTelefono eliminarTelefono = new EliminarTelefono();
            eliminarTelefono.Show();
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarTelefono modificarTelefono = new ModificarTelefono();
            modificarTelefono.Show();
        }

        private void siembraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConSiembra conSiembra = new ConSiembra();
        }
    }
}
