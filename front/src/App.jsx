import "./App.css";
import React from "react";
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Player from "./player/Player";
import { AuthorizationPage } from "./authorization/AuthorizationPage";
import { RegistrationPage } from "./authorization/RegistrationPage";
import { PageBuilder } from "./page_builder/PageBuilder";
import { MainPageSection } from "./mainPage/MainPageSection";


function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route path="*" element={<PageBuilder component={<AuthorizationPage />} />} />
          <Route path="/register" element={<PageBuilder component={<RegistrationPage />} />} />
          <Route path="/player" element={<PageBuilder component={<Player />} />} />
          <Route path="/main" element={<PageBuilder component={ <> <MainPageSection /> <Player /> </>} />} />
          
        </Routes>
      </BrowserRouter>
    </>
  );
};

export default App;
