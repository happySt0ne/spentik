import Modal from 'react-bootstrap/Modal';
import { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';

export default function AddProduct() {
  const [show, setShow] = useState(false);
  
  const modalToggle = () => setShow(!show);

  return ( 
    <>
      <button className='btn btn-danger btn-sm' onClick={modalToggle}>
          Add Product
      </button>
      
      <Modal show={show}>
        <Modal.Header>
          <Modal.Title>ass</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          Pipiska
        </Modal.Body>
      </Modal>
    </>
  )
}
