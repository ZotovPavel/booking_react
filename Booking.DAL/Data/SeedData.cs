using System;
using System.Collections.Generic;
using System.Text;
using Booking.Common.Models;

namespace Booking.DAL.Data
{
    public class SeedData
    {
        static public List<Country> GetCountries()
        {
            var countriesList = new List<Country>();

            countriesList.Add(new Country() { ID = 1, Name = "Sudan" });
            countriesList.Add(new Country() { ID = 2, Name = "Gabon" });
            countriesList.Add(new Country() { ID = 3, Name = "Korea" });
            countriesList.Add(new Country() { ID = 4, Name = "Guinea-Bissau" });
            countriesList.Add(new Country() { ID = 5, Name = "China" });
            countriesList.Add(new Country() { ID = 6, Name = "Somalia" });
            countriesList.Add(new Country() { ID = 7, Name = "Angola" });
            countriesList.Add(new Country() { ID = 8, Name = "Nigeria" });
            countriesList.Add(new Country() { ID = 9, Name = "Canada" });
            countriesList.Add(new Country() { ID = 10, Name = "Botswana" });
            countriesList.Add(new Country() { ID = 11, Name = "Lithuania" });
            countriesList.Add(new Country() { ID = 12, Name = "Iceland" });
            countriesList.Add(new Country() { ID = 13, Name = "Guinea" });
            countriesList.Add(new Country() { ID = 14, Name = "Chad" });
            countriesList.Add(new Country() { ID = 15, Name = "Mali" });
            countriesList.Add(new Country() { ID = 16, Name = "Tanzania" });
            countriesList.Add(new Country() { ID = 17, Name = "Central African Republic" });
            countriesList.Add(new Country() { ID = 18, Name = "Colombia" });
            countriesList.Add(new Country() { ID = 19, Name = "Guatemala" });
            countriesList.Add(new Country() { ID = 20, Name = "Equatorial Guinea" });
            countriesList.Add(new Country() { ID = 21, Name = "Oman" });
            countriesList.Add(new Country() { ID = 22, Name = "Gambia" });
            countriesList.Add(new Country() { ID = 23, Name = "Libya" });
            countriesList.Add(new Country() { ID = 24, Name = "Zimbabwe" });
            countriesList.Add(new Country() { ID = 25, Name = "Malawi" });
            countriesList.Add(new Country() { ID = 26, Name = "Ethiopia" });
            countriesList.Add(new Country() { ID = 27, Name = "Pakistan" });
            countriesList.Add(new Country() { ID = 28, Name = "Senegal" });
            countriesList.Add(new Country() { ID = 29, Name = "New Zealand" });
            countriesList.Add(new Country() { ID = 30, Name = "Ghana" });
            countriesList.Add(new Country() { ID = 31, Name = "Argentina" });
            countriesList.Add(new Country() { ID = 32, Name = "Philippines" });
            countriesList.Add(new Country() { ID = 33, Name = "Cameroon" });
            countriesList.Add(new Country() { ID = 34, Name = "Mauritania" });
            countriesList.Add(new Country() { ID = 35, Name = "Iraq" });
            countriesList.Add(new Country() { ID = 36, Name = "Malta" });
            countriesList.Add(new Country() { ID = 37, Name = "Mozambique" });
            countriesList.Add(new Country() { ID = 38, Name = "Syria" });
            countriesList.Add(new Country() { ID = 39, Name = "Benin" });
            countriesList.Add(new Country() { ID = 40, Name = "Israel" });
            countriesList.Add(new Country() { ID = 41, Name = "Bosnia and Herzegovina" });
            countriesList.Add(new Country() { ID = 42, Name = "Estonia" });
            countriesList.Add(new Country() { ID = 43, Name = "Lesotho" });
            countriesList.Add(new Country() { ID = 44, Name = "United Arab Emirates" });
            countriesList.Add(new Country() { ID = 45, Name = "Austria" });
            countriesList.Add(new Country() { ID = 46, Name = "Belgium" });
            countriesList.Add(new Country() { ID = 47, Name = "Bulgaria" });
            countriesList.Add(new Country() { ID = 48, Name = "Switzerland" });
            countriesList.Add(new Country() { ID = 49, Name = "Serbia" });
            countriesList.Add(new Country() { ID = 50, Name = "Czech Republic" });
            countriesList.Add(new Country() { ID = 51, Name = "Germany" });
            countriesList.Add(new Country() { ID = 52, Name = "Denmark" });
            countriesList.Add(new Country() { ID = 53, Name = "Spain" });
            countriesList.Add(new Country() { ID = 54, Name = "Finland" });
            countriesList.Add(new Country() { ID = 55, Name = "France" });
            countriesList.Add(new Country() { ID = 56, Name = "United Kingdom" });
            countriesList.Add(new Country() { ID = 57, Name = "Greece" });
            countriesList.Add(new Country() { ID = 58, Name = "Hong Kong" });
            countriesList.Add(new Country() { ID = 59, Name = "Croatia" });
            countriesList.Add(new Country() { ID = 60, Name = "Hungary" });
            countriesList.Add(new Country() { ID = 61, Name = "Ireland" });
            countriesList.Add(new Country() { ID = 62, Name = "India" });
            countriesList.Add(new Country() { ID = 63, Name = "Italy" });
            countriesList.Add(new Country() { ID = 64, Name = "Japan" });
            countriesList.Add(new Country() { ID = 65, Name = "Kazakhstan" });
            countriesList.Add(new Country() { ID = 66, Name = "Luxembourg" });
            countriesList.Add(new Country() { ID = 67, Name = "Morocco" });
            countriesList.Add(new Country() { ID = 68, Name = "Netherlands" });
            countriesList.Add(new Country() { ID = 69, Name = "Norway" });
            countriesList.Add(new Country() { ID = 70, Name = "Poland" });
            countriesList.Add(new Country() { ID = 71, Name = "Portugal" });
            countriesList.Add(new Country() { ID = 72, Name = "Romania" });
            countriesList.Add(new Country() { ID = 73, Name = "Russian Federation" });
            countriesList.Add(new Country() { ID = 74, Name = "Sweden" });
            countriesList.Add(new Country() { ID = 75, Name = "Singapore" });
            countriesList.Add(new Country() { ID = 76, Name = "Slovenia" });
            countriesList.Add(new Country() { ID = 77, Name = "Slovakia" });
            countriesList.Add(new Country() { ID = 78, Name = "Tunisia" });
            countriesList.Add(new Country() { ID = 79, Name = "Turkey" });
            countriesList.Add(new Country() { ID = 80, Name = "Taiwan" });
            countriesList.Add(new Country() { ID = 81, Name = "Ukraine" });
            countriesList.Add(new Country() { ID = 82, Name = "United States" });
            countriesList.Add(new Country() { ID = 83, Name = "Uzbekistan" });
            countriesList.Add(new Country() { ID = 84, Name = "South Africa" });
            countriesList.Add(new Country() { ID = 85, Name = "Egypt" });
            countriesList.Add(new Country() { ID = 86, Name = "Mexico" });
            countriesList.Add(new Country() { ID = 87, Name = "Brazil" });
            countriesList.Add(new Country() { ID = 88, Name = "Lebanon" });
            countriesList.Add(new Country() { ID = 89, Name = "Kuwait" });
            countriesList.Add(new Country() { ID = 90, Name = "Uruguay" });
            countriesList.Add(new Country() { ID = 91, Name = "Sierra Leone" });
            countriesList.Add(new Country() { ID = 92, Name = "Togo" });
            countriesList.Add(new Country() { ID = 93, Name = "Rwanda" });
            countriesList.Add(new Country() { ID = 94, Name = "Burundi" });
            countriesList.Add(new Country() { ID = 95, Name = "Saudi Arabia" });
            countriesList.Add(new Country() { ID = 96, Name = "Yemen" });
            countriesList.Add(new Country() { ID = 97, Name = "Albania" });
            countriesList.Add(new Country() { ID = 98, Name = "Ivory Coast" });
            countriesList.Add(new Country() { ID = 99, Name = "Kirkistan" });
            countriesList.Add(new Country() { ID = 100, Name = "Western Sahara" });
            countriesList.Add(new Country() { ID = 101, Name = "Kenya" });
            countriesList.Add(new Country() { ID = 102, Name = "Eritrea" });
            countriesList.Add(new Country() { ID = 103, Name = "Bahrain" });
            countriesList.Add(new Country() { ID = 104, Name = "Uganda" });
            countriesList.Add(new Country() { ID = 105, Name = "Madagascar" });
            countriesList.Add(new Country() { ID = 106, Name = "Republic of Macedonia" });
            countriesList.Add(new Country() { ID = 107, Name = "Burkina Faso" });
            countriesList.Add(new Country() { ID = 108, Name = "Afghanistan" });
            countriesList.Add(new Country() { ID = 109, Name = "Zambia" });
            countriesList.Add(new Country() { ID = 110, Name = "Swaziland" });
            countriesList.Add(new Country() { ID = 111, Name = "Algeria" });
            countriesList.Add(new Country() { ID = 112, Name = "Niger" });
            countriesList.Add(new Country() { ID = 113, Name = "Qatar" });
            countriesList.Add(new Country() { ID = 114, Name = "Palestine" });
            countriesList.Add(new Country() { ID = 115, Name = "Chile" });
            countriesList.Add(new Country() { ID = 116, Name = "Jordan" });
            countriesList.Add(new Country() { ID = 117, Name = "Iran" });
            countriesList.Add(new Country() { ID = 118, Name = "Australia" });
            countriesList.Add(new Country() { ID = 119, Name = "Liberia" });
            countriesList.Add(new Country() { ID = 120, Name = "Latvia" });

            return countriesList;
        }

