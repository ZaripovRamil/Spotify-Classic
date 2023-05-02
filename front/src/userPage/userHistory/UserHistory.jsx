import { NavLink } from "react-router-dom"
import Track from "../../components/Track/Track"
import "./UserHistory.css"
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";
import { useEffect, useState } from "react";

const prefix = "https://localhost:7022/";
const fetcher = getFetcher(Ports.MusicService);

export const UserHistory = (props) => {

    const [historyTracks, setHistoryTracks] = useState([{
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
        console.log(props)
        // TODO: add .catch()?
        fetcher.get('tracks').then((data) => {setHistoryTracks(data.data);});
        
        
    }, [])

    return(
    <>
        <div className="history-block" >
            <NavLink className={"clear"} >Сlear</NavLink>

            <div>
                {historyTracks.map(((track,id) => <Track props={props} tracks={historyTracks}  track={track} idInAlbum={id}/>))} 
            </div>
        </div>
        
    </>    
    )
}