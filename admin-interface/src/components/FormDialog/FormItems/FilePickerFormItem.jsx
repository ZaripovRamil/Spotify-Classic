import React from "react";
import { Button } from "@material-ui/core";

// todo: accept not only mp3. how do you upload previews? just add typeProps!
const FilePickerFormItem = ({ formData, column, handleFormChange }) => {
    return (
        <>
            <input
                accept="audio/mp3"
                capture="user"
                id="attachment-input"
                type="file"
                name={column.name}
                onChange={handleFormChange}
                style={{ display: 'none' }}
            />
            <label htmlFor="attachment-input">
                <Button variant="contained" component="span">Attach MP3</Button>
            </label>
            {formData[column.name] && formData[column.name].name}
            <br />
        </>
    );
}

export default FilePickerFormItem;