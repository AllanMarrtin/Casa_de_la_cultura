using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casa_Cultura.Datos;
using Casa_Cultura.Pojos;

namespace Casa_Cultura.Presentacion
{
    public partial class Alumnos : Form
    {
        DaoAlumnos datos = new DaoAlumnos();

        public Alumnos()
        {
            InitializeComponent();
            tabladatos.DataSource = datos.CargarDatos();
        }

        

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        //Menu Principal
        private void irAPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.MenuPrincipal a = new Presentacion.MenuPrincipal();
            a.Show();
            Hide();
        }


        //Buscar
        private void buscar_Click(object sender, EventArgs e)
        {
            string busca = "";
            // busca = txtBus.Text;

            if (busca.Length > 0)
            {
                tabladatos.DataSource = datos.BuscarDatos(busca);
            }
            else
            {
                MessageBox.Show("No hay usuario a Buscar");
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
