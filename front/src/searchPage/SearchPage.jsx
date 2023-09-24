import { useSearchParams, useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";
import "./SearchPage.css";
const fetcher = getFetcher(Ports.SearchService);

export const SearchPage = (props) => {
  const prefix = "https://localhost:7022/";
  const navigate = useNavigate();
  const [searchParams] = useSearchParams();
  const [albums, setAlbums] = useState([]);
  const [playlists, setPlaylists] = useState([]);
  const [tracks, setTracks] = useState([]);
  const [value, setValue] = useState();

  useEffect(() => {
    setValue(searchParams.get("value"));
    fetcher.get(`Search?query=${value}`).then((data) => {
      setAlbums(data.data.albums);
      setPlaylists(data.data.playlists);
      setTracks(data.data.tracks);
    });
  }, [searchParams, value]);

  const albumClick = (id) => {
    console.log(id);
    navigate({
      pathname: "/album",
      search: `?albumId=${id}`,
    });
  };

  const playlistClick = (id) => {
    console.log(id);
    navigate({
      pathname: "/playlist",
      search: `?playlistId=${id}`,
    });
  };

  return (
    <div className="search-suggestions-page">
      <h3>
        <strong> All results for {value}</strong>
      </h3>
      <br />
      <br />
      <div className="suggestions-block">
        {" "}
        {albums.length !== 0 && (
          <div>
            <strong>Albums</strong>
          </div>
        )}
        {albums.map((suggest) => (
          <div
            className="suggestion-page"
            onClick={() => {
              albumClick(suggest.id);
            }}
          >
            <img
              style={{ maxWidth: "70px", maxHeight: "70px" }}
              src={prefix + `Previews/get/${suggest.previewId}`}
              alt="img"
              width={"100%"}
              onError={({ currentTarget }) => {
                currentTarget.onerror = null;
              }}
            />
            <div>{suggest.name}</div>
          </div>
        ))}
      </div>

      <div className="suggestions-block">
        {" "}
        {tracks.length !== 0 && (
          <div>
            <strong>Tracks</strong>
          </div>
        )}
        {tracks.map((suggest) => (
          <div
            className="suggestion-page"
            onClick={() => {
              albumClick(suggest.album.id);
            }}
          >
            <img
              style={{ maxWidth: "70px", maxHeight: "70px" }}
              src={prefix + `Previews/get/${suggest.album.previewId}`}
              alt="img"
              width={"100%"}
              onError={({ currentTarget }) => {
                currentTarget.onerror = null;
              }}
            />
            <div> {suggest.name}</div>
          </div>
        ))}
      </div>
      <div className="suggestions-block">
        {" "}
        {playlists.length !== 0 && (
          <div>
            <strong>Playlists</strong>
          </div>
        )}
        {playlists.map((suggest) => (
          <div
            className="suggestion-page"
            onClick={() => {
              playlistClick(suggest.id);
            }}
          >
            <img
              style={{ maxWidth: "70px", maxHeight: "70px" }}
              src={prefix + `Previews/get/${suggest.previewId}`}
              alt="img"
              width={"100%"}
              onError={({ currentTarget }) => {
                currentTarget.onerror = null;
              }}
            />
            <div> {suggest.name}</div>
          </div>
        ))}
      </div>
    </div>
  );
};
