import React, { useState } from "react";
import ReactPlayer from "react-player/lazy";


// const urls = ['https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-2.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-3.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-4.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-5.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-6.mp3'];
const urls = ['https://localhost:7022/api/tracks/1', 'https://localhost:7022/api/tracks/2', 'https://localhost:7022/api/tracks/3'];

const Player = () => {
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
    // changeConfig("urlId", (playerConfig.urlId + 1) % urls.length)
    const playNext = () => {
        playerConfig.urlId = (playerConfig.urlId + 1) % urls.length;
        playerConfig.volume = Math.max(0, Math.min(1, playerConfig.volume));
        setPlayerCongig({ ...playerConfig });
    };

    const playPrevious = () => {
        playerConfig.urlId = (playerConfig.urlId - 1 + urls.length) % urls.length;
        setPlayerCongig({ ...playerConfig });
    };

    // duration is the track duration in seconds
    // passed and loaded are in range(0, 1) from 0 progress to 100% progress
    const [trackInfo, setTrackInfo] = useState({
        "duration": 0.0,
        "passed": 0.0,
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
                url={urls[playerConfig.urlId]}
                style={{ display: "None" }}
                onDuration={(duration) => updateTrackInfo('duration', duration.toFixed(2))}
                onProgress={(state) => {
                    updateTrackInfo('passed', state.played.toFixed(4));
                    updateTrackInfo('loaded', state.loaded.toFixed(4));
                }}
            />
            {`playing track #${playerConfig.urlId + 1}`}
            <div className="player-controls">
                <input type='button' value='play/stop' onClick={() => changeConfig('playing', !playerConfig.playing)} />
                <input type='button' value='volume+' onClick={() => changeConfig('volume', (playerConfig.volume + 0.1).toFixed(2))} />
                <input type='button' value='volume-' onClick={() => changeConfig('volume', (playerConfig.volume - 0.1).toFixed(2))} />
                <input type='button' value='speed+' onClick={() => changeConfig('playbackRate', (playerConfig.playbackRate + 0.1).toFixed(2))} />
                <input type='button' value='speed-' onClick={() => changeConfig('playbackRate', (playerConfig.playbackRate - 0.1).toFixed(2))} />
                <input type='button' value='next' onClick={() => playNext()} />
                <input type='button' value='previous' onClick={() => playPrevious()} />
            </div>
            <br/>
            {`duration is ${trackInfo.duration}s
            loaded ${trackInfo.loaded*100}%
            played ${trackInfo.passed*100}%`}
        </>
    )
}

export default Player;