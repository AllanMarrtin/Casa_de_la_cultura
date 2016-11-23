using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_Cultura.Pojos
{
    class clsUsuarios
    {

        private string tipo_usuario;
        private string usuario;
        private string contraseña;
        private Image imagen;

        public clsUsuarios()
        {

        }

        public clsUsuarios(string tipo, string usu, string pass)
        {
            tipo_usuario = tipo;
            usuario = usu;
            Contraseña = pass;
           
        }

        public clsUsuarios(string tipo, string usu, string pass, Image ima)
        {
            tipo_usuario = tipo;
            usuario = usu;
            Contraseña = pass;
            imagen = ima;
        }

        /*public Image Imagen
        {
            get
            {
                return Imagen;
            }
            set
            {
                Imagen = value;
            }
        }
        */
        public string Tipo_usuario
        {
            get
            {
                return tipo_usuario;
            }
            set
            {
                tipo_usuario = value;
            }
           
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }



    }

}
