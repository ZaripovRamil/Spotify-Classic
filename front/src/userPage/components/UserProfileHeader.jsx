import { NavLink } from "react-router-dom"

export const UserProfileHeader = ({component}) => {
    return(
        <>
            <div className="userHeader">
                <div className="userAvatar"></div>
                <div className="header-info">
                    <div className="userName">Kameueueu</div>
                    {component}
                </div>
                
            </div>
            
        </>    
    )

}