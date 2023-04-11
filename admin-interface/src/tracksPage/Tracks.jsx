import { Fragment } from "react";
import React, { useState } from "react";
import "./Tracks.css";

const Tracks = () => {
  const columns = ["name", "age"];
  const [data, setData] = useState([
    { name: "Alice", age: 25 },
    { name: "Bob", age: 30 },
    { name: "Charlie", age: 35 },
  ]);

  const [editIndex, setEditIndex] = useState(-1);
  const [newData, setNewData] = useState({ name: "", age: 0 });

  const handleSave = (index) => {
    const updatedData = [...data];
    updatedData[index] = { ...updatedData[index], ...newData };
    setData(updatedData);
    setEditIndex(-1);
    setNewData({ name: "", age: 0 });
  };

  const handleCancel = () => {
    setEditIndex(-1);
    setNewData({ name: "", age: 0 });
  };

  const handleAdd = () => {
    const updatedData = [{ ...newData }, ...data];
    setData(updatedData);
    setEditIndex(0);
    setNewData({ name: "", age: 0 });
  };

  const handleDelete = (index) => {
    const updatedData = [...data];
    updatedData.splice(index, 1);
    setData(updatedData);
  };

  return (
    <div className="table-container">
      <button className="button button-add" onClick={handleAdd}>
        Add Track
      </button>
      <table className="table">
        <thead>
          <tr>
            {columns.map((column) => (
              <th key={column}>{column}</th>
            ))}
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {data.map((item, index) => (
            <Fragment key={index}>
              {editIndex === index ? (
                <tr>
                  <td>
                    <input
                      className="input"
                      type="text"
                      value={newData.name}
                      onChange={(e) =>
                        setNewData({ ...newData, name: e.target.value })
                      }
                    />
                  </td>
                  <td>
                    <input
                      className="input"
                      type="text"
                      value={newData.age}
                      onChange={(e) =>
                        setNewData({
                          ...newData,
                          age: parseInt(e.target.value),
                        })
                      }
                    />
                  </td>
                  <td>
                    <button
                      className="button button-save"
                      onClick={() => handleSave(index)}
                    >
                      Save
                    </button>
                    <button
                      className="button button-cancel"
                      onClick={handleCancel}
                    >
                      Cancel
                    </button>
                  </td>
                </tr>
              ) : (
                <tr>
                  <td>{item.name}</td>
                  <td>{item.age}</td>
                  <td>
                    <button
                      className="button button-edit"
                      onClick={() => {
                        setEditIndex(index);
                        setNewData(item);
                      }}
                    >
                      Edit
                    </button>
                    <button
                      className="button button-delete"
                      onClick={() => handleDelete(index)}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              )}
            </Fragment>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Tracks;