﻿// <auto-generated />
using System;
using BudgetTool.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BudgetTool.UI.Migrations
{
    [DbContext(typeof(BudgetToolDbContext))]
    [Migration("20201031135359_BudgetModelFloatToDouble")]
    partial class BudgetModelFloatToDouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BudgetTool.Models.Models.BudgetModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FixedCostsId")
                        .HasColumnType("int");

                    b.Property<int?>("IncomesId")
                        .HasColumnType("int");

                    b.Property<int?>("VariableCostsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FixedCostsId");

                    b.HasIndex("IncomesId");

                    b.HasIndex("VariableCostsId");

                    b.ToTable("BudgetModels");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.FixedCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("FixedCostsTotal")
                        .HasColumnType("double");

                    b.Property<int?>("InsuranceAndMonthlyCostsId")
                        .HasColumnType("int");

                    b.Property<int?>("LivingCostsId")
                        .HasColumnType("int");

                    b.Property<int?>("LoansAndSavingsCostsId")
                        .HasColumnType("int");

                    b.Property<int?>("TravellingCostsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceAndMonthlyCostsId");

                    b.HasIndex("LivingCostsId");

                    b.HasIndex("LoansAndSavingsCostsId");

                    b.HasIndex("TravellingCostsId");

                    b.ToTable("FixedCost");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.FixedCost+InsuranceAndMonthlyCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AccidentInsurance")
                        .HasColumnType("double");

                    b.Property<double>("HomeInsurance")
                        .HasColumnType("double");

                    b.Property<double>("InsuranceAndMonthlyCostsTotal")
                        .HasColumnType("double");

                    b.Property<double>("MobileAndInternet")
                        .HasColumnType("double");

                    b.Property<double>("NewspaperAndMagazines")
                        .HasColumnType("double");

                    b.Property<double>("OtherInsuranceAndMonthlyCosts")
                        .HasColumnType("double");

                    b.Property<double>("SportAndExercise")
                        .HasColumnType("double");

                    b.Property<double>("TVAndPaymentChannels")
                        .HasColumnType("double");

                    b.Property<double>("TradeFundOrUnemploymentFund")
                        .HasColumnType("double");

                    b.Property<double>("TravelInsurance")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("InsuranceAndMonthlyCost");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.FixedCost+LivingCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("ElectricityOrGas")
                        .HasColumnType("double");

                    b.Property<double>("Heating")
                        .HasColumnType("double");

                    b.Property<double>("LivingCostsTotal")
                        .HasColumnType("double");

                    b.Property<double>("OtherLivingCosts")
                        .HasColumnType("double");

                    b.Property<double>("RentOrMortgage")
                        .HasColumnType("double");

                    b.Property<double>("ServiceCharge")
                        .HasColumnType("double");

                    b.Property<double>("Water")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("LivingCost");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.FixedCost+LoansAndSavingsCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CarLoan")
                        .HasColumnType("double");

                    b.Property<double>("OtherConstantSaving")
                        .HasColumnType("double");

                    b.Property<double>("OtherLoansAndSavings")
                        .HasColumnType("double");

                    b.Property<double>("RetirementSaving")
                        .HasColumnType("double");

                    b.Property<double>("StudentLoan")
                        .HasColumnType("double");

                    b.Property<double>("TotalLoansAndSavings")
                        .HasColumnType("double");

                    b.Property<double>("UsageLoan")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("LoansAndSavingsCost");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.FixedCost+TravellingCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CarAndMotorcycleInsurance")
                        .HasColumnType("double");

                    b.Property<double>("CarAndMotorcycleRepair")
                        .HasColumnType("double");

                    b.Property<double>("Fuel")
                        .HasColumnType("double");

                    b.Property<double>("OtherTravellingCosts")
                        .HasColumnType("double");

                    b.Property<double>("PublicTransport")
                        .HasColumnType("double");

                    b.Property<double>("TrafficAndVehiceTax")
                        .HasColumnType("double");

                    b.Property<double>("TravellingCostsTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("TravellingCost");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.Income", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("HousingAllowance")
                        .HasColumnType("double");

                    b.Property<double>("NetIncome")
                        .HasColumnType("double");

                    b.Property<double>("OtherBenefits")
                        .HasColumnType("double");

                    b.Property<double>("OtherIncomes")
                        .HasColumnType("double");

                    b.Property<double>("StudentLoan")
                        .HasColumnType("double");

                    b.Property<double>("StudyGrant")
                        .HasColumnType("double");

                    b.Property<double>("TotalIncomes")
                        .HasColumnType("double");

                    b.Property<double>("UnemploymentBenefit")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Income");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.VariableCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Clothing")
                        .HasColumnType("double");

                    b.Property<double>("DoctorAndMedicines")
                        .HasColumnType("double");

                    b.Property<double>("FoodAndDailyEquipments")
                        .HasColumnType("double");

                    b.Property<double>("Freetime")
                        .HasColumnType("double");

                    b.Property<double>("FurnitureAndDecoration")
                        .HasColumnType("double");

                    b.Property<double>("OtherVariableCosts")
                        .HasColumnType("double");

                    b.Property<double>("TotalVariableCosts")
                        .HasColumnType("double");

                    b.Property<double>("Vacation")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("VariableCost");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.BudgetModel", b =>
                {
                    b.HasOne("BudgetTool.Models.Models.FixedCost", "FixedCosts")
                        .WithMany()
                        .HasForeignKey("FixedCostsId");

                    b.HasOne("BudgetTool.Models.Models.Income", "Incomes")
                        .WithMany()
                        .HasForeignKey("IncomesId");

                    b.HasOne("BudgetTool.Models.Models.VariableCost", "VariableCosts")
                        .WithMany()
                        .HasForeignKey("VariableCostsId");
                });

            modelBuilder.Entity("BudgetTool.Models.Models.FixedCost", b =>
                {
                    b.HasOne("BudgetTool.Models.Models.FixedCost+InsuranceAndMonthlyCost", "InsuranceAndMonthlyCosts")
                        .WithMany()
                        .HasForeignKey("InsuranceAndMonthlyCostsId");

                    b.HasOne("BudgetTool.Models.Models.FixedCost+LivingCost", "LivingCosts")
                        .WithMany()
                        .HasForeignKey("LivingCostsId");

                    b.HasOne("BudgetTool.Models.Models.FixedCost+LoansAndSavingsCost", "LoansAndSavingsCosts")
                        .WithMany()
                        .HasForeignKey("LoansAndSavingsCostsId");

                    b.HasOne("BudgetTool.Models.Models.FixedCost+TravellingCost", "TravellingCosts")
                        .WithMany()
                        .HasForeignKey("TravellingCostsId");
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
#pragma warning restore 612, 618
        }
    }
}