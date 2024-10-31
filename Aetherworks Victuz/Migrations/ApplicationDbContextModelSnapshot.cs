﻿// <auto-generated />
using System;
using Aetherworks_Victuz.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aetherworks_Victuz.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aetherworks_Victuz.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaxCapacity = 24,
                            Name = "B.3.211"
                        },
                        new
                        {
                            Id = 2,
                            MaxCapacity = 96,
                            Name = "B.3.305"
                        },
                        new
                        {
                            Id = 3,
                            MaxCapacity = 72,
                            Name = "B.2.114"
                        },
                        new
                        {
                            Id = 4,
                            MaxCapacity = 96,
                            Name = "C.0.105"
                        });
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.Participation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<bool>("Attended")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("UserId");

                    b.ToTable("Participation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActivityId = 1,
                            Attended = false,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            ActivityId = 2,
                            Attended = false,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            ActivityId = 3,
                            Attended = false,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            ActivityId = 1,
                            Attended = false,
                            UserId = 3
                        },
                        new
                        {
                            Id = 5,
                            ActivityId = 2,
                            Attended = false,
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            ActivityId = 3,
                            Attended = false,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.Penalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId")
                        .IsUnique()
                        .HasFilter("[RoleId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Penalties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = "b136b696-dd1d-4ca8-bc09-dc9a242a8f9b",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Victuz T-Shirt",
                            Price = 20.00m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Victuz Mok",
                            Price = 20.00m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Victuz School Starter-Kit",
                            Price = 20.00m
                        });
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.Suggestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Suggestions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "I was expecting more cheese. And I was disturbed by the lack of cheese.",
                            Title = "More Cheese",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "I was expecting no cheese. And I was disturbed by the amount of cheese present.",
                            Title = "Less Cheese",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "I was expecting there to not be enough cheese. And I was surprised by the perfect amount of cheese present.",
                            Title = "Just enough Cheese",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CredentialId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CredentialId")
                        .IsUnique()
                        .HasFilter("[CredentialId] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CredentialId = "2e333d4b-4c24-448f-a7aa-7608197d5fad"
                        },
                        new
                        {
                            Id = 2,
                            CredentialId = "eaab06bd-a9b6-4785-90bb-d84573827962"
                        },
                        new
                        {
                            Id = 3,
                            CredentialId = "37373097-0ed7-4677-b07f-954fb9eb08ae"
                        });
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.VictuzActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("MemberPrice")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParticipantLimit")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.HasIndex("LocationId");

                    b.ToTable("VictuzActivities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActivityDate = new DateTime(2024, 11, 25, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            Category = 3,
                            Description = "Book Club Meetup",
                            HostId = 1,
                            LocationId = 1,
                            MemberPrice = 0.00m,
                            Name = "Book Club Meetup",
                            ParticipantLimit = 25,
                            Picture = "img\\BookClub.png",
                            Price = 0.00m
                        },
                        new
                        {
                            Id = 2,
                            ActivityDate = new DateTime(2024, 11, 20, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Category = 1,
                            Description = "Photography Workshop",
                            HostId = 1,
                            LocationId = 2,
                            MemberPrice = 15.00m,
                            Name = "Photography Workshop",
                            ParticipantLimit = 20,
                            Picture = "img\\Photography.png",
                            Price = 25.00m
                        },
                        new
                        {
                            Id = 3,
                            ActivityDate = new DateTime(2024, 11, 22, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Category = 0,
                            Description = "Battlebot Wars",
                            HostId = 1,
                            LocationId = 2,
                            MemberPrice = 12.00m,
                            Name = "Battlebot Wars",
                            ParticipantLimit = 10,
                            Picture = "img\\BattleBot.png",
                            Price = 0.00m
                        });
                });

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
                            Id = "b3cb4480-7af2-4cc5-90dc-0028c7b94190",
                            Name = "Organizer"
                        },
                        new
                        {
                            Id = "5cc78e5a-bd90-4adc-91c6-1b0bf91708ad",
                            Name = "Member"
                        },
                        new
                        {
                            Id = "b136b696-dd1d-4ca8-bc09-dc9a242a8f9b",
                            Name = "Guest"
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

                    b.HasData(
                        new
                        {
                            Id = "2e333d4b-4c24-448f-a7aa-7608197d5fad",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3d08f465-c409-412d-85c1-f4a212fc2e25",
                            Email = "organizer@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ORGANIZER@GMAIL.COM",
                            NormalizedUserName = "ORGANIZER@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBCO7kfhleA+rJgzblvMlQh/8EzLDeKO1hRDHFxuAX4hRaLAOZEICsYhYKoI97QYew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "MRKIS7ZM3PEX7XJX7FGMPZY4NKTH6Z76",
                            TwoFactorEnabled = false,
                            UserName = "organizer@gmail.com"
                        },
                        new
                        {
                            Id = "eaab06bd-a9b6-4785-90bb-d84573827962",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6f44b994-4920-49ff-84a3-37edfc164be6",
                            Email = "member@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MEMBER@GMAIL.COM",
                            NormalizedUserName = "MEMBER@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEO/MrnGzjJfNjh+vU2Zv9Dv1TR4ZFhiYqBkKFPYFFSVIT+S4DNyYqlNlFb/+ba/vjw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "LFSRBIXYR4P6ZTHPXRWDIQ7M5GTLJXK7",
                            TwoFactorEnabled = false,
                            UserName = "member@gmail.com"
                        },
                        new
                        {
                            Id = "37373097-0ed7-4677-b07f-954fb9eb08ae",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bf636d49-9342-4af5-aa7b-b1e9dd4a3a10",
                            Email = "guest@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "GUEST@GMAIL.COM",
                            NormalizedUserName = "GUEST@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEC9Tmh0HNHm5EQL0YPRmTJTZRmjRX4OnzusW767S7O2uW5XKJov6oSZPrQx/RGEcRA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "RQLSCP23C4O43IDZW3SETEUO2GI7VZOP",
                            TwoFactorEnabled = false,
                            UserName = "guest@gmail.com"
                        });
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
                            UserId = "2e333d4b-4c24-448f-a7aa-7608197d5fad",
                            RoleId = "b3cb4480-7af2-4cc5-90dc-0028c7b94190"
                        },
                        new
                        {
                            UserId = "eaab06bd-a9b6-4785-90bb-d84573827962",
                            RoleId = "5cc78e5a-bd90-4adc-91c6-1b0bf91708ad"
                        },
                        new
                        {
                            UserId = "37373097-0ed7-4677-b07f-954fb9eb08ae",
                            RoleId = "b136b696-dd1d-4ca8-bc09-dc9a242a8f9b"
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

            modelBuilder.Entity("Aetherworks_Victuz.Models.Participation", b =>
                {
                    b.HasOne("Aetherworks_Victuz.Models.VictuzActivity", "Activity")
                        .WithMany("ParticipantsList")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aetherworks_Victuz.Models.User", "User")
                        .WithMany("Participations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.Penalty", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithOne()
                        .HasForeignKey("Aetherworks_Victuz.Models.Penalty", "RoleId");

                    b.HasOne("Aetherworks_Victuz.Models.User", "User")
                        .WithMany("Penalties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.Suggestion", b =>
                {
                    b.HasOne("Aetherworks_Victuz.Models.User", "User")
                        .WithMany("Suggestions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.User", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Credential")
                        .WithOne()
                        .HasForeignKey("Aetherworks_Victuz.Models.User", "CredentialId");

                    b.Navigation("Credential");
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.VictuzActivity", b =>
                {
                    b.HasOne("Aetherworks_Victuz.Models.User", "Host")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aetherworks_Victuz.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Host");

                    b.Navigation("Location");
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

            modelBuilder.Entity("Aetherworks_Victuz.Models.User", b =>
                {
                    b.Navigation("Participations");

                    b.Navigation("Penalties");

                    b.Navigation("Suggestions");
                });

            modelBuilder.Entity("Aetherworks_Victuz.Models.VictuzActivity", b =>
                {
                    b.Navigation("ParticipantsList");
                });
#pragma warning restore 612, 618
        }
    }
}
