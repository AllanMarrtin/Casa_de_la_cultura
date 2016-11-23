using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa_Cultura.Presentacion
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.MenuPrincipal a = new Presentacion.MenuPrincipal();
            a.Show();
            Hide();
        }

        private void verToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Presentacion.MenuPrincipal a = new Presentacion.MenuPrincipal();
            a.Show();
            Hide();
        }
    }
}
