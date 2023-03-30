import React, { useEffect, useState, useRef } from "react";
import moment from "moment/moment";
import ReactPlayer from "react-player/lazy";
import { getFetcher } from "../axios/AxiosInstance";
import "./PlayerStyles.css";
import volume from "./PlayerImages/volume.svg";
import Ports from '../constants/Ports';

// care of http/https
const prefix = "https://localhost:7022/";
const fetcher = getFetcher(Ports.MusicService);

const Player = () => {
    const [tracks, setTracks] = useState([{
        id: "",
        name: "",
        album: {
            id: "",
            name: "",
            author: {
                id: "",
                name: ""
            }
        }
    }]);
    const player = useRef(null);
    useEffect(() => {
        // TODO: add .catch()?
        fetcher.get('tracks').then((data) => setTracks(data.data));
    }, [])


    const [playerConfig, setPlayerCongig] = useState({
        "controls": false,
        "trackId": 0,
        "playing": false,
        "volume": 0.8,
        "playbackRate": 1.0,
        "seeking": false
    });

    isPlaying = playerConfig.playing;

    const changeConfig = (configName, configValue) => {
        playerConfig[configName] = configValue;
        // to keep volume level in (0, 1) range. otherwise player falls
        playerConfig.volume = Math.max(0, Math.min(1, playerConfig.volume));
        playerConfig.playbackRate = Math.max(0.1, Math.min(2, playerConfig.playbackRate));
        setPlayerCongig({ ...playerConfig });
    };

    const playNext = () => {
        playerConfig.trackId = (playerConfig.trackId + 1) % tracks.length;
        setPlayerCongig({ ...playerConfig });
    };

    const playPrevious = () => {
        playerConfig.trackId = (playerConfig.trackId - 1 + tracks.length) % tracks.length;
        setPlayerCongig({ ...playerConfig });
    };

    // duration is the track duration in seconds
    // played and loaded are in range(0, 1) from 0 progress to 100% progress
    const [trackInfo, setTrackInfo] = useState({
        "duration": 0.0,
        "played": 0.0,
        "loaded": 0.0
    });

    const updateTrackInfo = (parameter, value) => {
        trackInfo[parameter] = value;
        setTrackInfo({ ...trackInfo });
    }
    ReactPlayer.removeCustomPlayers();

    return (
        <>
            <ReactPlayer
                ref={player}
                controls={playerConfig.controls}
                playing={playerConfig.playing}
                playbackRate={playerConfig.playbackRate}
                volume={playerConfig.volume}
                url={prefix + "tracks/" + tracks[playerConfig.trackId].id}
                onDuration={(duration) => updateTrackInfo('duration', duration.toFixed(2))}
                onProgress={(state) => {
                    updateTrackInfo('played', +state.played.toFixed(4));
                    updateTrackInfo('loaded', +state.loaded.toFixed(4));
                }}
                style={{ display: "None" }}
            />
            <div className="player">
                <div className="player-controls">
                    <div className="switch-btns player-btns">

                        <input type='button' className="player-btn buttonPrevious" onClick={() => playPrevious()} />

                        <input type='button'
                            className={`player-btn ${playerConfig.playing ? 'buttonStop' : 'buttonPlay'}`}
                            onClick={() => { changeConfig('playing', !playerConfig.playing) }} />

                        <input type='button' className="player-btn buttonNext" onClick={() => playNext()} />

                    </div>
                    <div className="player-track">
                        <div className="track-img" >
                            {tracks.id !== "" && <img style={{ width: "70px" }} src={prefix + `Previews/${tracks[playerConfig.trackId].id}`} width={"100%"} />}
                        </div>

                        <div className="track-control">
                            <div className="track-info">
                                <div>{tracks[playerConfig.trackId].name}
                                    {tracks.id !== "" && <div className="track-auth">{tracks[playerConfig.trackId].album.author.name}</div>}
                                </div>

                                <div className="player-btns track-btns">
                                    {/*TODO: logic of this buttons */}
                                    <input type='button' className="player-btn buttonRepeat" />
                                    <input type='button' className="player-btn buttonMix" />
                                    <input type='button' className="player-btn buttonLike" />
                                </div>
                            </div>

                            <input
                                className="music-track"
                                type="range"
                                min={0}
                                max={0.999999}
                                step="any"
                                value={trackInfo.played}
                                onChange={(e) => {
                                    player.current.seekTo(parseFloat(e.target.value), 'fraction');
                                }} />

                            <div className="track-time">
                                <div >{moment(1000 * trackInfo.played * trackInfo.duration).format('mm:ss')}</div>
                                <div>{moment(1000 * trackInfo.duration).format('mm:ss')}</div>
                            </div>
                        </div>
                    </div>

                    <div className="player-volume">
                        <img width={"23px"} height={"20px"} src={volume} />
                        <input type="range" min="0" max="1" step="0.1" onChange={(e) =>
                            playerConfig.volume = +e.target.value} />
                    </div>
                </div>
            </div>
        </>
    )
}

export default Player;