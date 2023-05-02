import React, { useEffect, useState } from "react";
import Track from "../components/Track/Track";
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports"
import { useSearchParams } from 'react-router-dom';

const fetcher = getFetcher(Ports.MusicService);


export const PlaylistPage = ({props}) => {

  const [searchParams] = useSearchParams();
  console.log(searchParams.get('playlistId'));

  const [playlistTracks, setPlaylistTracks] = useState([{
    id: "",
    name: "",
    album: {
        id: "",
        name: "",
        author: {
            id: "",
            name: ""
        }
    }
}]);

const { tracksList, setTracksList} = props;
useEffect(() => {
  fetcher.get('tracks').then((data) => {setPlaylistTracks(data.data);});
    // fetcher.get(`playlists/${idPlaylist}`).then((data) => {setPlaylistTracks(data.data);});
}, [])

  return (
    <main className="main-page">
      <div className="playlist-btn-header">
        <div className="playlist-back-btn">
          <img src="" alt="" />
        </div>
        <p>Времена года</p>
      </div>
      <div className="playlist-main">
        <img src="" alt="" />
        <div>
            <p className="playlist-author">П.И.Чайковский</p>
            <div className="playlist-btns">
            <img src="" alt="" className="play-btn"/>
            <img src="" alt="" className="like-btn"/>
            </div>
            <div className="playlist-tracks">
                {playlistTracks.map(((track,id) => <Track props={props} tracks={playlistTracks}  track={track} idInAlbum={id}/>))} 
            </div>
            
        </div>
      </div>
    </main> ); };