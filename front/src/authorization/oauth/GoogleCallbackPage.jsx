import React, { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import Ports from "../../constants/Ports";
import { getFetcher } from "../../axios/AxiosInstance";

const fetcher = getFetcher(Ports.AuthService);

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
        fetcher.post(`https://localhost:${Ports.AuthService}/oauth/google/callback`, { code })
            .then(resp => {
                localStorage.setItem('google_access_token', resp.data.access_token);
                localStorage.setItem('google_id_token', resp.data.id_token);
                return fetcher.post('oauth/google/login', {access_token: resp.data.access_token, id_token: resp.data.id_token});
            })
            .then(resp => {
                if (resp.data.isSuccessful) {
                    localStorage.setItem('access-token', resp.data.token);
                    navigate('/main');
                }
                else {
                    alert(resp.data.resultMessage);
                }
            });
    }, [])
    return (
        <>please, wait...</>
    );
}

export default GoogleCallbackPage;