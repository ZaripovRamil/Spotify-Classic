import React, { useEffect, useState , useRef} from "react";
import moment from "moment/moment";
import ReactPlayer from "react-player/lazy";
import { fetcher } from "../axios/AxiosInstance";
import "./PlayerStyles.css"
import volume from "./PlayerImages/volume.svg"

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

    //const player = useRef(null);

    const [playerConfig, setPlayerCongig] = useState({
        "controls": false,
        "trackId": 0,
        "playing": false,
        "volume": 0.8,
        "playbackRate": 1.0,
        "seeking":false
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
                //ref={player}
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
            <div className="player">
                <div className="player-controls">
                    <div className="player-btns">
                        
                        <input type='button' className="player-btn buttonPrevious" onClick={() => playPrevious()} />

                        <input type='button' 
                            className={`player-btn ${playerConfig.playing ? 'buttonStop' : 'buttonPlay'}`} 
                            onClick={() =>{ changeConfig('playing', !playerConfig.playing)}}  />

                        <input type='button' className="player-btn buttonNext"  onClick={() => playNext()} />

                    </div>
                    <div className="player-track">
                        <div className="track-img" style={{width:"77px",height:"74px",backgroundColor:"#FCFCFC"}}>
                            {/* picture is missing here */}
                        </div>

                        <div className="track-control">
                            <div className="track-info">
                                <div>{tracks[playerConfig.trackId].name}
                                    <div className="track-auth">The XX</div>
                                    {/* author is missing here */}
                                </div>

                                <div className="track-btns">
                                    {/*TODO: logic of this buttons */}
                                    <input type='button' className="player-btn buttonRepeat"/>
                                    <input type='button' className="player-btn buttonMix"/>
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
                                    updateTrackInfo('played',e.target.value)}}  />

                            <div className="track-time">    
                                <div>{moment(1000*trackInfo.played * trackInfo.duration).format('mm:ss')}</div> 
                                <div>{moment(1000*trackInfo.duration).format('mm:ss') }</div>
                            </div> 
                        </div>
                    </div>

                    <div className="player-volume">
                        <img width={"23px"} height={"20px"} src={volume}/>
                        <input type="range" min="0" max="1" step="0.1" onChange={(e) =>
                                     playerConfig.volume = +e.target.value}/>
                    </div>

                    {/* <p>loaded {(trackInfo.loaded * 100).toFixed(2)}%</p> */}
                    {/* <input type='button' value='speed+' onClick={() => changeConfig('playbackRate', +(playerConfig.playbackRate + 0.1).toFixed(2))} />
                    <input type='button' value='speed-' onClick={() => changeConfig('playbackRate', +(playerConfig.playbackRate - 0.1).toFixed(2))} />     */}
                </div>
            </div>
        </>
    )
}

export default Player;