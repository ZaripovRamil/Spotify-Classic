import React, { useEffect, useState, useRef } from "react";
// import { fetcher } from "../axios/AxiosInstance.js";
import { PlaylistCard } from "../../components/Playlist/PlaylistCard";

export const Playlists = () => {
  const [playlists, setPlaylists] = useState([
    {
      id: "",
      previewId: "",
      name: "",
      owner: {
        id: "",
        name: "",
      },
    },
  ]);

  const playlistsArray = [
    {
      id: "1",
      previewId: "3232492",
      name: "Title",
      owner: {
        id: "4234",
        name: "Author",
      },
    },
    {
      id: "1",
      previewId: "3232492",
      name: "Title",
      owner: {
        id: "4234",
        name: "Author",
      },
    },
    {
      id: "1",
      previewId: "3232492",
      name: "Title",
      owner: {
        id: "4234",
        name: "Author",
      },
    },
  ];
  // const [playlists, setPlaylists] = useState(playlistsArray);

  // get data from playlists controller in future
  useEffect(() => {
    setPlaylists(playlistsArray);
    // fetcher.get('playlists').then((data) => setPlaylists(data.data));
  }, []);

  return (
    <div className="playlists">
      {playlists.map((playlist, id) => (
        <PlaylistCard playlist={playlist} />
      ))}
    </div>
  );
};

// {historyTracks.map(((track,id) => <Track props={props} tracks={historyTracks}  track={track} idInAlbum={id}/>))} 