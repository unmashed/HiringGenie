﻿// <auto-generated />
using System;
using HiringGenie.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HiringGenie.Api.Migrations
{
    [DbContext(typeof(HiringGenieDbContext))]
    [Migration("20200218193259_base_entities")]
    partial class base_entities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("HiringGenie.Api.Entities.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Email");

                    b.Property<string>("FileType");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsInviteSent");

                    b.Property<Guid>("JobId");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("PostedBy");

                    b.Property<string>("ResumePath");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("PostedBy");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.Interview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlternateCareerNotes");

                    b.Property<Guid>("ApplicationId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("InterviewerId");

                    b.Property<bool>("IsInterviewScheduled");

                    b.Property<bool>("IsRejected");

                    b.Property<bool>("IsSelected");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Notes");

                    b.Property<int>("RoundNo");

                    b.Property<Guid>("SchedulerId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("InterviewerId");

                    b.HasIndex("SchedulerId")
                        .IsUnique();

                    b.ToTable("Interview");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("DueDate");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<int>("Positions");

                    b.Property<string>("PostedBy");

                    b.Property<string>("SkillsRequired");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PostedBy");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.Scheduler", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsAcceptedMailSent");

                    b.Property<bool>("IsSlotAccepted");

                    b.Property<bool>("IsSlotMailSent");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<DateTime>("ScheduledAt");

                    b.HasKey("Id");

                    b.ToTable("Scheduler");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.Application", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.Job", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HiringGenie.Api.Entities.ApplicationUser", "PostedByUser")
                        .WithMany("PostedApplications")
                        .HasForeignKey("PostedBy");
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.ApplicationUserRole", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HiringGenie.Api.Entities.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.Interview", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.Application", "Application")
                        .WithMany("Interviews")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HiringGenie.Api.Entities.ApplicationUser", "Interviewer")
                        .WithMany("Interviews")
                        .HasForeignKey("InterviewerId");

                    b.HasOne("HiringGenie.Api.Entities.Scheduler", "CurrentScheduler")
                        .WithOne("Interview")
                        .HasForeignKey("HiringGenie.Api.Entities.Interview", "SchedulerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiringGenie.Api.Entities.Job", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.ApplicationUser", "PostedByUser")
                        .WithMany("PostedJobs")
                        .HasForeignKey("PostedBy");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HiringGenie.Api.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}