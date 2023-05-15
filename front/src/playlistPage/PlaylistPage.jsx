import React, { useEffect, useState } from "react";
import Track from "../components/Track/Track";
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";
import { useSearchParams } from "react-router-dom";
import back from "./media/back-btn.svg";
import play from "./media/play.png";
import like from "./media/like.png";
import stop from "./media/stop.png";
import "./PlaylistPage.css";

const fetcher = getFetcher(Ports.MusicService);

export const PlaylistPage = (props) => {
  const prefix = "https://localhost:7022/";
  const [searchParams] = useSearchParams();

  const [playlistTracks, setPlaylistTracks] = useState([
    {
      fileId: "29ad8ca9-c791-4482-8a44-15776862b282",
      name: "Waltz No. 2",
      id: "track4",
      album: {
        previewId: "857e8dea-a4e3-431e-92d5-c50c515c3126",
        name: "Waltz No. 2",
        id: "album2",
        author: {
          id: "e791ac96-58fe-4e51-9a6d-248cbb6a1043",
          name: "Dmitri Shostakovich",
        },
      },
    },
  ]);

  const [playlist, setPlaylist] = useState({
    id: "7a9fc350-feb2-4429-ba6a-37d2af958f3a",
    previewId: "default_playlist",
    name: "Playlist4",
    owner: {
      id: "0bc22af7-4265-47ec-b3de-95588d5f56d4",
      profilePicId: "default_pfp",
      name: "kamilla",
    },
    trackCount: 0,
  });

  const { tracksList, setTracksList, playerConf, setPlayerConf } = props;

  useEffect(() => {
    fetcher.get("Tracks/get").then((data) => {
      setPlaylistTracks(data.data);
    });
    // fetcher.get(`Playlists/id/${idPlaylist}`).then((data) => {setPlaylist(data.data);setPlaylistTracks(data.data.tracks);});
  }, []);

  const playClick = () => {
    if (playlistTracks !== tracksList) {
      setTracksList(playlistTracks);
    }
    //если треки содержит играющи трек, то меняем состояние игры
    //иначе устанавливаем первый трек альбома
    if (playlistTracks.some((e) => e.id === playerConf.trackId)) {
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

  const backClick = () => {
    window.history.back();
  };

  return (
    <main className="main-page">
      <div className="playlist-btn-header">
        <div className="playlist-back-btn">
          <img
            src={back}
            alt="back"
            onClick={() => {
              backClick();
            }}
          />
        </div>
        <p className="playlist-name">{playlistTracks[0].album.name}</p>
        <div></div>
      </div>
      <div className="playlist-main">
        <div className="playlist-main-img">
          <img src={prefix + `Previews/get/${playlist.previewId}`} alt="" />
        </div>

        <div className="playlist-main-part">
          <p className="playlist-author">П.И.Чайковский</p>
          <div className="playlist-btns">
            <img
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
            />
            <img src={like} alt="" className="playlist-btn like-btn" />
          </div>
          <div className="playlist-tracks">
            {playlistTracks.map((track, id) => (
              <Track
                props={props}
                tracks={playlistTracks}
                track={track}
                idInAlbum={id}
              />
            ))}
          </div>
        </div>
      </div>
    </main>
  );
};
