using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_07451_Projet_Initial.DataAccess.Contexts;

public class AppDbContext : AbstractContext {

    public DbSet<DTOs.FournisseursDTO> Fournisseurs { get; set; }
    public DbSet<DTOs.ProduitsDTO> Produits { get; set; }
    public DbSet<ShippingOrderProducts> ShippingOrderProducts { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }
    public DbSet<DTOs.UserDTO> Users { get; set; }
    public DbSet<DTOs.RoleDTO> Roles { get; set; }
    public DbSet<AddressDTO> Addresses { get; set; }
    public DbSet<RestockOrderDTO> RestockOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.\\SQL2022DEV;Database=420da3_07451_projet_initial;Integrated Security=true;TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        #region Addresses

        _ = modelBuilder.Entity<AddressDTO>()
            .ToTable("Addresses")
            .HasKey(addr => addr.Id);

        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.Id)
            .HasColumnName("Id")
            .HasColumnType("int");
        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.CivicNumber)
            .HasColumnName("CivicNumber")
            .HasColumnType("int");
        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.Street)
            .HasColumnName("Street")
            .HasColumnType($"nvarchar({AddressDTO.STREET_MAX_LENGTH})");
        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.City)
            .HasColumnName("City")
            .HasColumnType($"nvarchar({AddressDTO.CITY_MAX_LENGTH})");
        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.Province)
            .HasColumnName("Province")
            .HasColumnType($"nvarchar({AddressDTO.PROVINCE_MAX_LENGTH})");
        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.Country)
            .HasColumnName("Country")
            .HasColumnType($"nvarchar({AddressDTO.COUNTRY_MAX_LENGTH})");
        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.PostalCode)
            .HasColumnName("PostalCode")
            .HasColumnType($"nvarchar({AddressDTO.POSTALCODE_MAX_LENGTH})");
        _ = modelBuilder.Entity<AddressDTO>().Property(addr => addr.Rowversion)
            .HasColumnName("Version")
            .IsRowVersion();


        #endregion
        
        #region Restock Orders

        _ = modelBuilder.Entity<RestockOrderDTO>()
            .ToTable("RestockOrders")
            .HasKey(ro => ro.Id);

        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.Id)
            .HasColumnName("Id")
            .HasColumnType("int");
        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.Status)
            .HasColumnName("Status")
            .HasColumnType("nvarchar(16)")
            .HasConversion<string>();
        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.DestinationWarehouseId)
            .HasColumnName("DestinationWarehouse")
            .HasColumnType("int");
        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.ProduitId)
            .HasColumnName("ProduitId")
            .HasColumnType("int");
        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.Quantity)
            .HasColumnName("Quantity")
            .HasColumnType("int");
        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.CreationDate)
            .HasColumnName("CreationDate")
            .HasColumnType("datetime2(7)")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd();
        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.CompletionDate)
            .HasColumnName("CompletionDate")
            .HasColumnType("datetime2(7)")
            .HasPrecision(7)
            .IsRequired(false);
        _ = modelBuilder.Entity<RestockOrderDTO>().Property(ro => ro.Rowversion)
            .HasColumnName("Version")
            .IsRowVersion();

        // Restock Order Relations
        _ = modelBuilder.Entity<RestockOrderDTO>()
            .HasOne(ro => ro.DestinationWarehouse)
            .WithMany(wh => wh.RestockOrders)
            .HasForeignKey(ro => ro.DestinationWarehouseId);

        _ = modelBuilder.Entity<RestockOrderDTO>()
            .HasOne(ro => ro.Produit)
            .WithMany(produit => produit.RestockOrders)
            .HasForeignKey(ro => ro.ProduitId);


        #endregion
        
        #region Fournisseurs
        _ = modelBuilder.Entity<FournisseursDTO>()
            .ToTable("Fournisseurs")
            .HasKey(fournisseurs => fournisseurs.Id);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.Id)
            .HasColumnOrder(0);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.NomFournisseur)
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({FournisseursDTO.NOMFOURNISSEUR_MAX_LENGTH})")
            .HasColumnName("Nom Fournisseur");
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.AddresseId)
            .HasColumnOrder(2)
            .HasColumnType($"int")
            .HasColumnName("Addresse Fournisseur");
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.NomResponsable)
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({FournisseursDTO.NOMRESPONSABLE_MAX_LENGTH})")
            .HasColumnName("Nom Responsable");
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.PrenomResponsable)
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({FournisseursDTO.PRENOMRESPONSABLE_MAX_LENGTH})")
            .HasColumnName("Prenom Responsable");
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.CourrielResponsable)
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({FournisseursDTO.COURRIELRESPONSABLE_MIN_LENGTH})")
            .HasColumnName("Courriel Responsable");
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.TelephoneResponsable)
            .HasColumnOrder(6)
            .HasColumnType($"nvarchar(10)")
            .HasColumnName("Telephone Responsable");
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.DateCreated)
            .HasColumnOrder(7)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateCreated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.DateUpdated)
            .HasColumnOrder(8)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateUpdated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.DateDeleted)
            .HasColumnOrder(9)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateDeleted")
            .IsRequired(false);
        _ = modelBuilder.Entity<FournisseursDTO>().Property(fournisseurs => fournisseurs.RowVersion)
            .HasColumnOrder(10)
            .HasColumnName("Version")
            .IsRowVersion();

        _ = modelBuilder.Entity<FournisseursDTO>()
            .HasMany(supplier => supplier.Produits)
            .WithOne(produit => produit.FournisseurProduit)
            .HasForeignKey(produit => produit.FournisseurId);

        _ = modelBuilder.Entity<FournisseursDTO>()
            .HasData(new FournisseursDTO("TestNomFournisseurs", "TestDescription","TestPrenomResponsable","TestCourrielResponsable","TestTelephone") { Id = 1 });
        
        #endregion

        #region Produits
        
        _ = modelBuilder.Entity<ProduitsDTO>()
            .ToTable("Produits")
            .HasKey(produits => produits.Id);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.Id)
            .HasColumnOrder(0);
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.NomProduit)
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({ProduitsDTO.NOM_MAX_LENGTH})")
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
        _ = modelBuilder.Entity<ProduitsDTO>().Property(produits => produits.ProduitUpc)
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

        
        
        #endregion

        #region Association ShippingOrder - Product


        _ = modelBuilder.Entity<DTOs.PivotsDTO.ShippingOrderProducts>()
            .HasKey(sp => new { sp.ShippingOrderId, sp.ProduitId });
         
        _ = modelBuilder.Entity<DTOs.PivotsDTO.ShippingOrderProducts>()
            .HasOne(sp => sp.ShippingOrder)
            .WithMany(so => so.ShippingOrderProducts)
            .HasForeignKey(sp => sp.ShippingOrderId);
        
        _ = modelBuilder.Entity<DTOs.PivotsDTO.ShippingOrderProducts>()
            .HasOne(sp => sp.Produit)
            .WithMany(p => p.ShippingOrderProducts)
            .HasForeignKey(sp => sp.ProduitId);

        #endregion

        #region Association User - Role

        _ = modelBuilder.Entity<UserRoles>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });
        _ = modelBuilder.Entity<UserRoles>()
            .HasOne(ur => ur.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserId);
        _ = modelBuilder.Entity<UserRoles>()
            .HasOne(ur => ur.Role)
            .WithMany(r => r.UserRoles)
            .HasForeignKey(ur => ur.RoleId);

        #endregion

        #region Users

        _ = modelBuilder.Entity<UserDTO>()
            .ToTable("Users")
            .HasKey(users => users.Id);

        _ = modelBuilder.Entity<UserDTO>()
            .HasIndex(users => users.UserName)
            .IsUnique(true);

        _ = modelBuilder.Entity<UserDTO>().Property(users => users.Id)
            .HasColumnType("int")
            .HasColumnName("UserId");
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.UserName)
            .HasColumnType($"nvarchar(32)")
            .HasColumnName("Username");
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.Password)
            .HasColumnType($"nvarchar(128)")
            .HasColumnName("Password");
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.DateCreation)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateCreation")
            .HasDefaultValueSql("getdate()");
        _ = modelBuilder.Entity<UserDTO>().Property(users => users.RowVersion)
            .HasColumnName("Version")
            .IsRowVersion();

        #endregion

        #region Roles

        _ = modelBuilder.Entity<RoleDTO>()
            .ToTable("Roles")
            .HasKey(roles => roles.Id);

        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.Id)
            .HasColumnType($"int")
            .HasColumnName("RoleId");
        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.RoleName)
            .HasColumnType($"nvarchar(128)")
            .HasColumnName("RoleName");
        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.RoleDescription)
            .HasColumnType($"nvarchar(256)")
            .HasColumnName("RoleDescription")
            .IsRequired(true);
        _ = modelBuilder.Entity<RoleDTO>().Property(roles => roles.RowVersion)
            .HasColumnName("Version")
            .IsRowVersion();

        #endregion


        #region Clients

        _ = modelBuilder.Entity<ClientDTO>()
            .ToTable("Clients")
            .HasKey(client => client.Id);

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.Id)
            .HasColumnType("int")
            .HasColumnName("Id");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.NomClient)
            .HasColumnType($"nvarchar({ClientDTO.CLIENT_NAME_MAX_LENGTH})")
            .HasColumnName("NomClient");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.AddressId)
            .HasColumnType("int")
            .HasColumnName("AddressId");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.WarehouseId)
            .HasColumnType("int")
            .HasColumnName("WarehouseId");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.NomPersonneContact)
            .HasColumnType($"nvarchar({ClientDTO.CONTACT_NOM_MAX_LENGTH})")
            .HasColumnName("NomContact");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.PrenomPersonneContact)
            .HasColumnType($"nvarchar({ClientDTO.CONTACT_PRENOM_MAX_LENGTH})")
            .HasColumnName("PrenomContact");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.CourrielPersonneContact)
            .HasColumnType($"nvarchar({ClientDTO.CONTACT_COURRIEL_MAX_LENGTH})")
            .HasColumnName("CourrielContact");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.TelephonePersonneContact)
            .HasColumnType($"nvarchar({ClientDTO.CONTACT_TELEPHONE_MAX_LENGTH})")
            .HasColumnName("TelephoneContact");

        _ = modelBuilder.Entity<ClientDTO>()
            .Property(client => client.Version)
            .IsRowVersion();

        // relations

        _ = modelBuilder.Entity<ClientDTO>()
            .HasOne(client => client.AssignedWarehouse)
            .WithMany(wh => wh.Clients)
            .HasForeignKey(client => client.WarehouseId);

        _ = modelBuilder.Entity<ClientDTO>()
            .HasOne(client => client.ClientAddress)
            .WithOne(addr => addr.ClientAssocie)
            .HasForeignKey<ClientDTO>(client => client.AddressId);


        _ = modelBuilder.Entity<ClientDTO>()
            .HasMany(client => client.ProduitsDuClient)
            .WithOne(produit => produit.ClientProprietaireProduit)
            .HasForeignKey(produit => produit.ClientId);

        #endregion


        #region Entrepot

        _ = modelBuilder.Entity<EntrepotDTO>()
            .ToTable("Entrepots")
            .HasKey(wh => wh.Id);

        _ = modelBuilder.Entity<EntrepotDTO>()
            .Property(wh => wh.Id)
            .HasColumnType("int")
            .HasColumnName("Id");

        _ = modelBuilder.Entity<EntrepotDTO>()
            .Property(wh => wh.NomEntrepot)
            .HasColumnType($"nvarchar({EntrepotDTO.NOM_ENTREPOT_MAX_LENGTH})")
            .HasColumnName("NomEntrepot");

        _ = modelBuilder.Entity<EntrepotDTO>()
            .Property(wh => wh.AddressId)
            .HasColumnType("int")
            .HasColumnName("AddressId");

        // relations


        _ = modelBuilder.Entity<EntrepotDTO>().HasOne(wh => wh.Address).WithOne(addr => addr.WarehouseAssociee);

        #endregion

    }
}
