// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using netdockermysqlexternalproject.DBContexts;

namespace netdockermysqlexternalproject.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("netdockermysqlexternalproject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Users");

                    b.HasIndex("FirstName")
                        .HasDatabaseName("Idx_FirstName");

                    b.HasIndex("LastName")
                        .HasDatabaseName("Idx_LastName");

                    b.HasIndex("UserGroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("netdockermysqlexternalproject.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_UserGroups");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("Idx_Name");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("netdockermysqlexternalproject.Models.User", b =>
                {
                    b.HasOne("netdockermysqlexternalproject.Models.UserGroup", null)
                        .WithMany()
                        .HasForeignKey("UserGroupId")
                        .HasConstraintName("FK_Users_UserGroups")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
