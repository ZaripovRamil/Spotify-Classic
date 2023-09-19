// import { makeStyles } from '@mui/styles';

// export const TableStyles = makeStyles((theme) => ({
export const TableStyles = () => ({
  root: {
    maxWidth: '60%',
    margin: '0 auto',
    // backgroundColor: theme.palette.background.paper,
  },
  table: {
    minWidth: 650,
    borderCollapse: "collapse",
    "& td, & th": {
      border: "1px solid #ddd",
      padding: 8,
      textAlign: "left"
    }
  },
  addButton: {
    background: "#4caf50",
    color: "white"
  },
  editButton: {
    background: "#2196f3",
    color: "white"
  },
  deleteButton: {
    background: "#f44336",
    color: "white"
  },
  saveButton: {
    background: "#4caf50",
    color: "white"
  },
  cancelButton: {
    background: "#ccc",
    color: "white"
  },
  input: {
    marginBottom: 8,
    borderRadius: 4,
    border: '1px solid #ddd'
  },
  formContainer: {
    padding: '16px',
    marginTop: '16px',
    borderRadius: '4px',
    backgroundColor: '#f9f9f9',
    border: '1px solid #ddd'
  }
});