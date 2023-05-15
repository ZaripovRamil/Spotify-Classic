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
      {
        id: "track10",
        fileId: "9d0a67df-6fb4-4fac-b670-49a5f590beb7",
        name: "Lacrimosa",
        album: {
          id: "album8",
          previewId: "9d0a67df-6fb4-4fac-b670-49a5f590beb7",
          name: "Requiem",
          author: {
            id: "author1",
            name: "Wolfgang Amadeus Mozart",
          },
        },
      },
      {
        id: "track11",
        fileId: "15fa89e4-7777-4330-b32e-62172cd398c0",
        name: "Marriage of Figaro - Overture",
        album: {
          id: "album9",
          previewId: "15fa89e4-7777-4330-b32e-62172cd398c0",
          name: "The marriage of Figaro",
          author: {
            id: "author1",
            name: "Wolfgang Amadeus Mozart",
          },
        },
      },
      {
        id: "track12",
        fileId: "493afb2c-eb2a-4eab-9e4e-6585eb9924ae",
        name: "La Campanella",
        album: {
          id: "album10",
          previewId: "493afb2c-eb2a-4eab-9e4e-6585eb9924ae",
          name: "Violin Concerto No. 2",
          author: {
            id: "author9",
            name: "Niccolò Paganini",
          },
        },
      },
      {
        id: "track13",
        fileId: "572cc6a2-a5ba-47f5-8819-8330770cf8b5",
        name: "Never gonna give you up",
        album: {
          id: "album11",
          previewId: "572cc6a2-a5ba-47f5-8819-8330770cf8b5",
          name: "Whenever you need somebody",
          author: {
            id: "author10",
            name: "Rick Astley",
          },
        },
      },
    ],
  });

  const { tracksList, setTracksList, playerConf, setPlayerConf } = props;

  useEffect(() => {
    // fetcher.get("Tracks/get").then((data) => {
    //   setPlaylistTracks(data.data);
    // });
    fetcher
      .get(`Playlists/get/${searchParams.get("playlistId")}`)
      .then((data) => {
        setPlaylist(data.data);
        setPlaylistTracks(data.data.tracks);
        console.log(data.data.tracks);
      });
  }, []);

  const playClick = () => {
    if (playlistTracks !== tracksList) {
      setTracksList(playlistTracks);
    }
    //если треки содержит играющи трек, то меняем состояние игры
    //иначе устанавливаем первый трек альбома
    console.log(playlistTracks.length);
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
        <p className="playlist-name">{playlist.name}</p>
        <div></div>
      </div>
      <div className="playlist-main">
        <div className="playlist-main-img">
          <img src={prefix + `Previews/get/${playlist.previewId}`} alt="" />
        </div>

        <div className="playlist-main-part">
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
