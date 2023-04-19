import React, { useEffect, useState } from "react";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.AdminService);

const Authors = () => {
  const [items, setItems] = useState([]);
  const [columns, setColumns] = useState([]);
  useEffect(() => {
    const getTracks = async () => {
      await fetcher.get('authors/')
        .then(res => {
          if (res.status !== 200) return;
          setItems(res.data);
          setColumns([
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

export default Authors;