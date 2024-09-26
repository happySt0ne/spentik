import logo from './logo.svg';
import './App.css';
import Table from './Table';
import {useEffect} from 'react';

function App() {
  useEffect(() => {
    document.title = "spentik";
  }, []);

  return(
    <Table />
  );
}

export default App;
