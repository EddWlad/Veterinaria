using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Entidades
{
    public class HistorialMascotaDueño
    {
        public int id_Historial { get; set; }
        public string nombre_dueño { get; set; }
        public string nombre_mascota { get; set; }
        public DateTime fecha { get; set; }
        public string diagnostico { get; set; }
        public string tratamiento { get; set; }
        public string observacion { get; set; }
        public int est_Historial { get; set; }
    }
}
