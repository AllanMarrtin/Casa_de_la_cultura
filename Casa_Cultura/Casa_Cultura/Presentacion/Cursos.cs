using Casa_Cultura.Pojos;
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
        clsCursos Curso = new clsCursos();
        int validaEntrada, validaSalida;
        int duracion,presionoDias;
        string L, M, Mi,J,V,S;
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtIdCurso.Text.Length > 0 && txtSalon.Text.Length>0 && txtNombreCurso.Text.Length > 0 && txtProfesor.Text.Length > 0 && validaEntrada>0 && validaSalida>0 && Cupocurso.Value>0 && inscritos.Value>0 && txtDuracion.Text.Length>0 && presionoDias>0)
            {

                MessageBox.Show("Ya agrega");
            }else
            {
                MessageBox.Show("Faltan Campos");
            }

        }

        private void fechaFinCurso_MouseMove(object sender, MouseEventArgs e)
        {
            Curso.Fin_curso = fechaFinCurso.Value.Year + "-" + fechaFinCurso.Value.Month + "-" + fechaFinCurso.Value.Day;
            validaSalida++;
            MessageBox.Show("Fin curso "+Curso.Fin_curso);
            //Resto fechas
            TimeSpan a = FechaInicioCurso.Value.Date - fechaFinCurso.Value.Date;
            duracion = a.Days;
        }

        private void ListaDias_MouseClick(object sender, MouseEventArgs e)
        {
            presionoDias++;
            L = ListaDias.SelectedItem.ToString();
            MessageBox.Show(L+ M+ Mi + J+ V+ S);
            M = ListaDias.CheckedItems[1].ToString();
            Mi = ListaDias.CheckedItems[2].ToString();
            J = ListaDias.CheckedItems[3].ToString();
            V = ListaDias.CheckedItems[4].ToString();
            S = ListaDias.CheckedItems[5].ToString();
        }

        private void FechaInicioCurso_MouseMove(object sender, MouseEventArgs e)
        {
            ///Formato Año-Mes-Día.
            Curso.Inicio_curso = FechaInicioCurso.Value.Year+"-"+FechaInicioCurso.Value.Month+"-"+FechaInicioCurso.Value.Day;
            validaEntrada++;//Convert.ToInt32(Curso.Inicio_curso);
            MessageBox.Show("Inicio Curso "+ Curso.Inicio_curso);
            //Resto fechas
            TimeSpan a= FechaInicioCurso.Value.Date - fechaFinCurso.Value.Date;
            duracion = a.Days; 
        }
    }
}
