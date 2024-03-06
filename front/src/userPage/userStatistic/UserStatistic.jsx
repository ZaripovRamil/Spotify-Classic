import React, { useRef, useEffect, useState } from "react";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";
import { useNavigate } from "react-router-dom";
import { useReactToPrint } from "react-to-print";

import "./UserStatistic.css";

const fetcher = getFetcher(Ports.AuthApi);
const prefix = `https://localhost:${Ports.StaticApi}/`;
export const UserStatisctics = () => {
  const navigate = useNavigate();
  const componentRef = useRef();

  const [isLoad, setIsLoad] = useState(false);
  const [statistic, setStatictic] = useState({
    totalListens: 0,
    tracks: [
      {
        track: {
          id: "",
          fileId: "",
          name: "",
          album: {
            id: "",
            previewId: "",
            name: "",
            author: {
              id: "",
              name: "",
            },
          },
        },
        count: 0,
      },
    ],
    authors: [
      {
        author: {
          id: "",
          name: "",
        },
        count: 0,
      },
    ],
    genres: [
      {
        genre: {
          id: "",
          name: "",
        },
        count: 0,
      },
    ],
  });

  useEffect(() => {
    fetcher
      .get("user/get/statistics")
      .then((res) => {
        setStatictic(res.data.snapshot);
        console.log(res.data.snapshot);
        setIsLoad(true);
      })
      .catch((err) => {
        if (err.response.status === 401) navigate("/authorize");
      });
  }, []);

  const handlePrint = useReactToPrint({
    content: () => componentRef.current,
  });

  return (
    isLoad && (
      <>
        <main className="main-page">
          <div className="print__section">
            <div className="container">
              <div className="row">
                <div className="col-md-12">
                  <button onClick={handlePrint} className="print">
                    Print
                  </button>
                  <div ref={componentRef} className="float__card statistic">
                    <div className="float__start">
                      <h3 className="card-title mb-0">Statistic</h3>
                    </div>
                    <hr />
                    <div className="float__infoss">
                      <div className="stat-block total-listens">
                        <div className="stat-title">
                          <strong>Total listens:</strong>
                        </div>
                        <div className="stat-number">
                          {statistic.totalListens}
                        </div>
                      </div>
                      <div className="stat-block">
                        <div className=" stat-title">
                          <strong>Tracks:</strong>
                        </div>
                        {statistic.tracks.map((data) => (
                          <div className="stat-part">
                            <img
                              src={
                                prefix +
                                `Previews/${data.track.album.previewId}`
                              }
                              alt=""
                            />
                            <div className="stat-part-info">
                              <div>{data.track.album.author.name}</div>
                              <div>{data.track.name}</div>
                            </div>
                            <div className="stat-number">{data.count}</div>
                          </div>
                        ))}
                      </div>
                      <div className="stat-block">
                        <div className=" stat-title">
                          <strong>Authors:</strong>
                        </div>
                        <ul className="stat-part stat-ul">
                          {statistic.authors.map((author) => (
                            <li>
                              <div className="stat-part-info">
                                <div>{author.author.name}</div>
                                <div className="stat-number">
                                  {author.count}
                                </div>
                              </div>
                            </li>
                          ))}
                        </ul>
                      </div>
                      <div className="stat-block">
                        <div className=" stat-title">
                          <strong>Genres:</strong>
                        </div>
                        <ul className="stat-part stat-ul">
                          {statistic.genres.map((genre) => (
                            <li>
                              <div className="stat-part-info">
                                {" "}
                                <div>{genre.genre.name}</div>
                                <div className="stat-number">{genre.count}</div>
                              </div>
                            </li>
                          ))}
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </main>
      </>
    )
  );
};
