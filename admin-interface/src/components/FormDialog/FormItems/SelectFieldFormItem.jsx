import React from 'react';
import { FormControl, InputLabel, Select, MenuItem } from '@material-ui/core';

const getCompoundProperty = (object, property, delimeter = '.') => {
    return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

const SelectFieldFormItem = ({ formData, handleFormChange, column }) => {
    return (
        <FormControl style={{width: '100%'}}>
            <InputLabel required={column.isRequired} >{column.label}</InputLabel>
            <Select value={getCompoundProperty(formData, column.name)} name={column.name} onChange={handleFormChange}>
                {column.typeProps && column.typeProps.map(option => (
                    <MenuItem key={option.value} value={option.value}>{option.label}</MenuItem>
                ))}
            </Select>
        </FormControl>
    );
};


export default SelectFieldFormItem;