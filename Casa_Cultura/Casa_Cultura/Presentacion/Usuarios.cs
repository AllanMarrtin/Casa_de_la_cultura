using Casa_Cultura.Datos;
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
    public partial class clsUsuarios : Form
    {
        metodos_Datos datos = new metodos_Datos();

        public clsUsuarios()
        {
            InitializeComponent();
            tabladatos.DataSource = datos.CargarDatos();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.MenuPrincipal a = new Presentacion.MenuPrincipal();
            a.Show();
            Hide();
        }

        private void regresarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsUsuarios a = new clsUsuarios();
            a.Show();
            Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        int yahayimagen = 0;
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Pojos.clsUsuarios a;
            Datos.metodos_Datos b = new Datos.metodos_Datos();
            if (comboUsuario.Text.Length > 0 && txtUsuarios.Text.Length > 0 && txtpass.Text.Length > 0 && yahayimagen == 1)
            {

                a = new Pojos.clsUsuarios(comboUsuario.Text, txtUsuarios.Text, txtpass.Text, cajaImagen.Image);
                int n = b.AgregarUsuario(a, cajaImagen.Image);
                MessageBox.Show("Usuario Agregado");
                yahayimagen = 0;
                txtpass.Text = "";
                txtUsuarios.Text = "";
                comboUsuario.Text = null;
                cajaImagen.Image = null;
                tabladatos.DataSource = datos.CargarDatos();
            }
            else
            {
                MessageBox.Show("Faltan campos o imagen");
            }

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string va = "";
            va = txtBusUsuario.Text;
            //            MessageBox.Show(txtBusUsuario.Text + " " + va.Length);

            if (va.Length > 0)
            {
                tabladatos.DataSource = datos.BuscarDatos(va);
            }
            else
            {
                MessageBox.Show("No hay usuario a Buscar");
            }
        }

        private void btnExaminar1(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                cajaImagen.ImageLocation = getImage.FileName;
                yahayimagen = 1;
            }
            else
            {
                MessageBox.Show("No hay imagen");
            }
        }

        private void cajaImagen_Click(object sender, EventArgs e)
        {

        }


        string campo_Eliminar;
        DataGridViewRow dgv;
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (campo_Eliminar.Length > 0)
                {
                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //  MessageBox.Show("llegue a eliminar "+campo_Eliminar ); 
                        datos.EliminarUsuario(campo_Eliminar);
                        MessageBox.Show("Registro eliminado");
                        tabladatos.DataSource = datos.CargarDatos();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("No has seleccionado el usuario a eliminar.");
            }
        }

        private void verUsuariiosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tabladatos.DataSource = datos.CargarDatos();
        }
        int yaseleccionopamodificar = 0;
        private void tabladatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv = tabladatos.Rows[e.RowIndex];
            campo_Eliminar = dgv.Cells[1].Value.ToString();
            MessageBox.Show("Dato Seleccionado: " + campo_Eliminar);
        }

        private void irAPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal vamos = new MenuPrincipal();
            vamos.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yaseleccionopamodificar==0) {
                try
                {
                    comboUsuario.Text = dgv.Cells[0].Value.ToString();
                    txtUsuarios.Text = dgv.Cells[1].Value.ToString();
                    txtpass.Text= dgv.Cells[2].Value.ToString();
                    
                    txtpass.Enabled = false;
                    txtUsuarios.Enabled = false;
                    yaseleccionopamodificar = 1;
                }
                catch
                {
                    MessageBox.Show("No has seleccionado un usuario a Modificar");
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yaseleccionopamodificar == 1)
            {

                
                Datos.metodos_Datos b = new Datos.metodos_Datos();
                if (comboUsuario.Text.Length > 0 && txtUsuarios.Text.Length > 0 && txtpass.Text.Length > 0 && yahayimagen == 1)
                {
                    string tipo1 = comboUsuario.Text;
                    string tipo2 = txtUsuarios.Text;
                    Image pic = cajaImagen.Image;
                   
                    int n = b.ModificarUsuario(tipo1,tipo2,pic);

                    if (n > 0)
                    {
                        MessageBox.Show("Cliente Modificado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtpass.Text = "";
                        yaseleccionopamodificar = 0;
                        //Activar(true) o desactivar(false) un txt
                        txtpass.Enabled = true;
                        txtUsuarios.Enabled = true;
                        txtUsuarios.Text = "";
                        txtpass.Text = "";
                        cajaImagen.Image = null;
                        comboUsuario.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cambio", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //Activar(true) o desactivar(false) un txt
                        txtpass.Enabled = true;
                        txtUsuarios.Enabled = true;
                        yaseleccionopamodificar = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No hay nada que modificar");
                    //Activar(true) o desactivar(false) un txt
                    txtpass.Enabled = true;
                    txtUsuarios.Enabled = true;
                }
            }
        }

        private void clsUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
