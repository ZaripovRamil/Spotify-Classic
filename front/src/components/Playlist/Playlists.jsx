import React, { useEffect, useState, useRef } from "react";
// import { fetcher } from "../axios/AxiosInstance.js";
// import { PlaylistCard } from "./PlaylistCard";
import { PlaylistCard } from "./PlaylistCard";
import "../../components/Playlist/PlaylistCard.css";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

const fetcher = getFetcher(Ports.MusicService);

export const Playlists = ({ playlists }) => {
  // const playlistsArray = [
  //   {
  //     id: "504e5f8a-49b1-4c2f-940b-568ac3e8fef2",
  //     previewId: "default_playlist",
  //     name: "Playlist5",
  //     owner: {
  //       id: "0bc22af7-4265-47ec-b3de-95588d5f56d4",
  //       profilePicId: "default_pfp",
  //       name: "kamilla",
  //     },
  //     trackCount: 5,
  //   },
  // ];
  // const [playlists, setPlaylists] = useState(playlistsArray);

  //get data from playlists controller in future
  useEffect(() => {
    // fetcher.get("Playlists/get").then((data) => setPlaylists(data.data));
  }, []);

  return (
    <>
      {playlists.map((playlist) => (
        <PlaylistCard playlist={playlist} />
      ))}
    </>
  );
};
