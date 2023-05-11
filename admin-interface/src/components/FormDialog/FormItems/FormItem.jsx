import React from "react";
import TextFieldFormItem from "./TextFieldFormItem";
import FilePickerFormItem from "./FilePickerFormItem";
import MultiInputFieldFormItem from "./MultiInputFieldFormItem";
import NumberFieldFormItem from "./NumberFieldFormItem";
import SelectFieldFormItem from "./SelectFieldFormItem";
import CheckboxFormItem from "./CheckboxFormItem";

const FormItem = ({ formData, setFormData, column, handleFormChange }) => {
    switch (column.type) {
        case 'text':
            return <TextFieldFormItem formData={formData} handleFormChange={handleFormChange} column={column} />;

        case 'array':
            return <MultiInputFieldFormItem formData={formData} setFormData={setFormData} handleFormChange={handleFormChange} column={column} />;

        case 'file':
            return <FilePickerFormItem formData={formData} column={column} handleFormChange={handleFormChange} />;

        case 'number':
            return <NumberFieldFormItem formData={formData} column={column} handleFormChange={handleFormChange} />;

        case 'select':
            return <SelectFieldFormItem formData={formData} column={column} handleFormChange={handleFormChange} />;

        case 'checkbox':
            return <CheckboxFormItem formData={formData} column={column} handleFormChange={handleFormChange} />;

        default: return (<></>);
    }
}

export default FormItem;