import React from "react";
import { DialogContent } from '@material-ui/core';
import FormItem from "./FormItems/FormItem";

const FormDialogContent = ({ formData, setFormData, columns }) => {
  // garbage. if something doesn't work, then this is probably the cause.
  const handleFormChange = (event) => {
    let field = event.target.name;
    let val = null;

    if (field.indexOf('.') !== -1) { // compound property, e.g. array type
      const data = field.split('.');
      const index = +data[1];
      const newItems = [...formData[data[0]]];
      newItems[index] = event.target.value;
      val = newItems;
      field = data[0];
    } else if (event.target.files) { // if there is a file and its media type is of what is allowed
      if (event.target.files[0].type.split('/')[0] === columns.find(column => column.name === field).typeProps[0].accept.split('/')[0])
        val = event.target.files[0];
    } else {
      val = event.target.value;
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