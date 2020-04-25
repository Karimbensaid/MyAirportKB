using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KB.MyAirport.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    ID_BAGAGE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_VOL = table.Column<int>(nullable: false),
                    CODE_IATA = table.Column<string>(nullable: true),
                    DATE_CREATION = table.Column<DateTime>(nullable: false),
                    CLASSE = table.Column<string>(nullable: true),
                    PRIORITAIRE = table.Column<bool>(nullable: false),
                    STA = table.Column<string>(nullable: true),
                    SSUR = table.Column<string>(nullable: true),
                    DESTINATION = table.Column<string>(nullable: true),
                    ESCALE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.ID_BAGAGE);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    ID_VOL = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIE = table.Column<int>(nullable: false),
                    LIG = table.Column<string>(nullable: true),
                    JEX = table.Column<short>(nullable: false),
                    DHC = table.Column<DateTime>(nullable: false),
                    PKG = table.Column<string>(nullable: true),
                    IMM = table.Column<string>(nullable: true),
                    PAX = table.Column<short>(nullable: false),
                    DES = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.ID_VOL);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
