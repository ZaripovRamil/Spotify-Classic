import { useEffect } from "react";
import { NavLink } from "react-router-dom";
import crown from "./crown.png";

export const UserProfileHeader = ({
  component,
  userName,
  subscribtionName,
}) => {
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
          {component}
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
