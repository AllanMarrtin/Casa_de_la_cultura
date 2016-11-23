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
    public partial class Aulas : Form
    {
        DaoAulas datos = new DaoAulas();

        public Aulas()
        {
            InitializeComponent();
            tabladatos.DataSource = datos.CargarDatos();

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        
        private void Aulas_Load(object sender, EventArgs e)
        {

        }

        //Menu Principal
        private void irAPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.MenuPrincipal a = new Presentacion.MenuPrincipal();
            a.Show();
            Hide();
        }


        //Agregar
        private void agregar_Click(object sender, EventArgs e)
        {
            //   Pojos.clsAulas a;
            //  Datos.DaoAulas b = new Datos.DaoAulas();
            // if (clave_grupo.Text.Length > 0 && no_aula.Text.Length > 0 && materia_imp.Text.Length > 0 && horario.Text.Length > 0 && profesor.Text.Length > 0 && no_alumnos.Text.Length > 0)
            /*  {

                 clsAulas aula = new Pojos.clsAulas(clave_grupo.Text, no_aula.Text, materia_imp.Text, horario.Text, profesor.Text, no_alumnos.Text);
                  int n = b.AgregarAula(a);
                  MessageBox.Show("Aula Agregada");
                  clave_grupo.Text = "";
                  no_aula.Text = "";
                  materia_imp.Text = "";
                  horario.Text = "";
                  profesor.Text = "";
                  a.Numero_alumnos = Convert.ToInt32(no_alumnos.Text); 
                  tabladatos.DataSource = datos.CargarDatos();
              }*/

             clsAulas aula = new clsAulas();
             aula.Clave_grupo = clave_grupo.Text;
             aula.Numero_aula = no_aula.Text;
             aula.Materia_impartida = materia_imp.Text;
             aula.Horario = horario.Text;
             aula.Profesor = profesor.Text;
             aula.Numero_alumnos = Convert.ToInt32(no_alumnos.Text);
             tabladatos.DataSource = datos.CargarDatos();
         

             DaoAulas objAula = new DaoAulas();
            int n = objAula.AgregarAula(aula);
             if (n==1)
             {
                 MessageBox.Show("Aula Agregado", "Aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MessageBox.Show("Faltan campos");
             }
         
         
        }


        //Buscar
        private void buscar_Click(object sender, EventArgs e)
        {
           
            string busca = "";
            busca = txtBus.Text;

            if (busca.Length > 0)
            {
                tabladatos.DataSource = datos.BuscarDatos(busca);
            }
            else
            {
                MessageBox.Show("No hay usuario a Buscar");
            }
        
    }

        private void tabladatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }




}
