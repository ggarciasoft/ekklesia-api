using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ekklesia.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Configuration");

            migrationBuilder.EnsureSchema(
                name: "Security");

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 15, nullable: false),
                    LastName = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 255, nullable: true),
                    HomePhone = table.Column<string>(maxLength: 30, nullable: true),
                    CellPhone = table.Column<string>(maxLength: 30, nullable: true),
                    IsLocalMember = table.Column<bool>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    ConversionDate = table.Column<DateTime>(nullable: true),
                    BaptismDate = table.Column<DateTime>(nullable: true),
                    ContactImage = table.Column<byte[]>(maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityType",
                schema: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                schema: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityType",
                schema: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ministry",
                schema: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ministry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovementType",
                schema: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                schema: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Security",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenant",
                schema: "Security",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityDate = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: false),
                    ActivityTypeId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalSchema: "Configuration",
                        principalTable: "ActivityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberMinistryPosition",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false),
                    MinistryId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberMinistryPosition", x => new { x.MemberId, x.MinistryId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_MemberMinistryPosition_Contact_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberMinistryPosition_Ministry_MinistryId",
                        column: x => x.MinistryId,
                        principalSchema: "Configuration",
                        principalTable: "Ministry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberMinistryPosition_Position_PositionId",
                        column: x => x.PositionId,
                        principalSchema: "Configuration",
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Security",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 15, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 255, nullable: false),
                    PasswordSalt = table.Column<byte[]>(maxLength: 255, nullable: false),
                    UserImage = table.Column<byte[]>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    MustChangePassword = table.Column<bool>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Security",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityAssistant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityId = table.Column<int>(nullable: false),
                    EntityTypeId = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAssistant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityAssistant_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAssistant_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityAssistant_EntityType_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalSchema: "Configuration",
                        principalTable: "EntityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovementDate = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: false),
                    ActivityId = table.Column<int>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    InsertUserId = table.Column<int>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movement_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTenant",
                schema: "Security",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTenant", x => new { x.TenantId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserTenant_Tenant_TenantId",
                        column: x => x.TenantId,
                        principalSchema: "Security",
                        principalTable: "Tenant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTenant_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Security",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovementId = table.Column<int>(nullable: false),
                    MovementTypeId = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: true),
                    AssetId = table.Column<int>(nullable: false),
                    AssetQuantity = table.Column<double>(nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementDetail_Asset_AssetId",
                        column: x => x.AssetId,
                        principalSchema: "Configuration",
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovementDetail_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovementDetail_Movement_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovementDetail_MovementType_MovementTypeId",
                        column: x => x.MovementTypeId,
                        principalSchema: "Configuration",
                        principalTable: "MovementType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ActivityTypeId",
                table: "Activity",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAssistant_ActivityId",
                table: "ActivityAssistant",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAssistant_ContactId",
                table: "ActivityAssistant",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAssistant_EntityTypeId",
                table: "ActivityAssistant",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberMinistryPosition_MinistryId",
                table: "MemberMinistryPosition",
                column: "MinistryId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberMinistryPosition_PositionId",
                table: "MemberMinistryPosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Movement_ActivityId",
                table: "Movement",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementDetail_AssetId",
                table: "MovementDetail",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementDetail_ContactId",
                table: "MovementDetail",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementDetail_MovementId",
                table: "MovementDetail",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementDetail_MovementTypeId",
                table: "MovementDetail",
                column: "MovementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                schema: "Security",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTenant_UserId",
                schema: "Security",
                table: "UserTenant",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityAssistant");

            migrationBuilder.DropTable(
                name: "MemberMinistryPosition");

            migrationBuilder.DropTable(
                name: "MovementDetail");

            migrationBuilder.DropTable(
                name: "UserTenant",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "EntityType",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Ministry",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Position",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Asset",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Movement");

            migrationBuilder.DropTable(
                name: "MovementType",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Tenant",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "ActivityType",
                schema: "Configuration");
        }
    }
}
