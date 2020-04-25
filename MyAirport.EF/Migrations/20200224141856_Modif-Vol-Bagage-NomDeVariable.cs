using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KB.MyAirport.EF.Migrations
{
    public partial class ModifVolBagageNomDeVariable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vols",
                table: "Vols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bagages",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "ID_VOL",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "JEX",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "ID_BAGAGE",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "CODE_IATA",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DATE_CREATION",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "ID_VOL",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "PKG",
                table: "Vols",
                newName: "Pkg");

            migrationBuilder.RenameColumn(
                name: "PAX",
                table: "Vols",
                newName: "Pax");

            migrationBuilder.RenameColumn(
                name: "LIG",
                table: "Vols",
                newName: "Lig");

            migrationBuilder.RenameColumn(
                name: "IMM",
                table: "Vols",
                newName: "Imm");

            migrationBuilder.RenameColumn(
                name: "DHC",
                table: "Vols",
                newName: "Dhc");

            migrationBuilder.RenameColumn(
                name: "DES",
                table: "Vols",
                newName: "Des");

            migrationBuilder.RenameColumn(
                name: "CIE",
                table: "Vols",
                newName: "Cie");

            migrationBuilder.RenameColumn(
                name: "STA",
                table: "Bagages",
                newName: "Sta");

            migrationBuilder.RenameColumn(
                name: "SSUR",
                table: "Bagages",
                newName: "Ssur");

            migrationBuilder.RenameColumn(
                name: "PRIORITAIRE",
                table: "Bagages",
                newName: "Prioritaire");

            migrationBuilder.RenameColumn(
                name: "ESCALE",
                table: "Bagages",
                newName: "Escale");

            migrationBuilder.RenameColumn(
                name: "DESTINATION",
                table: "Bagages",
                newName: "Destination");

            migrationBuilder.RenameColumn(
                name: "CLASSE",
                table: "Bagages",
                newName: "Classe");

            migrationBuilder.AlterColumn<string>(
                name: "Cie",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VoldID",
                table: "Vols",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BagageID",
                table: "Bagages",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CodeIata",
                table: "Bagages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "Bagages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VolID",
                table: "Bagages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vols",
                table: "Vols",
                column: "VoldID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bagages",
                table: "Bagages",
                column: "BagageID");

            migrationBuilder.CreateIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages",
                column: "VolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VoldID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vols",
                table: "Vols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bagages",
                table: "Bagages");

            migrationBuilder.DropIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "VoldID",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "BagageID",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "CodeIata",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "VolID",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "Pkg",
                table: "Vols",
                newName: "PKG");

            migrationBuilder.RenameColumn(
                name: "Pax",
                table: "Vols",
                newName: "PAX");

            migrationBuilder.RenameColumn(
                name: "Lig",
                table: "Vols",
                newName: "LIG");

            migrationBuilder.RenameColumn(
                name: "Imm",
                table: "Vols",
                newName: "IMM");

            migrationBuilder.RenameColumn(
                name: "Dhc",
                table: "Vols",
                newName: "DHC");

            migrationBuilder.RenameColumn(
                name: "Des",
                table: "Vols",
                newName: "DES");

            migrationBuilder.RenameColumn(
                name: "Cie",
                table: "Vols",
                newName: "CIE");

            migrationBuilder.RenameColumn(
                name: "Sta",
                table: "Bagages",
                newName: "STA");

            migrationBuilder.RenameColumn(
                name: "Ssur",
                table: "Bagages",
                newName: "SSUR");

            migrationBuilder.RenameColumn(
                name: "Prioritaire",
                table: "Bagages",
                newName: "PRIORITAIRE");

            migrationBuilder.RenameColumn(
                name: "Escale",
                table: "Bagages",
                newName: "ESCALE");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "Bagages",
                newName: "DESTINATION");

            migrationBuilder.RenameColumn(
                name: "Classe",
                table: "Bagages",
                newName: "CLASSE");

            migrationBuilder.AlterColumn<int>(
                name: "CIE",
                table: "Vols",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_VOL",
                table: "Vols",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<short>(
                name: "JEX",
                table: "Vols",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "ID_BAGAGE",
                table: "Bagages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CODE_IATA",
                table: "Bagages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATION",
                table: "Bagages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ID_VOL",
                table: "Bagages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vols",
                table: "Vols",
                column: "ID_VOL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bagages",
                table: "Bagages",
                column: "ID_BAGAGE");
        }
    }
}
