import { useEffect } from "react"
import { NavLink } from "react-router-dom"

export const UserProfileHeader = ({component,userName}) => {
    return(
        <>
            <div className="userHeader">
                <div className="userAvatar"></div>
                <div className="header-info">
                    <div className="userName">{userName}</div>
                    {component}
                </div>
                
            </div>
            
        </>    
    )

}