import React, { Fragment, useState } from "react";
import EditableRow from "./EditableRow";
import ReadOnlyRow from "./ReadOnlyRow";
import AddRowRow from "./AddRowRow";
import { TableBody } from "@material-ui/core";

const TableBodyDisplayer = ({ data, editDataWithResultAsync, deleteDataWithResultAsync, insertDataWithResultAsync, columns }) => {
  const [editIndex, setEditIndex] = useState(-1);
  const [newData, setNewData] = useState({});

  return (
    <TableBody>
      {data.map((item, index) => (
        <Fragment key={`data-${index}`}>
          {index === 0 && editIndex === -1 && (
            <AddRowRow insertDataWithResultAsync={insertDataWithResultAsync} columns={columns} />
          )}
          {index === editIndex ? (
            <EditableRow data={data} editDataWithResultAsync={editDataWithResultAsync} columns={columns} setEditIndex={setEditIndex} index={index} newData={newData} setNewData={setNewData} />
          ) : (
            <ReadOnlyRow data={data} deleteDataWithResultAsync={deleteDataWithResultAsync} columns={columns} setEditIndex={setEditIndex} item={item} index={index} setNewData={setNewData} />
          )}
        </Fragment>
      ))}
    </TableBody>
  );
}

export default TableBodyDisplayer;