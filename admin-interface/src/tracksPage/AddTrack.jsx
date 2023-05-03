import React, { useState } from "react";
import FormDialog from "../components/FormDialog/FormDialog";
import { Button } from "@material-ui/core";
import { Add as AddIcon } from "@material-ui/icons";
import { TableStyles } from "../components/Table/TableStyles";

const AddTrack = ({ insertItemsWithResultAsync }) => {
    const [openAddingForm, setOpenAddingForm] = useState(false);
    const [formData, setFormData] = useState({
        name: '',
        albumId: '',
        genreIds: [],
        trackFile: null,
    });
    const addingFormColumns = [
        {
            name: 'name',
            label: 'Track Name',
            type: 'text',
            isRequired: true,
        },
        {
            name: 'albumId',
            label: 'Album Id',
            type: 'text',
            isRequired: true,
        },
        {
            name: 'trackFile',
            label: 'Track File',
            type: 'file',
            typeProps: [{
                accept: "audio/mp3"
            }],
            isRequired: true,
        },
        {
            name: 'genreIds',
            label: 'Genres Ids',
            type: 'array',
            typeProps: [{
                type: 'text',
                typeProps: [],
            }],
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

export default AddTrack;