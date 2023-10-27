import { NavLink } from "react-router-dom";
import Track from "../../components/Track/Track";
import "./UserHistory.css";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";
import { useEffect, useState } from "react";

const prefix = `https://localhost:${Ports.PlayerApi}/`;
const fetcherAuth = getFetcher(Ports.AuthApi);
const fetcherPlayer = getFetcher(Ports.PlayerApi);

export const UserHistory = (props) => {
  const [isLoad, setIsLoad] = useState(false);
  const [historyTracks, setHistoryTracks] = useState([
    {
      id: "",
      fileId: "",
      name: "",
      album: {
        id: "",
        previewId: "",
        name: "",
        author: {
          id: "",
          name: "",
        },
      },
    },
  ]);

  function GetHistory() {
    fetcherAuth
      .get("User/GetHistory")
      .then((res) => setHistoryTracks(res.data))
      .catch((res) => console.log(res));
  }

  useEffect(() => {
    GetHistory();
  }, []);

  useEffect(() => {
    props.props.playerConf.trackId !== "" && setIsLoad(true);
    fetcherPlayer
      .get(`Tracks/addToHistory/${props.props.playerConf.trackId}`)
      .then((res) => {
        GetHistory();
      })
      .catch((res) => console.log(res));

    setIsLoad(false);
  }, [props.props.playerConf.trackId]);

  return (
    !isLoad && (
      <>
        <div className="history-block">
          <NavLink className={"clear"}>Clear</NavLink>
          <div>
            {historyTracks.map((track, id) => (
              <Track
                key={id}
                props={props.props}
                tracks={historyTracks}
                track={track}
                idInAlbum={id}
              />
            ))}
          </div>
        </div>
      </>
    )
  );
};
