import React, { useEffect, useState } from "react";
import AddAuthor from "./AddAuthor";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.AdminApi);

const Authors = () => {
  const [items, setItems] = useState([]);
  const [tableColumns, setTableColumns] = useState([]);
  useEffect(() => {
    const getTracks = async () => {
      await fetcher.get('authors/get/')
        .then(res => {
          if (res.status !== 200) return;
          setItems(res.data.map(item => {
            item.tableProps = {
              color: 'white'
            }
            return item;
          }));
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
    try {
      return await fetcher.put(`authors/update/${data.id}`, { id: data.id, name: data.name })
        .then(res => JSON.parse(res.data));
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
    }
  }

  const deleteItemsWithResultAsync = async (data) => {
    try {
      return await fetcher.delete(`authors/delete/${data.id}`)
        .then(res => JSON.parse(res.data));
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
    }
  }

  const insertItemsWithResultAsync = async (data) => {
    try {
      const newAuthorResult = await fetcher.post(`authors/add`, data)
        .then(r => JSON.parse(r.data));
      if (!newAuthorResult.isSuccessful) return newAuthorResult;
      const author = await getAuthorByIdAsync(newAuthorResult.authorId);
      author.tableProps = { color: '#b3cf99' }
      setItems([author, ...items]);
      return newAuthorResult;
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
    }
  }

  const getAuthorByIdAsync = async (id) => {
    try {
      const res = await fetcher.get(`authors/get/${id}`);
      return res.data;
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
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