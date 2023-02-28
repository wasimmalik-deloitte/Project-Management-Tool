﻿// <auto-generated />
using AssignmentProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentProject.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230227055611_initial11156")]
    partial class initial11156
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

                    b.Property<int>("userid")
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
                    b.HasOne("AssignmentProject.Models.user", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
