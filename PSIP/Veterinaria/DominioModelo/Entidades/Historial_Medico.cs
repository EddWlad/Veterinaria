//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DominioModelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Historial_Medico
    {
        public int ID_Historial { get; set; }
        public Nullable<System.DateTime> Fecha_Historial { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public string ID_Dueño_Cedula { get; set; }
        public Nullable<int> Est_Historial { get; set; }
        public Nullable<int> ID_Animal { get; set; }
    
        public virtual Dueño Dueño { get; set; }
    }
}
