import { useState } from 'react'; 
import './Navigation.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { FcMenu } from "react-icons/fc";
import { 
  Navbar, Nav, Button, Form,
  Offcanvas, Container, Modal,  
} from 'react-bootstrap';

export default function Navigation() {
  const [showAddPurchaseModal, setAddPurchaseModal] = useState(false);
  const [showAddProductModal, setAddProductModal] = useState(false);

  const handleAddPurchaseModal = () => setAddPurchaseModal(!showAddPurchaseModal);
  const handleAddProductModal = () => setAddProductModal(!showAddProductModal);

  const menuHandlers = {
    "Purchase": handleAddPurchaseModal,
    "Product": handleAddProductModal,
  }

  return (
    <>
      { CreateMenu(menuHandlers) }
      { AddPurchaseModal(showAddPurchaseModal, menuHandlers) }
      { AddProductModal(showAddProductModal, handleAddProductModal) }
    </>
  )
}

function CreateMenu(menuHandlers) {
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
              <Button 
                variant="outline-dark" 
                onClick={menuHandlers["Purchase"]} 
                className="mb-2">Добавить покупку</Button>
              <Button 
                variant="outline-dark" 
                onClick={menuHandlers["Product"]} 
                className="mb-2">Добавить продукт</Button>
            </Nav>
          </Offcanvas.Body>

        </Navbar.Offcanvas>
      </Navbar>
    </Container>
  )
}

function AddProductModal(showAddPurchaseModal, handleAddProductModal) {
  return (
    <Modal show={showAddPurchaseModal} onHide={handleAddProductModal}>
      <Modal.Header closeButton>
        <Modal.Title>Add product</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        { AddProductForm() }
      </Modal.Body>
    </Modal>
  )
}

function AddProductForm() {
  return (
    <Form>
      <Form.Group>
        <Form.Label>Название zxcv</Form.Label><br />
        <Form.Control type="text" /><br />
        
        <Form.Label>Дата</Form.Label><br />
        <Form.Control type="date" placeholder="sas"/>
        <Form.Text className="text-muted">
          Если оставить это поле пустым, то будет вставлена нынешняя дата.
        </Form.Text><br />
      </Form.Group>

      <div className="text-center mt-4">
        <Button variant="outline-dark" type="submit">
          Отправить
        </Button>
      </div>
    </Form>
  )
}

function AddPurchaseModal(showAddPurchaseModal, handlers) {
  return (
    <Modal show={showAddPurchaseModal} onHide={handlers["Purchase"]}>
      <Modal.Header closeButton>
        <Modal.Title>Моя форма</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        { AddPurchaseForm(handlers) }
      </Modal.Body>
    </Modal>
  )
}

function AddPurchaseForm(handlers) {
  return (
    <Form>
        <Form.Label>Название продукта</Form.Label><br />
        <Form.Control type="text" /><br />
        
        <Form.Label>Дата</Form.Label><br />
        <Form.Control type="date" placeholder="sas"/>
        <Form.Text muted>
          Если оставить это поле пустым, то будет вставлена нынешняя дата.
        </Form.Text><br />

      <div className="text-center mt-4">
        <Button variant="outline-dark" type="submit">
          Отправить
        </Button>{' '}
        <Button variant="outline-dark" onClick={handlers["Product"]}>
          Добавить продукт
        </Button>
      </div>
    </Form>
  )
}
