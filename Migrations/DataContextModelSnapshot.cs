﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAgil.API.Data;

namespace ProAgil.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ProAgil.API.Model.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataEvento");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Local");

                    b.Property<string>("Lote");

                    b.Property<int>("QtdPessoa");

                    b.Property<string>("Tema");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
