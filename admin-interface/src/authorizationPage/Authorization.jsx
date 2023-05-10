import React, { useState } from "react";
import { Button } from "@material-ui/core";
import FormDialog from "../components/FormDialog/FormDialog";
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";

const fetcher = getFetcher(Ports.AuthService);

const Authorization = () => {
    const [openAuthForm, setOpenAuthForm] = useState(false);
    const [credentials, setCredentials] = useState({
        username: '',
        password: '',
    })
    const authorizationFormColumns = [
        {
            name: 'username',
            label: 'Username',
            type: 'text',
            typeProps: {},
            isRequired: true
        },
        {
            name: 'password',
            label: 'Password',
            type: 'text',
            typeProps: {},
            isRequired: true
        },
    ]
    const authorizeWithResultAsync = async (data) => {
        return await fetcher.post('auth/login', data)
            .then(r => r.data)
            .then(r => {
                if (!r.isSuccessful || r.token.length === 0) {
                    return { isSuccessful: false, messageResult: r.messageResult || "Authorization failed" };
                }
                localStorage.setItem('access-token', r.token);
                return r;
            })
            .catch(error => error.message || (error.response?.data ?? "Authorization failed"));
    };
    return (
        <>
            <Button
                variant="contained"
                onClick={() => setOpenAuthForm(true)}
            >
                Authorize
            </Button>
            <FormDialog isOpen={openAuthForm} setIsOpen={setOpenAuthForm} formHeader={"Authorize"} formData={credentials} setFormData={setCredentials} columns={authorizationFormColumns} submitFormDataWithResultAsync={authorizeWithResultAsync} />
        </>
    );
};

export default Authorization;