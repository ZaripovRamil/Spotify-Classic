import React, { useState } from 'react';
import {
  Button,
  TextField,
  Dialog,
  DialogActions,
  DialogContent,
  DialogTitle,
} from '@material-ui/core';

// onFormDataSubmitWithCallbackAsync should be an async function that receives data from form
// and returns true or false, indicating whether data was proccedeed succesfully or not
const FormDialog = ({ isOpen, setIsOpen, onFormDataSubmitWithCallbackAsync }) => {
  const [formData, setFormData] = useState({
    trackName: '',
    albumId: '',
    genres: [],
    attachment: null,
  });
  const [formError, setFormError] = useState();

  const handleFormChange = (event) => {
    const field = event.target.name;
    let val = null;

    if (event.target.type !== 'file' && field !== 'genres') {
      val = event.target.value;
    } else if (event.target.files && event.target.files[0].type === 'audio/mpeg') {
      val = event.target.files[0];
    }

    if (field === 'genres') {
      const index = event.target.dataset.index;
      const newGenres = [...formData.genres];
      newGenres[index] = event.target.value;
      val = newGenres;
    }

    setFormData({ ...formData, [field]: val });
  };

  const handleAddGenre = () => {
    setFormData({
      ...formData,
      genres: [...formData.genres, ''],
    });
  };

  const validateFormData = () => {
    return formData.trackName && formData.albumId && formData.attachment;
  }

  const handleSubmit = async () => {
    if (!validateFormData()) {
      setFormError('Track name, album id and track mp3 file are required.')
      return;
    }
    const res = await onFormDataSubmitWithCallbackAsync(formData);
    if (!res) {
      setFormError('Something went wrong. Please check the correcteness of your input data');
      return;
    }
    setFormData({
      firstName: '',
      lastName: '',
      email: '',
      attachment: null,
      genres: [''],
    });

    setIsOpen(false);
  };

  return (
    <Dialog open={isOpen} onClose={() => setIsOpen(false)}>
      <DialogTitle>Add new track</DialogTitle>

      <DialogContent>
        <TextField
          required
          autoFocus
          margin="dense"
          name="trackName"
          label="Track name"
          fullWidth
          value={formData.trackName}
          onChange={handleFormChange}
        />

        <TextField
          required
          margin="dense"
          name="albumId"
          label="Album Id"
          fullWidth
          value={formData.albumId}
          onChange={handleFormChange}
        />

        <input
          accept="audio/mp3"
          capture="user"
          id="attachment-input"
          type="file"
          name="attachment"
          onChange={handleFormChange}
          style={{ display: 'none' }}
        />
        <label htmlFor="attachment-input">
          <Button variant="contained" component="span">
            Attach MP3
          </Button>
        </label>
        {formData.attachment && formData.attachment.name}
        <br />

        {formData.genres.map((value, index) => (
          <TextField
            key={index}
            margin="dense"
            name="genres"
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
        </Button>
      </DialogContent>

      <DialogActions>
        <div style={{color: 'red'}}>{formError && formError}</div>
        <Button onClick={() => setIsOpen(false)} color="primary">
          Cancel
        </Button>
        <Button onClick={handleSubmit} color="primary">
          Ok
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default FormDialog;