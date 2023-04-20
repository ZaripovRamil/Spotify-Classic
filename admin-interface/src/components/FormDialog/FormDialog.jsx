import React, { useState } from 'react';
import { Dialog, DialogTitle } from '@material-ui/core';
import FormDialogActions from './FormDialogActions';
import FormDialogContent from './FormDialogContent';

const getCompoundProperty = (object, property, delimeter = '.') => {
  return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

// submitFormDataWithResultAsync should be an async function that receives data from form
// and returns true or false, indicating whether data was proccedeed succesfully or not
const FormDialog = ({ isOpen, setIsOpen, formData, setFormData, columns, submitFormDataWithResultAsync }) => {
  const [formError, setFormError] = useState();

  const validateFormData = () => {
    return !columns.some(column => column.isRequired && !getCompoundProperty(formData, column.name));
  }

  const handleSubmit = async () => {
    if (!validateFormData()) {
      setFormError('Track name, album id and track mp3 file are required.')
      return;
    }
    const res = await submitFormDataWithResultAsync(formData);
    if (!res) {
      setFormError('Something went wrong. Please check the correcteness of your input data');
      return;
    }

    setIsOpen(false);
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