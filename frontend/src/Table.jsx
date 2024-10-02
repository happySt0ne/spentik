import { useEffect, useState } from "react";
import Column from "./Column.jsx";
import './Table.css';

const todate = new Date();
const year = todate.getFullYear();
const month = String(todate.getMonth() + 1).padStart(2, '0');
const day = String(todate.getDate()).padStart(2, '0');

const TODAY = `${year}-${month}-${day}`;

const root = document.documentElement;
var horizontalPadding = getComputedStyle(root)
  .getPropertyValue('--table-horizontal-padding');
var paddingValue = parseInt(horizontalPadding, 10);

export default function Table() {
  const [data, setData] = useState();

  useEffect(() => {
    fetch(`http://localhost:8080/api/Table/${TODAY}`)
    .then(response => response.json()) 
    .then(data => setData(data))
    .catch(error => console.error(error));
  }, []);

  const columnsCount = data && Object.keys(data.sums).length + 10;
  // TODO: Тут нужно будет немного переделать формулу.

  root.style.setProperty(
    '--table-horizontal-padding', 
    `${paddingValue / columnsCount}px`
  );

  return (
    <div className='Table'>
      { data && (GetDatesColumn(data.dates)) }
      { data && (GetColumns(data)) }
    </div>
  )
}

function GetDatesColumn(dates) {
  return (
    <Column 
      key={dates}
      columnName='Дата'
      columnData={dates}
    />
  );
}

function GetColumns(data) {
  const sumsKeys = Object.keys(data.sums);

  return (
    <div className='column-list'> 
      {data.sums && sumsKeys.map(key => 
        <Column 
          key={key}
          columnName={key} 
          columnData={data.sums[key]} 
        /> 
      )}
    </div>
  );
}
