using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_07451_Projet_Initial.DataAccess.Contexts;

/// <summary>
/// 
/// </summary>
public class ExampleContext : DbContext {

    /*
     * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE DE CONTEXTE.
     */

    public DbSet<ExampleDTO> Examples { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        /*
         * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE DE CONTEXTE.
         */

        _ = optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.\\SQL2022DEV;Database=420da3_projet_exemple;Integrated Security=true;TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        /*
         * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE DE CONTEXTE.
         */

        _ = modelBuilder.Entity<ExampleDTO>()
            .ToTable("Examples")
            .HasKey(example => example.Id);

        _ = modelBuilder.Entity<ExampleDTO>().Property(example => example.Id)
            .HasColumnOrder(0);
        _ = modelBuilder.Entity<ExampleDTO>().Property(example => example.Name)
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({ExampleDTO.NAME_MAX_LENGTH})")
            .HasColumnName("Name");
        _ = modelBuilder.Entity<ExampleDTO>().Property(example => example.Description)
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({ExampleDTO.DESCRIPTION_MAX_LENGTH})")
            .HasColumnName("Description")
            .IsRequired(false);
        _ = modelBuilder.Entity<ExampleDTO>().Property(example => example.DateCreated)
            .HasColumnOrder(3)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateCreated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<ExampleDTO>().Property(example => example.DateUpdated)
            .HasColumnOrder(4)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateUpdated")
            .HasDefaultValueSql("getdate()")
            .IsRequired(true);
        _ = modelBuilder.Entity<ExampleDTO>().Property(example => example.DateDeleted)
            .HasColumnOrder(5)
            .HasColumnType("datetime2(7)")
            .HasColumnName("DateDeleted")
            .IsRequired(false);
        _ = modelBuilder.Entity<ExampleDTO>().Property(example => example.RowVersion)
            .HasColumnOrder(6)
            .HasColumnName("Version")
            .IsRowVersion();

        /*
         * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE DE CONTEXTE.
         */

    }
}
