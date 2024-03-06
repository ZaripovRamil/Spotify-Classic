import "./Header.css";
import { Link, useSearchParams } from "react-router-dom";
import { useEffect, useState } from "react";
import { SearchSuggestions } from "./SearchSuggestions";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

const prefix = `https://localhost:${Ports.PlayerApi}/`;
const fetcher = getFetcher(Ports.SearchApi);

export const Header = () => {
  const [searchParams] = useSearchParams();
  const [page, setPage] = useState();
  const [suggestions, setSuggestions] = useState();
  const [searchValue, setSearchValue] = useState();

  const searchHander = (str) => {
    if (str === "") setSuggestions(null);
    else {
      fetcher.get(`Search?query=${str}`).then((data) => {
        console.log(data.data);
        setSuggestions(data.data);
        setSearchValue(str);
      });
    }
  };

  useEffect(() => {
    let href = window.location.pathname;
    setPage(href.split("/")[1]);
    setSuggestions(null);
    setSearchValue("");
  }, [window.location.pathname, searchParams]);

  return (
    <header className="header">
      {page != "main" ? (
        <div className="header-logo">
          <Link to="/main">
            {" "}
            <div>Classic music</div>{" "}
          </Link>
        </div>
      ) : (
        <div></div>
      )}

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
        <Link
          to="/user"
        >
          <div className="avatar"></div>
        </Link>
      </div>
    </header>
  );
};
