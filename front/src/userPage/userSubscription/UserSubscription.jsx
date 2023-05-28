import React, { useRef, useEffect, useState } from "react";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";
import Dropdown from "react-bootstrap/Dropdown";

import { useReactToPrint } from "react-to-print";

import "./UserSubscription.css";

const fetcher = getFetcher(Ports.AuthService);
const prefix = "https://localhost:7022/";

export const UserSubscription = () => {
  const [isLoad, setIsLoad] = useState(false);

  useEffect(() => {
    // fetcher
    //   .get("user/get/statistics")
    //   .then((res) => {
    //     setStatictic(res.data);
    //     console.log(res.data);
    //     setIsLoad(true);
    //   })
    //   .catch((err) => console.log(err));
  }, []);

  return (
    isLoad && (
      <>
        <main className="main-page"></main>
      </>
    )
  );
};
