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
    
    public partial class Cita
    {
        public int ID_Citas { get; set; }
        public Nullable<System.DateTime> Fecha_Cita { get; set; }
        public Nullable<int> ID_Animal { get; set; }
        public string ID_Especialista_Cedula { get; set; }
        public Nullable<int> ID_Servicio { get; set; }
        public Nullable<System.TimeSpan> Fecha_Hora { get; set; }
        public Nullable<bool> Est_Cita { get; set; }
        public string ID_Dueño_Cedula { get; set; }
    
        public virtual Animales Animales { get; set; }
        public virtual Servicios Servicios { get; set; }
    }
}
