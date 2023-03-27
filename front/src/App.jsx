import "./App.css";
import React, { useEffect, useState, useRef } from "react";
import Player from "./player/Player";
import { Header } from "./components/Header/Header";
import { Footer } from "./components/Footer/Footer";
import { AuthorizationPage } from "./authorization/AuthorizationPage";
import { RegistrationPage } from "./authorization/RegistrationPage";
import { MainPageSection } from "./mainPage/MainPageSection";
import { Routes, Route, Router } from "react-router-dom";

function App() {
  const [playerConfig, setPlayerConfig] = useState({
    controls: false,
    trackId: 0,
    playing: false,
    volume: 0.8,
    playbackRate: 1.0,
    seeking: false,
  });

  const changeConfig = (configName, configValue) => {
    playerConfig[configName] = configValue;
    // to keep volume level in (0, 1) range. otherwise player falls
    playerConfig.volume = Math.max(0, Math.min(1, playerConfig.volume));
    playerConfig.playbackRate = Math.max(
      0.1,
      Math.min(2, playerConfig.playbackRate)
    );
    setPlayerConfig({ ...playerConfig });
  };

  return (
    <>
        <Header />
        <div className="content">
          <Routes>
            <Route
              path={"/"}
              element={
                <MainPageSection
                  playerConfig={playerConfig}
                  changeConfig={changeConfig}
                />
              }
            ></Route>
            <Route
              path={"/registration"}
              element={<RegistrationPage />}
            ></Route>

            <Route
              path={"/authorization"}
              element={<AuthorizationPage />}
            ></Route>
          </Routes>

          <Player
            playerConfig={playerConfig}
            setPlayerConfig={setPlayerConfig}
            changeConfig={changeConfig}
          />
        </div>

        <Footer />
    </>
  );
}

export default App;
