import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";

export const B = (props) => {
    const { tracksList, setTracksList,playerConf, setPlayerConf } = props;
    
  useEffect(()=> {
    console.log(props)
  })
    const waltz = {
        "fileId": "29ad8ca9-c791-4482-8a44-15776862b282",
        "name": "Waltz No. 2",
        "id":"track4",
        "album": {
          "previewId": "857e8dea-a4e3-431e-92d5-c50c515c3126",
          "name": "Waltz No. 2",
          "id":"album2",
          "author": {
            "id": "e791ac96-58fe-4e51-9a6d-248cbb6a1043",
            "name": "Dmitri Shostakovich"
          }
        }
      };
    const valse = {
        "fileId": "36febf49-1c49-4b69-8084-73ebce69040a",
        "name": "Valse Sentimental",
        "id":"track14",
        "album": {
          "previewId": "f5e45467-3840-4a38-933d-e1edfa835789",
          "name": "Valse-Scherzo",
          "id":"album12",
          "author": {
            "id": "a852dcb1-7a96-4b41-8c36-48a69b30f97a",
            "name": "Pyotr Tchaikovsky"
          }
        }
      };
      
    const handleClick = (track) => {
        if (track.fileId === playerConf.trackId){
          setPlayerConf((oldPlayerConf) => 
          ({
              ...oldPlayerConf,
              playing: !oldPlayerConf.playing
          }))
        }
        else{
          setTracksList([track]);
          setPlayerConf((oldPlayerConf) => ({
            ...oldPlayerConf,
            playing: true,
            trackId:track.fileId
          }))
          
        }
        
    }
    return (
        <>
            <Link to={"/a"}>
                <button>to a</button>
            </Link>
            <button onClick={() => handleClick(waltz)}>listen to waltz</button>
            <button onClick={() => handleClick(valse)}>listen to valse</button>
        </>
    )
}