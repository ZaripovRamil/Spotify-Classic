import React, { useState } from "react";
import TableDisplayer from "../components/Table/TableDisplayer";

const Authors = () => {
  const [data, setData] = useState([
    { name: "Bob", age: 30 },
    { name: "Charlie", age: 35 },
    { name: "Alice", age: 25 },
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

export default Authors;