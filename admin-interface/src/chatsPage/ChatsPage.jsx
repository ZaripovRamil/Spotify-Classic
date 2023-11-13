import "./ChatPage.css"
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";
import { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";

const fetcher = getFetcher(Ports.AdminApi)
export const ChatsPage = ({component}) => {

    const [users, setUsers] = useState(null);

    useEffect(() => {
        const getUsers = async () => {
          await fetcher.get('users/rooms')
            .then(res => {setUsers(res.data);})
            .catch(err => console.log(err));     
        }
        getUsers();
      }, []);

    return (
        <div className="chats-page">
            <div className="chat-page">
                <div className="group-block">
                    {users && users.map(user => <NavLink key={user} className={"group-link"} to={`/chat/${user}`}>{user}</NavLink>)} 
                </div>  
                {component}
            </div>
        </div>

    )
}