import React, { useState } from 'react';
import {  Dialog, DialogTitle } from '@material-ui/core';
import FormDialogActions from './FormDialogActions';
import FormDialogContent from './FormDialogContent';

// submitFormDataWithResultAsync should be an async function that receives data from form
// and returns true or false, indicating whether data was proccedeed succesfully or not
const FormDialog = ({ isOpen, setIsOpen, submitFormDataWithResultAsync }) => {
  const [formData, setFormData] = useState({
    trackName: '',
    albumId: '',
    genres: [],
    attachment: null,
  });
  const [formError, setFormError] = useState();

  const validateFormData = () => {
    return formData.trackName && formData.albumId && formData.attachment;
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

  const columns = [
    {
      name: 'trackName',
      label: 'Track Name',
      type: 'text',
      isRequired: true,
    },
    {
      name: 'albumId',
      label: 'Album Id',
      type: 'text',
      isRequired: true,
    },
    {
      name: 'trackFile',
      label: 'Track File',
      type: 'file',
      isRequired: true,
    },
    {
      name: 'genres',
      label: 'Genres Ids',
      type: 'array',
      isRequired: false,
    },
  ]

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