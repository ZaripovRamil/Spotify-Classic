import axios from "axios";

// care of http/https
export const getFetcher = (port) => {
    let authToken = localStorage.getItem('access-token');
    if (authToken === null) authToken = '';
    return axios.create({
        headers: {
            'Authorization': `Bearer ${authToken}`
        },
        baseURL: `https://localhost:${port}/`
    });
}