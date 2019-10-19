import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import HotelBox from '../src/components/Admin/Hotels/HotelBox';

export default class App extends Component {
    displayName = App.name

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />            
                <Route path='/counter' component={Counter} />
                <Route path='/fetchdata' component={FetchData} />
                <Route path='/admin' component={() => 
                    <HotelBox getHotelsUrl='api/admin/gethotels'
                    addNewHotelUrl='api/admin/addnewhotel'/>} />
            </Layout>
        );
    }
}
