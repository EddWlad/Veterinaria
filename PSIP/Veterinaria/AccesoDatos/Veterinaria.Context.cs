﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using DominioModelo.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Veterinaria_FinalEntities : DbContext
    {
        public Veterinaria_FinalEntities()
            : base("name=Veterinaria_FinalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Animales> Animales { get; set; }
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Dueño> Dueño { get; set; }
        public virtual DbSet<Especialista> Especialista { get; set; }
        public virtual DbSet<Especialista_Horario> Especialista_Horario { get; set; }
        public virtual DbSet<Especie> Especie { get; set; }
        public virtual DbSet<Historial_Medico> Historial_Medico { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Raza> Raza { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public IEnumerable<object> DueñoDescripcionAnimal { get; internal set; }
    }
}
