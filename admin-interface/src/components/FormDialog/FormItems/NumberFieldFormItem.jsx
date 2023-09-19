import React from "react";
import { TextField } from "@mui/material";

const getCompoundProperty = (object, property, delimeter = '.') => {
    return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

const NumberFieldFormItem = ({ formData, handleFormChange, column }) => {
    return (
        <TextField
            required={column.isRequired || false}
            margin='dense'
            name={column.name}
            label={column.label}
            type='number'
            fullWidth
            value={getCompoundProperty(formData, column.name)}
            onChange={handleFormChange}
            InputProps={{
                inputProps: {
                    pattern: "[0-9]*",
                    inputMode: "numeric",
                    onKeyDown: (event) => {
                        if (!/[0-9]/.test(event.key) && event.key !== 'Backspace')
                            event.preventDefault();
                    },
                },
            }}
        />
    );
}

export default NumberFieldFormItem;