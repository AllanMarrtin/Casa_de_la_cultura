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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cursos_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cursos frm = new Cursos();

            frm.Show();
        }

       
        private void aulas_Click(object sender, EventArgs e)
        {
            this.Hide();

            Aulas frm = new Aulas();

            frm.Show();

        }

        private void alumnos_Click(object sender, EventArgs e)
        {
            this.Hide();

            Alumnos frm = new Alumnos();

            frm.Show();
        }

        private void instruc_Click(object sender, EventArgs e)
        {
            this.Hide();

            Instructores frm = new Instructores();

            frm.Show();
        }

        private void inscrip_Click(object sender, EventArgs e)
        {
            this.Hide();

            Inscripciones frm = new Inscripciones();

            frm.Show();
        }

        private void usuarios_Click(object sender, EventArgs e)
        {
           clsUsuarios a = new clsUsuarios();
            a.Show();
            this.Hide();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios");
            Application.Exit();
        }
    }
}
