import React, { useEffect, useState } from "react";
import Track from "../components/Track/Track";
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";
import { useSearchParams, useNavigate } from "react-router-dom";
import back from "./media/back-btn.svg";
import play from "./media/play.png";
import like from "./media/like.png";
import stop from "./media/stop.png";
import "./PlaylistPage.css";

const fetcher = getFetcher(Ports.PlayerApi);

export const PlaylistPage = (props) => {
  const navigate = useNavigate();
  const prefix = `https://localhost:${Ports.StaticApi}/`;
  const [searchParams] = useSearchParams();
  const [isPlaylist, setIsPlaylist] = useState(true);
  const [isLoad, setIsLoad] = useState(false);
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

  const [album, setAlbum] = useState({
    id: "album",
    previewId: "7c561b1e-3070-4e83-b71a-2fd7a69fa040",
    name: "The Four Seasons",
    author: {
      id: "author2",
      name: "Antonio Lucio Vivaldi",
    },
    tracks: [
      {
        id: "track1",
        fileId: "7c561b1e-3070-4e83-b71a-2fd7a69fa040",
        name: "Summer - Storm",
        album: {
          id: "album",
          previewId: "7c561b1e-3070-4e83-b71a-2fd7a69fa040",
          name: "The Four Seasons",
          author: {
            id: "author2",
            name: "Antonio Lucio Vivaldi",
          },
        },
      },
    ],
  });

  const [playlist, setPlaylist] = useState({
    id: "504e5f8a-49b1-4c2f-940b-568ac3e8fef2",
    previewId: "default_playlist",
    name: "Playlist5",
    owner: {
      id: "0bc22af7-4265-47ec-b3de-95588d5f56d4",
      profilePicId: "default_pfp",
      name: "kamilla",
    },
    tracks: [
      {
        id: "track1",
        fileId: "7c561b1e-3070-4e83-b71a-2fd7a69fa040",
        name: "Summer - Storm",
        album: {
          id: "album",
          previewId: "7c561b1e-3070-4e83-b71a-2fd7a69fa040",
          name: "The Four Seasons",
          author: {
            id: "author2",
            name: "Antonio Lucio Vivaldi",
          },
        },
      },
    ],
  });

  const { tracksList, setTracksList, playerConf, setPlayerConf } = props;

  useEffect(() => {
    if (searchParams.get("playlistId")) {
      fetcher
        .get(`Playlists/get/${searchParams.get("playlistId")}`)
        .then((data) => {
          setPlaylist(data.data);
          setPlaylistTracks(data.data.tracks);
          setIsPlaylist(true);
          setIsLoad(true);
          console.log(data.data, isPlaylist);
        })
        .catch((err) => {
          if (err.response.status === 401) navigate("/authorize");
        });
    } else {
      fetcher
        .get(`Albums/get/${searchParams.get("albumId")}`)
        .then((data) => {
          setAlbum(data.data);
          setPlaylistTracks(data.data.tracks);
          setIsPlaylist(false);
          setIsLoad(true);
          console.log(data.data, isPlaylist);
        })
        .catch((err) => {
          if (err.response.status === 401) navigate("/authorize");
        });
    }
  }, [searchParams]);

  const playClick = () => {
    if (playlistTracks !== tracksList) {
      setTracksList(playlistTracks);
      setPlayerConf((oldPlayerConf) => ({
        ...oldPlayerConf,
        trackId: playlistTracks[0].id,
        playing: false,
        trackPosInAlbum: 0,
      }));
    }
    //если треки содержит играющи трек, то меняем состояние игры
    //иначе устанавливаем первый трек альбома
    console.log(playlistTracks.length !== 0);
    if (playlistTracks.length !== 0) {
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
    }
  };

  const backClick = () => {
    window.history.back();
  };

  return (
    isLoad && (
      <main className="main-page">
        <div className="playlistPage">
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

            <p className="playlist-name">
              {isPlaylist ? playlist.name : album.name}
            </p>
            <div></div>
          </div>
          <div className="playlist-main">
            <div className="playlist-main-img">
              <img src={prefix + `Previews/${playlist.previewId}`} alt="" />
            </div>

            <div className="playlist-main-part">
              <p className="playlist-author">
                {isPlaylist ? (
                  <div>
                    Плейлист пользователя <b>{playlist.owner.name}</b>
                  </div>
                ) : (
                  <div>
                    Альбом <b>{album.author.name}</b>
                  </div>
                )}
              </p>
              <div className="playlist-btns">
                <img
                  src={
                    playerConf.playing && playlistTracks === tracksList
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
                {playlistTracks && playlistTracks.map((track, id) => (
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
        </div>
      </main>
    )
  );
};
