using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace resume_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstname = table.Column<string>(type: "text", nullable: false),
                    middlename = table.Column<string>(type: "text", nullable: true),
                    lastname = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    addressid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    street = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    zip = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.addressid);
                    table.ForeignKey(
                        name: "FK_addresses_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "awards",
                columns: table => new
                {
                    awardid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    awardtitle = table.Column<string>(type: "text", nullable: false),
                    awardingbody = table.Column<string>(type: "text", nullable: true),
                    year = table.Column<int>(type: "integer", nullable: true),
                    month = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_awards", x => x.awardid);
                    table.ForeignKey(
                        name: "FK_awards_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "certifications",
                columns: table => new
                {
                    certificationid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    certificationtitle = table.Column<string>(type: "text", nullable: false),
                    awardingbody = table.Column<string>(type: "text", nullable: true),
                    year = table.Column<int>(type: "integer", nullable: true),
                    month = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certifications", x => x.certificationid);
                    table.ForeignKey(
                        name: "FK_certifications_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "degrees",
                columns: table => new
                {
                    degreeid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    degreetitle = table.Column<string>(type: "text", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: true),
                    gpa = table.Column<float>(type: "real", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_degrees", x => x.degreeid);
                    table.ForeignKey(
                        name: "FK_degrees_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    jobid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    organizationname = table.Column<string>(type: "text", nullable: false),
                    location = table.Column<string>(type: "text", nullable: true),
                    jobtitle = table.Column<string>(type: "text", nullable: true),
                    startyear = table.Column<int>(type: "integer", nullable: false),
                    startmonth = table.Column<int>(type: "integer", nullable: false),
                    endyear = table.Column<int>(type: "integer", nullable: true),
                    endmonth = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.jobid);
                    table.ForeignKey(
                        name: "FK_jobs_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resumes",
                columns: table => new
                {
                    resumeid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resumes", x => x.resumeid);
                    table.ForeignKey(
                        name: "FK_resumes_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "duties",
                columns: table => new
                {
                    dutyid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_duties", x => x.dutyid);
                    table.ForeignKey(
                        name: "FK_duties_jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "jobs",
                        principalColumn: "jobid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    roleid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.roleid);
                    table.ForeignKey(
                        name: "FK_roles_jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "jobs",
                        principalColumn: "jobid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressResume",
                columns: table => new
                {
                    AddressesAddressId = table.Column<int>(type: "integer", nullable: false),
                    ResumesResumeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressResume", x => new { x.AddressesAddressId, x.ResumesResumeId });
                    table.ForeignKey(
                        name: "FK_AddressResume_addresses_AddressesAddressId",
                        column: x => x.AddressesAddressId,
                        principalTable: "addresses",
                        principalColumn: "addressid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressResume_resumes_ResumesResumeId",
                        column: x => x.ResumesResumeId,
                        principalTable: "resumes",
                        principalColumn: "resumeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AwardResume",
                columns: table => new
                {
                    AwardsAwardId = table.Column<int>(type: "integer", nullable: false),
                    ResumesResumeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardResume", x => new { x.AwardsAwardId, x.ResumesResumeId });
                    table.ForeignKey(
                        name: "FK_AwardResume_awards_AwardsAwardId",
                        column: x => x.AwardsAwardId,
                        principalTable: "awards",
                        principalColumn: "awardid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AwardResume_resumes_ResumesResumeId",
                        column: x => x.ResumesResumeId,
                        principalTable: "resumes",
                        principalColumn: "resumeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificationResume",
                columns: table => new
                {
                    CertificationsCertificationId = table.Column<int>(type: "integer", nullable: false),
                    ResumesResumeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationResume", x => new { x.CertificationsCertificationId, x.ResumesResumeId });
                    table.ForeignKey(
                        name: "FK_CertificationResume_certifications_CertificationsCertificat~",
                        column: x => x.CertificationsCertificationId,
                        principalTable: "certifications",
                        principalColumn: "certificationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificationResume_resumes_ResumesResumeId",
                        column: x => x.ResumesResumeId,
                        principalTable: "resumes",
                        principalColumn: "resumeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeResume",
                columns: table => new
                {
                    DegreesDegreeId = table.Column<int>(type: "integer", nullable: false),
                    ResumesResumeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeResume", x => new { x.DegreesDegreeId, x.ResumesResumeId });
                    table.ForeignKey(
                        name: "FK_DegreeResume_degrees_DegreesDegreeId",
                        column: x => x.DegreesDegreeId,
                        principalTable: "degrees",
                        principalColumn: "degreeid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DegreeResume_resumes_ResumesResumeId",
                        column: x => x.ResumesResumeId,
                        principalTable: "resumes",
                        principalColumn: "resumeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobResume",
                columns: table => new
                {
                    JobsJobId = table.Column<int>(type: "integer", nullable: false),
                    ResumesResumeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobResume", x => new { x.JobsJobId, x.ResumesResumeId });
                    table.ForeignKey(
                        name: "FK_JobResume_jobs_JobsJobId",
                        column: x => x.JobsJobId,
                        principalTable: "jobs",
                        principalColumn: "jobid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobResume_resumes_ResumesResumeId",
                        column: x => x.ResumesResumeId,
                        principalTable: "resumes",
                        principalColumn: "resumeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "links",
                columns: table => new
                {
                    linkid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    url = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ResumeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_links", x => x.linkid);
                    table.ForeignKey(
                        name: "FK_links_resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resumes",
                        principalColumn: "resumeid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_links_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    skillid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ResumeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.skillid);
                    table.ForeignKey(
                        name: "FK_skills_resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resumes",
                        principalColumn: "resumeid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_skills_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_addresses_UserId",
                table: "addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressResume_ResumesResumeId",
                table: "AddressResume",
                column: "ResumesResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_AwardResume_ResumesResumeId",
                table: "AwardResume",
                column: "ResumesResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_awards_UserId",
                table: "awards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationResume_ResumesResumeId",
                table: "CertificationResume",
                column: "ResumesResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_certifications_UserId",
                table: "certifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeResume_ResumesResumeId",
                table: "DegreeResume",
                column: "ResumesResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_degrees_degreeid",
                table: "degrees",
                column: "degreeid");

            migrationBuilder.CreateIndex(
                name: "IX_degrees_UserId",
                table: "degrees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_duties_dutyid",
                table: "duties",
                column: "dutyid");

            migrationBuilder.CreateIndex(
                name: "IX_duties_JobId",
                table: "duties",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobResume_ResumesResumeId",
                table: "JobResume",
                column: "ResumesResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_UserId",
                table: "jobs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_links_ResumeId",
                table: "links",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_links_UserId",
                table: "links",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_resumes_UserId",
                table: "resumes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_roles_JobId",
                table: "roles",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_skills_ResumeId",
                table: "skills",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_skills_UserId",
                table: "skills",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressResume");

            migrationBuilder.DropTable(
                name: "AwardResume");

            migrationBuilder.DropTable(
                name: "CertificationResume");

            migrationBuilder.DropTable(
                name: "DegreeResume");

            migrationBuilder.DropTable(
                name: "duties");

            migrationBuilder.DropTable(
                name: "JobResume");

            migrationBuilder.DropTable(
                name: "links");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "awards");

            migrationBuilder.DropTable(
                name: "certifications");

            migrationBuilder.DropTable(
                name: "degrees");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "resumes");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
