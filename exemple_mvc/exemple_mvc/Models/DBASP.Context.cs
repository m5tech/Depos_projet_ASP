﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exemple_mvc.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_ASP_ProjetEntities2 : DbContext
    {
        public DB_ASP_ProjetEntities2()
            : base("name=DB_ASP_ProjetEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<commande> commande { get; set; }
        public virtual DbSet<Details_Command> Details_Command { get; set; }
        public virtual DbSet<produit> produit { get; set; }
        public virtual DbSet<service> service { get; set; }
    }
}
