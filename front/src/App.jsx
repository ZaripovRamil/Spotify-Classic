import "./App.css";
import React from "react";
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Player from "./player/Player";
import { AuthorizationPage } from "./authorization/AuthorizationPage";
import { RegistrationPage } from "./authorization/RegistrationPage";
import { PageBuilder } from "./page_builder/PageBuilder";
import { MainPageSection } from "./mainPage/MainPageSection";
import { UserProfile } from "./userPage/UserProfile";
import { UserHistory } from "./userPage/userHistory/UserHistory";
import { UserMain } from "./userPage/userMain/UserMain";


function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route path="*" element={<PageBuilder component={<AuthorizationPage />} />} />
          <Route path="/register" element={<PageBuilder component={<RegistrationPage />} />} />
          <Route path="/player" element={<PageBuilder component={<Player />} />} />
          <Route path="/main" element={<PageBuilder component={<MainPageSection />} />} />
          <Route path="/history" element={<PageBuilder component={<UserProfile component={<UserHistory/>}/>} />} />
          <Route path="/user" element={<PageBuilder component={<UserProfile component={<UserMain/>}/>} />} />
        </Routes>
      </BrowserRouter>
    </>
  );
};

export default App;
