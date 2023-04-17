import React from "react";
import {
  TableRow,
  TableCell,
  TextField,
  Button,
} from '@material-ui/core';
import {
  Save as SaveIcon,
  Cancel as CancelIcon
} from '@material-ui/icons';
import { TableStyles } from "./TableStyles";

const EditableRow = ({ data, onDataChange, columns, editIndex, setEditIndex, index, newData, setNewData }) => {
  const handleSave = (index) => {
    const updatedData = [...data];
    updatedData[index] = { ...updatedData[index], ...newData };
    onDataChange(updatedData);
    setEditIndex(-1);
    setNewData({});
  };

  const handleCancel = () => {
    // if the row was created and then canceled immediately
    if (!Object.values(data[editIndex]).some(Boolean)) {
      handleDelete(editIndex);
    }
    setEditIndex(-1);
    setNewData({});
  };

  const handleDelete = (index) => {
    const updatedData = [...data];
    updatedData.splice(index, 1);
    onDataChange(updatedData);
  };

  const classes = TableStyles();
  return (
    <TableRow>
      {columns.map((column) => (
        <TableCell key={column.name}>
          <TextField
            className={classes.input}
            type={column.type || "text"}
            value={newData[column.name] || ""}
            onChange={(e) =>
              setNewData({ ...newData, [column.name]: e.target.value })
            }
          />
        </TableCell>
      ))}
      <TableCell>
        <Button
          variant="contained"
          className={classes.saveButton}
          onClick={() => handleSave(index)}
        >
          <SaveIcon />
        </Button>
        <Button
          variant="contained"
          className={classes.cancelButton}
          onClick={handleCancel}
        >
          <CancelIcon />
        </Button>
      </TableCell>
    </TableRow>
  );
}

export default EditableRow;