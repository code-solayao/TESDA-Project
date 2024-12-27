﻿// <auto-generated />
using EmploymentMonitoringSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmploymentMonitoringSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("EmploymentMonitoringSystem.Models.EmploymentRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("company_address")
                        .HasColumnType("longtext");

                    b.Property<string>("company_name")
                        .HasColumnType("longtext");

                    b.Property<string>("employment_status")
                        .HasColumnType("longtext");

                    b.Property<string>("hired_date")
                        .HasColumnType("longtext");

                    b.Property<string>("interview_date")
                        .HasColumnType("longtext");

                    b.Property<string>("job_title")
                        .HasColumnType("longtext");

                    b.Property<string>("not_hired_reason")
                        .HasColumnType("longtext");

                    b.Property<string>("submitted_documents_date")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Employment_Records");
                });

            modelBuilder.Entity("EmploymentMonitoringSystem.Models.ExternalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("assessment_result")
                        .HasColumnType("longtext");

                    b.Property<string>("count")
                        .HasColumnType("longtext");

                    b.Property<string>("date_hired")
                        .HasColumnType("longtext");

                    b.Property<string>("employer_name")
                        .HasColumnType("longtext");

                    b.Property<string>("employment_before_training")
                        .HasColumnType("longtext");

                    b.Property<string>("employment_type")
                        .HasColumnType("longtext");

                    b.Property<string>("job_vacancies")
                        .HasColumnType("longtext");

                    b.Property<string>("no_of_employed")
                        .HasColumnType("longtext");

                    b.Property<string>("no_of_graduates")
                        .HasColumnType("longtext");

                    b.Property<string>("occupation")
                        .HasColumnType("longtext");

                    b.Property<string>("remarks")
                        .HasColumnType("longtext");

                    b.Property<string>("training_status")
                        .HasColumnType("longtext");

                    b.Property<string>("verification")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("External_Records");
                });

            modelBuilder.Entity("EmploymentMonitoringSystem.Models.InitialRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("address")
                        .HasColumnType("longtext");

                    b.Property<string>("allocation")
                        .HasColumnType("longtext");

                    b.Property<string>("birthdate")
                        .HasColumnType("longtext");

                    b.Property<string>("city")
                        .HasColumnType("longtext");

                    b.Property<string>("contact_number")
                        .HasColumnType("longtext");

                    b.Property<string>("district")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("extension_name")
                        .HasColumnType("longtext");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("full_name")
                        .HasColumnType("longtext");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("middle_name")
                        .HasColumnType("longtext");

                    b.Property<string>("qualification_title")
                        .HasColumnType("longtext");

                    b.Property<string>("scholarship_type")
                        .HasColumnType("longtext");

                    b.Property<string>("sector")
                        .HasColumnType("longtext");

                    b.Property<string>("sex")
                        .HasColumnType("longtext");

                    b.Property<string>("tvi")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Initial_Records");
                });

            modelBuilder.Entity("EmploymentMonitoringSystem.Models.VerificationRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("follow_up_date_1")
                        .HasColumnType("longtext");

                    b.Property<string>("follow_up_date_2")
                        .HasColumnType("longtext");

                    b.Property<string>("invalid_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("no_referral_reason")
                        .HasColumnType("longtext");

                    b.Property<string>("not_interested_reason")
                        .HasColumnType("longtext");

                    b.Property<string>("referral_date")
                        .HasColumnType("longtext");

                    b.Property<string>("referral_status")
                        .HasColumnType("longtext");

                    b.Property<string>("response_status")
                        .HasColumnType("longtext");

                    b.Property<string>("verification_date")
                        .HasColumnType("longtext");

                    b.Property<string>("verification_means")
                        .HasColumnType("longtext");

                    b.Property<string>("verification_status")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Verification_Records");
                });
#pragma warning restore 612, 618
        }
    }
}