        static public List<City> GetCities()
        {
            var citiesList = new List<City>();

            citiesList.Add(new City() { ID = 1, Name = "City_Sudan", CountryID = 1 });
            citiesList.Add(new City() { ID = 2, Name = "City_Gabon", CountryID = 2 });
            citiesList.Add(new City() { ID = 3, Name = "City_Korea", CountryID = 3 });
            citiesList.Add(new City() { ID = 4, Name = "City_Guinea-Bissau", CountryID = 4 });
            citiesList.Add(new City() { ID = 5, Name = "City_China", CountryID = 5 });
            citiesList.Add(new City() { ID = 6, Name = "City_Somalia", CountryID = 6 });
            citiesList.Add(new City() { ID = 7, Name = "City_Angola", CountryID = 7 });
            citiesList.Add(new City() { ID = 8, Name = "City_Nigeria", CountryID = 8 });
            citiesList.Add(new City() { ID = 9, Name = "City_Canada", CountryID = 9 });
            citiesList.Add(new City() { ID = 10, Name = "City_Botswana", CountryID = 10 });
            citiesList.Add(new City() { ID = 11, Name = "City_Lithuania", CountryID = 11 });
            citiesList.Add(new City() { ID = 12, Name = "City_Iceland", CountryID = 12 });
            citiesList.Add(new City() { ID = 13, Name = "City_Guinea", CountryID = 13 });
            citiesList.Add(new City() { ID = 14, Name = "City_Chad", CountryID = 14 });
            citiesList.Add(new City() { ID = 15, Name = "City_Mali", CountryID = 15 });
            citiesList.Add(new City() { ID = 16, Name = "City_Tanzania", CountryID = 16 });
            citiesList.Add(new City() { ID = 17, Name = "City_Central African Republic", CountryID = 17 });
            citiesList.Add(new City() { ID = 18, Name = "City_Colombia", CountryID = 18 });
            citiesList.Add(new City() { ID = 19, Name = "City_Guatemala", CountryID = 19 });
            citiesList.Add(new City() { ID = 20, Name = "City_Equatorial Guinea", CountryID = 20 });
            citiesList.Add(new City() { ID = 21, Name = "City_Oman", CountryID = 21 });
            citiesList.Add(new City() { ID = 22, Name = "City_Gambia", CountryID = 22 });
            citiesList.Add(new City() { ID = 23, Name = "City_Libya", CountryID = 23 });
            citiesList.Add(new City() { ID = 24, Name = "City_Zimbabwe", CountryID = 24 });
            citiesList.Add(new City() { ID = 25, Name = "City_Malawi", CountryID = 25 });
            citiesList.Add(new City() { ID = 26, Name = "City_Ethiopia", CountryID = 26 });
            citiesList.Add(new City() { ID = 27, Name = "City_Pakistan", CountryID = 27 });
            citiesList.Add(new City() { ID = 28, Name = "City_Senegal", CountryID = 28 });
            citiesList.Add(new City() { ID = 29, Name = "City_New Zealand", CountryID = 29 });
            citiesList.Add(new City() { ID = 30, Name = "City_Ghana", CountryID = 30 });
            citiesList.Add(new City() { ID = 31, Name = "City_Argentina", CountryID = 31 });
            citiesList.Add(new City() { ID = 32, Name = "City_Philippines", CountryID = 32 });
            citiesList.Add(new City() { ID = 33, Name = "City_Cameroon", CountryID = 33 });
            citiesList.Add(new City() { ID = 34, Name = "City_Mauritania", CountryID = 34 });
            citiesList.Add(new City() { ID = 35, Name = "City_Iraq", CountryID = 35 });
            citiesList.Add(new City() { ID = 36, Name = "City_Malta", CountryID = 36 });
            citiesList.Add(new City() { ID = 37, Name = "City_Mozambique", CountryID = 37 });
            citiesList.Add(new City() { ID = 38, Name = "City_Syria", CountryID = 38 });
            citiesList.Add(new City() { ID = 39, Name = "City_Benin", CountryID = 39 });
            citiesList.Add(new City() { ID = 40, Name = "City_Israel", CountryID = 40 });
            citiesList.Add(new City() { ID = 41, Name = "City_Bosnia and Herzegovina", CountryID = 41 });
            citiesList.Add(new City() { ID = 42, Name = "City_Estonia", CountryID = 42 });
            citiesList.Add(new City() { ID = 43, Name = "City_Lesotho", CountryID = 43 });
            citiesList.Add(new City() { ID = 44, Name = "City_United Arab Emirates", CountryID = 44 });
            citiesList.Add(new City() { ID = 45, Name = "City_Austria", CountryID = 45 });
            citiesList.Add(new City() { ID = 46, Name = "City_Belgium", CountryID = 46 });
            citiesList.Add(new City() { ID = 47, Name = "City_Bulgaria", CountryID = 47 });
            citiesList.Add(new City() { ID = 48, Name = "City_Switzerland", CountryID = 48 });
            citiesList.Add(new City() { ID = 49, Name = "City_Serbia", CountryID = 49 });
            citiesList.Add(new City() { ID = 50, Name = "City_Czech Republic", CountryID = 50 });
            citiesList.Add(new City() { ID = 51, Name = "City_Germany", CountryID = 51 });
            citiesList.Add(new City() { ID = 52, Name = "City_Denmark", CountryID = 52 });
            citiesList.Add(new City() { ID = 53, Name = "City_Spain", CountryID = 53 });
            citiesList.Add(new City() { ID = 54, Name = "City_Finland", CountryID = 54 });
            citiesList.Add(new City() { ID = 55, Name = "City_France", CountryID = 55 });
            citiesList.Add(new City() { ID = 56, Name = "City_United Kingdom", CountryID = 56 });
            citiesList.Add(new City() { ID = 57, Name = "City_Greece", CountryID = 57 });
            citiesList.Add(new City() { ID = 58, Name = "City_Hong Kong", CountryID = 58 });
            citiesList.Add(new City() { ID = 59, Name = "City_Croatia", CountryID = 59 });
            citiesList.Add(new City() { ID = 60, Name = "City_Hungary", CountryID = 60 });
            citiesList.Add(new City() { ID = 61, Name = "City_Ireland", CountryID = 61 });
            citiesList.Add(new City() { ID = 62, Name = "City_India", CountryID = 62 });
            citiesList.Add(new City() { ID = 63, Name = "City_Italy", CountryID = 63 });
            citiesList.Add(new City() { ID = 64, Name = "City_Japan", CountryID = 64 });
            citiesList.Add(new City() { ID = 65, Name = "City_Kazakhstan", CountryID = 65 });
            citiesList.Add(new City() { ID = 66, Name = "City_Luxembourg", CountryID = 66 });
            citiesList.Add(new City() { ID = 67, Name = "City_Morocco", CountryID = 67 });
            citiesList.Add(new City() { ID = 68, Name = "City_Netherlands", CountryID = 68 });
            citiesList.Add(new City() { ID = 69, Name = "City_Norway", CountryID = 69 });
            citiesList.Add(new City() { ID = 70, Name = "City_Poland", CountryID = 70 });
            citiesList.Add(new City() { ID = 71, Name = "City_Portugal", CountryID = 71 });
            citiesList.Add(new City() { ID = 72, Name = "City_Romania", CountryID = 72 });
            citiesList.Add(new City() { ID = 73, Name = "City_Russian Federation", CountryID = 73 });
            citiesList.Add(new City() { ID = 74, Name = "City_Sweden", CountryID = 74 });
            citiesList.Add(new City() { ID = 75, Name = "City_Singapore", CountryID = 75 });
            citiesList.Add(new City() { ID = 76, Name = "City_Slovenia", CountryID = 76 });
            citiesList.Add(new City() { ID = 77, Name = "City_Slovakia", CountryID = 77 });
            citiesList.Add(new City() { ID = 78, Name = "City_Tunisia", CountryID = 78 });
            citiesList.Add(new City() { ID = 79, Name = "City_Turkey", CountryID = 79 });
            citiesList.Add(new City() { ID = 80, Name = "City_Taiwan", CountryID = 80 });
            citiesList.Add(new City() { ID = 81, Name = "City_Ukraine", CountryID = 81 });
            citiesList.Add(new City() { ID = 82, Name = "City_United States", CountryID = 82 });
            citiesList.Add(new City() { ID = 83, Name = "City_Uzbekistan", CountryID = 83 });
            citiesList.Add(new City() { ID = 84, Name = "City_South Africa", CountryID = 84 });
            citiesList.Add(new City() { ID = 85, Name = "City_Egypt", CountryID = 85 });
            citiesList.Add(new City() { ID = 86, Name = "City_Mexico", CountryID = 86 });
            citiesList.Add(new City() { ID = 87, Name = "City_Brazil", CountryID = 87 });
            citiesList.Add(new City() { ID = 88, Name = "City_Lebanon", CountryID = 88 });
            citiesList.Add(new City() { ID = 89, Name = "City_Kuwait", CountryID = 89 });
            citiesList.Add(new City() { ID = 90, Name = "City_Uruguay", CountryID = 90 });
            citiesList.Add(new City() { ID = 91, Name = "City_Sierra Leone", CountryID = 91 });
            citiesList.Add(new City() { ID = 92, Name = "City_Togo", CountryID = 92 });
            citiesList.Add(new City() { ID = 93, Name = "City_Rwanda", CountryID = 93 });
            citiesList.Add(new City() { ID = 94, Name = "City_Burundi", CountryID = 94 });
            citiesList.Add(new City() { ID = 95, Name = "City_Saudi Arabia", CountryID = 95 });
            citiesList.Add(new City() { ID = 96, Name = "City_Yemen", CountryID = 96 });
            citiesList.Add(new City() { ID = 97, Name = "City_Albania", CountryID = 97 });
            citiesList.Add(new City() { ID = 98, Name = "City_Ivory Coast", CountryID = 98 });
            citiesList.Add(new City() { ID = 99, Name = "City_Kirkistan", CountryID = 99 });
            citiesList.Add(new City() { ID = 100, Name = "City_Western Sahara", CountryID = 100 });
            citiesList.Add(new City() { ID = 101, Name = "City_Kenya", CountryID = 101 });
            citiesList.Add(new City() { ID = 102, Name = "City_Eritrea", CountryID = 102 });
            citiesList.Add(new City() { ID = 103, Name = "City_Bahrain", CountryID = 103 });
            citiesList.Add(new City() { ID = 104, Name = "City_Uganda", CountryID = 104 });
            citiesList.Add(new City() { ID = 105, Name = "City_Madagascar", CountryID = 105 });
            citiesList.Add(new City() { ID = 106, Name = "City_Republic of Macedonia", CountryID = 106 });
            citiesList.Add(new City() { ID = 107, Name = "City_Burkina Faso", CountryID = 107 });
            citiesList.Add(new City() { ID = 108, Name = "City_Afghanistan", CountryID = 108 });
            citiesList.Add(new City() { ID = 109, Name = "City_Zambia", CountryID = 109 });
            citiesList.Add(new City() { ID = 110, Name = "City_Swaziland", CountryID = 110 });
            citiesList.Add(new City() { ID = 111, Name = "City_Algeria", CountryID = 111 });
            citiesList.Add(new City() { ID = 112, Name = "City_Niger", CountryID = 112 });
            citiesList.Add(new City() { ID = 113, Name = "City_Qatar", CountryID = 113 });
            citiesList.Add(new City() { ID = 114, Name = "City_Palestine", CountryID = 114 });
            citiesList.Add(new City() { ID = 115, Name = "City_Chile", CountryID = 115 });
            citiesList.Add(new City() { ID = 116, Name = "City_Jordan", CountryID = 116 });
            citiesList.Add(new City() { ID = 117, Name = "City_Iran", CountryID = 117 });
            citiesList.Add(new City() { ID = 118, Name = "City_Australia", CountryID = 118 });
            citiesList.Add(new City() { ID = 119, Name = "City_Liberia", CountryID = 119 });
            citiesList.Add(new City() { ID = 120, Name = "City_Latvia", CountryID = 120 });

            return citiesList;
        }

