﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab8
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sport_Equipment : DbContext
    {
        public Sport_Equipment()
            : base("name=Sport_Equipment")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<OwnEquipment> OwnEquipments { get; set; }
        public virtual DbSet<SportEquipment> SportEquipments { get; set; }
        public virtual DbSet<Sportsman> Sportsmen { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
    }
}
