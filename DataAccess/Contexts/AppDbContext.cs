﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_07451_Projet_Initial.DataAccess.Contexts;

public class AppDbContext : AbstractContext {
    #region Fournisseurs
    public DbSet<DTOs.FournisseursDTO> Fournisseurs { get; set; }
    public DbSet<DTOs.ProduitsDTO> Produits { get; set; }
    public DbSet<DTOs.Pivots.ShippingOrderProducts> ShippingOrderProducts { get; set; }
    public DbSet<DTOs.UserDTO> Users { get; set; }
    public DbSet<DTOs.RoleDTO> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.\\SQL2022DEV;Database=420da3_07451_projet_initial;Integrated Security=true;TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

    #region Fournisseurs
        _ = modelBuilder.Entity<FournisseursDTO>()
            .ToTable("Fournisseurs")
            .HasKey(fournisseurs => fournisseurs.Id);

        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.Id)
            .HasColumnOrder(0);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.NomFournisseur)
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({FournisseursDTO.NAME_MAX_LENGTH})")
            .HasColumnName("Name");
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.Description)
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({FournisseursDTO.DESCRIPTION_MAX_LENGTH})")
            .HasColumnName("Description")
            .IsRequired(false);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.DateCreated)
            .HasColumnOrder(3)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateCreated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.DateUpdated)
            .HasColumnOrder(4)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateUpdated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.DateDeleted)
            .HasColumnOrder(5)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateDeleted")
            .IsRequired(false);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.RowVersion)
            .HasColumnOrder(6)
            .HasColumnName("Version")
            .IsRowVersion();

        _ = modelBuilder.Entity<FournisseursDTO>().HasData(new FournisseursDTO("TestNomFournisseurs", "TestDescription","TestPrenomResponsable","TestCourrielResponsable","TestTelephone") { Id = 1 });
        
    #endregion

    #region Produits
        
        _ = modelBuilder.Entity<ProduitsDTO>()
            .ToTable("Produits")
            .HasKey(produits => produits.Id);

        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.Id)
            .HasColumnOrder(0);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.NomProduit)
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({ProduitsDTO.NAME_MAX_LENGTH})")
            .HasColumnName("Name");
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.Description)
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({ProduitsDTO.DESCRIPTION_MAX_LENGTH})")
            .HasColumnName("Description")
            .IsRequired(false);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.DateCreated)
            .HasColumnOrder(3)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateCreated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.DateUpdated)
            .HasColumnOrder(4)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateUpdated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.DateDeleted)
            .HasColumnOrder(5)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateDeleted")
            .IsRequired(false);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.RowVersion)
            .HasColumnOrder(6)
            .HasColumnName("Version")
            .IsRowVersion();
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.Upc)
            .HasColumnOrder(7)
            .HasColumnName("Upc")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.ClientId)
            .HasColumnOrder(8)
            .HasColumnName("ClientId")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.FournisseurId)
            .HasColumnOrder(9)
            .HasColumnName("FournisseurId")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.CodeFournisseur)
            .HasColumnOrder(10)
            .HasColumnName("CodeFournisseur")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.UnitesEnStock)
            .HasColumnOrder(11)
            .HasColumnName("UnitesEnStock")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.NiveauDeReappro)
            .HasColumnOrder(12)
            .HasColumnName("NiveauDeReappro")
            .IsRequired(true);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.PoidsKilo)
            .HasColumnOrder(13)
            .HasColumnName("PoidsKilo")
            .IsRequired(true);
        
        _ = modelBuilder.Entity<ProduitsDTO>().HasData(new ProduitsDTO("TestNomProduit", "TestDescription") { Id = 1 });

    #endregion

    #region Association ShippingOrder - Product
        
        
        _ = modelBuilder.Entity<DTOs.Pivots.ShippingOrderProducts>()
            .ShippingOrderProducts(sop => new { sop.ShippingOrderId, sop.ProductId });
         
        _ = modelBuilder.Entity<DTOs.Pivots.ShippingOrderProducts>()
            .HasOne(sop => sop.ShippingOrder)
            .WithMany(so => so.Products)
            .HasForeignKey(sop => sop.ShippingOrderId);
        
        _ = modelBuilder.Entity<DTOs.Pivots.ShippingOrderProducts>()
            .HasOne(sop => sop.Product)
            .WithMany(p => p.ShippingOrders)
            .HasForeignKey(sop => sop.ProductId);
        #endregion

    #region Users
        _ = modelBuilder.Entity<UserDTO>()
            .ToTable("Users")
            .HasKey(users => users.UserId);

        _ = modelBuilder.Entity<UserDTO>().Property(users => users.UserId)
            .HasColumnOrder(0);
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.UserName)
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({UserDTO.NAME_MAX_LENGTH})")
            .HasColumnName("Name");
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.Password)
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({UserDTO.NAME_MAX_LENGTH})")
            .HasColumnName("PasswordHash")
            .IsRequired(true);
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.RoleId)
            .HasColumnOrder(3)
            .HasColumnName("RoleId")
            .IsRequired(true);
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.DateCreation)
            .HasColumnOrder(4)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateCreation")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.RowVersion)
            .HasColumnOrder(5)
            .HasColumnName("Version")
            .IsRowVersion();
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.Warehouse)
            .HasColumnOrder(6)
            .HasColumnName("Warehouse")
            .IsRequired(true);
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.Id)
            .HasColumnOrder(7)
            .HasColumnName("WarehouseId")
            .IsRequired(true);
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.DateUpdated)
            .HasColumnOrder(8)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateUpdated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.DateDeleted)
            .HasColumnOrder(9)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateDeleted")
            .IsRequired(false);
       
        _ = modelBuilder.Entity<UserDTO>().HasData(new UserDTO("TestUsername", "TestPassword", "TestRoleId", "TestWarehouse", "TestWarehouseId") { Id = 1 });
        #endregion

    #region Roles
        _ = modelBuilder.Entity<RoleDTO>()
            .ToTable("Roles")
            .HasKey(roles => roles.RoleId);

        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.UserId)
            .HasColumnOrder(0);
        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.RoleName)
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({RoleDTO.NAME_MAX_LENGTH})")
            .HasColumnName("RoleName");
        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.RoleDescription)
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({RoleDTO.NAME_MAX_LENGTH})")
            .HasColumnName("RoleDescription")
            .IsRequired(true);
        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.UserId)
            .HasColumnOrder(3)
            .HasColumnName("UserId")
            .IsRequired(true);
        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.RowVersion)
            .HasColumnOrder(4)
            .HasColumnName("Version")
            .IsRowVersion();

        _ = modelBuilder.Entity<RoleDTO>().HasData(new RoleDTO("TestRoleName", "TestRoleDescription") { Id = 1 });
        #endregion
    }
}
