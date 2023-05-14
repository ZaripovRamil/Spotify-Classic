import React, { useEffect, useState } from "react";
import compositor from "./media/compositor.png";
import { useNavigate, createSearchParams } from "react-router-dom";
import play from "./media/play.png";
import stop from "./media/stop.png";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

const fetcher = getFetcher(Ports.MusicService);

const useNavigateSearch = () => {
  const navigate = useNavigate();
  return (pathname, params) =>
    navigate({ pathname, search: `?${createSearchParams(params)}` });
};

export const PlaylistCard = ({ playlist, props }) => {
  const [playlistTracks, setPlaylistTracks] = useState();
  const { tracksList, setTracksList, playerConf, setPlayerConf } = props;
  const playlistClick = (playlist) =>
    navigateSearch("/playlist", { playlistId: playlist.id });

  const playClick = () => {
    fetcher.get("tracks").then((data) => {
      setPlaylistTracks(data.data);
    });
    //если треки содержит играющи трек, то меняем состояние игры
    //иначе устанавливаем первый трек альбома
    if (playlistTracks.find((e) => e.id === playerConf.trackId)) {
      setPlayerConf((oldPlayerConf) => ({
        ...oldPlayerConf,
        playing: !oldPlayerConf.playing,
      }));
    } else {
      setPlayerConf((oldPlayerConf) => ({
        ...oldPlayerConf,
        trackId: playlistTracks[0].id,
        playing: true,
        trackPosInAlbum: 0,
      }));
    }
  };

  // const playlistPlayClick = (track) => {
  //   if (tracks !== tracksList) {
  //     setTracksList(tracks);
  //   }
  //   if (track.id === playerConf.trackId) {
  //     setPlayerConf((oldPlayerConf) => ({
  //       ...oldPlayerConf,
  //       playing: !oldPlayerConf.playing,
  //     }));
  //   } else {
  //     setPlayerConf((oldPlayerConf) => ({
  //       ...oldPlayerConf,
  //       trackId: track.id,
  //       playing: true,
  //       trackPosInAlbum: idInAlbum,
  //     }));
  //   }
  // };

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
      <img className="user-playlist-img" alt="playlist" src={compositor} />
      <p className="user-playlist-title">{playlist.name}</p>
      <p className="user-playlist-author">{playlist.owner.name}</p>
    </div>
  );
};
