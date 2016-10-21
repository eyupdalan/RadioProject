import React, {PropTypes} from 'react';
import Header from '../widgets/header';
import {Grid, Col, Row} from 'react-bootstrap';

class App extends React.Component {
    render() {
        return (
            <Grid>
                <Row>
                    <Header/>
                </Row>
                <Row>
                    {this.props.children}
                </Row>
            </Grid>
        );
    }
}

App.propTypes = {
    children: PropTypes.object.isRequired
};

export default App;
