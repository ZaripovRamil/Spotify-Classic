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

const EditableRow = ({ data, editDataWithResultAsync, columns, setEditIndex, index, newData, setNewData }) => {
  const handleSave = async () => {
    const res = await editDataWithResultAsync(newData);
    if (!res) {
      alert('There was an error saving the data. Please check it and try again later');
    setEditIndex(-1);
      return;
    }
    setEditIndex(-1);
    setNewData({});
  };

  const handleCancel = () => {
    setEditIndex(-1);
    setNewData({});
  };

  const classes = TableStyles();
  return (
    <TableRow>
      {columns.map((column) => (
        column.isEditable ?
          (<TableCell key={column.name}>
            <TextField
              className={classes.input}
              type={column.type || "text"}
              value={column.name.split('.').reduce((o, propName) => o === undefined ? undefined : o[propName], newData) || ""}
              onChange={(e) => {
                // good luck
                const props = column.name.split('.');
                if (props.length === 0) {
                  return;
                }
                const changeObj = (idx, obj) => {
                  if (idx === props.length - 1) {
                    obj[props[idx]] = e.target.value;
                    return;
                  }
                  changeObj(++idx, obj[props[idx - 1]]);
                };

                changeObj(0, newData);
                setNewData({ ...newData });
              }
              }
            />
          </TableCell>
          ) : (
            <TableCell key={column.name}>{column.name.split('.').reduce((o, propName) => o === undefined ? undefined : o[propName], data[index])}</TableCell>
          )
      ))}
      <TableCell>
        <Button
          variant="contained"
          className={classes.saveButton}
          onClick={handleSave}
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