import "./ChatPage.css"
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";
import { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";

const fetcher = getFetcher(Ports.AdminService)
export const ChatsPage = ({component}) => {

    const [users, setUsers] = useState(null);

    useEffect(() => {
        const getUsers = async () => {
          await fetcher.get('users/get')
            .then(res => {setUsers(res.data);})
            .catch(err => console.log(err));     
        }
        getUsers();
      }, []);

    return (
        <div className="chat-page">
            <div className="group-block">
                {users && users.map(user => <NavLink key={user.userName} className={"group-link"} to={`/chat/${user.userName}`}>{user.userName}</NavLink>)} 
            </div>  
            {component}
        </div>

    )
}