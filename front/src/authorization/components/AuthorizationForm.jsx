import React, { useState } from "react";
import "./Authorization.css";
import Ports from "../../constants/Ports";
import AuthorizationErrors from "../../constants/AuthorizationErrors";
import { getFetcher } from "../../axios/AxiosInstance";
import { useNavigate } from "react-router";

const fetcher = getFetcher(Ports.AuthApi);

const AuthForm = () => {
  const navigate = useNavigate();
  const [credentials, setCredentials] = useState({
    username: "",
    password: "",
    rememberMe: false,
  });
  const [loginError, setLoginError] = useState();
  const [passwordError, setPasswordError] = useState();

  const handleSubmitForm = (event) => {
    event.preventDefault();
    if (!validateCredentials()) {
      return;
    }
    // console.log('here'); // this bitch displays when errors were set by validateCredentials and yet it returned true
    fetcher
      .post("auth/login", credentials)
      .then((res) => handleAuthorizationInfo(res.data))
      .catch((err) => console.log(err));
  };

  const handleAuthorizationInfo = (data) => {
    if (data && data.isSuccessful) {
      localStorage.setItem("access-token", data.token);
      navigate("/main");
    } else {
      setLoginError(AuthorizationErrors.wrongLoginOrPassword);
      setPasswordError(AuthorizationErrors.wrongLoginOrPassword);
    }
  };

  const updateCredentials = (name, value) => {
    credentials[name] = value;
    setCredentials({ ...credentials });
  };

  // while validating, manipulates credential errors states
  // returns false if at least one of credentials is wrong
  const validateCredentials = () => {
    if (credentials.password.length < 8) {
      setPasswordError(AuthorizationErrors.needMoreCharacters(8));
    } else {
      setPasswordError();
    }
    if (credentials.username.length < 4) {
      setLoginError(AuthorizationErrors.needMoreCharacters(4));
    } else {
      setLoginError();
    }
    // email is validated by browser for now
    return !loginError && !passwordError;
  };

  const handleGoogleOAuth = () => {
    window.location.replace(
      `https://localhost:${Ports.AuthApi}/oauth/google/entry`
    );
  };

  return (
    <form className="auth-form" onSubmit={handleSubmitForm}>
      <div className="auth-header">Authorization</div>
      <div className="credentials-input">
        <div>
          <div className="error-text error-login">{loginError}</div>
          <input
            type="text"
            placeholder="login"
            onChange={(e) =>
              updateCredentials("username", e.target.value.trim())
            }
          />
        </div>

        <div>
          <div className="error-text error-password">{passwordError}</div>
          <input
            type="password"
            placeholder="password"
            onChange={(e) =>
              updateCredentials("password", e.target.value.trim())
            }
          />
        </div>

        <div className="remember-me-span">
          <input
            type="checkbox"
            id="remember-me"
            checked={credentials.rememberMe}
            onChange={(e) => updateCredentials("rememberMe", e.target.checked)}
          />
          <label htmlFor="remember-me">Remember me</label>
        </div>
      </div>
      <div className="submit-btn">
        <input type="submit" value="OK" />
      </div>
      <div className="oauthBtn" onClick={handleGoogleOAuth}></div>
      <div>
        Don't have an account? <a href="/register">Register here</a>
      </div>
    </form>
  );
};

export default AuthForm;
