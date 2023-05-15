import { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import { Playlists } from "../../components/Playlist/Playlists";
import "./UserMain.css";

export const UserMain = (props) => {
  return (
    <>
      <div className="user-playlists-block">
        <div className="user-playlists">
          <Playlists playlists={props.playlists} />
        </div>
      </div>
    </>
  );
};
