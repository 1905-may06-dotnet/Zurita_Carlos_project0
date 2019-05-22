using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaBox.Data.model
{
    public partial class PizzaContext : DbContext
    {
        public PizzaContext()
        {
        }

        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizzas> Pizzas { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<Toppings> Toppings { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=czdatabase.database.windows.net;Database=Project0;user id=carlos;Password=4ZUR3&P455;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.Locationid)
                    .HasName("PK__Location__306F78A69750055E");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Street1)
                    .IsRequired()
                    .HasColumnName("street1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Street2)
                    .HasColumnName("street2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Locations__useri__60A75C0F");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__Orders__080E37750C7EB8FB");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Ocustomerid).HasColumnName("ocustomerid");

                entity.Property(e => e.Opizzaid).HasColumnName("opizzaid");

                entity.Property(e => e.Otimeid).HasColumnName("otimeid");

                entity.HasOne(d => d.Ocustomer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Ocustomerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__ocustome__693CA210");

                entity.HasOne(d => d.Opizza)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Opizzaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__opizzaid__6B24EA82");

                entity.HasOne(d => d.Otime)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Otimeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__otimeid__6A30C649");
            });

            modelBuilder.Entity<Pizzas>(entity =>
            {
                entity.HasKey(e => e.Pizzaid)
                    .HasName("PK__Pizzas__4D4B9487AD58839E");

                entity.Property(e => e.Pizzaid)
                    .HasColumnName("pizzaid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Crust)
                    .IsRequired()
                    .HasColumnName("crust")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ptoppiongid).HasColumnName("ptoppiongid");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasColumnName("size")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ptoppiong)
                    .WithMany(p => p.Pizzas)
                    .HasForeignKey(d => d.Ptoppiongid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizzas__ptoppion__6383C8BA");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.Property(e => e.Timeid)
                    .HasColumnName("timeid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Toppings>(entity =>
            {
                entity.HasKey(e => e.Toppingid)
                    .HasName("PK__Toppings__AAE65AF139980D08");

                entity.Property(e => e.Toppingid)
                    .HasColumnName("toppingid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Topping)
                    .HasColumnName("topping")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Customerid)
                    .HasName("PK__Users__B61ED7F5E13B075D");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ulocationid).HasColumnName("ulocationid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
