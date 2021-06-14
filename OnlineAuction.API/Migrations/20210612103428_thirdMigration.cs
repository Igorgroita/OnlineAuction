using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAuction.API.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ResponseId",
                table: "Questions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_LotId",
                table: "Questions",
                column: "LotId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ResponseId",
                table: "Questions",
                column: "ResponseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoPaths_LotId",
                table: "PhotoPaths",
                column: "LotId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoPaths_Lots_LotId",
                table: "PhotoPaths",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Lots_LotId",
                table: "Questions",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Responses_ResponseId",
                table: "Questions",
                column: "ResponseId",
                principalTable: "Responses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoPaths_Lots_LotId",
                table: "PhotoPaths");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Lots_LotId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Responses_ResponseId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_LotId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ResponseId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_PhotoPaths_LotId",
                table: "PhotoPaths");

            migrationBuilder.DropColumn(
                name: "ResponseId",
                table: "Questions");
        }
    }
}
