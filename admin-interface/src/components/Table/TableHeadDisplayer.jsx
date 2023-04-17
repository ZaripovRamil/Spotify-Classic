import React from "react";
import {
    TableHead,
    TableRow,
    TableCell
} from "@material-ui/core";

const TableHeader = ({ columns }) => {
    return (
        <TableHead>
            <TableRow>
                {columns.map((column, index) => (
                    <TableCell key={`column-${index}`}>{column.label}</TableCell>
                ))}
                <TableCell>Action</TableCell>
            </TableRow>
        </TableHead>
    );
}

export default TableHeader;