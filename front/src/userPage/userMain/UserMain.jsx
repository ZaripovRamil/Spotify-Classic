import { useEffect, useState } from "react"
import { NavLink } from "react-router-dom";
import { Playlists } from "./Playlists";
import "./UserMain.css"

export const UserMain = (props) => {
    return(
    <>
        <div className="user-playlists-block" >
            <Playlists playlists={props.playlists}/>
        </div>
    </>    
    )
}