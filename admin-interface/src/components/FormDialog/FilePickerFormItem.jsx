import React from "react";
import { Button } from "@material-ui/core";

// todo: accept not only mp3. how do you upload previews?
const FilePickerFormItem = ({ formData, handleFormChange }) => {
    return (
        <>
            <input
                accept="audio/mp3"
                capture="user"
                id="attachment-input"
                type="file"
                name="attachment"
                onChange={handleFormChange}
                style={{ display: 'none' }}
            />
            <label htmlFor="attachment-input">
                <Button variant="contained" component="span">Attach MP3</Button>
            </label>
            {formData.attachment && formData.attachment.name}
            <br />
        </>
    );
}

export default FilePickerFormItem;