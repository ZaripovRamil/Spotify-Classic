import React from "react";
import { Button } from '@material-ui/core';
import TextFieldFormItem from "./TextFieldFormItem";

const MultiTextFieldFormItem = ({ formData, setFormData, handleFormChange, column }) => {
    const handleAddItem = () => {
        formData[column.name] = [...formData[column.name], '']
        setFormData({ ...formData });
    };
    return (
        <>
            {formData[column.name].map((_, idx) =>
                <TextFieldFormItem key={idx} formData={formData} handleFormChange={handleFormChange} column={{
                    name: `${column.name}.${idx}`,
                    label: `${column.label} ${idx + 1}`,
                    type: 'text',
                    isRequired: column.isRequired && idx === 0,
                }} />
            )}
            <br />
            <Button onClick={handleAddItem} color="primary">
                Add new {column.label}
            </Button>
        </>
    );
}

export default MultiTextFieldFormItem;