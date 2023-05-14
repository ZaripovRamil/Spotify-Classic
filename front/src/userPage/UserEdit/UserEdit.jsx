import { NavLink } from "react-router-dom"
import { UserMenu } from "../components/UserMenu"
import { UserProfileHeader } from "../components/UserProfileHeader"
import "./UserEdit.css"
import { useState } from "react"

export const UserEdit = ({content}) => {
    
    return (
        <>
            <UserProfileHeader/>
            <UserMenu links={
            <>
                <NavLink to="/user/edit">Settings</NavLink>
                <NavLink to="/user/password">Change password</NavLink>
            </>}/>
            {content}
        </>  
    )
}