using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_Cultura.Pojos
{
    class clsInscripciones
    {
        private string matricula_alumno;
        private string id_curso;
        private string costo;
        private string fecha_inscripcion;

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

        public string Id_curso
        {
            get
            {
                return id_curso;
            }
            set
            {
                id_curso = value;
            }
        }

        public string Costo
        {
            get
            {
                return costo;
            }
            set
            {
                costo = value;
            }
        }

        public string TFecha_inscripcion
        {
            get
            {
                return fecha_inscripcion;
            }
            set
            {
                fecha_inscripcion = value;
            }
        }


    }
}
