import React from "react";
import "./MainPage.css";
import wheelImgSrc from "./media/wheel.png";
import klipartzImgSrc from "./media/klipartz.png";
import { Playlists } from "./containers/playlists";

export const MainPageSection = ({ playerConfig, changeConfig }) => {
  return (
    <>
      <main className="main-page">
        <section className="main_section">
          <div className="main-circle" id="first" />
          <div className="main-circle" id="second" />
          <h1>
            Classic
            <br />
            music
          </h1>
          <div className="wheel-klipartz-container">
            <img alt="klipartz" className="klipartz-img" src={klipartzImgSrc} />
            <div className="wheel-div">
              <img
                alt="wheel"
                className={`main-wheel-img ${
                  playerConfig.playing ? "wheel-img-rotate" : ""
                }`}
                src={wheelImgSrc}
              />
              <input
                type="button"
                className={`polygon-img ${
                  playerConfig.playing ? "buttonWheelStop" : "buttonWheelPlay"
                }`}
                onClick={() => {
                  changeConfig("playing", !playerConfig.playing);
                }}
              />
            </div>
          </div>
        </section>

        <section className="playlists-section">
          <div className="playlists-section-title">
            <h2>Playlists</h2>
          </div>

          <div className="right-btn"></div>
         <Playlists />
          <div className="left-btn"></div>
        </section> 
      </main>
    </>
  );
};
