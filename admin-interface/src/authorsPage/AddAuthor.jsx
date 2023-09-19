import React, { useState } from "react";
import FormDialog from "../components/FormDialog/FormDialog";
import { Button } from "@mui/material";
import { Add as AddIcon } from "@mui/icons-material";
import { TableStyles } from "../components/Table/TableStyles";

const AddAuthor = ({ insertItemsWithResultAsync }) => {
    const [openAddingForm, setOpenAddingForm] = useState(false);
    const [formError, setFormError] = useState();
    const [formData, setFormData] = useState({
        name: '',
        userId: '',
    });
    const addingFormColumns = [
        {
            name: 'name',
            label: 'Author Name',
            type: 'text',
            isRequired: true,
        },
        {
            name: 'userId',
            label: 'User Id',
            type: 'text',
            isRequired: true,
        },
    ];

    const classes = TableStyles();
    return (
        <>
            <Button
                variant="contained"
                className={classes.addButton}
                onClick={() => setOpenAddingForm(true)}
            >
                <AddIcon />
            </Button>
            <FormDialog isOpen={openAddingForm} setIsOpen={setOpenAddingForm} formHeader={"Add new author"} formData={formData} setFormData={setFormData} columns={addingFormColumns} formError={formError} setFormError={setFormError} submitFormDataWithResultAsync={insertItemsWithResultAsync} />
        </>
    );
}

export default AddAuthor;