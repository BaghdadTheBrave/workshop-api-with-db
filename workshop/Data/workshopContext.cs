using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using worksop.Models;

namespace workshop.Data
{
    public partial class workshopContext : DbContext
    {
        public workshopContext()
        {
        }

        public workshopContext(DbContextOptions<workshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Craftsman> Craftsmen { get; set; } = null!;
        public virtual DbSet<Fixing> Fixings { get; set; } = null!;
        public virtual DbSet<Fixings4> Fixings4s { get; set; } = null!;
        public virtual DbSet<Furniture> Furnitures { get; set; } = null!;
        public virtual DbSet<Lock> Locks { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<Opening> Openings { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Shape> Shapes { get; set; } = null!;
        public virtual DbSet<Sheath> Sheaths { get; set; } = null!;
        public virtual DbSet<Steel> Steels { get; set; } = null!;
        public virtual DbSet<Typess> Typesses { get; set; } = null!;
        public virtual DbSet<WorkSur> WorkSurs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-L17IMR5\\SQLEXPRESS;Initial Catalog=workshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClients)
                    .HasName("PK__Clients__8854579C5E2275E0");

                entity.Property(e => e.IdClients)
                    .ValueGeneratedNever()
                    .HasColumnName("idClients");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FlatClients)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HouseClients)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NameClients)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatronymicClients)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SettlmentClients)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("settlmentClients")
                    .IsFixedLength();

                entity.Property(e => e.StreetClients)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurnameClients)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Craftsman>(entity =>
            {
                entity.HasKey(e => e.IdCraftsmen)
                    .HasName("PK__Craftsme__C25C6784FCB01AAF");

                entity.Property(e => e.IdCraftsmen)
                    .ValueGeneratedNever()
                    .HasColumnName("idCraftsmen");

                entity.Property(e => e.ExpCraftsmen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("expCraftsmen")
                    .IsFixedLength();

                entity.Property(e => e.NameCraftsmen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameCraftsmen")
                    .IsFixedLength();

                entity.Property(e => e.PatronymicCraftsmen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("patronymicCraftsmen")
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RankCraftsmen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("rankCraftsmen")
                    .IsFixedLength();

                entity.Property(e => e.RatingCraftsmen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ratingCraftsmen")
                    .IsFixedLength();

                entity.Property(e => e.SurnameCraftsmen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Fixing>(entity =>
            {
                entity.HasKey(e => e.IdFixings)
                    .HasName("PK__fixings__4AED79047247C45A");

                entity.ToTable("fixings");

                entity.Property(e => e.IdFixings)
                    .ValueGeneratedNever()
                    .HasColumnName("idFixings");

                entity.Property(e => e.NameFixings)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameFixings")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Fixings4>(entity =>
            {
                entity.HasKey(e => e.IdFixings4s)
                    .HasName("PK__Fixings4__967BE7E6149A05D9");

                entity.Property(e => e.IdFixings4s)
                    .ValueGeneratedNever()
                    .HasColumnName("idFixings4s");

                entity.Property(e => e.NameFixings4s)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameFixings4s")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Furniture>(entity =>
            {
                entity.HasKey(e => e.IdFurnitures)
                    .HasName("PK__Furnitur__E683AF3C6FB2D3CF");

                entity.Property(e => e.IdFurnitures)
                    .ValueGeneratedNever()
                    .HasColumnName("idFurnitures");

                entity.Property(e => e.MaterialFurnitures)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("materialFurnitures")
                    .IsFixedLength();

                entity.Property(e => e.RatingFurnitures).HasColumnName("ratingFurnitures");
            });

            modelBuilder.Entity<Lock>(entity =>
            {
                entity.HasKey(e => e.IdLocks)
                    .HasName("PK__locks__019B3F3F0BA9EFB5");

                entity.ToTable("locks");

                entity.Property(e => e.IdLocks)
                    .ValueGeneratedNever()
                    .HasColumnName("idLocks");

                entity.Property(e => e.NameLocks)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameLocks")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.IdMaterials)
                    .HasName("PK__Material__D80A254655BC0958");

                entity.Property(e => e.IdMaterials)
                    .ValueGeneratedNever()
                    .HasColumnName("idMaterials");

                entity.Property(e => e.NameMaterials)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameMaterials")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Opening>(entity =>
            {
                entity.HasKey(e => e.IdOpenings)
                    .HasName("PK__openings__EA8A9A10CC4E2173");

                entity.ToTable("openings");

                entity.Property(e => e.IdOpenings)
                    .ValueGeneratedNever()
                    .HasColumnName("idOpenings");

                entity.Property(e => e.NameOpenings)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameOpenings")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrders)
                    .HasName("PK__Orders__57EB7B0D44FE48CF");

                entity.Property(e => e.IdOrders)
                    .ValueGeneratedNever()
                    .HasColumnName("idOrders");

                entity.Property(e => e.IdProductOrders).HasColumnName("idProductOrders");

                entity.Property(e => e.IdclntOrders).HasColumnName("idclntOrders");

                entity.Property(e => e.StartDateOrders)
                    .HasColumnType("date")
                    .HasColumnName("startDateOrders");

                entity.HasOne(d => d.IdProductOrdersNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdProductOrders)
                    .HasConstraintName("FK__Orders__idProduc__5DCAEF64");

                entity.HasOne(d => d.IdclntOrdersNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdclntOrders)
                    .HasConstraintName("FK__Orders__idclntOr__5CD6CB2B");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProducts)
                    .HasName("PK__Products__07F4A136DD217103");

                entity.Property(e => e.IdProducts)
                    .ValueGeneratedNever()
                    .HasColumnName("idProducts");

                entity.Property(e => e.IdCrftsmnProducts).HasColumnName("idCrftsmnProducts");

                entity.Property(e => e.IdFixingProducts).HasColumnName("idFixingProducts");

                entity.Property(e => e.IdFurnitureProducts).HasColumnName("idFurnitureProducts");

                entity.Property(e => e.IdLockProducts).HasColumnName("idLockProducts");

                entity.Property(e => e.IdOpeningProducts).HasColumnName("idOpeningProducts");

                entity.Property(e => e.IdSheathProducts).HasColumnName("idSheathProducts");

                entity.Property(e => e.IdTypeProducts).HasColumnName("idTypeProducts");

                entity.Property(e => e.IdWorkSurProducts).HasColumnName("idWorkSurProducts");

                entity.Property(e => e.LengthProducts).HasColumnName("lengthProducts");

                entity.Property(e => e.NameProducts)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameProducts")
                    .IsFixedLength();

                entity.Property(e => e.WeightProducts).HasColumnName("weightProducts");

                entity.HasOne(d => d.IdCrftsmnProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCrftsmnProducts)
                    .HasConstraintName("FK__Products__idCrft__5441852A");

                entity.HasOne(d => d.IdFixingProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdFixingProducts)
                    .HasConstraintName("FK__Products__idFixi__571DF1D5");

                entity.HasOne(d => d.IdFurnitureProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdFurnitureProducts)
                    .HasConstraintName("FK__Products__idFurn__52593CB8");

                entity.HasOne(d => d.IdLockProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdLockProducts)
                    .HasConstraintName("FK__Products__idLock__5629CD9C");

                entity.HasOne(d => d.IdOpeningProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdOpeningProducts)
                    .HasConstraintName("FK__Products__idOpen__5812160E");

                entity.HasOne(d => d.IdSheathProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdSheathProducts)
                    .HasConstraintName("FK__Products__idShea__534D60F1");

                entity.HasOne(d => d.IdTypeProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdTypeProducts)
                    .HasConstraintName("FK__Products__idType__5535A963");

                entity.HasOne(d => d.IdWorkSurProductsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdWorkSurProducts)
                    .HasConstraintName("FK__Products__idWork__5165187F");
            });

           

            modelBuilder.Entity<Shape>(entity =>
            {
                entity.HasKey(e => e.IdShapes)
                    .HasName("PK__Shapes__7ED9D83EBB77C1E5");

                entity.Property(e => e.IdShapes)
                    .ValueGeneratedNever()
                    .HasColumnName("idShapes");

                entity.Property(e => e.NameShapes)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameShapes")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sheath>(entity =>
            {
                entity.HasKey(e => e.IdSheaths)
                    .HasName("PK__Sheaths__B96CD28FB097A8D7");

                entity.Property(e => e.IdSheaths)
                    .ValueGeneratedNever()
                    .HasColumnName("idSheaths");

                entity.Property(e => e.IdFixingSheaths).HasColumnName("idFixingSheaths");

                entity.Property(e => e.IdMaterialSheaths).HasColumnName("idMaterialSheaths");

                entity.Property(e => e.WeightSheaths).HasColumnName("weightSheaths");

                entity.HasOne(d => d.IdFixingSheathsNavigation)
                    .WithMany(p => p.Sheaths)
                    .HasForeignKey(d => d.IdFixingSheaths)
                    .HasConstraintName("FK__Sheaths__idFixin__4222D4EF");

                entity.HasOne(d => d.IdMaterialSheathsNavigation)
                    .WithMany(p => p.Sheaths)
                    .HasForeignKey(d => d.IdMaterialSheaths)
                    .HasConstraintName("FK__Sheaths__idMater__4316F928");
            });

            modelBuilder.Entity<Steel>(entity =>
            {
                entity.HasKey(e => e.IdSteel)
                    .HasName("PK__Steel__983B718DD82156FA");

                entity.ToTable("Steel");

                entity.Property(e => e.IdSteel)
                    .ValueGeneratedNever()
                    .HasColumnName("idSteel");

                entity.Property(e => e.NameSteel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameSteel")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Typess>(entity =>
            {
                entity.HasKey(e => e.IdTypess)
                    .HasName("PK__Typess__E0A66F31EC64BB44");

                entity.ToTable("Typess");

                entity.Property(e => e.IdTypess)
                    .ValueGeneratedNever()
                    .HasColumnName("idTypess");

                entity.Property(e => e.NameTypess)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nameTypess")
                    .IsFixedLength();
            });

            modelBuilder.Entity<WorkSur>(entity =>
            {
                entity.HasKey(e => e.IdWorkSurs)
                    .HasName("PK__WorkSurs__46DE7F96179D6721");

                entity.Property(e => e.IdWorkSurs)
                    .ValueGeneratedNever()
                    .HasColumnName("idWorkSurs");

                entity.Property(e => e.AngleWorkSurs).HasColumnName("angleWorkSurs");

                entity.Property(e => e.IdShapeWorkSurs).HasColumnName("idShapeWorkSurs");

                entity.Property(e => e.IdSteelWorkSurs).HasColumnName("idSteelWorkSurs");

                entity.Property(e => e.LengthWorkSurs).HasColumnName("lengthWorkSurs");

                entity.Property(e => e.WeightWorkSurs).HasColumnName("weightWorkSurs");

                entity.HasOne(d => d.IdShapeWorkSursNavigation)
                    .WithMany(p => p.WorkSurs)
                    .HasForeignKey(d => d.IdShapeWorkSurs)
                    .HasConstraintName("FK__WorkSurs__idShap__3A81B327");

                entity.HasOne(d => d.IdSteelWorkSursNavigation)
                    .WithMany(p => p.WorkSurs)
                    .HasForeignKey(d => d.IdSteelWorkSurs)
                    .HasConstraintName("FK__WorkSurs__idStee__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
