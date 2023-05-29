import React, { useEffect, useState } from "react";
import AddTrack from "./AddTrack";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.AdminService);

const Tracks = () => {
  const [items, setItems] = useState([]);
  const [tableColumns, setTableColumns] = useState([]);
  const [filters, setFilters] = useState({
    pageSize: "",
    pageIndex: "",
    sortBy: "",
    search: "",
  });
  const [clicked, setClicked] = useState(false);

  useEffect(() => {
    const getTracks = () => {
      fetcher.get(`tracks/get?pageSize=${filters.pageSize}&pageIndex=${filters.pageIndex}&sortBy=${filters.sortBy}&search=${filters.search}`)
        .then(res => {
          if (res.status !== 200) return;
          setItems(res.data.map(item => {
            item.tableProps = { color: 'white' };
            return item;
          }));
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
  }, [clicked]);

  const editItemsWithResultAsync = async (data) => {
    try {
      return await fetcher.put(`tracks/update/${data.id}`, { id: data.id, name: data.name })
        .then(res => JSON.parse(res.data));
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, messageResult: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
  }

  const deleteItemsWithResultAsync = async (data) => {
    try {
      return await fetcher.delete(`tracks/delete/${data.id}`)
        .then(res => JSON.parse(res.data));
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, messageResult: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
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
      const newTrackResult = await fetcher.post(`tracks/add`, formData)
        .then(r => r.data);
      if (!newTrackResult.isSuccessful) return newTrackResult;
      const track = await getTrackByIdAsync(newTrackResult.trackId);
      track.tableProps = { color: '#b3cf99' };
      setItems([track, ...items]);
      return newTrackResult;
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, messageResult: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
  };

  const getTrackByIdAsync = async (id) => {
    try {
      const res = await fetcher.get(`tracks/get/${id}`);
      return res.data;
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, messageResult: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, messageResult: 'Unknown error' };
    }
  };

  const changeFilters = (propName, propValue) => {
    filters[propName] = propValue;
    setFilters({ ...filters });
  }

  return (
    <>
      <div className="filter-form" style={{ display: 'flex', justifyContent: 'center' }}>
        <div>
          Page size: 
          <input placeholder="page size" type="number" value={filters.pageSize} onChange={e => changeFilters('pageSize', e.target.value)} /> <br />
          Page index: 
          <input placeholder="page index" type="number" value={filters.pageIndex} onChange={e => changeFilters('pageIndex', e.target.value)} /> <br />
          Search for the album name: 
          <input placeholder="type somephin" type="text" value={filters.search.trim()} onChange={e => changeFilters('search', e.target.value)} /> <br />
          Sort by: 
          <select value={filters.sortBy} onChange={e => changeFilters('sortBy', e.target.value)}>
            <option value="">None</option>
            <option value="id">Id</option>
            <option value="name">Name</option>
            <option value="album">Album name</option>
            <option value="author">Author name</option>
          </select >
          <br />
        <input type="button" value="apply filters" onClick={() => setClicked(!clicked)} /> <br />
        </div>
      </div>
      <AddTrack insertItemsWithResultAsync={insertItemsWithResultAsync} />
      <TableDisplayer data={items} setData={setItems} editDataWithResultAsync={editItemsWithResultAsync} deleteDataWithResultAsync={deleteItemsWithResultAsync} columns={tableColumns} />
    </>
  );
}

export default Tracks;