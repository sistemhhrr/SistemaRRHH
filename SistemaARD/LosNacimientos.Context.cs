﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaARD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Afps> Afps { get; set; }
        public virtual DbSet<Aguinaldos> Aguinaldos { get; set; }
        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<CargosEmpleados> CargosEmpleados { get; set; }
        public virtual DbSet<CategoriasIndemnizaciones> CategoriasIndemnizaciones { get; set; }
        public virtual DbSet<CategoriasPlanillas> CategoriasPlanillas { get; set; }
        public virtual DbSet<CorreosEmpleados> CorreosEmpleados { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Indemnizaciones> Indemnizaciones { get; set; }
        public virtual DbSet<PlanillasProduccion> PlanillasProduccion { get; set; }
        public virtual DbSet<PlanillasVentas> PlanillasVentas { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TelefonosEmpleados> TelefonosEmpleados { get; set; }
        public virtual DbSet<TiposTelefonos> TiposTelefonos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Planillas_Jefes> Planillas_Jefes { get; set; }
    }
}
