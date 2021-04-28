﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Hospital;

namespace unq_iisoft_2021_c1_hospitalWebSite.Migrations
{
    [DbContext(typeof(SanatorioContext))]
    partial class SanatorioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Models.Hospital.Usuario", b =>
                {
                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ObraSocial")
                        .HasColumnType("TEXT");

                    b.HasKey("Mail");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
