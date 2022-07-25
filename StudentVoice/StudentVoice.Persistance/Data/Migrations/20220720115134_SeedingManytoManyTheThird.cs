using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentVoice.Persistance.Data.Migrations
{
    public partial class SeedingManytoManyTheThird : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 51, 34, 170, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 51, 34, 170, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "NotificationDate",
                value: new DateTime(2022, 7, 20, 14, 51, 34, 170, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.InsertData(
                table: "SurveyUser",
                columns: new[] { "SurveysId", "UsersId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 3, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 2, 4 },
                    { 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "SurveyUser",
                keyColumns: new[] { "SurveysId", "UsersId" },
                keyValues: new object[] { 3, 3 });

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
        }
    }
}
