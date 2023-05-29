import React, { useEffect, useState } from "react";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

import "./UserSubscription.css";
import { SubscribeForm } from "./SubscribeForm";
import { UserExistedSubscription } from "./userExistedSubscription";

const fetcher = getFetcher(Ports.AuthService);
const prefix = "https://localhost:7022/";

export const UserSubscription = () => {
  const [isLoad, setIsLoad] = useState(false);
  const [userInfo, setUserInfo] = useState({
    email: "",
    history: [],
    id: "ef26e9f9-c7e3-4705-955d-ea80d0e20ef9",
    name: "TestUser",
    subscription: "",
    subscriptionExpire: "",
    playlists: [],
    profilePicId: "default_pfp",
    role: 0,
  });

  useEffect(() => {
    fetcher
      .get(`user/getme`)
      .then((res) => {
        setUserInfo(res.data);
        setIsLoad(true);
      })
      .catch((err) => console.log(err));
  }, []);

  return (
    isLoad && (
      <>
        {userInfo.subscription === "" ? (
          <main className="main-page">
            <div className="sub_info">
              <h3>Subscription</h3>
              <strong>Why subscribe?</strong>
              <p>
                The subscription provides unique functionality that is not
                available to ordinary users. Take full advantage of all the
                features of our application!
              </p>
              <strong>What is included in the subscription?</strong>
              <p>
                You will be able to export statistics of your listened songs,
                albums and artists. Draw conclusions about what you like the
                most.
              </p>
              <strong>Subscription details</strong>
              <ul>
                <li>Price: 199rub</li>
                <li>Duration: 1 month</li>
              </ul>
            </div>
            <div className="subscribe__name">Subscribe</div>
            <SubscribeForm />
          </main>
        ) : (
          <UserExistedSubscription
            subscription={userInfo.subscription}
            subscriptionExpire={userInfo.subscriptionExpire}
          />
        )}
      </>
    )
  );
};
