// <auto-generated />
using System;
using C_Infrustructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C_Infrustructure.Migrations
{
    [DbContext(typeof(TelefonRehberiDbContext))]
    [Migration("20221218074603_abc")]
    partial class abc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A_Domain.Entity.Grup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 10L, 1);

                    b.Property<string>("GrupAdı")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("ID"));

                    b.ToTable("Grup");
                });

            modelBuilder.Entity("A_Domain.Entity.İletişimNumarası", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 10L, 1);

                    b.Property<int>("KisiID")
                        .HasColumnType("int");

                    b.Property<int>("Numara")
                        .HasColumnType("int");

                    b.Property<int>("TürID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KisiID");

                    b.HasIndex("TürID");

                    b.ToTable("İletişimNumarası");
                });

            modelBuilder.Entity("A_Domain.Entity.İletişimTür", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 10L, 1);

                    b.Property<string>("iletişimNoTür")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("İletişimNumarasıID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("ID"));

                    b.ToTable("İletişimTürü");
                });

            modelBuilder.Entity("A_Domain.Entity.Kisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 10L, 1);

                    b.Property<string>("Adres")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Açıklama")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DoğumTarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 18, 10, 46, 3, 9, DateTimeKind.Local).AddTicks(6791));

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.ToTable("Kişiler");
                });

            modelBuilder.Entity("A_Domain.Entity.KisiGruplari", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 10L, 1);

                    b.Property<int>("GrupID")
                        .HasColumnType("int");

                    b.Property<int>("KisiID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GrupID");

                    b.HasIndex("KisiID");

                    b.ToTable("KisiGrupları");
                });

            modelBuilder.Entity("A_Domain.Entity.Mail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 10L, 1);

                    b.Property<int>("KisiID")
                        .HasColumnType("int");

                    b.Property<string>("MailAdresi")
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.HasKey("ID");

                    b.HasIndex("KisiID");

                    b.ToTable("Mailler");
                });

            modelBuilder.Entity("A_Domain.Entity.İletişimNumarası", b =>
                {
                    b.HasOne("A_Domain.Entity.Kisi", "Kisi")
                        .WithMany("IletisimNumaralari")
                        .HasForeignKey("KisiID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_Domain.Entity.İletişimTür", "Türü")
                        .WithMany("iletişimNumaralarin")
                        .HasForeignKey("TürID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Kisi");

                    b.Navigation("Türü");
                });

            modelBuilder.Entity("A_Domain.Entity.KisiGruplari", b =>
                {
                    b.HasOne("A_Domain.Entity.Grup", "Grup")
                        .WithMany("KisiGruplari")
                        .HasForeignKey("GrupID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_Domain.Entity.Kisi", "Kisi")
                        .WithMany("KisiGruplari")
                        .HasForeignKey("KisiID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Grup");

                    b.Navigation("Kisi");
                });

            modelBuilder.Entity("A_Domain.Entity.Mail", b =>
                {
                    b.HasOne("A_Domain.Entity.Kisi", "Kisi")
                        .WithMany("Mailler")
                        .HasForeignKey("KisiID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Kisi");
                });

            modelBuilder.Entity("A_Domain.Entity.Grup", b =>
                {
                    b.Navigation("KisiGruplari");
                });

            modelBuilder.Entity("A_Domain.Entity.İletişimTür", b =>
                {
                    b.Navigation("iletişimNumaralarin");
                });

            modelBuilder.Entity("A_Domain.Entity.Kisi", b =>
                {
                    b.Navigation("IletisimNumaralari");

                    b.Navigation("KisiGruplari");

                    b.Navigation("Mailler");
                });
#pragma warning restore 612, 618
        }
    }
}
