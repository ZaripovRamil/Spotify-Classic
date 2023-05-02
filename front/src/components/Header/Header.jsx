import "./Header.css";
import { Link } from "react-router-dom";
import { useEffect, useState } from "react";

export const Header = () => {
const[page, setPage] = useState()

  useEffect(() => {
    let href = window.location.pathname;
    setPage(href.split("/")[1]);
    console.log(page);
  }, [window.location.pathname]);

  if (page != "main") {
    return (
      <header className="header-main">
        <div className="header-logo">
        <Link to="/main"> <div>Classic music</div> </Link>
        </div>
        <div className="header-nav">
          <div>
            <input type="text" placeholder="Search" />
          </div>
          <Link to="/authorization">
            <div className="avatar"></div>
          </Link>
        </div>
      </header>
    );
  } else
    return (
      <header className="header">
        <div>
          <input type="text" placeholder="Search" />
        </div>
        <Link to="/authorization">
          <div className="avatar"></div>
        </Link>
      </header>
    );
};
