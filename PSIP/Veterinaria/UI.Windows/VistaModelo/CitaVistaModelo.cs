using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class CitaVistaModelo
    {
        public int ID_Citas { get; set; }
        public Nullable<System.DateTime> Fecha_Cita { get; set; }
        public Nullable<int> ID_Animal { get; set; }
        public string ID_Especialista_Cedula { get; set; }
        public Nullable<int> ID_Servicio { get; set; }
        public Nullable<System.TimeSpan> Fecha_Hora { get; set; }
        public int Est_Cita { get; set; }
        public string ID_Dueño_Cedula { get; set; }
    }
}
