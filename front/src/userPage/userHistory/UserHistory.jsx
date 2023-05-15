import { NavLink } from "react-router-dom";
import Track from "../../components/Track/Track";
import "./UserHistory.css";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";
import { useEffect, useState } from "react";

const prefix = "https://localhost:7022/";

export const UserHistory = (props) => {
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
  useEffect(() => {
    setHistoryTracks(props.history);
  }, []);

  return (
    <>
      <div className="history-block">
        <NavLink className={"clear"}>Clear</NavLink>
        <div>
          {historyTracks.map((track, id) => (
            <Track
              key={id}
              props={props}
              tracks={historyTracks}
              track={track}
              idInAlbum={id}
            />
          ))}
        </div>
      </div>
    </>
  );
};
