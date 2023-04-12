import React, { useState } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Tracks from './tracksPage/Tracks';
import Albums from './albumsPage/Albums';
import Authors from './authorsPage/Authors';
import Menu from './components/MenuComponent';
import './App.css';

function App() {
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
      <BrowserRouter>
        <Menu />
        <Routes>
          <Route path="/tracks" element={<Tracks data={data} onDataChange={setData} columns={columns} />} />
          <Route path="/albums" element={<Albums />} />
          <Route path="/authors" element={<Authors />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
