import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Tracks from './tracksPage/Tracks';
import Albums from './albumsPage/Albums';
import Authors from './authorsPage/Authors';
import Menu from './components/MenuComponent';

function App() {
  return (
    <>
      <BrowserRouter>
        <Menu />
        <Routes>
          <Route path="/tracks" element={<Tracks />} />
          <Route path="/albums" element={<Albums />} />
          <Route path="/authors" element={<Authors />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
