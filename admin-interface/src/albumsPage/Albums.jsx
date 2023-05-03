import React, { useEffect, useState } from "react";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";
import AddAlbum from "./AddAlbum";

const fetcher = getFetcher(Ports.AdminService);

const Albums = () => {
  const [items, setItems] = useState([]);
  const [tableColumns, setTableColumns] = useState([]);
  useEffect(() => {
    const getTracks = async () => {
      await fetcher.get('albums/get/')
        .then(res => {
          if (res.status !== 200) return;
          setItems(res.data);
          setTableColumns([
            {
              name: 'id',
              label: 'id',
              type: 'text',
              isEditable: false,
            },
            {
              name: 'previewId',
              label: 'Preview id',
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
              name: 'author.name',
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
    return await fetcher.put(`albums/update/${data.id}`, { id: data.id, name: data.name })
      .then(res => JSON.parse(res.data));
  }

  const deleteItemsWithResultAsync = async (data) => {
    return await fetcher.delete(`albums/delete/${data.id}`)
      .then(res => JSON.parse(res.data));
  }

  const insertItemsWithResultAsync = async (data) => {
    data.releaseDate = parseInt(data.releaseDate);
    data.albumType = parseInt(data.albumType);
    return await fetcher.post('albums/add/', data)
      .then(res => JSON.parse(res.data))
      .finally(() => window.location.reload());
  }

  return (
    <>
      <AddAlbum insertItemsWithResultAsync={insertItemsWithResultAsync} />
      <TableDisplayer data={items} setData={setItems} editDataWithResultAsync={editItemsWithResultAsync} deleteDataWithResultAsync={deleteItemsWithResultAsync} columns={tableColumns} />
    </>
  );
}

export default Albums;