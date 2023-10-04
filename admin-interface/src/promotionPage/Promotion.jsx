import React, { useState } from "react";
import Ports from "../constants/Ports";
import { getFetcher } from '../axios/AxiosInstance';

const fetcher = getFetcher(Ports.AdminApi);

const PromotionPage = () => {
    const [username, setusername] = useState('');
    const [result, setResult] = useState('');

    const handleInputChange = (event) => {
        setusername(event.target.value);
    };

    const handleButtonClick = () => {
        fetcher.post('users/promote', { username: username })
            .then(_ => {
                setResult('Successful');
            });
    };

    return (
        <div>
            <input type="text" value={username} onChange={handleInputChange} />
            <button onClick={handleButtonClick}>Send Request</button>
            <pre />
            {result && <p>{result}</p>}
        </div>
    );
}

export default PromotionPage