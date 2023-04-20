import React, { useState } from "react";
import FormDialog from "../components/FormDialog/FormDialog";
import { Button } from "@material-ui/core";
import { Add as AddIcon } from "@material-ui/icons";
import { TableStyles } from "../components/Table/TableStyles";

const AddAlbum = ({ insertItemsWithResultAsync }) => {
    const [openAddingForm, setOpenAddingForm] = useState(false);
    const [formData, setFormData] = useState({
        albumName: '',
        authorId: '',
        albumType: '',
        releaseDate: '',
    });
    const addingFormColumns = [
        {
            name: 'albumName',
            label: 'Album Name',
            type: 'text',
            typeProps: [],
            isRequired: true,
        },
        {
            name: 'authorId',
            label: 'Author Id',
            type: 'text',
            typeProps: [],
            isRequired: true,
        },
        {
            name: 'albumType',
            label: 'ALbum Type',
            type: 'select',
            typeProps: [{
                value: '0',
                label: 'album',
            },
            {
                value: '1',
                label: 'single',
            }],
            isRequired: true,
        },
        {
            name: 'releaseDate',
            label: 'Release Date',
            type: 'number',
            typeProps: [],
            isRequired: false,
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

export default AddAlbum;