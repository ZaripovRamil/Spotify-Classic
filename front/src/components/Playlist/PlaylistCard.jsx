import React, { useEffect, useState } from "react";
import compositor from "./media/compositor.png";
import { useNavigate, createSearchParams } from "react-router-dom";
import play from "./media/play.png";
import stop from "./media/stop.png";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

const fetcher = getFetcher(Ports.MusicService);
const prefix = "https://localhost:7022/";

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
      {/* <img
        src={
          playerConf.playing &&
          playlistTracks.find((e) => e.id === playerConf.trackId)
            ? stop
            : play
        }
        alt=""
        className="playlist-btn play-btn"
        onClick={() => {
          playClick();
        }}
      /> */}
      <img
        className="user-playlist-img"
        alt="playlist"
        src={prefix + `Previews/get/${playlist.previewId}`}
      />
      <p className="user-playlist-title">{playlist.name}</p>
      {/* <p className="user-playlist-author">{playlist.owner.name}</p> */}
    </div>
  );
};
