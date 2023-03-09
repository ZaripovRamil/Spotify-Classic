import React, { useState } from "react";
import ReactPlayer from "react-player/lazy";


const urls = ['https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-2.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-3.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-4.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-5.mp3', 'https://www.soundhelix.com/examples/mp3/SoundHelix-Song-6.mp3'];

const Player = () => {
    const [playerConfig, setPlayerCongig] = useState({
        "controls": false,
        "urlId": 0,
        "playing": false,
        "volume": 0.8,
        "playbackRate": 1.0,
    })

    const changeConfig = (configName, configValue) => {
        playerConfig[configName] = configValue;
        setPlayerCongig({ ...playerConfig });
    }

    // these functions may be replaced with
    // changeConfig("urlId", (playerConfig.urlId + 1) % urls.length)
    const playNext = () => {
        playerConfig.urlId = (playerConfig.urlId + 1) % urls.length;
        playerConfig.volume = Math.max(0, Math.min(1, playerConfig.volume));
        setPlayerCongig({ ...playerConfig });
    }

    const playPrevious = () => {
        playerConfig.urlId = (playerConfig.urlId - 1 + urls.length) % urls.length;
        setPlayerCongig({ ...playerConfig });
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
            />
            {`playing track${playerConfig.urlId}`}
            <div className="player-controls">
                <input type='button' value='play/stop' onClick={() => changeConfig('playing', !playerConfig.playing)} />
                <input type='button' value='volume+' onClick={() => changeConfig('volume', +(playerConfig.volume + 0.1).toPrecision(2))} />
                <input type='button' value='volume-' onClick={() => changeConfig('volume', +(playerConfig.volume - 0.1).toPrecision(2))} />
                <input type='button' value='speed+' onClick={() => changeConfig('playbackRate', +(playerConfig.playbackRate + 0.1).toPrecision(2))} />
                <input type='button' value='speed-' onClick={() => changeConfig('playbackRate', +(playerConfig.playbackRate - 0.1).toPrecision(2))} />
                <input type='button' value='next' onClick={() => playNext()}/>
                <input type='button' value='previous' onClick={() => playPrevious()}/>
            </div>
        </>
    )
}

export default Player;