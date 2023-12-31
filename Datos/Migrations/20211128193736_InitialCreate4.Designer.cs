﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    [Migration("20211128193736_InitialCreate4")]
    partial class InitialCreate4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidad.Agenda", b =>
                {
                    b.Property<int>("idAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("idAgenda");

                    b.ToTable("agendas");
                });

            modelBuilder.Entity("Entidad.Cita", b =>
                {
                    b.Property<int>("idCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("diagnosticoidDiagnostico")
                        .HasColumnType("int");

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pacienteidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("psicologoidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idCita");

                    b.HasIndex("diagnosticoidDiagnostico");

                    b.HasIndex("pacienteidentificacion");

                    b.HasIndex("psicologoidentificacion");

                    b.ToTable("citas");
                });

            modelBuilder.Entity("Entidad.Diagnostico", b =>
                {
                    b.Property<int>("idDiagnostico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("psicologoidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idDiagnostico");

                    b.HasIndex("psicologoidentificacion");

                    b.ToTable("diagnosticos");
                });

            modelBuilder.Entity("Entidad.Disponibilidad", b =>
                {
                    b.Property<int>("idDisponibilidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgendaidAgenda")
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("idDisponibilidad");

                    b.HasIndex("AgendaidAgenda");

                    b.ToTable("disponibilidades");
                });

            modelBuilder.Entity("Entidad.Persona", b =>
                {
                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("usuarioidUsuario")
                        .HasColumnType("int");

                    b.HasKey("identificacion");

                    b.HasIndex("usuarioidUsuario");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Entidad.Tratamiento", b =>
                {
                    b.Property<int>("idTratamiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiagnosticoidDiagnostico")
                        .HasColumnType("int");

                    b.Property<string>("descripcionTratamiento")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("nombreTratamiento")
                        .HasColumnType("varchar(30)");

                    b.HasKey("idTratamiento");

                    b.HasIndex("DiagnosticoidDiagnostico");

                    b.ToTable("tratamientos");
                });

            modelBuilder.Entity("Entidad.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("Entidad.Paciente", b =>
                {
                    b.HasBaseType("Entidad.Persona");

                    b.Property<string>("Eps")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("Entidad.Psicologo", b =>
                {
                    b.HasBaseType("Entidad.Persona");

                    b.Property<string>("UniversidadEgreso")
                        .HasColumnType("varchar(40)");

                    b.Property<int?>("agendaPsicologoidAgenda")
                        .HasColumnType("int");

                    b.Property<string>("areaEspecializada")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("areaPsicologo")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("fechaFinalizacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mesesExperiencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("agendaPsicologoidAgenda");

                    b.HasDiscriminator().HasValue("Psicologo");
                });

            modelBuilder.Entity("Entidad.Administrador", b =>
                {
                    b.HasBaseType("Entidad.Usuario");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("Entidad.Cita", b =>
                {
                    b.HasOne("Entidad.Diagnostico", "diagnostico")
                        .WithMany()
                        .HasForeignKey("diagnosticoidDiagnostico");

                    b.HasOne("Entidad.Paciente", "paciente")
                        .WithMany("citas")
                        .HasForeignKey("pacienteidentificacion");

                    b.HasOne("Entidad.Psicologo", "psicologo")
                        .WithMany()
                        .HasForeignKey("psicologoidentificacion");

                    b.Navigation("diagnostico");

                    b.Navigation("paciente");

                    b.Navigation("psicologo");
                });

            modelBuilder.Entity("Entidad.Diagnostico", b =>
                {
                    b.HasOne("Entidad.Psicologo", "psicologo")
                        .WithMany()
                        .HasForeignKey("psicologoidentificacion");

                    b.Navigation("psicologo");
                });

            modelBuilder.Entity("Entidad.Disponibilidad", b =>
                {
                    b.HasOne("Entidad.Agenda", null)
                        .WithMany("disponibilidadesPsicologo")
                        .HasForeignKey("AgendaidAgenda");
                });

            modelBuilder.Entity("Entidad.Persona", b =>
                {
                    b.HasOne("Entidad.Usuario", "usuario")
                        .WithMany("personas")
                        .HasForeignKey("usuarioidUsuario");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Entidad.Tratamiento", b =>
                {
                    b.HasOne("Entidad.Diagnostico", null)
                        .WithMany("tramientosSeguir")
                        .HasForeignKey("DiagnosticoidDiagnostico");
                });

            modelBuilder.Entity("Entidad.Psicologo", b =>
                {
                    b.HasOne("Entidad.Agenda", "agendaPsicologo")
                        .WithMany()
                        .HasForeignKey("agendaPsicologoidAgenda");

                    b.Navigation("agendaPsicologo");
                });

            modelBuilder.Entity("Entidad.Agenda", b =>
                {
                    b.Navigation("disponibilidadesPsicologo");
                });

            modelBuilder.Entity("Entidad.Diagnostico", b =>
                {
                    b.Navigation("tramientosSeguir");
                });

            modelBuilder.Entity("Entidad.Usuario", b =>
                {
                    b.Navigation("personas");
                });

            modelBuilder.Entity("Entidad.Paciente", b =>
                {
                    b.Navigation("citas");
                });
#pragma warning restore 612, 618
        }
    }
}
