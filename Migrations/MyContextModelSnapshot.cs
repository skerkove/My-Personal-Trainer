﻿// <auto-generated />
using System;
using EntityProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginReg.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EntityProject.Models.Muscle", b =>
                {
                    b.Property<int>("MuscleId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("MuscleName")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("MuscleId");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("EntityProject.Models.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.Property<int>("WorkoutId");

                    b.HasKey("PlanId");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("EntityProject.Models.Train", b =>
                {
                    b.Property<int>("TrainId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MuscleId");

                    b.Property<int>("WorkoutId");

                    b.HasKey("TrainId");

                    b.HasIndex("MuscleId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("EntityProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityProject.Models.Workout", b =>
                {
                    b.Property<int>("WorkoutId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Animation");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("MuscleId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int?>("UserId");

                    b.Property<string>("WorkoutName")
                        .IsRequired();

                    b.HasKey("WorkoutId");

                    b.HasIndex("MuscleId");

                    b.HasIndex("UserId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("EntityProject.Models.Plan", b =>
                {
                    b.HasOne("EntityProject.Models.User", "Athlete")
                        .WithMany("MyPlan")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EntityProject.Models.Workout", "WorkoutPlan")
                        .WithMany("addedWorkouts")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EntityProject.Models.Train", b =>
                {
                    b.HasOne("EntityProject.Models.Muscle", "tMuscle")
                        .WithMany("mTrains")
                        .HasForeignKey("MuscleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EntityProject.Models.Workout", "tWorkout")
                        .WithMany("wTrains")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EntityProject.Models.Workout", b =>
                {
                    b.HasOne("EntityProject.Models.Muscle", "wMuscle")
                        .WithMany("mWorkouts")
                        .HasForeignKey("MuscleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EntityProject.Models.User")
                        .WithMany("MyWorkouts")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
