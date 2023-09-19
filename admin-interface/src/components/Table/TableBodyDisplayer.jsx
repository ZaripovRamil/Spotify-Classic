import React, { Fragment, useState } from "react";
import EditableRow from "./EditableRow";
import ReadOnlyRow from "./ReadOnlyRow";
import { TableBody } from "@mui/material";

const TableBodyDisplayer = ({ data, setData, editDataWithResultAsync, deleteDataWithResultAsync, columns }) => {
  const [editIndex, setEditIndex] = useState(-1);
  const [newData, setNewData] = useState({});

  return (
    <TableBody>
      {data.map((item, index) => (
        <Fragment key={`data-${index}`}>
          {index === editIndex ? (
            <EditableRow data={data} setData={setData} editDataWithResultAsync={editDataWithResultAsync} columns={columns} setEditIndex={setEditIndex} index={index} newData={newData} setNewData={setNewData} />
          ) : (
            <ReadOnlyRow data={data} setData={setData} deleteDataWithResultAsync={deleteDataWithResultAsync} columns={columns} setEditIndex={setEditIndex} item={item} index={index} setNewData={setNewData} />
          )}
        </Fragment>
      ))}
    </TableBody>
  );
}

export default TableBodyDisplayer;