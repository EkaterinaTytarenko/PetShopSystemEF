﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimalsClassLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnimalsEntities : DbContext
    {
        public AnimalsEntities()
            : base("name=AnimalsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Cage> Cage { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Food1> Food1 { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<SpeciesFood> SpeciesFood { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
