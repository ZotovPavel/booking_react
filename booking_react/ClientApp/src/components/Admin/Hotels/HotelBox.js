import React from 'react';
import HotelList from './HotelsList';
import HotelForm from './HotelForm';

class HotelBox extends React.Component {
    constructor(props) {
      super(props);  
      this.state ={
        data: []
      };  
      this.handleHotelSubmit = this.handleHotelSubmit.bind(this);
    }
    loadHotelsFromServer() {
      const xhr = new XMLHttpRequest();
      xhr.open('get', this.props.getHotelsUrl, true);
      xhr.onload = () => {
        const data = JSON.parse(xhr.responseText);
        this.setState({ data: data });
      };
      xhr.send();
    }
    componentDidMount() {
      this.loadHotelsFromServer();
    }
    handleHotelSubmit(hotel){
      const data = new FormData();
      data.append('HotelName', hotel.HotelName);
      data.append('CityName', hotel.CityName);
      const xhr = new XMLHttpRequest();
      xhr.open('post', this.props.addNewHotelUrl, true);
      xhr.onload = () => this.loadHotelsFromServer();
      xhr.send(data);
    }
  
    render() {
      return (
        <div className="hotelBox">
          <h1>List of hotels</h1>
            <HotelList data={this.state.data} />
            <HotelForm onHotelSubmit={this.handleHotelSubmit}/>
        </div>
      )
    }
  }

  export default HotelBox;