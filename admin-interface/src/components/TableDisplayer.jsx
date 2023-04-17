import { Fragment, useState } from "react";
import {
  Table,
  TableHead,
  TableCell,
  TableRow,
  TableBody,
  IconButton,
  Paper,
  Button,
  TextField
} from '@material-ui/core';
import {
  Edit as EditIcon,
  Delete as DeleteIcon,
  Save as SaveIcon,
  Cancel as CancelIcon,
  Add as AddIcon
} from "@material-ui/icons";
import { TableStyles } from "./TableStyles";

const TableDisplayer = ({ data, onDataChange, columns }) => {
  const [editIndex, setEditIndex] = useState(-1);
  const [newData, setNewData] = useState({});

  const handleSave = (index) => {
    const updatedData = [...data];
    updatedData[index] = { ...updatedData[index], ...newData };
    onDataChange(updatedData);
    setEditIndex(-1);
    setNewData({});
  };

  const handleCancel = () => {
    // if the row was created by add track and then canceled immediately
    if (!Object.values(data[editIndex]).some(Boolean)) {
      handleDelete(editIndex);
    }
    setEditIndex(-1);
    setNewData({});
  };

  const handleAdd = () => {
    const updatedData = [{ ...newData }, ...data];
    onDataChange(updatedData);
    setEditIndex(0);
    setNewData({});
  };

  const handleDelete = (index) => {
    const updatedData = [...data];
    updatedData.splice(index, 1);
    onDataChange(updatedData);
  };

  const classes = TableStyles();

  return (
    <div className={classes.root}>
      <Button
        variant="contained"
        className={classes.addButton}
        onClick={handleAdd}
      >
        <AddIcon />
      </Button>
      <Table className={classes.table}>
        <TableHead>
          <TableRow>
            {columns.map((column, index) => (
              <TableCell key={`column-${index}`}>{column.label}</TableCell>
            ))}
            <TableCell>Action</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {data.map((item, index) => (
            <Fragment key={`data-${index}`}>
              {editIndex === index ? (
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
                        {...(column.props || {})}
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
              ) : (
                <TableRow>
                  {columns.map((column) => (
                    <TableCell key={column.name}>{item[column.name]}</TableCell>
                  ))}
                  <TableCell>
                    <IconButton
                      aria-label="edit"
                      className={classes.editButton}
                      onClick={() => {
                        setEditIndex(index);
                        setNewData(item);
                      }}
                    >
                      <EditIcon />
                    </IconButton>
                    <IconButton
                      aria-label="delete"
                      className={classes.deleteButton}
                      onClick={() => handleDelete(index)}
                    >
                      <DeleteIcon />
                    </IconButton>
                  </TableCell>
                </TableRow>
              )}
            </Fragment>
          ))}
        </TableBody>
      </Table>
    </div>
  );
};

export default TableDisplayer;