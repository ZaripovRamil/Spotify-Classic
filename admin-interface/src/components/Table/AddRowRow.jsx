import React from "react";
import {
    TableRow,
    TableCell,
    Button,
} from '@material-ui/core';
import { Add as AddIcon } from "@material-ui/icons";
import { TableStyles } from "./TableStyles";

const AddRowRow = ({ data, onDataChange, columns, setEditIndex, newData, setNewData }) => {
    const handleAdd = () => {
        const updatedData = [{ ...newData }, ...data];
        onDataChange(updatedData);
        setEditIndex(0);
        setNewData({});
    };

    const classes = TableStyles();
    return (
        <TableRow>
            {columns.map((_, index) => (
                <TableCell key={`empty-space-${index}`} />
            ))}
            <TableCell>
                <Button
                    variant="contained"
                    className={classes.addButton}
                    onClick={handleAdd}
                >
                    <AddIcon />
                </Button>
            </TableCell>
        </TableRow>
    );
}

export default AddRowRow;