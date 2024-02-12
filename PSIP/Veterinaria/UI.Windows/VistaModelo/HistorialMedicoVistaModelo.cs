using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class HistorialMedicoVistaModelo
    {
        public int ID_Historial { get; set; }
        public Nullable<System.DateTime> Fecha_Historial { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public string ID_Dueño_Cedula { get; set; }
        public Nullable<int> Est_Historial { get; set; }
        public Nullable<int> ID_Animal { get; set; }
    }
}
