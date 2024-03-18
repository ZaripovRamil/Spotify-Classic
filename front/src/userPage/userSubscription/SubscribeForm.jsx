import React, { useRef, useEffect, useState } from "react";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";
import InputMask from "react-input-mask";
import passwordHideIcon from "../media/PasswordHide.png";
import passwordShowIcon from "../media/PasswordShow.png";
import "./UserSubscription.css";

import { PaymentServiceClient } from "./protos/payment_grpc_web_pb";
import { SubscriptionUpdateData, ResultDto } from "./protos/payment_pb";

const fetcher = new PaymentServiceClient(`http://localhost:8080`);

export const SubscribeForm = () => {
  const [errorMessage, setErrorMessage] = useState("");
  const data = {
    subscriptionId: "Premium",
  };
  const [cvsHide, setCvsHide] = useState(true);

  const validateDate = (value) => {
    var today = new Date();
    var mm = String(today.getMonth() + 1).padStart(2, "0"); //January is 0!
    var yyyy = today.getFullYear();
    console.log(value, mm, yyyy);
    if (value.substring(0, 2) < mm && "20" + value.substring(2, 4) < yyyy) {
      setErrorMessage("The card has expired");
    }
  };

  const handleSubmitForm = (event) => {
    setErrorMessage("");
    event.preventDefault();
    const token = localStorage.getItem("access-token");
    const metadata = { "Authorization": `Bearer ${token}` };
    const request = new SubscriptionUpdateData();
    request.setSubscriptionid("Premium");
    fetcher.updateSubscription(request, metadata, (err, response) => {
      if (err) {
        console.log(err);
        setErrorMessage("что то пошло не так(");
      } else {
        window.location.reload();
        console.log("sucess");
      }
    });
  };

  return (
    <>
      <div className="subscribe__settings">
        <div className="settings-block">
          <InputMask mask="99999999999999999999">
            {() => (
              <input
                className="settings-input"
                type={""}
                placeholder="card number"
                required
              />
            )}
          </InputMask>
        </div>
        <div className="settings-block">
          <InputMask mask="99/99">
            {() => (
              <input
                className="settings-input"
                type={""}
                placeholder="month/year"
                onInput={(e) => validateDate(e.target.value)}
                required
              />
            )}
          </InputMask>
        </div>
        <input type="text" hidden />
        <input type="password" hidden />
        <div className="settings-block">
          <input
            maxLength={3}
            minLength={3}
            className="settings-input"
            type={cvsHide ? "password" : "text"}
            placeholder="cvs"
            required
          />
          <img
            style={{ width: "25px" }}
            src={cvsHide ? passwordHideIcon : passwordShowIcon}
            onClick={() => setCvsHide(!cvsHide)}
          />
        </div>
        <div className="error-message noMargin-error-message">
          {errorMessage}
        </div>
        <input
          className="save-btn"
          type="button"
          onClick={handleSubmitForm}
          value="Confirm"
        />
      </div>
      ;
    </>
  );
};
