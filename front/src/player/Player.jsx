import React, { useEffect, useState } from "react";
import ReactPlayer from "react-player/lazy";
import { fetcher } from "../axios/AxiosInstance";

// care of http/https
const prefix = "https://localhost:7022/api/tracks/";

const Player = () => {
    // TODO: add animation logic until tracks have been fetched
    const [tracks, setTracks] = useState([{
        id: "",
        name: "",
        preview: "",
    }]);
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
    });

    const changeConfig = (configName, configValue) => {
        playerConfig[configName] = configValue;
        // to keep volume level in (0, 1) range. otherwise player falls
        playerConfig.volume = Math.max(0, Math.min(1, playerConfig.volume));
        playerConfig.playbackRate = Math.max(0.1, Math.min(2, playerConfig.playbackRate));
        setPlayerCongig({ ...playerConfig });
    };

    // these functions may be replaced with, but should they?
    // changeConfig("trackId", (playerConfig.trackId + 1) % tracks.length)
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

    return (
        <>
            <ReactPlayer
                controls={playerConfig.controls}
                playing={playerConfig.playing}
                playbackRate={playerConfig.playbackRate}
                volume={playerConfig.volume}
                url={prefix + tracks[playerConfig.trackId].id}
                onDuration={(duration) => updateTrackInfo('duration', duration.toFixed(2))}
                onProgress={(state) => {
                    updateTrackInfo('played', +state.played.toFixed(4));
                    updateTrackInfo('loaded', +state.loaded.toFixed(4));
                }}
                style={{ display: "None" }}
            />
            {`playing track ${tracks[playerConfig.trackId].name}`}
            <div className="player-controls">
                <input type='button' value='play/stop' onClick={() => changeConfig('playing', !playerConfig.playing)} />
                <input type='button' value='volume+' onClick={() => changeConfig('volume', +(playerConfig.volume + 0.1).toFixed(2))} />
                <input type='button' value='volume-' onClick={() => changeConfig('volume', +(playerConfig.volume - 0.1).toFixed(2))} />
                <input type='button' value='speed+' onClick={() => changeConfig('playbackRate', +(playerConfig.playbackRate + 0.1).toFixed(2))} />
                <input type='button' value='speed-' onClick={() => changeConfig('playbackRate', +(playerConfig.playbackRate - 0.1).toFixed(2))} />
                <input type='button' value='next' onClick={() => playNext()} />
                <input type='button' value='previous' onClick={() => playPrevious()} />
            </div>
            <br />
            {`duration is ${trackInfo.duration}s
            loaded ${(trackInfo.loaded * 100).toFixed(2)}%
            played ${(trackInfo.played * 100).toFixed(2)}%`}
        </>
    )
}

export default Player;