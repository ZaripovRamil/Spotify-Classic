import React from "react";
import { Button } from "@material-ui/core";

const FilePickerFormItem = ({ formData, column, handleFormChange }) => {
    return (
        <>
            <input
                accept={column.typeProps[0].accept}
                capture="user"
                id="attachment-input"
                type="file"
                name={column.name}
                onChange={handleFormChange}
                style={{ display: 'none' }}
            />
            <label htmlFor="attachment-input">
                <Button variant="contained" component="span">Attach {column.label}</Button>
            </label>
            {formData[column.name] && formData[column.name].name}
            <br />
        </>
    );
}

export default FilePickerFormItem;