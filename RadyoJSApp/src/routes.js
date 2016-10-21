import React from 'react';
import  {Route, IndexRoute} from 'react-router';
import App from './pages/app';
import HomePage from './pages/HomePage/index';

export default (
    <Route path="/" component={App}>
        <IndexRoute component={HomePage}/>
        <Route path="about" component={HomePage}/>
    </Route>
);
