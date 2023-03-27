import axios from "axios";

// care of http/https
export const fetcher = axios.create({
    baseURL: 'http://localhost:7022/api/'
});