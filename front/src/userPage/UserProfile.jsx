import React, { useEffect, useState } from "react";
import "./UserProfile.css";
import { UserProfileHeader } from "./components/UserProfileHeader";
import { NavLink, useNavigate } from "react-router-dom";
import { UserMenu } from "./components/UserMenu";
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.AuthService);

export const UserProfile = (props) => {
  const navigate = useNavigate();
  const [userInfo, setUserInfo] = useState({
    email: "",
    history: [],
    id: "ef26e9f9-c7e3-4705-955d-ea80d0e20ef9",
    name: "TestUser",
    playlists: [],
    profilePicId: "default_pfp",
    role: 0,
  });

  useEffect(() => {
    fetcher
      .get(`user/getme`)
      .then((res) => setUserInfo(res.data))
      .catch((err) => console.log(err));
  }, []);

  return (
    <>
      <main className="main-page">
        <UserProfileHeader
          userName={userInfo.name}
          component={
            <NavLink to="/user/edit" className={"edit"}>
              Edit
            </NavLink>
          }
        />
        <UserMenu
          links={
            <>
              <NavLink to="/user">Playlists</NavLink>
              <NavLink to="/history">History</NavLink>
            </>
          }
        />
        {React.cloneElement(props.component, {
          props: props,
          playlists: userInfo.playlists,
          history: userInfo.history,
        })}
      </main>
    </>
  );
};
