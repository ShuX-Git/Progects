// <auto-generated />
using HospitalPetRegist.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalPetRegist.Migrations
{
    [DbContext(typeof(HospitalAPIContext))]
    [Migration("20220109123619_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalPetRegist.Models.HospitalAPI", b =>
                {
                    b.Property<int>("NumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("OwnersLastname")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("OwnersName")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("PetsName")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Services")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("NumberId");

                    b.ToTable("HospitalAPIs");
                });
#pragma warning restore 612, 618
        }
    }
}
