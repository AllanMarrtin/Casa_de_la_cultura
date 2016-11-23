using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data.SqlClient;
using Casa_Cultura.Pojos;
using Casa_Cultura.Presentacion;

namespace Casa_Cultura.Datos
{
    class metodos_Datos
    {

        //Creo la variable que permite establecer conexión 
        private MySqlConnection cnConexion = new MySqlConnection();
        //Metodo para ábrir la Conexión
        public void Conectar()
        {
            string strinCadeConexion;
            strinCadeConexion = "server=127.0.0.1; database=cursos; Uid=root; pwd=root;";
            cnConexion.ConnectionString = strinCadeConexion;
            cnConexion.Open();
        }
        //Metodo para Cerrar la Conexión
        public void Cerrar()
        {
            cnConexion.Close();
        }

        //Metodo AgregarUsuario que toma todos los campos y una imagen y los inserta en la tabla con contraseña encriptada
        public int AgregarUsuario(Pojos.clsUsuarios obj, Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, ImageFormat.Gif);
                byte[] imgArr = ms.ToArray();

                string sql;
                MySqlCommand cm;
                Conectar();
                cm = new MySqlCommand();
                cm.Parameters.AddWithValue("@tipo", obj.Tipo_usuario);
                cm.Parameters.AddWithValue("@usuario", obj.Usuario);
                cm.Parameters.AddWithValue("@contraseña", obj.Contraseña);
                cm.Parameters.AddWithValue("@imagen", imgArr);
                sql = "INSERT INTO login (Usuario,password,Tipo_Usuario,Imagen) VALUES (@usuario,SHA1(@contraseña),@tipo,@imagen)";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;

                int t = cm.ExecuteNonQuery();
                Cerrar();
                return t;
            }
        }
        //Llega un objeto de usuario
        //Metodo que valida si el usuario es correcto con todo los campos y el password encriptado
        public int BuscarUsuario(Pojos.clsUsuarios obj)
        {
            int n = 0;
            string sql;
            MySqlCommand cm = new MySqlCommand();

            MySqlDataReader resulto = null;

            Conectar();

            cm.Parameters.AddWithValue("@tipo", obj.Tipo_usuario);
            cm.Parameters.AddWithValue("@usuario", obj.Usuario);
            cm.Parameters.AddWithValue("@contraseña", obj.Contraseña);
            sql = "SELECT * FROM login WHERE Usuario=@usuario and password=SHA1(@contraseña) and Tipo_Usuario=@tipo";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;

            resulto = cm.ExecuteReader();
            if (resulto.Read())
            {
                n = 1;
            }
            Cerrar();
            //Si el usuario es valido retorna 1 si no 0
            return n;
        }





        //Metodo Buscar un usuario
        public List<Pojos.clsUsuarios> BuscarDatos(string usuario)
        {
            List<Pojos.clsUsuarios> _lista = new List<Pojos.clsUsuarios>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader _reader;
            Conectar();
            cm.Parameters.AddWithValue("@usuario", usuario);
            sql = "SELECT * FROM login WHERE Usuario=@usuario";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            _reader = cm.ExecuteReader();
            while (_reader.Read())
            {
                Pojos.clsUsuarios pusuario = new Pojos.clsUsuarios();


                pusuario.Usuario = _reader.GetString(0);
                pusuario.Contraseña = _reader.GetString(1);
                pusuario.Tipo_usuario = _reader.GetString(2);
                //comocargar imagen  pusuario.Imagen = _reader.GetString(3);



                _lista.Add(pusuario);
            }
            Cerrar();
            return _lista;
        }


        //Metodo CargarDatos
        public List<Pojos.clsUsuarios> CargarDatos()
        {
            List<Pojos.clsUsuarios> _lista = new List<Pojos.clsUsuarios>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader _reader;
            Conectar();
            sql = "SELECT * FROM login";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            _reader = cm.ExecuteReader();
            while (_reader.Read())
            {
                Pojos.clsUsuarios pusuario = new Pojos.clsUsuarios();


                pusuario.Usuario = _reader.GetString(0);
                pusuario.Contraseña = _reader.GetString(1);
                pusuario.Tipo_usuario = _reader.GetString(2);
                //comocargar imagen  pusuario.Imagen = _reader.GetString(3);



                _lista.Add(pusuario);
            }
            Cerrar();
            return _lista;
        }

        public List<Pojos.clsUsuarios> EliminarUsuario(string usuario)
        {
            List<Pojos.clsUsuarios> _lista = new List<Pojos.clsUsuarios>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader _reader;
            Conectar();
            sql = "DELETE FROM login WHERE usuario=@usuario";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@usuario", usuario);
            cm.Connection = cnConexion;
            _reader = cm.ExecuteReader();
            while (_reader.Read())
            {
                Pojos.clsUsuarios pusuario = new Pojos.clsUsuarios();


                pusuario.Usuario = _reader.GetString(0);
                pusuario.Contraseña = _reader.GetString(1);
                pusuario.Tipo_usuario = _reader.GetString(2);


                _lista.Add(pusuario);
            }
            Cerrar();
            return _lista;
        }

        public int validaCarga(Pojos.clsUsuarios obj)
        {
            int n = 0;
            string sql;
            MySqlCommand cm = new MySqlCommand();

            MySqlDataReader resulto = null;

            Conectar();


            cm.Parameters.AddWithValue("@usuario", obj.Usuario);
            sql = "SELECT * FROM login WHERE Usuario=@usuario";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;

            resulto = cm.ExecuteReader();
            if (resulto.Read())
            {
                n = 1;
            }
            Cerrar();
            //Si el usuario es valido retorna 1 si no 0
            return n;
        }

        //Carga la imagen del usuario si el nombre esta bien en caso de que se equivoque o al momento de ingresar
        public Image CargarImagen(Pojos.clsUsuarios obj)
        {

            string sql;
            Conectar();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
                sql = "SELECT Imagen FROM login WHERE Usuario=@usuario";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnConexion;
                byte[] imgArr = (byte[])cmd.ExecuteScalar();
                imgArr = (byte[])cmd.ExecuteScalar();
                using (var stream = new MemoryStream(imgArr))
                {
                    Image img = Image.FromStream(stream);
                    return img;
                }
            }


        }

        private static MySqlConnection GetNewConnection()
        {
            throw new NotImplementedException();
        }


        public int ModificarUsuario(string tipo,string usuario, Image picture)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                picture.Save(ms, ImageFormat.Gif);
                byte[] imgArr = ms.ToArray();
                string sql;
                MySqlCommand cm;
                Conectar();
                cm = new MySqlCommand();
                cm.Parameters.AddWithValue("@tipo", tipo);
                cm.Parameters.AddWithValue("@imagen", imgArr);
                cm.Parameters.AddWithValue("@usuario", usuario);

                sql = "UPDATE login SET Tipo_Usuario=@tipo, Imagen=@imagen WHERE Usuario=@usuario";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;

                int t = cm.ExecuteNonQuery();
                Cerrar();
                return t;
            }
        }

        
    }
}
