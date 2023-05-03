import React, { useEffect } from "react"
import "./UserProfile.css"
import { UserProfileHeader } from "./UserProfileHeader"

export const UserProfile = (props) => {
    useEffect(()=>{
    })
    return (
        <>
            <UserProfileHeader/>
            {React.cloneElement(props.component, props)}
        </>
        
    )
}