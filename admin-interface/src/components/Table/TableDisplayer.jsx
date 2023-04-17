import { Table } from '@material-ui/core';
import { TableStyles } from "./TableStyles";
import TableHeader from "./TableHeadDisplayer";
import TableBodyDisplayer from "./TableBodyDisplayer";

const TableDisplayer = ({ data, onDataChange, columns }) => {
  const classes = TableStyles();

  return (
    <div className={classes.root}>
      <Table className={classes.table}>
        <TableHeader columns={columns} />
        <TableBodyDisplayer data={data} onDataChange={onDataChange} columns={columns} />
      </Table>
    </div>
  );
};

export default TableDisplayer;