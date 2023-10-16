import React, { useEffect, useState } from "react";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

import "./UserSubscription.css";
import { SubscribeForm } from "./SubscribeForm";

const fetcher = getFetcher(Ports.AuthApi);
const prefix = `https://localhost:${Ports.PlayerApi}/`;

export const UserExistedSubscription = ({
  subscription,
  subscriptionExpire,
}) => {
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
    <>
      <main className="main-page">
        <div className="sub_info">
          <div className="subscribe__name">Subscribtion info</div>
          <ul>
            {subscription && (
              <div>
                <li>Name: {subscription.name}</li>
                <li>Price: {subscription.price}rub</li>
                <li>Expires: {subscriptionExpire.slice(0, 10)}</li>
              </div>
            )}
          </ul>
        </div>
        <div className="subscribe__subname">
          Would you like to renew subscription?
        </div>
        <SubscribeForm />
      </main>
    </>
  );
};
