import React, { useState } from "react";
import TableDisplayer from "../components/Table/TableDisplayer";

const Tracks = () => {
  const [data, setData] = useState([
    { name: "Alice", age: 25 },
    { name: "Bob", age: 30 },
    { name: "Charlie", age: 35 },
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

export default Tracks;