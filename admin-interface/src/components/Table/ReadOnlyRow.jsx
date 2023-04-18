import React from "react";
import {
    TableRow,
    TableCell,
    IconButton,
} from '@material-ui/core';
import {
    Edit as EditIcon,
    Delete as DeleteIcon
} from "@material-ui/icons";
import { TableStyles } from "./TableStyles";

const ReadOnlyRow = ({ data, onDataChange, columns, setEditIndex, item, index, setNewData }) => {
    const handleDelete = (index) => {
        const updatedData = [...data];
        updatedData.splice(index, 1);
        onDataChange(updatedData);
    };

    const classes = TableStyles();
    return (
        <TableRow>
            {columns.map((column) => (
                <TableCell key={column.name}>{column.name.split('.').reduce((o, propName) => o === undefined ? undefined : o[propName], data[index])}</TableCell>
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
    );
}

export default ReadOnlyRow;