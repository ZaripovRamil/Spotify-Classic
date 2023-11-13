import React from "react";
import { useNavigate, createSearchParams } from "react-router-dom";
import Ports from "../../constants/Ports";

const prefix = `https://localhost:${Ports.StaticApi}/`;

const useNavigateSearch = () => {
  const navigate = useNavigate();
  return (pathname, params) =>
    navigate({ pathname, search: `?${createSearchParams(params)}` });
};

export const PlaylistCard = ({ playlist }) => {
  const playlistClick = (playlist) =>
    navigateSearch("/playlist", { playlistId: playlist.id });

  const navigateSearch = useNavigateSearch();

  return (
    <div
      className="user-playlist-card"
      onClick={() => {
        playlistClick(playlist);
      }}
    >
      <img
        className="user-playlist-img"
        alt="playlist"
        src={prefix + `Previews/${playlist.previewId}`}
      />
      <p className="user-playlist-title">{playlist.name}</p>
    </div>
  );
};
