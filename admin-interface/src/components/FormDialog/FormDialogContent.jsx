import React from "react";
import { DialogContent } from '@material-ui/core';
import FormItem from "./FormItem";

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
      {columns.map((column, idx) => {
        return (<FormItem formData={formData} setFormData={setFormData} handleFormChange={handleFormChange} column={column} key={`form-item-${idx}`} />);
      })}
      {/* 
      {formData.genres.map((value, index) => (
        <TextField
          key={index}
          margin="dense"
          name={`genres-${index}`}
          label={`genre-id ${index + 1}`}
          value={value}
          data-index={index}
          fullWidth
          onChange={handleFormChange}
        />
      ))}
      <br />
      <Button onClick={handleAddGenre} color="primary">
        Add new genre
      </Button> */}
    </DialogContent>
  );
}

export default FormDialogContent;