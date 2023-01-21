using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaTrabajoFinal
{
    public partial class EmpleadoMenu : Form
    {
        public EmpleadoMenu()
        {
            InitializeComponent();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            ControlPrestamo Control = new ControlPrestamo();
            panel1.Controls.Clear();
            Control = new ControlPrestamo();
            Control.Dock = DockStyle.Fill;
            panel1.Controls.Add(Control);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ControlCliente Control = new ControlCliente();
            panel1.Controls.Clear();
            Control = new ControlCliente();
            Control.Dock = DockStyle.Fill;
            panel1.Controls.Add(Control);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            ControlLibro Control = new ControlLibro();
            panel1.Controls.Clear();
            Control = new ControlLibro();
            Control.Dock = DockStyle.Fill;
            panel1.Controls.Add(Control);
        }

        private void EmpleadoMenu_Load(object sender, EventArgs e)
        {
            ConexionBiblioteca con = new ConexionBiblioteca();
            con.abrir();
        }
    }
}
