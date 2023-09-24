import React from "react";
import { PlaylistCard } from "./PlaylistCard";
import "../../components/Playlist/PlaylistCard.css";

export const Playlists = ({ playlists }) => {
  return (
    <>
      {playlists.map((playlist) => (
        <PlaylistCard playlist={playlist} />
      ))}
    </>
  );
};
