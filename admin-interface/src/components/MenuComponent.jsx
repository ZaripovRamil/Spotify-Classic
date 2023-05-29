import React from "react";
import { NavLink } from "react-router-dom";
import './styles/menu_styles.css';

const Menu = () => {
    return (
        <>
            <nav style={{float: 'left', padding: '20px'}}>
                <NavLink to={'/tracks'}><p>Tracks</p></NavLink>
                <NavLink to={'/albums'}><p>Albums</p></NavLink>
                <NavLink to={'/authors'}><p>Authors</p></NavLink>
                <NavLink to={'/chats'}><p>Chats</p></NavLink>
            </nav>
        </>
    );
}

export default Menu;