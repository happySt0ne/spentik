import AddProduct from './AddProduct';
import './Navigation.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { FcMenu } from "react-icons/fc";
import { Navbar, Nav, NavDropdown, Offcanvas, Container } from 'react-bootstrap';
import { useState } from 'react';

export default function Navigation() {

  return (
    <Container className='position-fixed top-0 start-0 w-auto'>
      <Navbar key={false} expand={false}>
      <Navbar.Toggle aria-controls={`offcanvasNavbar-expand-${false}`} >
        <FcMenu />
      </Navbar.Toggle>
      <Navbar.Offcanvas
        id={`offcanvasNavbar-expand-${false}`}
        aria-labelledby={`offcanvasNavbarLabel-expand-${false}`}
        placement="start"
      >
        <Offcanvas.Header closeButton>
          <Offcanvas.Title id={`offcanvasNavbarLabel-expand-${false}`}>
            Menu
          </Offcanvas.Title>
        </Offcanvas.Header>
        <Offcanvas.Body>
          <Nav className="justify-content-end flex-grow-1 pe-3">
            <NavDropdown
              title="Dropdown"
              id={`offcanvasNavbarDropdown-expand-${false}`}
            >
              <NavDropdown.Item href="#action3">Action</NavDropdown.Item>
              <NavDropdown.Item href="#action4">
                Another action
              </NavDropdown.Item>
              <NavDropdown.Item href="#action5">
                Something else here
              </NavDropdown.Item>
            </NavDropdown>
          </Nav>
        </Offcanvas.Body>
      </Navbar.Offcanvas>
    </Navbar>
    </Container>
  )
}
