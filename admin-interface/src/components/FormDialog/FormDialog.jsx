import React, { useState, useEffect } from 'react';
import { Dialog, DialogTitle } from '@mui/material';
import FormDialogActions from './FormDialogActions';
import FormDialogContent from './FormDialogContent';

const getCompoundProperty = (object, property, delimeter = '.') => {
  const result = property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object);
  if (!result || !result.toString()) return "";
  return result;
}

// submitFormDataWithResultAsync should be an async function that receives data from form
// and returns object with fields {isSuccessful: boolean, resultMessage: string}
const FormDialog = ({ isOpen, setIsOpen, formHeader, formData, setFormData, columns, submitFormDataWithResultAsync }) => {
  const [formError, setFormError] = useState();
  useEffect(() => setFormError(), [formData]);

  const validateFormData = () => {
    return !columns.some(column => column.isRequired && !getCompoundProperty(formData, column.name));
  }

  const handleSubmit = async () => {
    if (!validateFormData()) {
      setFormError(`Fields ${columns.map(column => column.isRequired && !getCompoundProperty(formData, column.name) ? column.label : '').filter(Boolean).join(', ')} are required. Please fill it in.`)
      return;
    }
    const res = await submitFormDataWithResultAsync(formData);
    if (!res.isSuccessful) {
      setFormError(res.messageResult);
      return;
    }

    setIsOpen(false);
    setFormData({});
  };

  return (
    <Dialog open={isOpen} onClose={() => setIsOpen(false)}>
      <DialogTitle>{formHeader ? formHeader : "Form"}</DialogTitle>
      <FormDialogContent formData={formData} setFormData={setFormData} columns={columns} />
      <FormDialogActions setIsOpen={setIsOpen} handleFormSubmit={handleSubmit} />
      <div style={{ color: 'red' }}>{formError && formError}</div>
    </Dialog>
  );
};

export default FormDialog;