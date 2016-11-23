using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_Cultura.Pojos
{
    class clsAlumnos
    {
        private string matricula_alumno;
        private string nombres;
        private string apellidos;
        private string fecha_nacimiento;
        private string tipo_sangre;
        private string horario;
        private string curso;
        private string domicilio;
        private string codigo_postal;
        private string lugar_origen;
        private string curp;


        public string Matricula_alumno
        {
            get
            {
                return matricula_alumno;
            }
            set
            {
                matricula_alumno = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }
            set
            {
                nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }

        public string Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }
            set
            {
                fecha_nacimiento = value;
            }
        }

        public string Tipo_sangre
        {
            get
            {
                return tipo_sangre;
            }
            set
            {
                tipo_sangre = value;
            }
        }

        public string Horario
        {
            get
            {
                return horario;
            }
            set
            {
                horario = value;
            }
        }

        public string Curso
        {
            get
            {
                return curso;
            }
            set
            {
                curso = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }

        public string Codigo_postal
        {
            get
            {
                return codigo_postal;
            }
            set
            {
                codigo_postal = value;
            }
        }

        public string Lugar_origen
        {
            get
            {
                return lugar_origen;
            }
            set
            {
               lugar_origen = value;
            }
        }

        public string Curp
        {
            get
            {
                return curp;
            }
            set
            {
                curp = value;
            }
        }

    }
}
