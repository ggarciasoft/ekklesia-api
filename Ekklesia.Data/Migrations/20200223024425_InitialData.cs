using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ekklesia.Data.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "ActivityType",
                columns: new[] { "Id", "Alias", "Description", "InsertDate", "InsertUserId", "IsActive", "Name", "TenantId", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, "CULT", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Culto", null, null, null },
                    { 2, "CAMPAIGN", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Campaña", null, null, null },
                    { 3, "VIGIL", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Vigilia", null, null, null },
                    { 4, "PRAY_CULT", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Culto de Oración", null, null, null },
                    { 5, "LADY_CULT", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Culto de Damas", null, null, null },
                    { 6, "GENTLEMAN_CULT", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Culto de Caballeros", null, null, null },
                    { 7, "CHILDREN_CULT", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Culto de Niños", null, null, null },
                    { 8, "OTHER", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Otro", null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "Asset",
                columns: new[] { "Id", "Alias", "Description", "InsertDate", "InsertUserId", "IsActive", "Name", "TenantId", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 9, "OTHER", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Otro", null, null, null },
                    { 8, "SAUCER", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Platillo", null, null, null },
                    { 7, "DRUM", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Tambora", null, null, null },
                    { 5, "PROJECTOR", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Poyector", null, null, null },
                    { 6, "PIANO", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Piano", null, null, null },
                    { 3, "MICROPHONE", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Micrófono", null, null, null },
                    { 2, "TABLE", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Mesa", null, null, null },
                    { 1, "CHAIR", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Silla", null, null, null },
                    { 4, "SPEAKER", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Bocina", null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "EntityType",
                columns: new[] { "Id", "Alias", "Description", "InsertDate", "InsertUserId", "IsActive", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, "PERSON", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Persona", null, null },
                    { 2, "CHURCH", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Iglesia", null, null },
                    { 3, "MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio", null, null },
                    { 4, "OTHER", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Otro", null, null }
                });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "Ministry",
                columns: new[] { "Id", "Alias", "Description", "InsertDate", "InsertUserId", "IsActive", "Name", "TenantId", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 8, "EVANGELISM_MISSION_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Finanzas", null, null, null },
                    { 12, "WORSHIP_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Otro", null, null, null },
                    { 11, "MARRIED_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Adoración", null, null, null },
                    { 10, "DIAKONIA_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Casados", null, null, null },
                    { 9, "FINANCIAL_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Diaconía", null, null, null },
                    { 7, "CHILDREN_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Evangelismo y Misiones", null, null, null },
                    { 1, "PRAY_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Oración", null, null, null },
                    { 5, "YOUNG_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Adolecentes", null, null, null },
                    { 4, "YOUNG_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Jóvenes", null, null, null },
                    { 3, "GENTLEMAN_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Caballeros", null, null, null },
                    { 2, "LADY_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Damas", null, null, null },
                    { 6, "TEEN_MINISTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ministerio de Niños", null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "MovementType",
                columns: new[] { "Id", "Alias", "Description", "InsertDate", "InsertUserId", "IsActive", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, "ENTRY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Ingreso", null, null },
                    { 2, "EGRESS", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Egreso", null, null }
                });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "Position",
                columns: new[] { "Id", "Alias", "Description", "InsertDate", "InsertUserId", "IsActive", "Name", "TenantId", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, "SHEPHERD", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Pastor/a", null, null, null },
                    { 2, "DIRECTOR", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Director/a", null, null, null },
                    { 3, "SUBDIRECTOR", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Sub-Director/a", null, null, null },
                    { 4, "SECRETARY", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Secretario/a", null, null, null },
                    { 5, "OTHER", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Otro", null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Security",
                table: "Role",
                columns: new[] { "Id", "Alias", "Description", "InsertDate", "InsertUserId", "IsActive", "Name", "TenantId", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 2, "OPERATOR", null, new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Operador/a", null, null, null },
                    { 1, "ADMIN", "Administrador", new DateTime(2020, 2, 22, 22, 44, 24, 619, DateTimeKind.Local).AddTicks(8739), 0, true, "Admin", null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Security",
                table: "Tenant",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Iglesia El Buen Pastor", "El Buen Pastor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Asset",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "EntityType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "EntityType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "EntityType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "EntityType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Ministry",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "MovementType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "MovementType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Position",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Position",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Position",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Position",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "Position",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Security",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Security",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Security",
                table: "Tenant",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
