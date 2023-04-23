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

const getCompoundProperty = (object, property, delimeter='.') => {
    return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

const EditableRow = ({ data, setData, editDataWithResultAsync, columns, setEditIndex, index, newData, setNewData }) => {
  const handleSave = async () => {
    const res = await editDataWithResultAsync(newData);
    if (!res) {
      alert('There was an error saving the data. Please check it and try again later');
      setEditIndex(-1);
      return;
    }
    data[index] = structuredClone(newData);
    setData(data);
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
              value={getCompoundProperty(newData, column.name)}
              onChange={(e) => {
                const props = column.name.split('.');
                if (props.length === 0) return;
                // good luck
                props.reduce((o, propName, idx) => o === undefined ?
                  undefined : idx === props.length - 1 ?
                    o[props[idx]] = e.target.value : o[propName], newData);
                setNewData({ ...newData });
              }
              }
            />
          </TableCell>
          ) : (
            <TableCell key={column.name}>{getCompoundProperty(data[index], column.name)}</TableCell>
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