import { useEffect, useRef, useState } from "react";
import {useParams } from "react-router-dom"
import { getFetcher } from "../axios/AxiosInstance";
import Ports from "../constants/Ports";
import { HttpTransportType, HubConnectionBuilder } from "@microsoft/signalr";
import { ChatWindow } from "./ChatWindow";
import { ChatInput } from "./ChatInput";

const fetcher = getFetcher(Ports.ChatService)
export const ChatPage = () => {

    const [ connection, setConnection ] = useState(null);
    const [ chat, setChat ] = useState([]);
    const latestChat = useRef(null);
    const { userName } = useParams();

    latestChat.current = chat;

    function updateHistory(){
        fetcher.get(`/chat/history/${userName}`)
            .then(result =>{ setChat(result.data); console.log(result.data)})
            .catch(ex => console.log(ex));    
    }

    useEffect( () => {
        const authToken = localStorage.getItem("access-token") ?? "";
        const newConnection = new HubConnectionBuilder()
            .withUrl('https://localhost:7077/chat',{
                transport: HttpTransportType.WebSockets,
                skipNegotiation: true,
                accessTokenFactory: () => `${authToken}`
            })
            .withAutomaticReconnect()
            .build();
        setConnection(newConnection)
        updateHistory();
        
    }, [userName]);

    useEffect(() => {
        if (connection) {
            connection.start()
                .then( (result) => {
                    console.log('Connected!');
                    connection.send("AddToGroupByName",`${userName}`);

                    connection.on('ReceiveMessage', message => {
                        const updatedChat = [...latestChat.current];
                        updatedChat.push(message);
                        setChat(updatedChat);
                    });
                })
                .catch(e => console.log('Connection failed: ', e));
        }
    }, [connection]);

    const sendMessage = async (user, message) => {
        const chatMessage = {
            user: user,
            message: message,
            isOwner: true,
            groupName: userName
        };

        if (connection._connectionStarted) {
            try {
                await connection.send('SendAdminMessage', chatMessage);
            }
            catch(e) {
                console.log(e);
            }
        }
        else {
            alert('No connection to server yet.');
        }
    }

    return (
        <div className="chat-block">
            <div className="group-link">{userName}</div>
            <ChatWindow chat={chat}/>
            <ChatInput sendMessage={sendMessage} />
        </div>
        

    )
}