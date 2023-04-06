import { NavLink } from "react-router-dom"
import Track from "../../components/Track/Track"
import "./UserHistory.css"

export const UserHistory = () => {
    return(
    <>
        <div className="history-block" >
            <NavLink className={"clear"} >Сlear</NavLink>

            <div>
                <Track/>
            </div>
        </div>
        
    </>    
    )
}