import React, { useEffect, useState, useRef } from "react";
// import { fetcher } from "../axios/AxiosInstance.js";
import { PlaylistCard } from "./PlaylistCard";

export const Playlists = ({playlists}) => {


  return (
    <div className="user-playlists">
      {playlists.map((playlist) => (
        <PlaylistCard playlist={playlist} />
      ))}
    </div>
  );
};
