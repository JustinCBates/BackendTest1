﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using resume_api.Data;

#nullable disable

namespace resume_api.Migrations
{
    [DbContext(typeof(ResumeContext))]
    partial class ResumeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AddressResume", b =>
                {
                    b.Property<int>("AddressesAddressId")
                        .HasColumnType("integer");

                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("integer");

                    b.HasKey("AddressesAddressId", "ResumesResumeId");

                    b.HasIndex("ResumesResumeId");

                    b.ToTable("AddressResume");
                });

            modelBuilder.Entity("AwardResume", b =>
                {
                    b.Property<int>("AwardsAwardId")
                        .HasColumnType("integer");

                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("integer");

                    b.HasKey("AwardsAwardId", "ResumesResumeId");

                    b.HasIndex("ResumesResumeId");

                    b.ToTable("AwardResume");
                });

            modelBuilder.Entity("CertificationResume", b =>
                {
                    b.Property<int>("CertificationsCertificationId")
                        .HasColumnType("integer");

                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("integer");

                    b.HasKey("CertificationsCertificationId", "ResumesResumeId");

                    b.HasIndex("ResumesResumeId");

                    b.ToTable("CertificationResume");
                });

            modelBuilder.Entity("DegreeResume", b =>
                {
                    b.Property<int>("DegreesDegreeId")
                        .HasColumnType("integer");

                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("integer");

                    b.HasKey("DegreesDegreeId", "ResumesResumeId");

                    b.HasIndex("ResumesResumeId");

                    b.ToTable("DegreeResume");
                });

            modelBuilder.Entity("JobResume", b =>
                {
                    b.Property<int>("JobsJobId")
                        .HasColumnType("integer");

                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("integer");

                    b.HasKey("JobsJobId", "ResumesResumeId");

                    b.HasIndex("ResumesResumeId");

                    b.ToTable("JobResume");
                });

            modelBuilder.Entity("resume_api.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("addressid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Phone")
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<string>("State")
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<string>("Street")
                        .HasColumnType("text")
                        .HasColumnName("street");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("Zip")
                        .HasColumnType("integer")
                        .HasColumnName("zip");

                    b.HasKey("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("resume_api.Models.Award", b =>
                {
                    b.Property<int>("AwardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("awardid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AwardId"));

                    b.Property<string>("AwardTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("awardtitle");

                    b.Property<string>("AwardingBody")
                        .HasColumnType("text")
                        .HasColumnName("awardingbody");

                    b.Property<int?>("Month")
                        .HasColumnType("integer")
                        .HasColumnName("month");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("AwardId");

                    b.HasIndex("UserId");

                    b.ToTable("awards");
                });

            modelBuilder.Entity("resume_api.Models.Certification", b =>
                {
                    b.Property<int>("CertificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("certificationid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CertificationId"));

                    b.Property<string>("AwardingBody")
                        .HasColumnType("text")
                        .HasColumnName("awardingbody");

                    b.Property<string>("CertificationTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("certificationtitle");

                    b.Property<int?>("Month")
                        .HasColumnType("integer")
                        .HasColumnName("month");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("CertificationId");

                    b.HasIndex("UserId");

                    b.ToTable("certifications");
                });

            modelBuilder.Entity("resume_api.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("degreeid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DegreeId"));

                    b.Property<string>("DegreeTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("degreetitle");

                    b.Property<float?>("GPA")
                        .HasColumnType("real")
                        .HasColumnName("gpa");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("DegreeId");

                    b.HasIndex("DegreeId");

                    b.HasIndex("UserId");

                    b.ToTable("degrees");
                });

            modelBuilder.Entity("resume_api.Models.Duty", b =>
                {
                    b.Property<int>("DutyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("dutyid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DutyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("JobId")
                        .HasColumnType("integer");

                    b.HasKey("DutyId");

                    b.HasIndex("DutyId");

                    b.HasIndex("JobId");

                    b.ToTable("duties");
                });

            modelBuilder.Entity("resume_api.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("jobid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("JobId"));

                    b.Property<int?>("EndMonth")
                        .HasColumnType("integer")
                        .HasColumnName("endmonth");

                    b.Property<int?>("EndYear")
                        .HasColumnType("integer")
                        .HasColumnName("endyear");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text")
                        .HasColumnName("jobtitle");

                    b.Property<string>("Location")
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("organizationname");

                    b.Property<int>("StartMonth")
                        .HasColumnType("integer")
                        .HasColumnName("startmonth");

                    b.Property<int>("StartYear")
                        .HasColumnType("integer")
                        .HasColumnName("startyear");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("resume_api.Models.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("linkid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LinkId"));

                    b.Property<int>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LinkId");

                    b.HasIndex("ResumeId");

                    b.HasIndex("UserId");

                    b.ToTable("links");
                });

            modelBuilder.Entity("resume_api.Models.Resume", b =>
                {
                    b.Property<int>("ResumeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("resumeid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ResumeId"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.HasKey("ResumeId");

                    b.HasIndex("UserId");

                    b.ToTable("resumes");
                });

            modelBuilder.Entity("resume_api.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("roleid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<int>("JobId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.HasKey("RoleId");

                    b.HasIndex("JobId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("resume_api.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("skillid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SkillId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("SkillId");

                    b.HasIndex("ResumeId");

                    b.HasIndex("UserId");

                    b.ToTable("skills");
                });

            modelBuilder.Entity("resume_api.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("firstname");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastname");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text")
                        .HasColumnName("middlename");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("AddressResume", b =>
                {
                    b.HasOne("resume_api.Models.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resume_api.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AwardResume", b =>
                {
                    b.HasOne("resume_api.Models.Award", null)
                        .WithMany()
                        .HasForeignKey("AwardsAwardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resume_api.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CertificationResume", b =>
                {
                    b.HasOne("resume_api.Models.Certification", null)
                        .WithMany()
                        .HasForeignKey("CertificationsCertificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resume_api.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DegreeResume", b =>
                {
                    b.HasOne("resume_api.Models.Degree", null)
                        .WithMany()
                        .HasForeignKey("DegreesDegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resume_api.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobResume", b =>
                {
                    b.HasOne("resume_api.Models.Job", null)
                        .WithMany()
                        .HasForeignKey("JobsJobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resume_api.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("resume_api.Models.Address", b =>
                {
                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Award", b =>
                {
                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Awards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Certification", b =>
                {
                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Certifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Degree", b =>
                {
                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Degrees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Duty", b =>
                {
                    b.HasOne("resume_api.Models.Job", "Job")
                        .WithMany("Duties")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("resume_api.Models.Job", b =>
                {
                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Link", b =>
                {
                    b.HasOne("resume_api.Models.Resume", "Resume")
                        .WithMany("Links")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Links")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Resume", b =>
                {
                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Resumes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Role", b =>
                {
                    b.HasOne("resume_api.Models.Job", "Job")
                        .WithMany("Roles")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("resume_api.Models.Skill", b =>
                {
                    b.HasOne("resume_api.Models.Resume", "Resume")
                        .WithMany("Skills")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resume_api.Models.User", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");

                    b.Navigation("User");
                });

            modelBuilder.Entity("resume_api.Models.Job", b =>
                {
                    b.Navigation("Duties");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("resume_api.Models.Resume", b =>
                {
                    b.Navigation("Links");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("resume_api.Models.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Awards");

                    b.Navigation("Certifications");

                    b.Navigation("Degrees");

                    b.Navigation("Jobs");

                    b.Navigation("Links");

                    b.Navigation("Resumes");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
