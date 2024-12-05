using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubiculoProjecto
{
    public class RegistroCubiculoExternos
    {


        public string nombre
        {
            get;
            set;
        }

        public string apellido_paterno
        {
            get;
            set;
        }

        public string apellido_materno
        {
            get;
            set;
        }
        public string numero_cubiculo
        {
            get;
            set;
        }
        public string numero_personas
        {
            get;
            set;
        }
        public DateTime hora_entrada
        {
            get;
            set;
        }
        public DateTime hora_salida // Se actualizará posteriormente
        {
            get;
            set;
        }
        public string num_prestamo
        {
            get;
            set;
        }
    }
}
