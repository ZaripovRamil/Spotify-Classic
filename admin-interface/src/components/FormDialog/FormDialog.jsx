import React, {useState} from 'react';
import { Dialog, DialogTitle } from '@material-ui/core';
import FormDialogActions from './FormDialogActions';
import FormDialogContent from './FormDialogContent';

const getCompoundProperty = (object, property, delimeter = '.') => {
  return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

// submitFormDataWithResultAsync should be an async function that receives data from form
// and returns object with fields {isSuccessful: boolean, resultMessage: string}
const FormDialog = ({ isOpen, setIsOpen, formData, setFormData, columns, submitFormDataWithResultAsync }) => {
  const [formError, setFormError] = useState();
  const validateFormData = () => {
    return !columns.some(column => column.isRequired && !getCompoundProperty(formData, column.name));
  }

  const handleSubmit = async () => {
    if (!validateFormData()) {
      setFormError(`Fields ${columns.map(column => column.isRequired ? column.label : '').filter(Boolean).join(', ')} are required. Please fill it it.`)
      return;
    }
    const res = await submitFormDataWithResultAsync(formData);
    if (!res.isSuccessful) {
      setFormError(res.resultMessage);
      return;
    }

    setIsOpen(false);
    setFormData({});
  };

  return (
    <Dialog open={isOpen} onClose={() => setIsOpen(false)}>
      <DialogTitle>Add new item</DialogTitle>
      <FormDialogContent formData={formData} setFormData={setFormData} columns={columns} />
      <FormDialogActions setIsOpen={setIsOpen} handleFormSubmit={handleSubmit} />
      <div style={{ color: 'red' }}>{formError && formError}</div>
    </Dialog>
  );
};

export default FormDialog;