import { useState } from 'react'; 
import './Navigation.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { FcMenu } from "react-icons/fc";
import { 
  Navbar, Nav, Button, Form,
  Offcanvas, Container, Modal,  
} from 'react-bootstrap';

export default function Navigation() {
  const [showModal, setShowModal] = useState(false);

  const handleModal = () => setShowModal(!showModal);

  return (
    <>
      { CreateMenu(handleModal) }
      { CreateModal(showModal, handleModal) }
    </>
  )
}

function CreateMenu(handleModal) {
  return (
    <Container fluid>
      <Navbar expand={false}>
        <Navbar.Toggle> <FcMenu /> </Navbar.Toggle>
    
        <Navbar.Offcanvas placement="start">
          <Offcanvas.Header closeButton>
            <Offcanvas.Title> Menu </Offcanvas.Title>
          </Offcanvas.Header>

          <Offcanvas.Body>
            <Nav className="justify-content-end flex-grow-1 pe-3">
              <Button onClick={handleModal} className="mb-2">Добавить покупку</Button>
              <Button onClick={handleModal} className="mb-2">Добавить продукт</Button>
            </Nav>
          </Offcanvas.Body>

        </Navbar.Offcanvas>
      </Navbar>
    </Container>
  )
}

function CreateModal(showModal, handleModal) {
  return (
    <Modal show={showModal} onHide={handleModal}>
      <Modal.Header closeButton>
        <Modal.Title>Моя форма</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        { CreateForm() }
      </Modal.Body>
    </Modal>
  )
}

function CreateForm() {
  return (
    <Form>
      <Form.Group controlId="formBasicEmail">
        <Form.Label>Email адрес</Form.Label>
        <Form.Control type="email" placeholder="Введите email" />
        <Form.Label>Дата</Form.Label><br />
        <Form.Label>Название продукта</Form.Label><br />
        <Form.Label>Тип продукта</Form.Label><br />
      </Form.Group>

      <div className="text-center">
        <Button variant="primary" type="submit">
          Отправить
        </Button>
      </div>
    </Form>
  )
}
