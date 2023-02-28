﻿// <auto-generated />
using System;
using AssignmentProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentProject.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230227093642_initial996")]
    partial class initial996
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AssignmentProject.Models.project", b =>
                {
                    b.Property<int>("projectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("projectDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("projectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("projectid");

                    b.HasIndex("userid");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("AssignmentProject.Models.user", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("userid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AssignmentProject.Models.project", b =>
                {
                    b.HasOne("AssignmentProject.Models.user", null)
                        .WithMany("project")
                        .HasForeignKey("userid");
                });

            modelBuilder.Entity("AssignmentProject.Models.user", b =>
                {
                    b.Navigation("project");
                });
#pragma warning restore 612, 618
        }
    }
}
