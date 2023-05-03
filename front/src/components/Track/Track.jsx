import React, { useEffect, useState, useRef } from "react";
import "./Track.css";

// care of http/https

const prefix = "https://localhost:7022/";
const Track = ({ props, track, idInAlbum, tracks }) => {

    const { tracksList, setTracksList, playerConf, setPlayerConf } = props;

    const trackClick = (track) => {
        if (tracks !== tracksList) {
            setTracksList(tracks)
        }
        if (track.id === playerConf.trackId) {
            setPlayerConf((oldPlayerConf) =>
            ({
                ...oldPlayerConf,
                playing: !oldPlayerConf.playing
            }))
        }
        else {
            setPlayerConf((oldPlayerConf) => ({ ...oldPlayerConf, trackId: track.id, playing: true, trackPosInAlbum: idInAlbum }))
        }
    }


    return (
        <>{playerConf &&
            <div className="track">
                <div className="track-preview">
                    <div className="track-play-img">
                        <img className="track-img" src={prefix + `Previews/get/${track.album.previewId}`} onError={({ currentTarget }) => {
                            currentTarget.onerror = null;
                        }} />
                        <input type='button'
                            className={`track-btn ${(playerConf.playing && track.id == playerConf.trackId) ? 'track-buttonStop' : 'track-buttonPlay'}`}
                            onClick={() => trackClick(track)} />
                    </div>
                    <div>{track.name}
                        <div className="track-audiotrack-auth">{track.album.author.name}</div>
                    </div>
                </div>
                <div className="track-info">
                    {/*TODO: logic of this button */}
                    <input type='button' className="track-buttonLike" />
                    {/* <div className="track-duration">{moment(1000 * trackInfo.duration).format('mm:ss')}</div> */}
                </div>
            </div>}
        </>
    )
}
export default Track;