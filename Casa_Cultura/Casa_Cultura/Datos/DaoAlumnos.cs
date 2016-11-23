using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace Casa_Cultura.Datos
{
    class DaoAlumnos
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
            public int AgregarAula(Pojos.clsAlumnos obj)
            {


                string sql;
                MySqlCommand cm;
                Conectar();
                cm = new MySqlCommand();
                cm.Parameters.AddWithValue("@matricula", obj.Matricula_alumno);
                cm.Parameters.AddWithValue("@nombres", obj.Nombres);
                cm.Parameters.AddWithValue("@apellidos", obj.Apellidos);
                cm.Parameters.AddWithValue("@fecha_nac", obj.Fecha_nacimiento);
                cm.Parameters.AddWithValue("@sangre", obj.Tipo_sangre);
                cm.Parameters.AddWithValue("@horario", obj.Horario);
                cm.Parameters.AddWithValue("@curso", obj.Curso);
                cm.Parameters.AddWithValue("@domicilio", obj.Domicilio);
                cm.Parameters.AddWithValue("@cp", obj.Codigo_postal);
                cm.Parameters.AddWithValue("@lugar_origen", obj.Lugar_origen);
                cm.Parameters.AddWithValue("@curp", obj.Curp);


            sql = "INSERT INTO alumnos (Matricula_Alumno,Nombres,Apellidos,fecha_nacimiento,tipo_sangre,Horario,curso,Domicilio,codigo_postal,Lugar_Origen,CURP) VALUES (@matricula,@nombres,@apellidos,@fecha_nac,@sangre,@horario,@curso,@domicilio,@cp,@lugar_origen,@curp)";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;

                int t = cm.ExecuteNonQuery();
                Cerrar();
                return t;

            }



            //Metodo Buscar
            public List<Pojos.clsAlumnos> BuscarDatos(string matricula)
            {
                List<Pojos.clsAlumnos> _lista = new List<Pojos.clsAlumnos>();
                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader _reader;
                Conectar();
                cm.Parameters.AddWithValue("@matricula", matricula);
                sql = "SELECT * FROM alumnos WHERE Matricula_Alumno=@matricula";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;
                _reader = cm.ExecuteReader();
                while (_reader.Read())
                {
                    Pojos.clsAlumnos alumno = new Pojos.clsAlumnos();

                    alumno.Matricula_alumno = _reader.GetString(0);
                    alumno.Nombres = _reader.GetString(1);
                    alumno.Apellidos = _reader.GetString(2);
                    alumno.Fecha_nacimiento = _reader.GetString(3);
                    alumno.Tipo_sangre = _reader.GetString(4);
                    alumno.Horario = _reader.GetString(5);
                    alumno.Curso = _reader.GetString(6);
                    alumno.Domicilio = _reader.GetString(7);
                    alumno.Codigo_postal = _reader.GetString(8);
                    alumno.Lugar_origen = _reader.GetString(9);
                    alumno.Curp = _reader.GetString(10);

                _lista.Add(alumno);
                }
                Cerrar();
                return _lista;
            }


            //Metodo CargarDatos
            public List<Pojos.clsAlumnos> CargarDatos()
            {
                List<Pojos.clsAlumnos> _lista = new List<Pojos.clsAlumnos>();
                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader _reader;
                Conectar();
                sql = "SELECT * FROM alumnos";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;
                _reader = cm.ExecuteReader();
                while (_reader.Read())
                {
                    Pojos.clsAlumnos alumno = new Pojos.clsAlumnos();

                alumno.Matricula_alumno = _reader.GetString(0);
                alumno.Nombres = _reader.GetString(1);
                alumno.Apellidos = _reader.GetString(2);
                alumno.Fecha_nacimiento = _reader.GetString(3);
                alumno.Tipo_sangre = _reader.GetString(4);
                alumno.Horario = _reader.GetString(5);
                alumno.Curso = _reader.GetString(6);
                alumno.Domicilio = _reader.GetString(7);
                alumno.Codigo_postal = _reader.GetString(8);
                alumno.Lugar_origen = _reader.GetString(9);
                alumno.Curp = _reader.GetString(10);


                _lista.Add(alumno);
                }
                Cerrar();
                return _lista;
            }


            //Metodo Eliminar
            public List<Pojos.clsAlumnos> EliminarAlumno(string matricula)
            {
                List<Pojos.clsAlumnos> _lista = new List<Pojos.clsAlumnos>();
                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader _reader;
                Conectar();
                sql = "DELETE FROM alumnos WHERE Matricula_Alumno=@matricula";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Parameters.AddWithValue("@matricula", matricula);
                cm.Connection = cnConexion;
                _reader = cm.ExecuteReader();
                while (_reader.Read())
                {
                    Pojos.clsAlumnos alumno = new Pojos.clsAlumnos();

                alumno.Matricula_alumno = _reader.GetString(0);
                alumno.Nombres = _reader.GetString(1);
                alumno.Apellidos = _reader.GetString(2);
                alumno.Fecha_nacimiento = _reader.GetString(3);
                alumno.Tipo_sangre = _reader.GetString(4);
                alumno.Horario = _reader.GetString(5);
                alumno.Curso = _reader.GetString(6);
                alumno.Domicilio = _reader.GetString(7);
                alumno.Codigo_postal = _reader.GetString(8);
                alumno.Lugar_origen = _reader.GetString(9);
                alumno.Curp = _reader.GetString(10);


                _lista.Add(alumno);
                }
                Cerrar();
                return _lista;
            }


            //Validacion
            public int validaCarga(Pojos.clsAlumnos obj)
            {
                int n = 0;
                string sql;
                MySqlCommand cm = new MySqlCommand();

                MySqlDataReader resulto = null;

                Conectar();


                cm.Parameters.AddWithValue("@matricula", obj.Matricula_alumno);
                sql = "SELECT * FROM alumnos WHERE Matricula_Alumno=@matricula";
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
            public int ModificarAlumno(string matricula, string nombres, string apellidos, string fecha_nac, string sangre, string horario, string curso, string domicilio, string cp, string lo, string curp)
            {


                string sql;
                MySqlCommand cm;
                Conectar();
                cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@matricula", matricula);
            cm.Parameters.AddWithValue("@nombres", nombres);
            cm.Parameters.AddWithValue("@apellidos", apellidos);
            cm.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            cm.Parameters.AddWithValue("@sangre", sangre);
            cm.Parameters.AddWithValue("@horario", horario);
            cm.Parameters.AddWithValue("@curso", curso);
            cm.Parameters.AddWithValue("@domicilio", domicilio);
            cm.Parameters.AddWithValue("@cp", cp);
            cm.Parameters.AddWithValue("@lugar_origen", lo);
            cm.Parameters.AddWithValue("@curp", curp);

            sql = "UPDATE alumnos SET Nombres=@nombres, Apellidos=@apellidos,fecha_Nacimiento=@fecha_nac, tipo_Sangre=@sangre, Horario=@horario, curso = @curso, Domicilio = @domicilio, codigo_postal=@cp, Lugar_Origen=@lo, CURP=@curp  WHERE Matricula_Alumno = @matricula";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cnConexion;

                int t = cm.ExecuteNonQuery();
                Cerrar();
                return t;

            }


        }

    }

