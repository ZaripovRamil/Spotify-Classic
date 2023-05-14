import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Tracks from './tracksPage/Tracks';
import Albums from './albumsPage/Albums';
import Authors from './authorsPage/Authors';
import Menu from './components/MenuComponent';
import Authorization from './authorizationPage/Authorization';

function App() {
  return (
    <>
      <BrowserRouter>
        <Menu />
        <Routes>
          <Route path="/tracks" element={<Tracks />} />
          <Route path="/albums" element={<Albums />} />
          <Route path="/authors" element={<Authors />} />
          <Route path="/authorize" element={<Authorization />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
