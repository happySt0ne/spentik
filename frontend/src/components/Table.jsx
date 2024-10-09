import { useEffect, useState } from "react";
import Column from "./Column.jsx";
import './Table.css';

const todate = new Date();
const year = todate.getFullYear();
const month = String(todate.getMonth() + 1).padStart(2, '0');
const day = String(todate.getDate()).padStart(2, '0');

const TODAY = `${year}-${month}-${day}`;

// const apiUrl = process.env.REACT_APP_BACKEND_URL;

export default function Table() {
  const [data, setData] = useState();

  useEffect(() => {
    fetch(`http://localhost:8080/api/Table/${TODAY}`)
    .then(response => response.json()) 
    .then(data => setData(data))
    .catch(error => console.error(error));
  }, []);

  return (
    <div className="Table">
      {data && (data.dates[0].slice(0, 7))}
      {data && (GetDatesColumn(data.dates))}
      {data && (GetDataColumns(data))}
    </div>
  )
}

function GetDatesColumn(dates) {
  return (
    <Column
      key={dates}
      columnName='Дата'
      columnData={dates.map(str => str.slice(-2))}
    />
  );
}

function GetDataColumns(data) {
  const sumsKeys = Object.keys(data.sums);

  return (
    <>
      {data.sums && sumsKeys.map(key =>
        <Column
          key={key}
          columnName={key}
          columnData={data.sums[key]}
        />
      )}
    </>
  );
}

