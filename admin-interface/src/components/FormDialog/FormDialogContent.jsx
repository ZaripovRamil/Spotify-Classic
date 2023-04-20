import React from "react";
import { DialogContent } from '@material-ui/core';
import FormItem from "./FormItems/FormItem";

const FormDialogContent = ({ formData, setFormData, columns }) => {
  const handleFormChange = (event) => {
    let field = event.target.name;
    let val = null;

    if (event.target.type !== 'file' && field !== 'genres') {
      val = event.target.value;
    } else if (event.target.files && event.target.files[0].type === 'audio/mpeg') {
      val = event.target.files[0];
    }

    if (field.startsWith('genres.')) {
      const index = +field.split('genres.').filter(Boolean)[0];
      const newGenres = [...formData.genres];
      newGenres[index] = event.target.value;
      val = newGenres;
      field = 'genres';
    }

    setFormData({ ...formData, [field]: val });
  };

  return (
    <DialogContent>
      {columns.map((column, idx) => (
        <FormItem formData={formData} setFormData={setFormData} handleFormChange={handleFormChange} column={column} key={`form-item-${idx}`} />
      ))}
    </DialogContent>
  );
}

export default FormDialogContent;