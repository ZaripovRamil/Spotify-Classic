import React, { useEffect, useState } from "react";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.MusicService);

const Tracks = () => {
  const [items, setItems] = useState([]);
  const [columns, setColumns] = useState([]);
  useEffect(() => {
    const getTracks = async () => {
      await fetcher.get('tracks/')
        .then(res => {
          if (res.status !== 200) return;
          res.data.map(item => {
            items.push({
              id: item.id,
              name: item.name,
              album: item.album.name,
              author: item.album.author.name
            });
            setItems([...items]);
          });
          items.length > 0 && Object.keys(items[0]).map(item => {
            columns.push({
              name: item,
              label: item,
              type: !isNaN(items[0][item]) ? 'number' : 'text'
            });
            setColumns([...columns]);
          });
        });
    }
    getTracks();
  }, []);

  return (
    <>
      <TableDisplayer data={items} columns={columns} onDataChange={setItems} />
    </>
  );
}

export default Tracks;