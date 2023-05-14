import React from "react";
import "./MainPage.css";
import wheelImgSrc from "./media/wheel.png";
import klipartzImgSrc from "./media/klipartz.png";
import { Playlists } from "../components/Playlist/Playlists";

export const MainPageSection = (props) => {
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
                className={`main-wheel-img`}
                src={wheelImgSrc}
              />
              <input
                type="button"
                className={`polygon-img`}
              />
            </div>
          </div>
        </section>

        <section className="playlists-section">
          <div className="playlists-section-title">
            <h2>Playlists</h2>
          </div>

          <div className="right-btn"></div>
           <div className="playlists">
         <Playlists  props={props}/>
         </div>
          <div className="left-btn"></div>
        </section> 
      </main>
    </>
  );
};
