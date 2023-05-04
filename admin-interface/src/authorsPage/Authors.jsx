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
    return await fetcher.put(`authors/update/${data.id}`, { id: data.id, name: data.name })
      .then(res => JSON.parse(res.data));
  }

  const deleteItemsWithResultAsync = async (data) => {
    return await fetcher.delete(`authors/delete/${data.id}`)
      .then(res => JSON.parse(res.data));
  }

  const insertItemsWithResultAsync = async (data) => {
    try {
      const res = await fetcher.post(`authors/add`, data);
      const author = await getAuthorByIdAsync(res.data.authorId);
      setItems([author, ...items]);
      return res.data;
    } catch (error) {
      return error.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
  }

  const getAuthorByIdAsync = async (id) => {
    try {
      const res = await fetcher.get(`authors/get/${id}`);
      return res.data;
    } catch (error) {
      return error.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
  }

  return (
    <>
      <AddAuthor insertItemsWithResultAsync={insertItemsWithResultAsync} />
      <TableDisplayer data={items} setData={setItems} editDataWithResultAsync={editItemsWithResultAsync} deleteDataWithResultAsync={deleteItemsWithResultAsync} columns={tableColumns} />
    </>
  );
}

export default Authors;