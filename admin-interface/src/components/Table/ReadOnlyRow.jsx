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

const getCompoundProperty = (object, property, delimeter = '.') => {
	return property.split(delimeter).reduce((obj, propName) => obj ? obj[propName] : obj, object) || "";
}

const ReadOnlyRow = ({ data, setData, columns, setEditIndex, item, index, setNewData, deleteDataWithResultAsync }) => {
	const handleDelete = async () => {
		if (!window.confirm("You're about to delete this item. Are you sure?")) return;
		const res = await deleteDataWithResultAsync(data[index]);
		if (!res.isSuccessful) {
			alert(res.resultMessage);
			return;
		}
		setData(data.filter((_, i) => i !== index));
	};

	const handleEdit = () => {
		setEditIndex(index);
		setNewData(structuredClone(item));
	}

	const classes = TableStyles();
	return (
		<TableRow>
			{columns.map((column) => (
				<TableCell key={column.name}>{getCompoundProperty(data[index], column.name)}</TableCell>
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