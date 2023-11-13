import React, { useEffect, useState } from "react";
import TableDisplayer from "../components/Table/TableDisplayer";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from "../constants/Ports";
import AddAlbum from "./AddAlbum";

const fetcher = getFetcher(Ports.AdminApi);

const Albums = () => {
  const [items, setItems] = useState([]);
  const [tableColumns, setTableColumns] = useState([]);
  const [filters, setFilters] = useState({
    albumType: "",
    tracksMin: "",
    tracksMax: "",
    maxCount: "",
    search: "",
    sortBy: ""
  });
  const [clicked, setClicked] = useState(false);
  useEffect(() => {
    const getTracks = () => {
      fetcher.get(`albums?albumType=${filters.albumType}&tracksMin=${filters.tracksMin}&tracksMax=${filters.tracksMax}&maxCount=${filters.maxCount}&search=${filters.search.trim()}&sortBy=${filters.sortBy}`)
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
              name: 'type',
              label: 'type',
              type: 'text',
              isEditable: false,
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
  }, [clicked]);

  const editItemsWithResultAsync = async (data) => {
    try {
      return await fetcher.put(`albums`, { id: data.id, name: data.name })
        .then(res => res.data);
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
    }
  }

  const deleteItemsWithResultAsync = async (data) => {
    try {
      return await fetcher.delete(`albums/${data.id}`)
        .then(res => res.data);
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
    }
  }

  const insertItemsWithResultAsync = async (data) => {
    data.releaseYear = parseInt(data.releaseYear);
    data.albumType = parseInt(data.albumType);
    const formData = new FormData();
    Object.entries(data).forEach(([prop, value]) => formData.append(prop, value));
    try {
      const newAlbumResult = await fetcher.post(`albums`, formData)
        .then(r => r.data);
      if (!newAlbumResult.isSuccessful) return newAlbumResult;
      const album = await getAlbumByIdAsync(newAlbumResult.albumId);
      album.tableProps = { color: '#b3cf99' }
      setItems([album, ...items]);
      return newAlbumResult;
    } catch (err) {
      if (err.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return err.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
    }
  }

  const getAlbumByIdAsync = async (id) => {
    try {
      const res = await fetcher.get(`albums/${id}`);
      return res.data;
    } catch (error) {
      if (error.code === 401) {
        return { isSuccessful: false, resultMessage: "Unauthorized. Authorize please." }
      }
      return error.response?.data ?? { isSuccessful: false, resultMessage: 'Unknown error' };
    }
  }

  const changeFilters = (propName, propValue) => {
    filters[propName] = propValue;
    setFilters({ ...filters });
  }

  return (
    <>
      <div className="filter-form" style={{ display: 'flex', justifyContent: 'center' }}>
        <div>
          Album type:
          <select value={filters.albumType} onChange={e => changeFilters('albumType', e.target.value)}>
            <option value={""}>All</option>
            <option value={"Single"}>Single</option>
            <option value={"Album"}>ALbum</option>
          </select >
          <br />
          Minimum tracks for album:
          <input placeholder="minimum number of tracks" type="number" value={filters.tracksMin} onChange={e => changeFilters('tracksMin', e.target.value)} /> <br />
          Maximum tracks for album:
          <input placeholder="maximum number of tracks" type="number" value={filters.tracksMax} onChange={e => changeFilters('tracksMax', e.target.value)} /> <br />
          Maximum number of displayed albums:
          <input placeholder="max count" type="number" value={filters.maxCount} onChange={e => changeFilters('maxCount', e.target.value)} /> <br />
          Search for the album name:
          <input placeholder="type somephin" type="text" value={filters.search} onChange={e => changeFilters('search', e.target.value)} /> <br />
          Sort by:
          <select value={filters.sortBy} onChange={e => changeFilters('sortBy', e.target.value)}>
            <option value="">None</option>
            <option value="id">Id</option>
            <option value="name">Name</option>
            <option value="type">Album type</option>
            <option value="author">Author name</option>
          </select >
          <br />
          <input type="button" value="apply filters" onClick={() => setClicked(!clicked)} /> <br />
        </div>
      </div>
      <AddAlbum insertItemsWithResultAsync={insertItemsWithResultAsync} />
      <TableDisplayer data={items} setData={setItems} editDataWithResultAsync={editItemsWithResultAsync} deleteDataWithResultAsync={deleteItemsWithResultAsync} columns={tableColumns} />
    </>
  );
}

export default Albums;