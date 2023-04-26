import React from "react";
import { Button } from '@material-ui/core';
import FormItem from "./FormItem";
import { Delete } from "@material-ui/icons";

const MultiInputFieldFormItem = ({ formData, setFormData, handleFormChange, column }) => {
    const handleAddItem = () => {
        formData[column.name] = [...formData[column.name], '']
        setFormData({ ...formData });
    };

    const handleDeleteItem = (idx) => {
        formData[column.name].splice(idx, 1);
        setFormData({ ...formData });
    }
    return (
        <>
            {formData[column.name] && formData[column.name].map((_, idx) =>
                <div style={{width: '100%', display: 'flex'}}>
                    <FormItem key={idx} formData={formData} handleFormChange={handleFormChange} column={{
                        name: `${column.name}.${idx}`,
                        label: `${column.label} ${idx + 1}`,
                        type: column.typeProps[0].type,
                        typeProps: column.typeProps[0].typeProps,
                        isRequired: column.isRequired && idx === 0,
                    }} />
                    <Button key={`delete-btn-${idx}`} onClick={() => handleDeleteItem(idx)}><Delete /></Button>
                </div>
            )}
            <br />
            <Button onClick={handleAddItem} color="primary">
                Add new {column.label}
            </Button>
        </>
    );
}

export default MultiInputFieldFormItem;