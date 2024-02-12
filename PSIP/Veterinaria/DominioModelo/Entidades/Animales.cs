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
    
    public partial class Animales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Animales()
        {
            this.Cita = new HashSet<Cita>();
        }
    
        public int ID_Animal { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public Nullable<int> ID_Especie { get; set; }
        public Nullable<int> ID_Raza { get; set; }
        public Nullable<int> ID_Sexo { get; set; }
        public string ID_Dueño_Cedula { get; set; }
        public Nullable<int> Est_Animal { get; set; }
    
        public virtual Dueño Dueño { get; set; }
        public virtual Especie Especie { get; set; }
        public virtual Raza Raza { get; set; }
        public virtual Sexo Sexo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Cita { get; set; }
    }
}