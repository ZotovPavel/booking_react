import React from 'react';

class HotelForm extends React.Component{
    constructor(props){
      super(props);
      this.state = {
        hotelName: '',
        city: '',
        raiting: ''
      };
      this.handleHotelNameChange = this.handleHotelNameChange.bind(this);
      this.handleCityChange = this.handleCityChange.bind(this);
      this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleHotelNameChange(e){
      this.setState({hotelName: e.target.value});
    }
    handleCityChange(e){
      this.setState({city: e.target.value})
    }
    handleSubmit(e){
      e.preventDefault();
          const hotelName = this.state.hotelName.trim();
          const city = this.state.city.trim();
          if(!hotelName || !city){
              return;
          }
          this.props.onHotelSubmit({ HotelName: hotelName, CityName: city});
          this.setState({ hotelName: '', city: ''});
    }
    render() {
      return (
        <form className="hotelForm" onSubmit={this.handleSubmit}>
          <div>
            <h2>
              Add new hotel
          </h2>
          </div>
          <div>
            <input
              type="text"
              placeholder="Hotel name"
              value={this.state.hotelName}
              onChange={this.handleHotelNameChange}
            />
          </div>
          <div>
            <input
              type="text"
              placeholder="City"
              value={this.state.city}
              onChange={this.handleCityChange}
            />
          </div>
          <input type="submit" value="Post" />
        </form>
      )
    }
  }

  export default HotelForm;