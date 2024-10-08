import './Table.css';

export default function Column({columnName, columnData}) {

let list = ListWithBreaks(columnData);

return (
    <div className='Column'>
      <div className='table-header'>
        { columnName }
      </div>
      <div>
        { list }
      </div>
    </div>
  );
}

function ListWithBreaks( items ) {
  const elements = items.flatMap((item, index) => [
    <span className={`column-box ${index % 2 === 1 ? 'alternate-row' : ''}`} key={index}>{item}</span>, 
  ]);

  return <div>{elements}</div>; 
}
