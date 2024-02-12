using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class EspecialistaVistaModelo
    {
        public string ID_Especialista_Cedula { get; set; }
        public string Nombre_Espe { get; set; }
        public string Apellido_Espe { get; set; }
        public string Telefono_Espe { get; set; }
        public string Email_Espe { get; set; }
        public string Especialización_Espe { get; set; }
        public Nullable<int> Est_Espe { get; set; }
        public Nullable<int> ID_Servicio { get; set; }
    }
    public class EspecialistaCBVistaModelo
    {
        public String ID_Especialista_Cedula { get; set; }
        public string Nombre_Espe { get; set; }
    }
}
