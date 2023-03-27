import React from "react";
import compositor from "../media/compositor.png";
export const PlaylistCard = ({ playlist }) => {
    return (
        <div className="playlist-card" onClick={() => console.log("clicked")}>
            <img className="playlist-img" alt="playlist" src={compositor} />
            <p className="playlist-title">{playlist.name}</p>
            <p className="playlist-author">{playlist.owner}</p>
        </div>)
};