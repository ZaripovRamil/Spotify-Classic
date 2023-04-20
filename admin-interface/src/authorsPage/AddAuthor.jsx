import React, { useState } from "react";
import FormDialog from "../components/FormDialog/FormDialog";
import { Button } from "@material-ui/core";
import { Add as AddIcon } from "@material-ui/icons";
import { TableStyles } from "../components/Table/TableStyles";

const AddAuthor = ({ insertItemsWithResultAsync }) => {
    const [openAddingForm, setOpenAddingForm] = useState(false);
    const [formData, setFormData] = useState({
        authorName: '',
        userId: '',
    });
    const addingFormColumns = [
        {
            name: 'authorName',
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
            <FormDialog isOpen={openAddingForm} setIsOpen={setOpenAddingForm} formData={formData} setFormData={setFormData} columns={addingFormColumns} submitFormDataWithResultAsync={insertItemsWithResultAsync} />
        </>
    );
}

export default AddAuthor;