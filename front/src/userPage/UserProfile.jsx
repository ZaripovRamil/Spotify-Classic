import React, { useEffect, useState } from "react"
import "./UserProfile.css"
import { UserProfileHeader } from "./components/UserProfileHeader"
import { NavLink, useNavigate } from "react-router-dom"
import { UserMenu } from "./components/UserMenu"
import { getFetcher } from "../axios/AxiosInstance"
import Ports from "../constants/Ports"

const fetcher = getFetcher(Ports.AuthService);

export const UserProfile = (props) => {
    const navigate = useNavigate();
    const [accessToken, setAccessToken] = useState(localStorage.getItem('access-token'));
    const [userInfo, setUserInfo] = useState({
        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name":"testuser",
        "http://schemas.microsoft.com/ws/2008/06/identity/claims/role":"Free",
        "nbf":0,
        "exp":0,
        "iss":"",
        "aud":""
    });
    // useEffect(()=>{
    //     if (accessToken === null || accessToken === ""){
    //         navigate('/authorize')
    //     }
    //     console.log(accessToken)
    //     fetcher.get(`UserInfo/getUserInfo/${accessToken}`)
    //         .then(res => console.log(res.data))
    //         .catch(err => console.log(err));


    // },[])

    
    return (
        <>
            <UserProfileHeader component={<NavLink to="/user/edit" className={"edit"} >Edit</NavLink>}/>
            <UserMenu links={
            <>
                <NavLink to="/user">Playlists</NavLink>
                <NavLink to="/history">History</NavLink>
            </>}/>
            {React.cloneElement(props.component, props)}
        </>
        
    )
}