import React, { useState } from "react";
import { TableRow, TableCell, Button } from '@material-ui/core';
import { Add as AddIcon } from "@material-ui/icons";
import { TableStyles } from "./TableStyles";
import FormDialog from "../FormDialog/FormDialog";

const AddRowRow = ({ insertDataWithResultAsync, columns }) => {
    const [openForm, setOpenForm] = useState(false);

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
                    onClick={() => setOpenForm(true)}
                >
                    <AddIcon />
                </Button>
                <FormDialog isOpen={openForm} setIsOpen={setOpenForm} submitFormDataWithResultAsync={insertDataWithResultAsync} />
            </TableCell>
        </TableRow>
    );
}

export default AddRowRow;