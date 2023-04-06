import "./UserProfile.css"
import { UserProfileHeader } from "./UserProfileHeader"

export const UserProfile = ({ component }) => {
    return (
        <>
            <UserProfileHeader/>
            {component}
        </>
        
    )
}