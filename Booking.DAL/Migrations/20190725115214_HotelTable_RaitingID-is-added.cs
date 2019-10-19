using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.DAL.Migrations
{
    public partial class HotelTable_RaitingIDisadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Raiting_RaitingID",
                table: "Hotel");

            migrationBuilder.AlterColumn<int>(
                name: "RaitingID",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Raiting_RaitingID",
                table: "Hotel",
                column: "RaitingID",
                principalTable: "Raiting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Raiting_RaitingID",
                table: "Hotel");

            migrationBuilder.AlterColumn<int>(
                name: "RaitingID",
                table: "Hotel",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Raiting_RaitingID",
                table: "Hotel",
                column: "RaitingID",
                principalTable: "Raiting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
