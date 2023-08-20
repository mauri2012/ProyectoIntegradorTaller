using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.formularios
{
    public partial class CrearAula : Form
    {
        public CrearAula()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BMaximizar.Visible = false;
            BRestaurar.Visible = true;
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BMaximizar.Visible = true;
            BRestaurar.Visible = false;
        }

        private void BEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
