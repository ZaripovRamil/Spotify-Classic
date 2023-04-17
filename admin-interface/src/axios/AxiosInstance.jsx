import axios from "axios";

// care of http/https
export const getFetcher = (port) => axios.create({
    baseURL: `https://localhost:${port}/`
});