import React, { useState } from "react";
import FormDialog from "../components/FormDialog/FormDialog";
import { Button } from "@mui/material";
import { Add as AddIcon } from "@mui/icons-material";
import { TableStyles } from "../components/Table/TableStyles";

const AddAlbum = ({ insertItemsWithResultAsync }) => {
    const [openAddingForm, setOpenAddingForm] = useState(false);
    const [formData, setFormData] = useState({
        name: '',
        authorId: '',
        albumType: '',
        releaseYear: '',
    });
    const addingFormColumns = [
        {
            name: 'name',
            label: 'Album Name',
            type: 'text',
            typeProps: {},
            isRequired: true,
        },
        {
            name: 'authorId',
            label: 'Author Id',
            type: 'text',
            typeProps: {},
            isRequired: true,
        },
        {
            name: 'albumType',
            label: 'ALbum Type',
            type: 'select',
            typeProps: {
                values: [
                    {
                        value: '0',
                        label: 'album'
                    },
                    {
                        value: '1',
                        label: 'single'
                    },
                ]
            },
            isRequired: true,
        },
        {
            name: 'releaseYear',
            label: 'Release Year',
            type: 'number',
            typeProps: {},
            isRequired: false,
        },
        {
            name: 'previewFile',
            label: 'Preview picture',
            type: 'file',
            typeProps: {
                accept: "image/jpg"
            },
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
            <FormDialog isOpen={openAddingForm} setIsOpen={setOpenAddingForm} formHeader={"Add new album"} formData={formData} setFormData={setFormData} columns={addingFormColumns} submitFormDataWithResultAsync={insertItemsWithResultAsync} />
        </>
    );
}

export default AddAlbum;