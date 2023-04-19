import { Table } from '@material-ui/core';
import { TableStyles } from "./TableStyles";
import TableHeader from "./TableHeadDisplayer";
import TableBodyDisplayer from "./TableBodyDisplayer";

const TableDisplayer = ({ data, editDataWithResultAsync, deleteDataWithResultAsync, insertDataWithResultAsync, columns }) => {
  const classes = TableStyles();

  return (
    <div className={classes.root}>
      <Table className={classes.table}>
        <TableHeader columns={columns} />
        <TableBodyDisplayer data={data} editDataWithResultAsync={editDataWithResultAsync} deleteDataWithResultAsync={deleteDataWithResultAsync} insertDataWithResultAsync={insertDataWithResultAsync} columns={columns} />
      </Table>
    </div>
  );
};

export default TableDisplayer;