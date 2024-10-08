import './Navigation.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { FcMenu } from "react-icons/fc";
import { 
  Navbar, Nav, NavDropdown, 
  Offcanvas, Container 
} from 'react-bootstrap';

export default function Navigation() {
  return (
    <Container className='position-fixed top-0 start-0 w-auto'>
      <Navbar expand={false}>
        <Navbar.Toggle> <FcMenu /> </Navbar.Toggle>
    
        <Navbar.Offcanvas placement="start">
          <Offcanvas.Header closeButton>
            <Offcanvas.Title> Menu </Offcanvas.Title>
          </Offcanvas.Header>

          <Offcanvas.Body>
            <Nav className="justify-content-end flex-grow-1 pe-3">
              <NavDropdown title="Dropdown">
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
