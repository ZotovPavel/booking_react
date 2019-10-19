import React from 'react';
import Hotel from './Hotel';

class HotelList extends React.Component {
    render() {
      console.log("Data prop in HotelList");
      console.log(this.props.data);
      const hotels = this.props.data.map(hotel => (
        <Hotel key={hotel.hotelId} name={hotel.hotelName} cityId={hotel.cityId} raitingId={hotel.raitingId}>
          <div>City: {hotel.cityName}</div>
          <div>Hotel Raiting: {hotel.raitingDescription}</div>
          <div>Hotel coordinates: {hotel.hotelCoordinates}</div>
        </Hotel>
      ));
      return (
        <div className="hotelList"> {hotels} </div>
      )
    }
  }

  export default HotelList;