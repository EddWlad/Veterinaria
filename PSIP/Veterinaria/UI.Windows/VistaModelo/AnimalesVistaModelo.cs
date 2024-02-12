using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class AnimalesVistaModelo
    {
        public int ID_Animal { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public Nullable<int> ID_Especie { get; set; }
        public Nullable<int> ID_Raza { get; set; }
        public Nullable<int> ID_Sexo { get; set; }
        public string ID_Dueño_Cedula { get; set; }
        public Nullable<int> Est_Animal { get; set; }
    }
}
