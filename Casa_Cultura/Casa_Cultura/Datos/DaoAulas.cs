using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casa_Cultura.Pojos;
using Casa_Cultura.Presentacion;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Casa_Cultura.Datos
{
    class DaoAulas
    {
        //Crear conexion
        private MySqlConnection cnConexion = new MySqlConnection();

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

        //Metodo Agregar 
        public int AgregarAula(Pojos.clsAulas obj)
        {
                 
                string sql;
                MySqlCommand cm;
                Conectar();
                cm = new MySqlCommand();
                cm.Parameters.AddWithValue("@clave", obj.Clave_grupo);
                cm.Parameters.AddWithValue("@no_aula", obj.Numero_aula);
                cm.Parameters.AddWithValue("@materia", obj.Materia_impartida);
                cm.Parameters.AddWithValue("@horario", obj.Horario);
                cm.Parameters.AddWithValue("@profesor", obj.Profesor);
                cm.Parameters.AddWithValue("@no_alumnos", obj.Numero_alumnos);

            sql = "INSERT INTO aulas (Clave_grupo,Numero_Aula,Materia_Impartida,Horario,Profesor,Numero_Alumnos) VALUES (@clave,@no_aula,@materia,@horario,@profesor,@no_alumnos)";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;

                int t = cm.ExecuteNonQuery();
                Cerrar();
                return t;
            
        }


      
        //Metodo Buscar
        public List<Pojos.clsAulas> BuscarDatos(string clave)
        {
            List<Pojos.clsAulas> _lista = new List<Pojos.clsAulas>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader _reader;
            Conectar();
            cm.Parameters.AddWithValue("@clave", clave);
            sql = "SELECT * FROM aulas WHERE Clave_grupo=@clave";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            _reader = cm.ExecuteReader();
            while (_reader.Read())
            {
                Pojos.clsAulas aula = new Pojos.clsAulas();

                aula.Clave_grupo = _reader.GetString(0);
                aula.Numero_aula = _reader.GetString(1);
                aula.Materia_impartida  = _reader.GetString(2);
                aula.Horario = _reader.GetString(3);
                aula.Profesor = _reader.GetString(4);
                aula.Numero_alumnos = _reader.GetChar(5);
               
                _lista.Add(aula);
            }
            Cerrar();
            return _lista;
        }


        //Metodo CargarDatos
        public List<Pojos.clsAulas> CargarDatos()
        {
            List<Pojos.clsAulas> _lista = new List<Pojos.clsAulas>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader _reader;
            Conectar();
            sql = "SELECT * FROM aulas";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            _reader = cm.ExecuteReader();
            while (_reader.Read())
            {
                Pojos.clsAulas aula = new Pojos.clsAulas();

                aula.Clave_grupo = _reader.GetString(0);
                aula.Numero_aula = _reader.GetString(1);
                aula.Materia_impartida = _reader.GetString(2);
                aula.Horario = _reader.GetString(3);
                aula.Profesor = _reader.GetString(4);
                aula.Numero_alumnos = _reader.GetChar(5);


                _lista.Add(aula);
            }
            Cerrar();
            return _lista;
        }


       //Metodo Eliminar
        public List<Pojos.clsAulas> EliminarAula(string clave)
        {
            List<Pojos.clsAulas> _lista = new List<Pojos.clsAulas>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader _reader;
            Conectar();
            sql = "DELETE FROM aulas WHERE Clave_grupo=@clave";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@clave", clave);
            cm.Connection = cnConexion;
            _reader = cm.ExecuteReader();
            while (_reader.Read())
            {
                Pojos.clsAulas aula = new Pojos.clsAulas();

                aula.Clave_grupo = _reader.GetString(0);
                aula.Numero_aula = _reader.GetString(1);
                aula.Materia_impartida = _reader.GetString(2);
                aula.Horario = _reader.GetString(3);
                aula.Profesor = _reader.GetString(4);
                aula.Numero_alumnos = _reader.GetChar(5);



                _lista.Add(aula);
            }
            Cerrar();
            return _lista;
        }


        //Validacion
        public int validaCarga(Pojos.clsAulas obj)
        {
            int n = 0;
            string sql;
            MySqlCommand cm = new MySqlCommand();

            MySqlDataReader resulto = null;

            Conectar();


            cm.Parameters.AddWithValue("@clave", obj.Clave_grupo);
            sql = "SELECT * FROM aulas WHERE Clave_grupo=@clave";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;

            resulto = cm.ExecuteReader();
            if (resulto.Read())
            {
                n = 1;
            }
            Cerrar();
           
            return n;
        }

       
        private static MySqlConnection GetNewConnection()
        {
            throw new NotImplementedException();
        }

        //Metodo Modificar
        public int ModificarAula(string clave, string no_aula, string materia, string horario, string profesor, int no_alumnos)
        {
            
            
                string sql;
                MySqlCommand cm;
                Conectar();
                cm = new MySqlCommand();
                cm.Parameters.AddWithValue("@clave", clave);
                cm.Parameters.AddWithValue("@no_aula", no_aula);
                cm.Parameters.AddWithValue("@materia", materia);
                cm.Parameters.AddWithValue("@horario", horario);
                cm.Parameters.AddWithValue("@profesor", profesor);
                cm.Parameters.AddWithValue("@no_alumnos", no_alumnos);

            sql = "UPDATE aulas SET Numero_Aula=@no_aula, Materia_Impartida=@materia,Horario=@horario,Profesor=@profesor,Numero_Alumnos=@no_alumnos WHERE Clave_grupo=@clave";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;

                int t = cm.ExecuteNonQuery();
                Cerrar();
                return t;
            
        }


    }
}

