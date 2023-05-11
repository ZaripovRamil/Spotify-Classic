import React from "react";
import { TextField } from "@material-ui/core";

const getCompoundProperty = (object, property, delimeter='.') => {
    return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

const TextFieldFormItem = ({formData, handleFormChange, column}) => {
    return (
        <TextField
            required={column.isRequired || false}
            margin='dense'
            name={column.name}
            label={column.label}
            fullWidth
            value={getCompoundProperty(formData, column.name)}
            onChange={handleFormChange}
        />
    );
}

export default TextFieldFormItem;