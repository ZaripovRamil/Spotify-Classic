import React, { useState } from "react";
import TableDisplayer from "../components/Table/TableDisplayer";

const Albums = () => {
  const [data, setData] = useState([
    { name: "Alice", age: 25 },
    { name: "Charlie", age: 35 },
    { name: "Bob", age: 30 },
  ]);

  const columns = [
    {
      name: "name",
      label: "name",
      type: "text",
    },
    {
      name: "age",
      label: "age",
      type: "number",
    }
  ];

  return (
    <>
      <TableDisplayer data={data} columns={columns} onDataChange={setData} />
    </>
  );
}

export default Albums;