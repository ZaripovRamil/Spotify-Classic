import React, { useState } from "react";
import FormDialog from "../components/FormDialog/FormDialog";
import { Button } from "@material-ui/core";
import { Add as AddIcon } from "@material-ui/icons";

const AddTrack = ({ insertItemsWithResultAsync }) => {
    const [openAddingForm, setOpenAddingForm] = useState(false);
    const [formData, setFormData] = useState({
        trackName: '',
        albumId: '',
        genres: [],
        trackFile: null,
    });
    const addingFormColumns = [
        {
            name: 'trackName',
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
            isRequired: true,
        },
        {
            name: 'genres',
            label: 'Genres Ids',
            type: 'array',
            isRequired: false,
        },
    ];

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