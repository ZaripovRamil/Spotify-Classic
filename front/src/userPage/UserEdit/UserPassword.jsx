import { useState } from "react";
import passwordHideIcon from "../media/PasswordHide.png";
import passwordShowIcon from "../media/PasswordShow.png";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

const fetcher = getFetcher(Ports.AuthApi);

export const UserPassword = () => {
  const [errorMessage, setErrorMessage] = useState("");
  const [successMessage, setSuccessMessage] = useState("");
  const [passwordBlock, setPasswordBlock] = useState({
    oldPassword: "",
    password: "",
    repeatPassword: "",
  });
  const [passwordHide, setPasswordHide] = useState(true);
  const updatePasswordBlock = (name, value) => {
    passwordBlock[name] = value.trim();
    setPasswordBlock({ ...passwordBlock });
  };

  function resetPasswordBlock() {
    updatePasswordBlock("oldPassword", "");
    updatePasswordBlock("password", "");
    updatePasswordBlock("repeatPassword", "");
  }

  const handleSubmitForm = (event) => {
    setSuccessMessage("");
    setErrorMessage("");
    event.preventDefault();
    // if (!validateCredentials()) {
    //     return;
    // }
    console.log("here");
    fetcher
      .put("User/update/password", passwordBlock)
      .then((res) => {
        setSuccessMessage("Пароль сменен");
        resetPasswordBlock();
      })
      .catch((err) => {
        console.log(err);
        setErrorMessage("что то пошло не так(");
      });
  };

  return (
    <div className="settings">
      Change password
      <div className="settings-block">
        <input style={{ opacity: 0, position: "absolute" }} />
        {/* <input type="password" style={{ opacity: 0, position: "absolute" }} /> */}
        <input
          className="settings-input"
          type={"password"}
          value={passwordBlock.oldPassword}
          spellCheck={true}
          placeholder="Old password"
          onChange={(e) => updatePasswordBlock("oldPassword", e.target.value)}
        />
      </div>
      <div className="settings-block">
        <input
          className="settings-input"
          type={passwordHide ? "password" : "text"}
          value={passwordBlock.password}
          placeholder="New password"
          onChange={(e) => updatePasswordBlock("password", e.target.value)}
        />
        <img
          style={{ width: "25px" }}
          src={passwordHide ? passwordHideIcon : passwordShowIcon}
          onClick={() => setPasswordHide(!passwordHide)}
        />
      </div>
      <div className="settings-block">
        <input
          className="settings-input"
          type={"password"}
          value={passwordBlock.repeatPassword}
          placeholder="Repeat password"
          onChange={(e) =>
            updatePasswordBlock("repeatPassword", e.target.value)
          }
        />
      </div>
      <div className="message noMargin-error-message">{successMessage}</div>
      <div className="error-message noMargin-error-message">{errorMessage}</div>
      <input
        className="save-btn"
        type="button"
        onClick={handleSubmitForm}
        value="Save"
      />
    </div>
  );
};
