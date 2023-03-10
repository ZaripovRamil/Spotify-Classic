import React, { useEffect, useState } from "react";
import ReactPlayer from "react-player/lazy";
import { instance } from "../axios/AxiosInstance";

const prefix = "https://localhost:7022/api/";

const Player = () => {
    const [tracks, setTracks] = useState([{
        url: "",
        name: ""
    }]);
    useEffect(() => {
        instance.get('tracks').then((data) => setTracks(data.data));
    }, [])

    const [playerConfig, setPlayerCongig] = useState({
        "controls": false,
        "urlId": 0,
        "playing": false,
        "volume": 0.8,
        "playbackRate": 1.0,
    });

    const changeConfig = (configName, configValue) => {
        playerConfig[configName] = configValue;
        setPlayerCongig({ ...playerConfig });
    };

    // these functions may be replaced with
    // changeConfig("urlId", (playerConfig.urlId + 1) % tracks.length)
    const playNext = () => {
        playerConfig.urlId = (playerConfig.urlId + 1) % tracks.length;
        playerConfig.volume = Math.max(0, Math.min(1, playerConfig.volume));
        setPlayerCongig({ ...playerConfig });
    };

    const playPrevious = () => {
        playerConfig.urlId = (playerConfig.urlId - 1 + tracks.length) % tracks.length;
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

    return (
        <>
            <ReactPlayer
                controls={playerConfig.controls}
                playing={playerConfig.playing}
                playbackRate={playerConfig.playbackRate}
                volume={playerConfig.volume}
                url={prefix + tracks[playerConfig.urlId].url}
                style={{ display: "None" }}
                onDuration={(duration) => updateTrackInfo('duration', duration.toFixed(2))}
                onProgress={(state) => {
                    updateTrackInfo('played', state.played.toFixed(4));
                    updateTrackInfo('loaded', state.loaded.toFixed(4));
                }}
            />
            {`playing track ${tracks[playerConfig.urlId].name}`}
            <div className="player-controls">
                <input type='button' value='play/stop' onClick={() => changeConfig('playing', !playerConfig.playing)} />
                <input type='button' value='volume+' onClick={() => changeConfig('volume', (playerConfig.volume + 0.1).toFixed(2))} />
                <input type='button' value='volume-' onClick={() => changeConfig('volume', (playerConfig.volume - 0.1).toFixed(2))} />
                <input type='button' value='speed+' onClick={() => changeConfig('playbackRate', (playerConfig.playbackRate + 0.1).toFixed(2))} />
                <input type='button' value='speed-' onClick={() => changeConfig('playbackRate', (playerConfig.playbackRate - 0.1).toFixed(2))} />
                <input type='button' value='next' onClick={() => playNext()} />
                <input type='button' value='previous' onClick={() => playPrevious()} />
            </div>
            <br />
            {`duration is ${trackInfo.duration}s
            loaded ${trackInfo.loaded * 100}%
            played ${trackInfo.played * 100}%`}
        </>
    )
}

export default Player;