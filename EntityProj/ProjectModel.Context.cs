﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProj
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Window_ProjectContext : DbContext
    {
        public Window_ProjectContext()
            : base("name=Window_ProjectContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Cancel_Info> Cancel_Info { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ShippingInfo> ShippingInfoes { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<Voucher_Account> Voucher_Account { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Recommend> Recommends { get; set; }
    }
}
