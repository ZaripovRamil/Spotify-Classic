import React from "react";
import compositor from "../media/compositor.png";
export const PlaylistCard = ({ playlist }) => {
    return (
        <div className="user-playlist-card" onClick={() => console.log("clicked")}>
            <img className="user-playlist-img" alt="playlist" src={compositor} />
            <p className="user-playlist-title">{playlist.name}</p>
            <p className="user-playlist-author">{playlist.owner}</p>
        </div>)
};