import React, { useEffect, useState, useRef } from "react";
// import { fetcher } from "../axios/AxiosInstance.js";
// import { PlaylistCard } from "./PlaylistCard";
import { PlaylistCard } from "./PlaylistCard";
import "../../components/Playlist/PlaylistCard.css";

export const Playlists = ({ props }) => {
  const playlistsArray = [
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
    { name: "Title", owner: "Author", img: "./media/compositor.png" },
  ];
  const [playlists, setPlaylists] = useState(playlistsArray);

  //get data from playlists controller in future
  // useEffect(() => {
  //     fetcher.get('playlists').then((data) => setPlaylists(data.data));
  // }, [])

  return (
    <>
      {playlists.map((playlist) => (
        <PlaylistCard playlist={playlist} props={props} />
      ))}
    </>
  );
};