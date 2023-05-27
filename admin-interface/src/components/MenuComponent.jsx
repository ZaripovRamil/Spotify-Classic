import React from "react";
import { NavLink } from "react-router-dom";

const Menu = () => {
    return (
        <>
            <nav>
                <NavLink to={'/tracks'}><p>Tracks</p></NavLink>
                <NavLink to={'/albums'}><p>Albums</p></NavLink>
                <NavLink to={'/authors'}><p>Authors</p></NavLink>
                <NavLink to={'/chats'}><p>Chats</p></NavLink>
            </nav>
        </>
    );
}

export default Menu;