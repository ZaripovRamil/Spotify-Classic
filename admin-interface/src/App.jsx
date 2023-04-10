import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Tracks from './tracksPage/Tracks';
import Albums from './albumsPage/Albums';
import Authors from './authorsPage/Authors';
import './App.css';

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route path="/tracks" element={<Tracks />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
