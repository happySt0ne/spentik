import './App.css';
import Table from './Table';
import { useEffect } from 'react';
import Navigation from './Navigation';

function App() {
  useEffect(() => {
    document.title = "spentik";
  }, []);

  return(
    <div>
      <Navigation />
      <Table />
    </div>
  );
}

export default App;
