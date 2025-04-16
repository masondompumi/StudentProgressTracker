﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentProgressTracker.Data;

#nullable disable

namespace StudentProgressTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250416190207_FixEnrollmentSeed")]
    partial class FixEnrollmentSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Viewer",
                            NormalizedName = "VIEWER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "user-1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "user-2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "user-3",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "user-4",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "user-5",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StudentProgressTracker.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AverageToDate")
                        .HasColumnType("real");

                    b.Property<DateTime>("EnrolmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QualificationType")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageToDate = 72.5f,
                            EnrolmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 1A",
                            Qualification = "Degree A1",
                            QualificationType = 1,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            AverageToDate = 81.3f,
                            EnrolmentDate = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 1B",
                            Qualification = "Degree B1",
                            QualificationType = 2,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 3,
                            AverageToDate = 72.5f,
                            EnrolmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 2A",
                            Qualification = "Degree A2",
                            QualificationType = 1,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 4,
                            AverageToDate = 81.3f,
                            EnrolmentDate = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 2B",
                            Qualification = "Degree B2",
                            QualificationType = 2,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 5,
                            AverageToDate = 72.5f,
                            EnrolmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 3A",
                            Qualification = "Degree A3",
                            QualificationType = 1,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 6,
                            AverageToDate = 81.3f,
                            EnrolmentDate = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 3B",
                            Qualification = "Degree B3",
                            QualificationType = 2,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 7,
                            AverageToDate = 72.5f,
                            EnrolmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 4A",
                            Qualification = "Degree A4",
                            QualificationType = 1,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 8,
                            AverageToDate = 81.3f,
                            EnrolmentDate = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 4B",
                            Qualification = "Degree B4",
                            QualificationType = 2,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 9,
                            AverageToDate = 72.5f,
                            EnrolmentDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 5A",
                            Qualification = "Degree A5",
                            QualificationType = 1,
                            StudentId = 5
                        },
                        new
                        {
                            Id = 10,
                            AverageToDate = 81.3f,
                            EnrolmentDate = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University 5B",
                            Qualification = "Degree B5",
                            QualificationType = 2,
                            StudentId = 5
                        });
                });

            modelBuilder.Entity("StudentProgressTracker.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Alice",
                            LastName = "Admin",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Bob",
                            LastName = "Brown",
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Charlie",
                            LastName = "Clark",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Diana",
                            LastName = "Doe",
                            StudentId = 4
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Evan",
                            LastName = "Evans",
                            StudentId = 5
                        });
                });

            modelBuilder.Entity("StudentProgressTracker.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("ProfileImage")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdNumber = 101,
                            Name = "Alice A"
                        },
                        new
                        {
                            Id = 2,
                            IdNumber = 102,
                            Name = "Bob B"
                        },
                        new
                        {
                            Id = 3,
                            IdNumber = 103,
                            Name = "Charlie C"
                        },
                        new
                        {
                            Id = 4,
                            IdNumber = 104,
                            Name = "Diana D"
                        },
                        new
                        {
                            Id = 5,
                            IdNumber = 105,
                            Name = "Evan E"
                        });
                });

            modelBuilder.Entity("StudentProgressTracker.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasIndex("PersonId");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "user-1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7b6b8835-d46d-4ef3-bd8e-e8f83233b666",
                            Email = "alice@domain.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALICE@DOMAIN.COM",
                            NormalizedUserName = "ALICE@DOMAIN.COM",
                            PasswordHash = "1e9a6b9afd56cf274a1b46367cad2ff478fb6f0e29e5766195848b1482d2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bbee5bda-0ad0-48df-9f7e-7c7c644d0c9e",
                            TwoFactorEnabled = false,
                            UserName = "alice@domain.com",
                            IsAdmin = true,
                            PersonId = 1
                        },
                        new
                        {
                            Id = "user-2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ee318d1-2b2e-45ca-9ea3-fb3a07d1fd84",
                            Email = "bob@domain.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "BOB@DOMAIN.COM",
                            NormalizedUserName = "BOB@DOMAIN.COM",
                            PasswordHash = "cd92953692442115e21ca8c5daefaffe2b3d8737769700667cb8ca864ae1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "437fb9d8-7c90-4da9-b0c3-a000fc8f73a9",
                            TwoFactorEnabled = false,
                            UserName = "bob@domain.com",
                            IsAdmin = false,
                            PersonId = 2
                        },
                        new
                        {
                            Id = "user-3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a2eb9cf-12e7-465e-abde-b433f6cd0aa2",
                            Email = "charlie@domain.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CHARLIE@DOMAIN.COM",
                            NormalizedUserName = "CHARLIE@DOMAIN.COM",
                            PasswordHash = "8821f0b783db3f50973e537d6c60e6d11b9f54e468f7ad3310d33a7ce5bd",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b290f6ba-403f-4b3f-b76d-6d1593f1f740",
                            TwoFactorEnabled = false,
                            UserName = "charlie@domain.com",
                            IsAdmin = false,
                            PersonId = 3
                        },
                        new
                        {
                            Id = "user-4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "431cf1eb-f2f8-434c-8e1a-7b1fb251d613",
                            Email = "diana@domain.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DIANA@DOMAIN.COM",
                            NormalizedUserName = "DIANA@DOMAIN.COM",
                            PasswordHash = "7d2a607c01865556ee0b41989327f79cf4611f64ad6395b70c8dabce265a",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a0e1aef7-56dc-499e-a173-62d94a95fb33",
                            TwoFactorEnabled = false,
                            UserName = "diana@domain.com",
                            IsAdmin = false,
                            PersonId = 4
                        },
                        new
                        {
                            Id = "user-5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "45181178-272a-4bdd-a04a-a497fc5b720a",
                            Email = "evan@domain.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EVAN@DOMAIN.COM",
                            NormalizedUserName = "EVAN@DOMAIN.COM",
                            PasswordHash = "1d822bf156637662c4dea432bf14e9a91395f395c81695069253c512665f",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "141dbf73-e86c-48a8-a282-b7d431c1da4f",
                            TwoFactorEnabled = false,
                            UserName = "evan@domain.com",
                            IsAdmin = false,
                            PersonId = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentProgressTracker.Models.Enrollment", b =>
                {
                    b.HasOne("StudentProgressTracker.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentProgressTracker.Models.Person", b =>
                {
                    b.HasOne("StudentProgressTracker.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentProgressTracker.Models.ApplicationUser", b =>
                {
                    b.HasOne("StudentProgressTracker.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("StudentProgressTracker.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
