using System;
using System.Collections.Generic;
using System.Text;
using Booking.Common.Interface;
using Booking.Common.Models;
using System.Linq;

namespace Booking.BL.Services
{
    public class HotelService
    {
        #region Private fields
        private IDataRepository<Hotel> _hotelRepository;
        #endregion

        #region Public constructors
        public HotelService(IDataRepository<Hotel> hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        #endregion

        #region Public methods
        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAll().ToList();
        }
        #endregion
    }
}
