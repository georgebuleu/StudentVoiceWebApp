using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentVoice.Persistance.Data.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false)
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
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
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
                    { 1, new DateTime(2022, 7, 29, 14, 48, 7, 788, DateTimeKind.Local).AddTicks(9503), "Question needs to be approved", null, false },
                    { 2, new DateTime(2022, 7, 29, 14, 48, 7, 788, DateTimeKind.Local).AddTicks(9510), "A student answered a question", null, true },
                    { 3, new DateTime(2022, 7, 29, 14, 48, 7, 788, DateTimeKind.Local).AddTicks(9513), "Your qustion was aproved", null, true }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "QuestionName", "SurveyId", "Type" },
                values: new object[,]
                {
                    { 1, "5", "Please rate this class.", null, "Rating" },
                    { 2, "I really liked the fact that this class focused more on the quality of code than the quantity", "What is something you liked about this class?", null, "Text" },
                    { 3, "I really liked the fact that this class focused more on the quality of code than the quantity.", "What is something you liked about this class?", null, "Text" },
                    { 4, "I don't feel like there are improvements needed.", "What is something that we can improve about this class?", null, "Text" }
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "Class", "Date", "ExpirationDate", "Likes", "Professor", "Rating", "Subject" },
                values: new object[,]
                {
                    { 1, "I", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 34, "Alex", 5, "Mate" },
                    { 2, "II", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 23, "Cosmin", 4, "Mate" },
                    { 3, "II", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 23, "Cosmin", 4, "Info" }
                });

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
