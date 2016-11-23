using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Casa_Cultura.Datos
{
    class DaoInstructores
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
    public int AgregarInstructor(Pojos.clsInstructores obj)
    {


        string sql;
        MySqlCommand cm;
        Conectar();
        cm = new MySqlCommand();
        cm.Parameters.AddWithValue("@matricula", obj.Matricula_instructor);
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


        sql = "INSERT INTO instructores (Matricula,Nombres,Apellidos,fecha_Nacimiento,tipo_Sangre,Horario,Curso,Domicilio,codigo_postal,Lugar_Origen,CURP) VALUES (@matricula,@nombres,@apellidos,@fecha_nac,@sangre,@horario,@curso,@domicilio,@cp,@lugar_origen,@curp)";
        cm.CommandText = sql;
        cm.CommandType = CommandType.Text;
        cm.Connection = cnConexion;

        int t = cm.ExecuteNonQuery();
        Cerrar();
        return t;

    }



    //Metodo Buscar
    public List<Pojos.clsInstructores> BuscarDatos(string matricula)
    {
        List<Pojos.clsInstructores> _lista = new List<Pojos.clsInstructores>();
        string sql;
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader _reader;
        Conectar();
        cm.Parameters.AddWithValue("@matricula", matricula);
        sql = "SELECT * FROM instructores WHERE Matricula=@matricula";
        cm.CommandText = sql;
        cm.CommandType = CommandType.Text;
        cm.Connection = cnConexion;
        _reader = cm.ExecuteReader();
        while (_reader.Read())
        {
            Pojos.clsInstructores instructor = new Pojos.clsInstructores();

                instructor.Matricula_instructor = _reader.GetString(0);
                instructor.Nombres = _reader.GetString(1);
                instructor.Apellidos = _reader.GetString(2);
                instructor.Fecha_nacimiento = _reader.GetString(3);
                instructor.Tipo_sangre = _reader.GetString(4);
                instructor.Horario = _reader.GetString(5);
                instructor.Curso = _reader.GetString(6);
                instructor.Domicilio = _reader.GetString(7);
                instructor.Codigo_postal = _reader.GetString(8);
                instructor.Lugar_origen = _reader.GetString(9);
                instructor.Curp = _reader.GetString(10);

            _lista.Add(instructor);
        }
        Cerrar();
        return _lista;
    }


    //Metodo CargarDatos
    public List<Pojos.clsInstructores> CargarDatos()
    {
        List<Pojos.clsInstructores> _lista = new List<Pojos.clsInstructores>();
        string sql;
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader _reader;
        Conectar();
        sql = "SELECT * FROM instructores";
        cm.CommandText = sql;
        cm.CommandType = CommandType.Text;
        cm.Connection = cnConexion;
        _reader = cm.ExecuteReader();
        while (_reader.Read())
        {
            Pojos.clsInstructores instructor = new Pojos.clsInstructores();

                instructor.Matricula_instructor = _reader.GetString(0);
                instructor.Nombres = _reader.GetString(1);
                instructor.Apellidos = _reader.GetString(2);
                instructor.Fecha_nacimiento = _reader.GetString(3);
                instructor.Tipo_sangre = _reader.GetString(4);
                instructor.Horario = _reader.GetString(5);
                instructor.Curso = _reader.GetString(6);
                instructor.Domicilio = _reader.GetString(7);
                instructor.Codigo_postal = _reader.GetString(8);
                instructor.Lugar_origen = _reader.GetString(9);
                instructor.Curp = _reader.GetString(10);


            _lista.Add(instructor);
        }
        Cerrar();
        return _lista;
    }


    //Metodo Eliminar
    public List<Pojos.clsInstructores> EliminarInstructor(string matricula)
    {
        List<Pojos.clsInstructores> _lista = new List<Pojos.clsInstructores>();
        string sql;
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader _reader;
        Conectar();
        sql = "DELETE FROM instructores WHERE Matricula=@matricula";
        cm.CommandText = sql;
        cm.CommandType = CommandType.Text;
        cm.Parameters.AddWithValue("@matricula", matricula);
        cm.Connection = cnConexion;
        _reader = cm.ExecuteReader();
        while (_reader.Read())
        {
            Pojos.clsInstructores instructor = new Pojos.clsInstructores();

                instructor.Matricula_instructor = _reader.GetString(0);
                instructor.Nombres = _reader.GetString(1);
                instructor.Apellidos = _reader.GetString(2);
                instructor.Fecha_nacimiento = _reader.GetString(3);
                instructor.Tipo_sangre = _reader.GetString(4);
                instructor.Horario = _reader.GetString(5);
                instructor.Curso = _reader.GetString(6);
                instructor.Domicilio = _reader.GetString(7);
                instructor.Codigo_postal = _reader.GetString(8);
                instructor.Lugar_origen = _reader.GetString(9);
                instructor.Curp = _reader.GetString(10);


                _lista.Add(instructor);
        }
        Cerrar();
        return _lista;
    }


    //Validacion
    public int validaCarga(Pojos.clsInstructores obj)
    {
        int n = 0;
        string sql;
        MySqlCommand cm = new MySqlCommand();

        MySqlDataReader resulto = null;

        Conectar();


        cm.Parameters.AddWithValue("@matricula", obj.Matricula_instructor);
        sql = "SELECT * FROM instructores WHERE Matricula=@matricula";
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
    public int ModificarInstructor(string matricula, string nombres, string apellidos, string fecha_nac, string sangre, string horario, string curso, string domicilio, string cp, string lo, string curp)
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

        sql = "UPDATE alumnos SET Nombres=@nombres, Apellidos=@apellidos,fecha_Nacimiento=@fecha_nac, tipo_Sangre=@sangre, Horario=@horario, Curso = @curso, Domicilio = @domicilio, codigo_postal=@cp, Lugar_Origen=@lo, CURP=@curp  WHERE Matricula = @matricula";
        cm.CommandText = sql;
        cm.CommandType = CommandType.Text;
        cm.Connection = cnConexion;

        int t = cm.ExecuteNonQuery();
        Cerrar();
        return t;

    }


}

    }