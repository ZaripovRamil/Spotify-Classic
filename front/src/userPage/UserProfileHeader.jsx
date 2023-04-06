import { NavLink } from "react-router-dom"

export const UserProfileHeader = () => {
    return(
        <>
            <div className="userHeader">
                <div className="userAvatar"></div>
                <div className="header-info">
                    <div className="userName">Kameueueu</div>
                    <NavLink className={"edit"} >Edit</NavLink>
                </div>
                
            </div>

            <div className="user-menu">
                <div className="user-menu-list">
                    <NavLink to="/user" style={({ isActive }) => console.log(isActive)}  >Playlists</NavLink>
                    <NavLink to="/history" style={({ isActive }) => console.log(isActive)}  >History</NavLink>
                </div>
            </div>
            
        </>    
    )

}