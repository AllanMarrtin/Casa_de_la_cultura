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
    public partial class Instructores : Form
    {
        DaoInstructores datos = new DaoInstructores();

        public Instructores()
        {
            InitializeComponent();
            tabladatos.DataSource = datos.CargarDatos();
        }

        
        // Menu principal
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
            //busca = txtBuscar.Text;

            if (busca.Length > 0)
            {
                tabladatos.DataSource = datos.BuscarDatos(busca);
            }
            else
            {
                MessageBox.Show("No hay usuario a Buscar");
            }
        }

        //Agregar
        private void agregar_Click(object sender, EventArgs e)
        {
            clsInstructores instructor = new clsInstructores();
            instructor.Matricula_instructor = txtMatricula.Text;
            instructor.Nombres = txtNombres.Text;
            instructor.Apellidos = txtApellidos.Text;
            instructor.Fecha_nacimiento = fecha.Text;
            instructor.Tipo_sangre = cmbSangre.Text;
            instructor.Horario = txtHorario.Text;
            instructor.Curso = txtCurso.Text;
            instructor.Domicilio = txtDomicilio.Text;
            instructor.Codigo_postal = txtCp.Text;
            instructor.Lugar_origen = txtLO.Text;
            instructor.Curp = txtCurp.Text;

           /* DaoInstructores objInstructor = new DaoInstructores();
            if (objInstructor.AgregarInstructor(instructor))
            {
                MessageBox.Show("Instructor Agregado", "Instructor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faltan campos");
            }*/
        }

        private void Instructores_Load(object sender, EventArgs e)
        {

        }
    }
}
