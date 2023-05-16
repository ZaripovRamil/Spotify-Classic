import "./Header.css";
import { Link } from "react-router-dom";
import { useEffect, useState } from "react";
import { SearchSuggestions } from "./SearchSuggestions";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

const prefix = "https://localhost:7022/";
const fetcher = getFetcher(Ports.SearchService);

export const Header = () => {
  const [page, setPage] = useState();
  const [suggestions, setSuggestions] = useState();
  const [searchValue, setSearchValue] = useState();

  const searchHander = (str) => {
    if (str === "") setSuggestions(null);
    fetcher.get(`Search?query=${str}`).then((data) => {
      setSuggestions(data.data);
      setSearchValue(str);
    });
  };

  useEffect(() => {
    let href = window.location.pathname;
    setPage(href.split("/")[1]);
  }, [window.location.pathname]);

  if (page != "main") {
    return (
      <header className="header-main">
        <div className="header-logo">
          <Link to="/main">
            {" "}
            <div>Classic music</div>{" "}
          </Link>
        </div>
        <div className="header-nav">
          <div className="search">
            <input
              type="text"
              placeholder="Search"
              onChange={(e) => searchHander(e.target.value)}
            />
            {suggestions && (
              <SearchSuggestions data={suggestions} value={searchValue} />
            )}
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
