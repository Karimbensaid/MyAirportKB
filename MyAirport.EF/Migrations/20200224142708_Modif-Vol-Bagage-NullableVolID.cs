using Microsoft.EntityFrameworkCore.Migrations;

namespace KB.MyAirport.EF.Migrations
{
    public partial class ModifVolBagageNullableVolID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages");

            migrationBuilder.AlterColumn<int>(
                name: "VolID",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VoldID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages");

            migrationBuilder.AlterColumn<int>(
                name: "VolID",
                table: "Bagages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VoldID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
