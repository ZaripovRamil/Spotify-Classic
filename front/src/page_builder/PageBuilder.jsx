import React, { useEffect, useState } from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import "./PageBuilder.css";
import Player from "../player/Player";

export const PageBuilder = ({ component }) => {
  const [tracksList, setTracksList] = useState(
    JSON.parse(localStorage.getItem("player-tracklist"))
  );
  const [playerConf, setPlayerConf] = useState(
    JSON.parse(localStorage.getItem("player-config"))
  );

  useEffect(() => {
    if (playerConf === null) {
      setPlayerConf((oldPlayerConf) => ({
        ...oldPlayerConf,
        playing: false,
        trackId: "",
        trackPosInAlbum: 0,
      }));
    }
    localStorage.setItem("player-config", JSON.stringify(playerConf));
  }, [playerConf]);

  useEffect(() => {
    localStorage.setItem("player-tracklist", JSON.stringify(tracksList));
  }, [tracksList]);

  const tracksProps = { tracksList, setTracksList, playerConf, setPlayerConf };

  return (
    <>
      <Header />
      <div className="content">
        {React.cloneElement(component, tracksProps)}
      </div>
      <Footer props={tracksProps} />
      <Player props={tracksProps} />
    </>
  );
};
