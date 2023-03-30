import "./Authorization.css";
import React, { useState } from "react";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from '../../constants/Ports';
import AuthorizationErrors from "../../constants/AuthorizationErrors";
import { useNavigate } from "react-router";

const fetcher = getFetcher(Ports.AuthService);

export const RegisterForm = () => {
    const navigate = useNavigate();
    const [credentials, setCredentials] = useState({
        login: "",
        name: "",
        email: "",
        password: ""
    });
    const [loginError, setLoginError] = useState();
    const [nameError, setNameError] = useState();
    const [emailError, setEmailError] = useState();
    const [passwordError, setPasswordError] = useState();

    const handleSubmitForm = (event) => {
        event.preventDefault();
        if (!validateCredentials()) {
            return;
        }
        // console.log('here'); // this bitch displays when errors were set by validateCredentials and yet it returned true
        fetcher.post("registration/add", credentials)
            .then(res => handleRegistrationInfo(res.data))
            .catch(err => console.log(err));
        navigate('/main');
    };

    const handleRegistrationInfo = (info) => {
        switch (info) {
            case 0:
                console.log('ok');
                break;
            case 1:
                setLoginError(AuthorizationErrors.loginIsAlreadyTaken);
                break;
            case 2:
                setEmailError(AuthorizationErrors.emailIsAlreadyTaken);
                break;
            case 3:
                setPasswordError(AuthorizationErrors.needMoreCharacters(8));
                break;
            default:
                console.log('watta fuck');
                break;
        }
    }

    const updateCredentials = (name, value) => {
        credentials[name] = value.trim();
        setCredentials({ ...credentials });
    }

    // while validating, manipulates credential errors states
    // returns false if at least one of credentials is wrong
    const validateCredentials = () => {
        if (credentials.name.length < 4) {
            setNameError(AuthorizationErrors.needMoreCharacters(4));
        } else if (!/^[A-Za-zа-яА-Я]+$/.test(credentials.name)) {
            setNameError(AuthorizationErrors.incorrectName);
        } else {
            setNameError();
        }
        if (credentials.password.length < 8) {
            setPasswordError(AuthorizationErrors.needMoreCharacters(8));
        } else {
            setPasswordError();
        }
        if (credentials.login.length < 4) {
            setLoginError(AuthorizationErrors.needMoreCharacters(4));
        } else {
            setLoginError();
        }
        if (credentials.email.length < 5) {
            setEmailError(AuthorizationErrors.needMoreCharacters(5));
        } else {
            setEmailError();
        }
        // email is validated by browser for now
        return !loginError && !nameError && !emailError && !passwordError;
    }

    return (
        <form className="register-form" onSubmit={handleSubmitForm}>
            <div className="register-header">
                Registration
            </div>
            <div className="credentials-input">
                <div>
                    <div className="error-text error-login">{loginError}</div>
                    <input type="text" placeholder="login" onChange={e => updateCredentials("login", e.target.value)} />
                </div>
                <div>
                    <div className="error-text error-name">{nameError}</div>
                    <input type="text" placeholder="your name" onChange={e => updateCredentials("name", e.target.value)} />
                </div>
                <div>
                    <div className="error-text error-email">{emailError}</div>
                    <input type="email" placeholder="e-mail" onChange={e => updateCredentials("email", e.target.value)} />
                </div>

                <div>
                    <div className="error-text error-password">{passwordError}</div>
                    <input type="password" placeholder="password" onChange={e => updateCredentials("password", e.target.value)} />
                </div>
            </div>
            <div className="submit-btn">
                <input type="submit" value="OK" />
            </div>
        </form>
    )
}
