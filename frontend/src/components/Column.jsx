import './Table.css';
import PropTypes from 'prop-types';

export default function Column({columnName, columnData}) {

  let list = ListWithBreaks(columnData);

  return (
    <div className='Row'>
      <div className='table-header'>
        { columnName }
      </div>
      <div className='table-body'>
        { list }
      </div>
    </div>
  );
}

function ListWithBreaks(items) {
  const elements = items.map((item, index) => (
    <span className={`row-item ${index % 2 === 1 ? 'alternate-row' : ''}`} key={index}>
      {item}
    </span>
  ));

  return <div className="row-container">{elements}</div>;
}

Column.propTypes = {
  columnName: PropTypes.string.isRequired,
  columnData: PropTypes.array.isRequired,
}
