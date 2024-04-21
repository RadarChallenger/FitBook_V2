﻿// <auto-generated />
using System;
using FitBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FitBook.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FitBook.Models.Exercise", b =>
                {
                    b.Property<Guid>("ExerciseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ExerciseID");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitBook.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitBook.Models.Workout", b =>
                {
                    b.Property<Guid>("WorkoutID")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Endtime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("WorkoutID");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("FitBook.Models.WorkoutExercise", b =>
                {
                    b.Property<Guid>("WorkoutExerciseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ExerciseID")
                        .HasColumnType("uuid");

                    b.Property<int>("Repetition")
                        .HasColumnType("integer");

                    b.Property<int>("Sets")
                        .HasColumnType("integer");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.Property<Guid>("WorkoutID")
                        .HasColumnType("uuid");

                    b.HasKey("WorkoutExerciseID");

                    b.HasIndex("ExerciseID");

                    b.HasIndex("WorkoutID");

                    b.ToTable("WorkoutExercises");
                });

            modelBuilder.Entity("FitBook.Models.Workout", b =>
                {
                    b.HasOne("FitBook.Models.User", "User")
                        .WithMany("Workouts")
                        .HasForeignKey("WorkoutID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitBook.Models.WorkoutExercise", b =>
                {
                    b.HasOne("FitBook.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitBook.Models.Workout", null)
                        .WithMany()
                        .HasForeignKey("WorkoutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitBook.Models.User", b =>
                {
                    b.Navigation("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
