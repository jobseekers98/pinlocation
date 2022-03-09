using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class h1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City1",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Distance",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District1",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitude1",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude1",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postal1",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateId1",
                table: "tbl_SaveAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "country1",
                table: "tbl_SaveAddress",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address2",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "City1",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "Distance",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "District1",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "Latitude1",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "Longitude1",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "Postal1",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "StateId1",
                table: "tbl_SaveAddress");

            migrationBuilder.DropColumn(
                name: "country1",
                table: "tbl_SaveAddress");
        }
    }
}
