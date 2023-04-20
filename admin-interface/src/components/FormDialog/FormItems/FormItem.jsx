import React from "react";
import TextFieldFormItem from "./TextFieldFormItem";
import FilePickerFormItem from "./FilePickerFormItem";
import MultiTextFieldFormItem from "./MultiTextFieldFormItem";
import NumberFieldFormItem from "./NumberFieldFormItem";

const FormItem = ({ formData, setFormData, column, handleFormChange }) => {
    switch (column.type) {
        case 'text':
            return <TextFieldFormItem formData={formData} handleFormChange={handleFormChange} column={column} />;

        case 'array':
            return <MultiTextFieldFormItem formData={formData} setFormData={setFormData} handleFormChange={handleFormChange} column={column} />;

        case 'file':
            return <FilePickerFormItem formData={formData} column={column} handleFormChange={handleFormChange} />;

        case 'number':
            return <NumberFieldFormItem formData={formData} column={column} handleFormChange={handleFormChange} />;
            
        default: return (<></>);
    }
}

export default FormItem;