        static public List<Raiting> GetRaitings()
        {
            var raitingsList = new List<Raiting>();

            raitingsList.Add(new Raiting() { ID = 1, Description = "1 star" });
            raitingsList.Add(new Raiting() { ID = 2, Description = "2 star" });
            raitingsList.Add(new Raiting() { ID = 3, Description = "3 star" });
            raitingsList.Add(new Raiting() { ID = 4, Description = "4 star" });
            raitingsList.Add(new Raiting() { ID = 5, Description = "5 star" });

            return raitingsList;
        }

        static public List<Hotel> GetHotels()
        {
            var hotelsList = new List<Hotel>();

            hotelsList.Add(new Hotel() { ID = 1, Name = "Hotel_1 star", CityID = 1, Coordinates = " ", RaitingID = 1 });
            hotelsList.Add(new Hotel() { ID = 2, Name = "Hotel_2 star", CityID = 2, Coordinates = " ", RaitingID = 2 });
            hotelsList.Add(new Hotel() { ID = 3, Name = "Hotel_3 star", CityID = 3, Coordinates = " ", RaitingID = 3 });
            hotelsList.Add(new Hotel() { ID = 4, Name = "Hotel_4 star", CityID = 4, Coordinates = " ", RaitingID = 4 });
            hotelsList.Add(new Hotel() { ID = 5, Name = "Hotel_5 star", CityID = 5, Coordinates = " ", RaitingID = 5 });

            return hotelsList;
        }

        static public List<Role> GetRoles()
        {
            var rolesList = new List<Role>();

            rolesList.Add(new Role() { ID = 1, Description = "User" });
            rolesList.Add(new Role() { ID = 2, Description = "Administrator" });

            return rolesList;
        }

        static public List<User> GetUsers()
        {
            var usersList = new List<User>();

            usersList.Add(new User() { ID = 1, FirstName = "FirstName1", LastName = "LastName1", Email = "email1@gmail.com", Passport = "11 11 111111", RoleID = 1 });
            usersList.Add(new User() { ID = 2, FirstName = "FirstName2", LastName = "LastName2", Email = "email2@gmail.com", Passport = "22 22 222222", RoleID = 1 });
            usersList.Add(new User() { ID = 3, FirstName = "FirstName3", LastName = "LastName3", Email = "email3@gmail.com", Passport = "33 33 333333", RoleID = 1 });
            usersList.Add(new User() { ID = 4, FirstName = "John", LastName = "Doe", Email = "john.doe@gmail.com", Passport = "44 44 444444", RoleID = 2 });

            return usersList;
        }
    }
}
