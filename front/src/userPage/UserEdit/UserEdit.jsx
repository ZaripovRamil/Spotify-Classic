import { NavLink } from "react-router-dom";
import { UserMenu } from "../components/UserMenu";
import { UserProfileHeader } from "../components/UserProfileHeader";
import "./UserEdit.css";
import React, { useEffect, useState } from "react";
import Ports from "../../constants/Ports";
import { getFetcher } from "../../axios/AxiosInstance";

const fetcher = getFetcher(Ports.AuthService);
export const UserEdit = ({ content }) => {
  const [isLoad, setIsLoad] = useState(false);

  const [userInfo, setUserInfo] = useState({
    email: "",
    history: [],
    id: "",
    name: "",
    playlists: [],
    profilePicId: "",
    role: 0,
  });

  useEffect(() => {
    fetcher
      .get(`user/getme`)
      .then((res) => {
        console.log(res.data);
        setUserInfo(res.data);
        setIsLoad(true);
      })
      .catch((err) => console.log(err));
  }, []);
  return (
    <main className="main-page">
      {isLoad && (
        <>
          <UserProfileHeader userName={userInfo.name} />
          <UserMenu
            links={
              <>
                <NavLink to="/user/edit">Settings</NavLink>
                <NavLink to="/user/password">Change password</NavLink>
              </>
            }
          />
          {React.cloneElement(content, { userInfo: userInfo })}
        </>
      )}
    </main>
  );
};
