using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubiculoProyectoNuevo
{
    public class RegistroCubiculoPersonal
    {
        public string no_tarjeta { get; set; }
        public string numero_cubiculo { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_salida { get; set; } 
        public string numero_personas { get; set; }
        public string num_prestamo { get; set; }
    }

}
