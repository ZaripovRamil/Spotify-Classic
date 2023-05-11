import { Checkbox, FormControlLabel } from "@material-ui/core";
import React from "react";

const getCompoundProperty = (object, property, delimeter = '.') => {
    return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || false;
}

const CheckboxFormItem = ({ formData, column, handleFormChange }) => {
    return (
        <FormControlLabel
            control={<Checkbox
                name={column.name}
                value={getCompoundProperty(formData, column.name)}
                onChange={handleFormChange}
            />}
            label={column.label}
        />
    );
};

export default CheckboxFormItem;