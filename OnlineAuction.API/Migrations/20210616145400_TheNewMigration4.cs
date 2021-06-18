using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAuction.API.Migrations
{
    public partial class TheNewMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Questions_ResponseId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Responses");

            migrationBuilder.AlterColumn<string>(
                name: "Formulation",
                table: "Responses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ResponseId",
                table: "Questions",
                column: "ResponseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Questions_ResponseId",
                table: "Questions");

            migrationBuilder.AlterColumn<long>(
                name: "Formulation",
                table: "Responses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "QuestionId",
                table: "Responses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ResponseId",
                table: "Questions",
                column: "ResponseId",
                unique: true);
        }
    }
}
