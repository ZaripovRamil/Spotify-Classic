import React from "react";
import { Button, DialogActions } from '@mui/material';

const FormDialogActions = ({ setIsOpen, handleFormSubmit }) => {
    return (
        <DialogActions>
            <Button onClick={() => setIsOpen(false)} color="primary">Cancel</Button>
            <Button onClick={handleFormSubmit} color="primary">Ok</Button>
        </DialogActions>
    );
}

export default FormDialogActions;