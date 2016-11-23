using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_Cultura.Pojos
{
    class clsAulas 
    {
        private string clave_grupo;
        private string numero_aula;
        private string materia_impartida;
        private string horario;
        private string profesor;
        private int numero_alumnos;

        public clsAulas()
        {

        }

        /*public clsAulas(string clave_grupo, string numero_aula, string materia_impartida, string horario, string profesor, int numero_alumnos)
        {
            Clave_grupo = clave_grupo;
            Numero_aula = numero_aula;
            Materia_impartida = materia_impartida;
            Horario = horario;
            Profesor = profesor;
            Numero_alumnos = numero_alumnos;


        }*/

        public string Clave_grupo
        {
            get
            {
                return clave_grupo;
            }
            set
            {
                clave_grupo = value;
            }
        }

        public string Numero_aula
        {
            get
            {
                return numero_aula;
            }
            set
            {
                numero_aula = value;
            }
        }

        public string Materia_impartida
        {
            get
            {
                return materia_impartida;
            }
            set
            {
                materia_impartida = value;
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

        public string Profesor
        {
            get
            {
                return profesor;
            }
            set
            {
                profesor = value;
            }
        }

        public int Numero_alumnos
        {
            get
            {
                return numero_alumnos;
            }
            set
            {
                numero_alumnos = value;
            }
        }

    }

}
