import React from 'react';

class Hotel extends React.Component {
    render() {
      return (
        <div className="hotel">
          <h2>{this.props.name}</h2>
          {this.props.children}
        </div>
      )
    }
  }

  export default Hotel;