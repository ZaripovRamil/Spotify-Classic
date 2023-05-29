import React, { useEffect } from "react";
import { NavLink, useNavigate } from "react-router-dom";
import crown from "./crown.png";
import logout from "./logout.png";

export const UserProfileHeader = ({
  component,
  userName,
  subscribtionName,
}) => {
  const navigate = useNavigate();
  const SignOut = () => {
    localStorage.removeItem("access-token");
    navigate("/");
  };
  return (
    <>
      <div className="userHeader">
        <div className="userAvatar"></div>
        <div className="header-info">
          <NavLink to="/user">
            <div style={{ display: "flex" }}>
              <div className="userName">{userName}</div>
              {subscribtionName !== "" && (
                <img
                  src={crown}
                  alt={subscribtionName}
                  style={{ width: "40px" }}
                />
              )}
            </div>
          </NavLink>
          <div
            style={{
              display: "flex",
              alignItems: "center",
            }}
          >
            {component}
            <img
              className="signOutBtn"
              width="30px"
              height="30px"
              src={logout}
              alt="Sign out"
              onClick={() => {
                SignOut();
              }}
            />
          </div>

          {/* only for authorized */}
          {subscribtionName !== "" && (
            <NavLink to="/user/statistic">Export data</NavLink>
          )}
          <NavLink to="/user/subscription">Subscription</NavLink>
        </div>
      </div>
    </>
  );
};
