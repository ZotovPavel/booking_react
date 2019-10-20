using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.BL.Services;
using Booking.Common.Interface;
using Booking.Common.Models;
using Booking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booking_react.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        #region Default methods. May look later
        // GET: api/Admin
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Admin/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Admin
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion

        #region Private fields
        private HotelService _hotelService;
        private IDataRepository<Hotel> _hotelRepository;
        #endregion

        public static List<HotelModel> _hotelsOnServer = new List<HotelModel>()
        {
            new HotelModel()
            {
                HotelId = 1,
                HotelName = "Hotel_1",
                CityId = 1,
                CityName = "City_1",
                HotelCoordinates = "00 00 00",
                RaitingId = 1,
                RaitingDescription = "1 star"
            },
            new HotelModel()
            {
                HotelId = 2,
                HotelName = "Hotel_2",
                CityId = 2,
                CityName = "City_2",
                HotelCoordinates = "00 00 00",
                RaitingId = 2,
                RaitingDescription = "2 star"
            },
        };
        #region Public constructors
        public AdminController()
        {
           
        }
        #endregion

        #region Public methods
        public HotelModel Hotel()
        {
            return _hotelsOnServer.First();
            //return View(_hotelRepository.GetAll().ToList().Select(e => new HotelModel()
            //{
            //    HotelId = e.ID,
            //    HotelName = e.Name,
            //    CityId = e.CityID,
            //    CityName = e.City.Name,
            //    HotelCoordinates = e.Coordinates,
            //    RaitingId = e.RaitingID,
            //    RaitingDescription = e.Raiting.Description
            //})
            //);
        }
        
        [HttpGet]
        public IEnumerable<HotelModel> GetHotels()
        {                   
            return _hotelsOnServer;
            //return Json(_hotelRepository.GetAll().ToList().Select(e => new HotelModel()
            //{
            //    HotelId = e.ID,
            //    HotelName = e.Name,
            //    CityId = e.CityID,
            //    CityName = e.City.Name,
            //    HotelCoordinates = e.Coordinates,
            //    RaitingId = e.RaitingID,
            //    RaitingDescription = e.Raiting.Description
            //})
            //);
        }

        [HttpPost]
        public void AddNewHotel([FromBody] HotelModel newHotel)
        {
            var hotelName = newHotel.HotelName;
            var cityName = newHotel.CityName;
            _hotelsOnServer.Add(newHotel);
        }
        #endregion
    }
}
