import "./Authorization.css";
import React, { useState } from "react";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";
import AuthorizationErrors from "../../constants/AuthorizationErrors";
import { useNavigate } from "react-router";

const fetcher = getFetcher(Ports.AuthService);

export const RegisterForm = () => {
  const navigate = useNavigate();
  const [credentials, setCredentials] = useState({
    login: "",
    name: "",
    email: "",
    password: "",
  });
  const [errors, setErrors] = useState({
    name: "",
    login: "",
    password: "",
    email: "",
  });

  const resetErrors = () => {
    errors.name = "";
    errors.login = "";
    errors.email = "";
    errors.password = "";
    setErrors({ ...errors });
  };

  const handleSubmitForm = (event) => {
    event.preventDefault();
    resetErrors();
    if (!validateCredentials()) {
      return;
    }

    fetcher
      .post("registration/add", credentials)
      .then((res) => handleRegistrationResult(res.data))
      .catch((err) => console.log(err));
  };

  // while validating, manipulates credential errors states
  // returns false if at least one of credentials is wrong
  const validateCredentials = () => {
    let isValid = true;
    if (credentials.name.length < 4) {
      isValid = false;
      errors.name = AuthorizationErrors.needMoreCharacters(4);
    } else if (!/^[A-Za-z0-9]+$/.test(credentials.name)) {
      isValid = false;
      errors.name = AuthorizationErrors.incorrectName;
    }
    if (credentials.password.length < 8) {
      isValid = false;
      errors.password = AuthorizationErrors.needMoreCharacters(8);
    }
    if (credentials.login.length < 4) {
      isValid = false;
      errors.login = AuthorizationErrors.needMoreCharacters(4);
    }
    if (credentials.email.length < 5) {
      isValid = false;
      errors.email = AuthorizationErrors.needMoreCharacters(5);
    }

    // email is validated by browser for now
    setErrors({ ...errors });
    return isValid;
  };

  const handleRegistrationResult = (data) => {
    if (data && data.isSuccessful) {
      navigate("/authorize");
    }
    const resultMessage = data.resultMessage.toLowerCase();
    if (resultMessage.indexOf("login") > -1) {
      errors.login = AuthorizationErrors.loginIsAlreadyTaken;
    }
    if (resultMessage.indexOf("email") > -1) {
      errors.email = AuthorizationErrors.emailIsAlreadyTaken;
    }
    if (resultMessage.indexOf("password") > -1) {
      errors.password = AuthorizationErrors.needMoreCharacters(8);
    }
    setErrors({ ...errors });
  };

  const updateCredentials = (name, value) => {
    credentials[name] = value.trim();
    setCredentials({ ...credentials });
  };

  return (
    <form className="register-form" onSubmit={handleSubmitForm}>
      <div className="register-header">Registration</div>
      <div className="credentials-input">
        <div>
          <input
            type="text"
            placeholder="login"
            onChange={(e) => updateCredentials("login", e.target.value)}
          />
          <div className="error-text error-login">{errors.login}</div>
        </div>
        <div>
          <input
            type="text"
            placeholder="your name"
            onChange={(e) => updateCredentials("name", e.target.value)}
          />
          <div className="error-text error-name">{errors.name}</div>
        </div>
        <div>
          <input
            type="email"
            placeholder="e-mail"
            onChange={(e) => updateCredentials("email", e.target.value)}
          />
          <div className="error-text error-email">{errors.email}</div>
        </div>
        <div>
          <input
            type="password"
            placeholder="password"
            onChange={(e) => updateCredentials("password", e.target.value)}
          />
          <div className="error-text error-password">{errors.password}</div>
        </div>
      </div>
      <div className="submit-btn">
        <input type="submit" value="OK" />
      </div>
      <div>
        Already have an account? <a href="/authorize">Login here</a>
      </div>
    </form>
  );
};
