import "./Header.css";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

export const SearchSuggestions = ({ data, value }) => {
  const prefix = "https://localhost:7022/";
  const navigate = useNavigate();
  const [albums, setAlbums] = useState([]);
  const [authors, setAuthors] = useState([]);
  const [playlists, setPlaylists] = useState([]);
  const [tracks, setTracks] = useState([]);

  useEffect(() => {
    setAlbums(data.albums.slice(0, 2));
    setAuthors(data.authors.slice(0, 2));
    setPlaylists(data.playlists.slice(0, 2));
    setTracks(data.tracks.slice(0, 2));
  }, [data]);

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

  const authorClick = (id) => {
    console.log(id);
    navigate({
      pathname: "/album",
      search: `?albumId=${id}`,
    });
  };

  const searchAll = () => {
    navigate({
      pathname: "/search",
      search: `?value=${value}`,
    });
  };

  return (
    <div className="search-suggestions">
      {albums.length === 0 && playlists.length === 0 && tracks.length === 0 ? (
        <div>Nothing here...</div>
      ) : (
        <div
          onClick={() => {
            searchAll();
          }}
          className="suggestion"
        >
          <strong> All results for {value}</strong>
        </div>
      )}
      <div className="suggestions-block">
        {" "}
        {albums.length !== 0 && (
          <div>
            <strong>Albums</strong>
          </div>
        )}
        {albums.map((suggest) => (
          <div
            className="suggestion"
            onClick={() => {
              albumClick(suggest.id);
            }}
          >
            <img
              style={{ maxWidth: "50px", maxHeight: "50px" }}
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
      {/* <div className="suggestions-block">
        {" "}
        {authors.length !== 0 && (
          <div>
            <strong>Authors</strong>
          </div>
        )}
        {authors.map((suggest) => (
          <div className="suggestion">{suggest.name}</div>
        ))}
      </div> */}
      <div className="suggestions-block">
        {" "}
        {tracks.length !== 0 && (
          <div>
            <strong>Tracks</strong>
          </div>
        )}
        {tracks.map((suggest) => (
          <div
            className="suggestion"
            onClick={() => {
              albumClick(suggest.album.id);
            }}
          >
            <img
              style={{ maxWidth: "50px", maxHeight: "50px" }}
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
            className="suggestion"
            onClick={() => {
              playlistClick(suggest.id);
            }}
          >
            <img
              style={{ maxWidth: "50px", maxHeight: "50px" }}
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
