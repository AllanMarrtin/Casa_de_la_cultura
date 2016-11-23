using Casa_Cultura.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa_Cultura
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pojos.clsUsuarios a ;
            Datos.metodos_Datos b= new Datos.metodos_Datos();

                if (comboUsuario.Text.Length > 0 && txtUsuarios.Text.Length > 0 && txtpass.Text.Length > 0)
                {
                    a = new Pojos.clsUsuarios(comboUsuario.Text, txtUsuarios.Text, txtpass.Text);
               
                    int n = b.BuscarUsuario(a);
                    if (n == 1)
                    {
                        MenuPrincipal s = new MenuPrincipal();
                        s.Show();
                        Hide();
                    }
                    else{int carga = b.validaCarga(a);//manda el objeto usuario pero solo se ocupa el nombre
                    if (carga == 1)
                    {
                        //carga imagen si el usuario al menos es correcto
                        Image usu = b.CargarImagen(a);
                        cajaImagen.Image = usu;
                    }
                    else
                    {
                        //limpia el campo de imagenes si no es correcto el usuario
                        cajaImagen.Image =null;
                    }
                    MessageBox.Show("Usuario no valido");
                    }
            }else{MessageBox.Show("Faltan Campos");}

            // Presentacion.MenuPrincipal a = new Presentacion.MenuPrincipal();
            //a.Show();
            //Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "Imagenes JPG|*.jpg|Imagenes GIF|*.gif|Imagenes bitmasps|*.bmp";
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*jpg";

            BuscarImagen.InitialDirectory = "C:\\";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                //Si se ocupa la ruta
                //cajadetexto= buscarImagen.fileName;
                cajaImagen.ImageLocation = BuscarImagen.FileName;
                
            }

        }
    }
}
