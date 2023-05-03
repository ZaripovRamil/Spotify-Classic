import React, { useEffect, useState } from "react";
import AddTrack from "./AddTrack";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.AdminService);

const Tracks = () => {
  const [items, setItems] = useState([]);
  const [tableColumns, setTableColumns] = useState([]);

  useEffect(() => {
    const getTracks = async () => {
      await fetcher.get('tracks/get/')
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
              name: 'fileId',
              label: 'file id',
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
            // not working for now
            // {
            //   name: 'genres',
            //   label: 'genres',
            //   type: 'text',
            //   isEditable: false,
            // },
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
      .then(res => JSON.parse(res.data));
  }

  const insertItemsWithResultAsync = async (data) => {
    const formData = new FormData();
    Object.entries(data).forEach(([prop, value]) => {
      if (prop === 'genreIds') {
        value.forEach((genre) => formData.append('genreIds[]', genre));
      } else {
        formData.append(prop, value);
      }
    });
    try {
      const res = await fetcher.post(`tracks/add`, formData);
      const track = await getTrackByIdAsync(res.data.trackId);
      setItems([track, ...items]);
      return res.data;
    } catch (error) {
      return error.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
  };

  const getTrackByIdAsync = async (id) => {
    try {
      const res = await fetcher.get(`tracks/get/${id}`);
      return res.data;
    } catch (error) {
      return error.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
  };

  return (
    <>
      <AddTrack insertItemsWithResultAsync={insertItemsWithResultAsync} />
      <TableDisplayer data={items} setData={setItems} editDataWithResultAsync={editItemsWithResultAsync} deleteDataWithResultAsync={deleteItemsWithResultAsync} columns={tableColumns} />
    </>
  );
}

export default Tracks;