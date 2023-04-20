import React from "react";
import { Button } from '@material-ui/core';
import FormItem from "./FormItem";

const MultiInputFieldFormItem = ({ formData, setFormData, handleFormChange, column }) => {
    const handleAddItem = () => {
        formData[column.name] = [...formData[column.name], '']
        setFormData({ ...formData });
    };
    return (
        <>
            {formData[column.name].map((_, idx) =>
                <FormItem key={idx} formData={formData} handleFormChange={handleFormChange} column={{
                    name: `${column.name}.${idx}`,
                    label: `${column.label} ${idx + 1}`,
                    type: column.typeProps[0].type,
                    typeProps: column.typeProps[0].typeProps,
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

export default MultiInputFieldFormItem;