// <auto-generated />
using KieuVanThang341.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KieuVanThang341.Migrations
{
    [DbContext(typeof(KieuVanThang341Context))]
    [Migration("20211006004024_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KieuVanThang341.Models.KVT341", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PersonId");

                    b.ToTable("KVT341");
                });
#pragma warning restore 612, 618
        }
    }
}
