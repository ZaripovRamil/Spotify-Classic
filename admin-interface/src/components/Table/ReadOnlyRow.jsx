import React from "react";
import {
	TableRow,
	TableCell,
	IconButton,
} from '@material-ui/core';
import {
	Edit as EditIcon,
	Delete as DeleteIcon
} from "@material-ui/icons";
import { TableStyles } from "./TableStyles";

const ReadOnlyRow = ({ data, deleteDataWithResultAsync, columns, setEditIndex, item, index, setNewData }) => {
	const handleDelete = async () => {
		const res = await deleteDataWithResultAsync(data[index]);
		if (!res) {
			alert('There was an error while deleting the data. Please, refresh the page and try again');
			return;
		}
	};

	const handleEdit = () => {
		setEditIndex(index);
		setNewData(item);
	}

	const classes = TableStyles();
	return (
		<TableRow>
			{columns.map((column) => (
				<TableCell key={column.name}>{column.name.split('.').reduce((o, propName) => o === undefined ? undefined : o[propName], data[index])}</TableCell>
			))}
			<TableCell>
				<IconButton
					aria-label="edit"
					className={classes.editButton}
					onClick={handleEdit}
				>
					<EditIcon />
				</IconButton>
				<IconButton
					aria-label="delete"
					className={classes.deleteButton}
					onClick={handleDelete}
				>
					<DeleteIcon />
				</IconButton>
			</TableCell>
		</TableRow>
	);
}

export default ReadOnlyRow;