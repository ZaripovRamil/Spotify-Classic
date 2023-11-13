import React, { useState, useEffect } from "react";
import "./MainPage.css";
import wheelImgSrc from "./media/wheel.png";
import klipartzImgSrc from "./media/klipartz.png";
import { Playlists } from "../components/Playlist/Playlists";
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.PlayerApi);

export const MainPageSection = (props) => {
  const playlistsArray = [
    {
      id: "504e5f8a-49b1-4c2f-940b-568ac3e8fef2",
      previewId: "default_playlist",
      name: "Playlist5",
      owner: {
        id: "0bc22af7-4265-47ec-b3de-95588d5f56d4",
        profilePicId: "default_pfp",
        name: "kamilla",
      },
      trackCount: 5,
    },
  ];

  const [playlists, setPlaylists] = useState(playlistsArray);

  useEffect(() => {
    const authToken = localStorage.getItem("access-token");
    authToken &&
      fetcher.get("Playlists/get").then((data) => setPlaylists(data.data));
  }, []);

  return (
    <>
      <p>{Ports.AuthApi}</p>
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
              <img alt="wheel" className={`main-wheel-img`} src={wheelImgSrc} />
              <input type="button" className={`polygon-img`} />
            </div>
          </div>
        </section>

        <section className="playlists-section">
          <div className="playlists-section-title">
            <h2>Playlists</h2>
          </div>

          <div className="right-btn"></div>
          <div className="playlists">
            <Playlists playlists={playlists} />
          </div>
          <div className="left-btn"></div>
        </section>
      </main>
    </>
  );
};
