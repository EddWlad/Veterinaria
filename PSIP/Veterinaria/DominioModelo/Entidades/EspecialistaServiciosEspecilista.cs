using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Entidades
{
    public class EspecialistaServiciosEspecilista
    {
        public string id_especialista_cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string especializacion { get; set; }
        public int estado { get; set; }
        public string servicio { get; set; }
    }
}
