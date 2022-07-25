using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentVoice.Persistance.Data.Migrations
{
    public partial class SeedingManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Professor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Class = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    isBanned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isSeen = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurveyUser",
                columns: table => new
                {
                    SurveysId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyUser", x => new { x.SurveysId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_SurveyUser_Surveys_SurveysId",
                        column: x => x.SurveysId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "NotificationDate", "Notification", "UserId", "isSeen" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 20, 14, 0, 5, 723, DateTimeKind.Local).AddTicks(6982), "Question needs to be approved", null, false },
                    { 2, new DateTime(2022, 7, 20, 14, 0, 5, 723, DateTimeKind.Local).AddTicks(8071), "A student answered a question", null, true },
                    { 3, new DateTime(2022, 7, 20, 14, 0, 5, 723, DateTimeKind.Local).AddTicks(8089), "Your qustion was aproved", null, true }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuestionName", "Rating", "SurveyId", "TextField" },
                values: new object[,]
                {
                    { 1, "Please rate this class.", 8, null, "" },
                    { 2, "What is something you liked about this class?", -1, null, "I really liked the fact that this class focused more on the quality of code than the quantity" },
                    { 3, "What is something you liked about this class?", -1, null, "I really liked the fact that this class focused more on the quality of code than the quantity" },
                    { 4, "What is something that we can improve about this class", -1, null, "N/A" }
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "Class", "Date", "ExpirationDate", "Likes", "Name", "Professor", "Rating", "Status", "Subject" },
                values: new object[,]
                {
                    { 1, "I", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 34, "Survey 1", "Alex", 5, "Completed", "Mate" },
                    { 2, "II", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 23, "Survey 2", "Cosmin", 4, "Completed", "Mate" },
                    { 3, "II", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 23, "Survey 2", "Cosmin", 4, "Uncompleted", "Info" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "isAdmin", "isBanned" },
                values: new object[,]
                {
                    { 1, "viorel@gmail.com", "Viorel", "Raul", "1234", "02320234", false, false },
                    { 2, "cosmin@gmail.com", "Cosmin", "QQQ", "34252", "0rrwrt54", false, false },
                    { 3, "andreiRotar@admin.gmail.com", "Andrei", "Rotar", "sgsdsjeere", "0rrwrt54", true, false },
                    { 4, "sarah.ionescu@gmail.com", "Sarah", "Ionescu", "sgsdsjeere", "0rrwrt54", false, true }
                });

            migrationBuilder.InsertData(
                table: "SurveyUser",
                columns: new[] { "SurveysId", "UsersId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyId",
                table: "Questions",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyUser_UsersId",
                table: "SurveyUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "SurveyUser");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
