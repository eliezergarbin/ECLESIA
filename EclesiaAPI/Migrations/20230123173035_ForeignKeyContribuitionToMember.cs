using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EclesiaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyContribuitionToMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributions_Members_MemberId",
                table: "Contributions");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Contributions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contributions_Members_MemberId",
                table: "Contributions",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributions_Members_MemberId",
                table: "Contributions");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Contributions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contributions_Members_MemberId",
                table: "Contributions",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id");
        }
    }
}
