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
      await fetcher.get('trackjs/')
        .then(res => {
          if (res.status !== 200) return;
          setItems(res.data);
          setColumns([
            {
              name: 'name',
              label: 'name',
              type: 'text',
              isEditable: true,
            },
            {
              name: 'album.name',
              label: 'album',
              type: 'text',
              isEditable: false,
            },
            {
              name: 'album.author.name',
              label: 'author',
              type: 'text',
              isEditable: false,
            },
          ]);
        })
        .catch(err => {
          setItems([{
            err: err.message,
          }]);
          setColumns([{
            name: 'err',
            label: 'error',
            isEditable: false,
          }])
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