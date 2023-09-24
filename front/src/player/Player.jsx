import React, { useState, useRef } from "react";
import moment from "moment/moment";
import ReactPlayer from "react-player/lazy";
import "./PlayerStyles.css";
import volume from "./PlayerImages/volume.svg";
import { useNavigate } from "react-router-dom";

// care of http/https
const prefix = "https://localhost:7022/";

const Player = ({ props }) => {
  const navigate = useNavigate();
  const { tracksList, playerConf, setPlayerConf } = props;
  // const [tracks, setTracks] = useState([
  //   {
  //     id: "",
  //     fileId: "",
  //     name: "",
  //     album: {
  //       id: "",
  //       name: "",
  //       previewId: "",
  //       author: {
  //         id: "",
  //         name: "",
  //       },
  //     },
  //   },
  // ]);
  // const player = useRef(null);
  // useEffect(() => {
  //   // TODO: add .catch()?
  //   fetcher.get("tracks/get").then((data) => setTracks(data.data));
  //   setTracksList(tracks);
  // }, []);
  const player = useRef(null);

  const [playerConfig] = useState({
    controls: false,
    volume: 0.8,
    playbackRate: 1.0,
    seeking: false,
  });

  const playNext = () => {
    playerConf.trackPosInAlbum =
      (playerConf.trackPosInAlbum + 1) % tracksList.length;
    playerConf.trackId = tracksList[playerConf.trackPosInAlbum].id;
    setPlayerConf({ ...playerConf });
  };

  const playPrevious = () => {
    playerConf.trackPosInAlbum =
      (playerConf.trackPosInAlbum - 1 + tracksList.length) % tracksList.length;
    playerConf.trackId = tracksList[playerConf.trackPosInAlbum].id;
    setPlayerConf({ ...playerConf });
  };

  // duration is the track duration in seconds
  // played and loaded are in range(0, 1) from 0 progress to 100% progress
  const [trackInfo, setTrackInfo] = useState({
    duration: 0.0,
    played: 0.0,
    loaded: 0.0,
  });

  const updateTrackInfo = (parameter, value) => {
    trackInfo[parameter] = value;
    setTrackInfo({ ...trackInfo });
  };

  const getToken = () => {
    const token = localStorage.getItem("access-token");
    return token ?? "";
  };

  const audioNameClick = (id) => {
    console.log(id);
    navigate({
      pathname: "/album",
      search: `?albumId=${id}`,
    });
  };

  ReactPlayer.removeCustomPlayers();

  return (
    <>
      {localStorage.getItem("access-token") && tracksList && playerConf && (
        <ReactPlayer
          ref={player}
          controls={playerConfig.controls}
          playing={playerConf.playing}
          playbackRate={playerConfig.playbackRate}
          volume={playerConfig.volume}
          url={
            tracksList &&
            prefix + "tracks/get/" + tracksList[playerConf.trackPosInAlbum].id
          }
          onDuration={(duration) =>
            updateTrackInfo("duration", duration.toFixed(2))
          }
          onProgress={(state) => {
            updateTrackInfo("played", +state.played.toFixed(4));
            updateTrackInfo("loaded", +state.loaded.toFixed(4));
          }}
          config={{
            file: {
              forceHLS: true,
              hlsOptions: {
                xhrSetup: function (xhr, url) {
                  xhr.setRequestHeader("Authorization", `Bearer ${getToken()}`);
                },
              },
            },
          }}
          onEnded={playNext}
          style={{ display: "None" }}
        />
      )}
      {localStorage.getItem("access-token") && tracksList && playerConf && (
        <div className="player">
          <div className="player-controls">
            <div className="player-switch-btns player-btns">
              <input
                type="button"
                className="player-btn player-buttonPrevious"
                onClick={() => playPrevious()}
              />

              {
                <input
                  type="button"
                  className={`player-btn ${
                    playerConf.playing
                      ? "player-buttonStop"
                      : "player-buttonPlay"
                  }`}
                  onClick={() => {
                    setPlayerConf((oldPlayerConf) => ({
                      ...oldPlayerConf,
                      playing: !oldPlayerConf.playing,
                    }));
                  }}
                />
              }

              <input
                type="button"
                className="player-btn player-buttonNext"
                onClick={() => playNext()}
              />
            </div>
            <div className="player-audiotrack">
              <div className="player-audiotrack-img">
                {playerConf.trackId !== "" && (
                  <img
                    style={{ maxWidth: "70px", maxHeight: "70px" }}
                    src={
                      prefix +
                      `Previews/get/${
                        tracksList[playerConf.trackPosInAlbum].album.previewId
                      }`
                    }
                    alt="img"
                    width={"100%"}
                    onError={({ currentTarget }) => {
                      currentTarget.onerror = null;
                    }}
                  />
                )}
              </div>

              <div className="player-audiotrack-control">
                <div className="player-audiotrack-info">
                  <div>
                    <div
                      className="player-audiotrack-name"
                      onClick={() => {
                        audioNameClick(
                          tracksList[playerConf.trackPosInAlbum].album.id
                        );
                      }}
                    >
                      {tracksList[playerConf.trackPosInAlbum].name}
                    </div>
                    {playerConf.trackId !== "" && (
                      <div className="player-audiotrack-auth">
                        {
                          tracksList[playerConf.trackPosInAlbum].album.author
                            .name
                        }
                      </div>
                    )}
                  </div>

                  <div className="player-btns">
                    {/*TODO: logic of this buttons */}
                    <input
                      type="button"
                      className="player-btn player-buttonRepeat"
                    />
                    <input
                      type="button"
                      className="player-btn player-buttonMix"
                    />
                    <input
                      type="button"
                      className="player-btn player-buttonLike"
                    />
                  </div>
                </div>

                <input
                  className="player-music-track"
                  type="range"
                  min={0}
                  max={0.999999}
                  step="any"
                  value={trackInfo.played}
                  onChange={(e) => {
                    player.current.seekTo(
                      parseFloat(e.target.value),
                      "fraction"
                    );
                  }}
                />

                <div className="player-track-time">
                  <div>
                    {moment(
                      1000 * trackInfo.played * trackInfo.duration
                    ).format("mm:ss")}
                  </div>
                  <div>{moment(1000 * trackInfo.duration).format("mm:ss")}</div>
                </div>
              </div>
            </div>

            <div className="player-volume">
              <img width={"23px"} height={"20px"} src={volume} alt="img" />
              <input
                type="range"
                min="0"
                max="1"
                step="0.1"
                onChange={(e) => (playerConfig.volume = +e.target.value)}
              />
            </div>
          </div>
        </div>
      )}
    </>
  );
};

export default Player;
