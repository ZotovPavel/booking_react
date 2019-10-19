using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.DAL.Migrations
{
    public partial class BookingContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Sudan" },
                    { 89, "Kuwait" },
                    { 88, "Lebanon" },
                    { 87, "Brazil" },
                    { 86, "Mexico" },
                    { 85, "Egypt" },
                    { 84, "South Africa" },
                    { 83, "Uzbekistan" },
                    { 82, "United States" },
                    { 81, "Ukraine" },
                    { 80, "Taiwan" },
                    { 79, "Turkey" },
                    { 78, "Tunisia" },
                    { 90, "Uruguay" },
                    { 77, "Slovakia" },
                    { 75, "Singapore" },
                    { 74, "Sweden" },
                    { 73, "Russian Federation" },
                    { 72, "Romania" },
                    { 71, "Portugal" },
                    { 70, "Poland" },
                    { 69, "Norway" },
                    { 68, "Netherlands" },
                    { 67, "Morocco" },
                    { 66, "Luxembourg" },
                    { 65, "Kazakhstan" },
                    { 63, "Italy" },
                    { 76, "Slovenia" },
                    { 91, "Sierra Leone" },
                    { 92, "Togo" },
                    { 93, "Rwanda" },
                    { 120, "Latvia" },
                    { 119, "Liberia" },
                    { 118, "Australia" },
                    { 117, "Iran" },
                    { 116, "Jordan" },
                    { 115, "Chile" },
                    { 114, "Palestine" },
                    { 113, "Qatar" },
                    { 112, "Niger" },
                    { 111, "Algeria" },
                    { 110, "Swaziland" },
                    { 109, "Zambia" },
                    { 108, "Afghanistan" },
                    { 107, "Burkina Faso" },
                    { 106, "Republic of Macedonia" },
                    { 105, "Madagascar" },
                    { 104, "Uganda" },
                    { 103, "Bahrain" },
                    { 102, "Eritrea" },
                    { 101, "Kenya" },
                    { 100, "Western Sahara" },
                    { 99, "Kirkistan" },
                    { 98, "Ivory Coast" },
                    { 97, "Albania" },
                    { 96, "Yemen" },
                    { 95, "Saudi Arabia" },
                    { 94, "Burundi" },
                    { 62, "India" },
                    { 61, "Ireland" },
                    { 64, "Japan" },
                    { 59, "Croatia" },
                    { 60, "Hungary" },
                    { 27, "Pakistan" },
                    { 26, "Ethiopia" },
                    { 25, "Malawi" },
                    { 24, "Zimbabwe" },
                    { 23, "Libya" },
                    { 22, "Gambia" },
                    { 21, "Oman" },
                    { 20, "Equatorial Guinea" },
                    { 19, "Guatemala" },
                    { 18, "Colombia" },
                    { 17, "Central African Republic" },
                    { 16, "Tanzania" },
                    { 15, "Mali" },
                    { 14, "Chad" },
                    { 13, "Guinea" },
                    { 12, "Iceland" },
                    { 11, "Lithuania" },
                    { 10, "Botswana" },
                    { 9, "Canada" },
                    { 8, "Nigeria" },
                    { 7, "Angola" },
                    { 6, "Somalia" },
                    { 5, "China" },
                    { 4, "Guinea-Bissau" },
                    { 3, "Korea" },
                    { 2, "Gabon" },
                    { 29, "New Zealand" },
                    { 30, "Ghana" },
                    { 28, "Senegal" },
                    { 32, "Philippines" },
                    { 58, "Hong Kong" },
                    { 57, "Greece" },
                    { 56, "United Kingdom" },
                    { 55, "France" },
                    { 54, "Finland" },
                    { 53, "Spain" },
                    { 52, "Denmark" },
                    { 51, "Germany" },
                    { 50, "Czech Republic" },
                    { 31, "Argentina" },
                    { 48, "Switzerland" },
                    { 47, "Bulgaria" },
                    { 46, "Belgium" },
                    { 49, "Serbia" },
                    { 44, "United Arab Emirates" },
                    { 33, "Cameroon" },
                    { 34, "Mauritania" },
                    { 45, "Austria" },
                    { 36, "Malta" },
                    { 37, "Mozambique" },
                    { 35, "Iraq" },
                    { 39, "Benin" },
                    { 40, "Israel" },
                    { 41, "Bosnia and Herzegovina" },
                    { 42, "Estonia" },
                    { 43, "Lesotho" },
                    { 38, "Syria" }
                });

            migrationBuilder.InsertData(
                table: "Raiting",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 1, "1 star" },
                    { 2, "2 star" },
                    { 3, "3 star" },
                    { 4, "4 star" },
                    { 5, "5 star" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "ID", "CountryID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "City_Sudan" },
                    { 89, 89, "City_Kuwait" },
                    { 88, 88, "City_Lebanon" },
                    { 87, 87, "City_Brazil" },
                    { 86, 86, "City_Mexico" },
                    { 85, 85, "City_Egypt" },
                    { 84, 84, "City_South Africa" },
                    { 83, 83, "City_Uzbekistan" },
                    { 82, 82, "City_United States" },
                    { 81, 81, "City_Ukraine" },
                    { 80, 80, "City_Taiwan" },
                    { 79, 79, "City_Turkey" },
                    { 78, 78, "City_Tunisia" },
                    { 90, 90, "City_Uruguay" },
                    { 77, 77, "City_Slovakia" },
                    { 75, 75, "City_Singapore" },
                    { 74, 74, "City_Sweden" },
                    { 73, 73, "City_Russian Federation" },
                    { 72, 72, "City_Romania" },
                    { 71, 71, "City_Portugal" },
                    { 70, 70, "City_Poland" },
                    { 69, 69, "City_Norway" },
                    { 68, 68, "City_Netherlands" },
                    { 67, 67, "City_Morocco" },
                    { 66, 66, "City_Luxembourg" },
                    { 65, 65, "City_Kazakhstan" },
                    { 64, 64, "City_Japan" },
                    { 76, 76, "City_Slovenia" },
                    { 91, 91, "City_Sierra Leone" },
                    { 92, 92, "City_Togo" },
                    { 93, 93, "City_Rwanda" },
                    { 120, 120, "City_Latvia" },
                    { 119, 119, "City_Liberia" },
                    { 118, 118, "City_Australia" },
                    { 117, 117, "City_Iran" },
                    { 116, 116, "City_Jordan" },
                    { 115, 115, "City_Chile" },
                    { 114, 114, "City_Palestine" },
                    { 113, 113, "City_Qatar" },
                    { 112, 112, "City_Niger" },
                    { 111, 111, "City_Algeria" },
                    { 110, 110, "City_Swaziland" },
                    { 109, 109, "City_Zambia" },
                    { 108, 108, "City_Afghanistan" },
                    { 107, 107, "City_Burkina Faso" },
                    { 106, 106, "City_Republic of Macedonia" },
                    { 105, 105, "City_Madagascar" },
                    { 104, 104, "City_Uganda" },
                    { 103, 103, "City_Bahrain" },
                    { 102, 102, "City_Eritrea" },
                    { 101, 101, "City_Kenya" },
                    { 100, 100, "City_Western Sahara" },
                    { 99, 99, "City_Kirkistan" },
                    { 98, 98, "City_Ivory Coast" },
                    { 97, 97, "City_Albania" },
                    { 96, 96, "City_Yemen" },
                    { 95, 95, "City_Saudi Arabia" },
                    { 94, 94, "City_Burundi" },
                    { 63, 63, "City_Italy" },
                    { 61, 61, "City_Ireland" },
                    { 62, 62, "City_India" },
                    { 29, 29, "City_New Zealand" },
                    { 28, 28, "City_Senegal" },
                    { 27, 27, "City_Pakistan" },
                    { 26, 26, "City_Ethiopia" },
                    { 25, 25, "City_Malawi" },
                    { 24, 24, "City_Zimbabwe" },
                    { 23, 23, "City_Libya" },
                    { 22, 22, "City_Gambia" },
                    { 21, 21, "City_Oman" },
                    { 20, 20, "City_Equatorial Guinea" },
                    { 19, 19, "City_Guatemala" },
                    { 18, 18, "City_Colombia" },
                    { 17, 17, "City_Central African Republic" },
                    { 60, 60, "City_Hungary" },
                    { 16, 16, "City_Tanzania" },
                    { 14, 14, "City_Chad" },
                    { 13, 13, "City_Guinea" },
                    { 12, 12, "City_Iceland" },
                    { 11, 11, "City_Lithuania" },
                    { 10, 10, "City_Botswana" },
                    { 9, 9, "City_Canada" },
                    { 8, 8, "City_Nigeria" },
                    { 7, 7, "City_Angola" },
                    { 6, 6, "City_Somalia" },
                    { 5, 5, "City_China" },
                    { 4, 4, "City_Guinea-Bissau" },
                    { 3, 3, "City_Korea" },
                    { 15, 15, "City_Mali" },
                    { 30, 30, "City_Ghana" },
                    { 31, 31, "City_Argentina" },
                    { 32, 32, "City_Philippines" },
                    { 59, 59, "City_Croatia" },
                    { 58, 58, "City_Hong Kong" },
                    { 57, 57, "City_Greece" },
                    { 56, 56, "City_United Kingdom" },
                    { 55, 55, "City_France" },
                    { 54, 54, "City_Finland" },
                    { 53, 53, "City_Spain" },
                    { 52, 52, "City_Denmark" },
                    { 51, 51, "City_Germany" },
                    { 50, 50, "City_Czech Republic" },
                    { 49, 49, "City_Serbia" },
                    { 48, 48, "City_Switzerland" },
                    { 47, 47, "City_Bulgaria" },
                    { 46, 46, "City_Belgium" },
                    { 45, 45, "City_Austria" },
                    { 44, 44, "City_United Arab Emirates" },
                    { 43, 43, "City_Lesotho" },
                    { 42, 42, "City_Estonia" },
                    { 41, 41, "City_Bosnia and Herzegovina" },
                    { 40, 40, "City_Israel" },
                    { 39, 39, "City_Benin" },
                    { 38, 38, "City_Syria" },
                    { 37, 37, "City_Mozambique" },
                    { 36, 36, "City_Malta" },
                    { 35, 35, "City_Iraq" },
                    { 34, 34, "City_Mauritania" },
                    { 33, 33, "City_Cameroon" },
                    { 2, 2, "City_Gabon" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "FirstName", "LastName", "Passport", "RoleID" },
                values: new object[,]
                {
                    { 2, "email2@gmail.com", "FirstName2", "LastName2", "22 22 222222", 1 },
                    { 3, "email3@gmail.com", "FirstName3", "LastName3", "33 33 333333", 1 },
                    { 1, "email1@gmail.com", "FirstName1", "LastName1", "11 11 111111", 1 },
                    { 4, "john.doe@gmail.com", "John", "Doe", "44 44 444444", 2 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "CityID", "Coordinates", "Name", "RaitingID" },
                values: new object[,]
                {
                    { 1, 1, " ", "Hotel_1 star", 1 },
                    { 2, 2, " ", "Hotel_2 star", 2 },
                    { 3, 3, " ", "Hotel_3 star", 3 },
                    { 4, 4, " ", "Hotel_4 star", 4 },
                    { 5, 5, " ", "Hotel_5 star", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Raiting",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Raiting",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Raiting",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Raiting",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Raiting",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
