using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.DAL.Migrations
{
    public partial class ChangeOfHotelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Country_CountryID",
                table: "Hotel");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "Hotel",
                newName: "CityID");

            migrationBuilder.RenameIndex(
                name: "IX_Hotel_CountryID",
                table: "Hotel",
                newName: "IX_Hotel_CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_City_CityID",
                table: "Hotel",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_City_CityID",
                table: "Hotel");

            migrationBuilder.RenameColumn(
                name: "CityID",
                table: "Hotel",
                newName: "CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_Hotel_CityID",
                table: "Hotel",
                newName: "IX_Hotel_CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Country_CountryID",
                table: "Hotel",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
