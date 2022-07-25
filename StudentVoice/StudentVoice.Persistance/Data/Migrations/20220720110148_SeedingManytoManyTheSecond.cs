using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentVoice.Persistance.Data.Migrations
{
    public partial class SeedingManytoManyTheSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 1, 48, 64, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 1, 48, 64, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 1, 48, 64, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.InsertData(
                table: "SurveyUser",
                columns: new[] { "SurveysId", "UsersId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 0, 5, 723, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 0, 5, 723, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 0, 5, 723, DateTimeKind.Local).AddTicks(8089));
        }
    }
}
