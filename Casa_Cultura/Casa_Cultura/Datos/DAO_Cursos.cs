using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Casa_Cultura.Datos
{
    class DAO_Cursos
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




        public int AgregarCurso(Pojos.clsUsuarios obj)
        {
            string sql;
            MySqlCommand cm;
            Conectar();
            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@tipo", obj.Tipo_usuario);
            cm.Parameters.AddWithValue("@usuario", obj.Usuario);
            cm.Parameters.AddWithValue("@contraseña", obj.Contraseña);
           // cm.Parameters.AddWithValue("@imagen", imgArr);
            sql = "INSERT INTO login (Usuario,password,Tipo_Usuario,Imagen) VALUES (@usuario,SHA1(@contraseña),@tipo,@imagen)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;

            int t = cm.ExecuteNonQuery();
            Cerrar();
            return t;
        }
    }




    
}
