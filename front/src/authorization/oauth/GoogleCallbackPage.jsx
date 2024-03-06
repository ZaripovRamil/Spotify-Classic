import React, { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import Ports from "../../constants/Ports";
import { getFetcher } from "../../axios/AxiosInstance";

const fetcher = getFetcher(Ports.AuthApi);

const GoogleCallbackPage = () => {
    const navigate = useNavigate();
    useEffect(() => {
        const params = new URLSearchParams(window.location.search);
        const code = params.get('code');
        const state = params.get('state');
        if (!code || state !== '13245') {
            console.log('watta fuck');
            return;
        }
        fetcher.post(`https://localhost:${Ports.AuthApi}/oauth/google/callback`, { code })
            .then(resp => {
                return fetcher.post('oauth/google/login', {access_token: resp.data.access_token, id_token: resp.data.id_token});
            })
            .then(resp => {
                if (resp.data.loginResult.isSuccessful) {
                    localStorage.setItem('access-token', resp.data.loginResult.token);
                    navigate('/main');
                }
                else {
                    alert(resp.data.loginResult.resultMessage);
                }
            });
    }, [])
    return (
        <>please, wait...</>
    );
}

export default GoogleCallbackPage;