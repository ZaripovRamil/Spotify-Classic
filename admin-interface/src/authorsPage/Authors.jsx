import React, { useEffect, useState } from "react";
import AddAuthor from "./AddAuthor";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.AdminService);

const Authors = () => {
  const [items, setItems] = useState([]);
  const [tableColumns, setTableColumns] = useState([]);
  useEffect(() => {
    const getTracks = async () => {
      await fetcher.get('authors/get/')
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
              name: 'name',
              label: 'name',
              type: 'text',
              isEditable: true,
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
    await new Promise(r => setTimeout(r, 1000));
    return true;
  }

  const deleteItemsWithResultAsync = async (data) => {
    return await fetcher.delete(`authors/delete/${data.id}`)
      .then(res => JSON.parse(res.data));
  }

  const insertItemsWithResultAsync = async (data) => {
    return await fetcher.post('authors/add', data)
      .then(res => JSON.parse(res.data));
  }

  return (
    <>
      <AddAuthor insertItemsWithResultAsync={insertItemsWithResultAsync} />
      <TableDisplayer data={items} editDataWithResultAsync={editItemsWithResultAsync} deleteDataWithResultAsync={deleteItemsWithResultAsync} columns={tableColumns} />
    </>
  );
}

export default Authors;