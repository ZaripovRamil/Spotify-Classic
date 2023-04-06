import { useState } from "react"
import { NavLink } from "react-router-dom";
import { Playlists } from "./Playlists";
import "./UserMain.css"

export const UserMain = () => {
    return(
    <>
        <div className="user-playlists-block" >
            <Playlists/>
        </div>
    </>    
    )
}