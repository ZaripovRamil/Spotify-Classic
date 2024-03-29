import React from "react";
import {
  TableRow,
  TableCell,
  TextField,
  Button,
} from '@mui/material';
import {
  Save as SaveIcon,
  Cancel as CancelIcon
} from '@mui/icons-material';
import { TableStyles } from "./TableStyles";

const getCompoundProperty = (object, property, delimeter='.') => {
    return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

const EditableRow = ({ data, setData, editDataWithResultAsync, columns, setEditIndex, index, newData, setNewData }) => {
  const handleSave = async () => {
    const res = await editDataWithResultAsync(newData);
    if (!res.isSuccessful) {
      alert(res.resultMessage);
      setEditIndex(-1);
      return;
    }
    data[index] = structuredClone(newData);
    data[index].tableProps.color = '#fffc99';
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
    <TableRow style={{ backgroundColor: data[index]?.tableProps?.color ?? 'eeeeee' }}>
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