import "./Header.css";
import { Link } from "react-router-dom";
import { useEffect, useState } from "react";

export const SearchSuggestions = ({ data, value }) => {
  const [albums, setAlbums] = useState([]);
  const [authors, setAuthors] = useState([]);
  const [playlists, setPlaylists] = useState([]);
  const [tracks, setTracks] = useState([]);

  useEffect(() => {
    setAlbums(data.albums.slice(0, 3));
    setAuthors(data.authors.slice(0, 3));
    setPlaylists(data.playlists.slice(0, 3));
    setTracks(data.tracks.slice(0, 3));
  }, []);

  return (
    <div className="search-suggestions">
      {albums.length === 0 &&
      authors.length === 0 &&
      playlists.length === 0 &&
      tracks.length === 0 ? (
        <div>Nothing here...</div>
      ) : (
        <Link>All results for {value}</Link>
      )}

      {albums.length !== 0 && <div>Albums</div>}
      {albums.map((suggest) => (
        <Link>
          <div className="suggestion">{suggest.name}</div>
        </Link>
      ))}
      {authors.length !== 0 && <div>Authors</div>}
      {authors.map((suggest) => (
        <Link>
          <div className="suggestion">{suggest.name}</div>
        </Link>
      ))}
      {playlists.length !== 0 && <div>Playlists</div>}
      {playlists.map((suggest) => (
        <Link>
          <div className="suggestion">{suggest.name}</div>
        </Link>
      ))}
      {tracks.length !== 0 && <div>Tracks</div>}
      {tracks.map((suggest) => (
        <Link>
          <div className="suggestion">{suggest.name}</div>
        </Link>
      ))}
    </div>
  );
};
