import React, { useEffect, useState } from "react";
import AddTrack from "./AddTrack";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";
import { Promise } from "q";

const fetcher = getFetcher(Ports.AdminService);

const Tracks = () => {
  const [items, setItems] = useState([]);
  const [tableColumns, setTableColumns] = useState([]);

  useEffect(() => {
    const getTracks = async () => {
      await fetcher.get('tracks/')
        .then(res => {
          if (res.status !== 200) return;
          setItems(res.data);
          setTableColumns([
            {
              name: 'id',
              label: 'track id',
              type: 'text',
              isEditable: false,
            },
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
          setTableColumns([{
            name: 'err',
            label: 'error',
            isEditable: false,
          }])
        });
    }
    getTracks();
  }, []);

  const editItemsWithResultAsync = async (data) => {
    return await fetcher.put(`tracks/update/${data.id}`, { id: data.id, name: data.name })
      .then(res => JSON.parse(res.data));
  }

  const deleteItemsWithResultAsync = async (data) => {
    return await fetcher.delete(`tracks/delete/${data.id}`)
  }

  const insertItemsWithResultAsync = async (data) => {
    await new Promise(r => setTimeout(r, 1000));
    return false;
  }

  return (
    <>
      <AddTrack insertItemsWithResultAsync={insertItemsWithResultAsync} />
      <TableDisplayer data={items} setData={setItems} editDataWithResultAsync={editItemsWithResultAsync} deleteDataWithResultAsync={deleteItemsWithResultAsync} columns={tableColumns} />
    </>
  );
}

export default Tracks;