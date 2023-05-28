import { useEffect } from "react";
import { NavLink } from "react-router-dom";

export const UserProfileHeader = ({ component, userName }) => {
  return (
    <>
      <div className="userHeader">
        <div className="userAvatar"></div>
        <div className="header-info">
          <NavLink to="/user">
            <div className="userName">{userName}</div>
          </NavLink>
          {component}
          {/* only for authorized */}
          <NavLink to="/user/statistic">Export data</NavLink>
          <NavLink to="/user/subscription">Subscription</NavLink>
        </div>
      </div>
    </>
  );
};
