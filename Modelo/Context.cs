using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo;

public class Context : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<Lote> Lotes { get; set; }
    public DbSet<DetalleFactura> DetalleFacturas { get; set; }
    public DbSet<DetallePresupuesto> DetallePresupuestos { get; set; }
    public DbSet<DetalleOrdenDeCompra> DetalleOrdenDeCompras { get; set; }
    public DbSet<OrdenDeCompra> OrdenDeCompras { get; set; }
    public DbSet<Presupuesto> Presupuestos { get; set; }
    public DbSet<ProductoPercedero> ProductoPercederos { get; set; }
    public DbSet<ProductoNoPercedero> ProductoNoPercederos { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Remito> Remitos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        // Definir la ruta completa del archivo SQLite en el directorio del usuario
        var dbPath = System.IO.Path.Combine(homeDirectory, "app.db");

        // Configurar SQLite con la ruta a la base de datos en el directorio del usuario
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        /// Categoria
        modelBuilder.Entity<Categoria>()
            .ToTable("Categoria")
            .HasKey(x => x.Id);

        modelBuilder.Entity<Categoria>()
            .Property(c => c.Descripcion)
            .IsRequired()
            .HasMaxLength(50);

        /// Cliente
        modelBuilder.Entity<Cliente>()
            .ToTable("Clientes") // Nombre de la tabla
            .HasKey(c => c.Cuit); // Configura la clave primaria


        modelBuilder.Entity<Cliente>()
            .Property(x => x.Cuit)
            .ValueGeneratedNever();

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Apellido)
            .IsRequired()
            .HasMaxLength(30);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Direccion)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Correo)
            .IsRequired()
            .HasMaxLength(150);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Habilitado)
            .IsRequired()
            .HasDefaultValue(true);

        /// Factura Y DetalleFactura
        modelBuilder.Entity<Factura>()
            .ToTable("Facturas")
            .HasKey(f => f.Id);

        modelBuilder.Entity<Factura>()
            .HasMany(f => f.Detalles)
            .WithOne()
            .HasForeignKey(df => df.IdFactura);

        modelBuilder.Entity<DetalleFactura>()
            .ToTable("DetallesFacturas")
            .HasKey(df => new { df.Id, df.IdFactura });


        modelBuilder.Entity<DetalleFactura>()
            .Property(df => df.IdFactura)
            .IsRequired();


        //Producto
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(30);

            entity.Property(e => e.Precio)
                .HasColumnType("float");

            entity.Property(e => e.Habilitado)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.EsPerecedero)
                .IsRequired();

            entity.HasMany(e => e.proveedores)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoProveedor",
                    j => j.HasOne<Proveedor>().WithMany().HasForeignKey("ProveedorId"),
                    j => j.HasOne<Producto>().WithMany().HasForeignKey("ProductoId"),
                    j => j.HasKey("ProveedorId", "ProductoId"));


            entity.HasMany(e => e.categorias)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoCategoria",
                    j => j.HasOne<Categoria>().WithMany().HasForeignKey("CategoriaId"),
                    j => j.HasOne<Producto>().WithMany().HasForeignKey("ProductoId"),
                    j => j.HasKey("CategoriaId", "ProductoId"));
        });

        // Mapeo para ProductoNoPercedero
        modelBuilder.Entity<ProductoNoPercedero>(entity =>
        {
            entity.Property(e => e.TipoDeEnvase)
                .HasConversion<string>();
            entity.Property(p => p.TipoDeEnvase)
                .HasColumnType("TEXT");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(x => x.Cuit);

            entity.Property(x => x.Cuit).ValueGeneratedNever();

            entity.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(30);

            entity.Property(x => x.Habilitado)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(x => x.RazonSocial)
                .IsRequired()
                .HasMaxLength(60);

            entity.Property(x => x.Direccion)
                .IsRequired()
                .HasMaxLength(60);
        });

        modelBuilder.Entity<DetalleOrdenDeCompra>()
            .HasKey(df => new { df.Id, df.IdOrdenDeCompra });

        modelBuilder.Entity<OrdenDeCompra>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<OrdenDeCompra>()
            .HasMany(x => x.detalles)
            .WithOne()
            .HasForeignKey(x => x.IdOrdenDeCompra);

        modelBuilder.Entity<DetallePresupuesto>()
            .HasKey(df => new { df.Id, df.IdPresupuesto });

        modelBuilder.Entity<Presupuesto>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<Presupuesto>()
            .HasMany(x => x.detalles)
            .WithOne()
            .HasForeignKey(x => x.IdPresupuesto);

        modelBuilder.Entity<Lote>()
            .HasKey(df => new { df.Id, df.IdRemito });

        modelBuilder.Entity<Remito>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<Remito>()
            .HasMany(x => x.Lotes)
            .WithOne()
            .HasForeignKey(x => x.IdRemito);

        
    }
}

