import axios from "axios";

// care of http/https
export const fetcher = axios.create({
    baseURL: 'https://localhost:7022/api/'
});