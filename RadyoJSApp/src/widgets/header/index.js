import React, {Component} from 'react';
import {Navbar, Nav, NavItem} from 'react-bootstrap';

class Header extends Component {
    render() {
        return (
            <Navbar>
                <Navbar.Header>
                    <Navbar.Brand>
                        <a href="#">Radyo</a>
                    </Navbar.Brand>
                </Navbar.Header>
                <Nav>
                    <NavItem eventKey={1} href="/">Ana Sayfa</NavItem>
                    <NavItem eventKey={2} href="/about">About</NavItem>
                </Nav>
            </Navbar>

        );
    }
}

export default Header;