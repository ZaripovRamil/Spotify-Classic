import React, { useEffect, useState, useRef } from "react";
import moment from "moment/moment";
import ReactPlayer from "react-player/lazy";
import { getFetcher } from "../../axios/AxiosInstance";
import "./Track.css";
import Ports from "../../constants/Ports";

// care of http/https
const prefix = "https://localhost:7022/";
const fetcher = getFetcher(Ports.MusicService);

const Track = () => {
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

    const changeConfig = (configName, configValue) => {
        playerConfig[configName] = configValue;
        // to keep volume level in (0, 1) range. otherwise player falls
        playerConfig.volume = Math.max(0, Math.min(1, playerConfig.volume));
        playerConfig.playbackRate = Math.max(0.1, Math.min(2, playerConfig.playbackRate));
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
                style={{ display: "None" }}/>
            <div className="track">
                <div className="track-preview">
                    <div className="track-play-img">
                        {tracks.id !== "" && <img className="track-img" src={prefix + `Previews/${tracks[playerConfig.trackId].id}`} onError={({currentTarget}) => {
                            currentTarget.onerror = null;
                            currentTarget.src = prefix+`Previews/${tracks[playerConfig.trackId].album.id}`;
                        }}/>}

                        <input type='button'
                            className={`track-btn ${playerConfig.playing ? 'track-buttonStop' : 'track-buttonPlay'}`}
                            onClick={() => { changeConfig('playing', !playerConfig.playing) }} />
                    </div>
                    <div>{tracks[playerConfig.trackId].name}
                        {tracks.id !== "" && <div className="track-audiotrack-auth">{tracks[playerConfig.trackId].album.author.name}</div>}
                    </div>   
                </div> 
                <div className="track-info">
                    {/*TODO: logic of this button */}
                    <input type='button' className="track-buttonLike" />
                    <div className="track-duration">{moment(1000 * trackInfo.duration).format('mm:ss')}</div>
                </div>
            </div>
        </>
    )
}
export default Track;