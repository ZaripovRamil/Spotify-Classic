import React from "react";
import compositor from "./media/compositor.png";
import { useNavigate, createSearchParams } from "react-router-dom";

const useNavigateSearch = () => {
  const navigate = useNavigate();
  return (pathname, params) =>
    navigate({ pathname, search: `?${createSearchParams(params)}` });
};

export const PlaylistCard = ({ playlist }) => {
  const playlistClick = (playlist) =>
    navigateSearch("/playlist", { playlistId: playlist.id});
  const navigateSearch = useNavigateSearch();
  return (
    <div
      className="user-playlist-card"
      onClick={() => {
        playlistClick(playlist);
      }}
    >
      <img className="user-playlist-img" alt="playlist" src={compositor} />
      <p className="user-playlist-title">{playlist.name}</p>
      <p className="user-playlist-author">{playlist.owner.name}</p>
    </div>
  );
};
