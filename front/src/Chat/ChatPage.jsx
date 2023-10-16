import React, { useState, useEffect, useRef } from 'react';
import { HttpTransportType, HubConnectionBuilder } from '@microsoft/signalr';
import { ChatInput } from './ChatInput';
import { ChatWindow } from './ChatWindow';
import "./ChatPage.css";
import { getFetcher } from '../axios/AxiosInstance';
import Ports from '../constants/Ports';

const fetcher = getFetcher(Ports.ChatApi);
export const ChatPage = ({props}) => {
    const [ connection, setConnection ] = useState(null);
    const [ chat, setChat ] = useState([]);
    const latestChat = useRef(null);

    latestChat.current = chat;


    function updateHistory(){
        fetcher.get('/chat/history')
            .then(result => setChat(result.data))
            .catch(ex => console.log(ex));   
    }

    useEffect( () => {
        const authToken = localStorage.getItem("access-token") ?? "";
        const newConnection = new HubConnectionBuilder()
            .withUrl(`https://localhost:${Ports.ChatApi}/chat`,{
                transport: HttpTransportType.WebSockets,
                skipNegotiation: true,
                accessTokenFactory: () => `${authToken}`
            })
            .withAutomaticReconnect()
            .build();
        setConnection(newConnection)
        updateHistory();
        
    }, []);

    useEffect(() => {
        if (connection) {
            connection.start()
                .then( (result) => {
                    console.log('Connected!');
                    connection.send("AddToGroup");

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
            groupName: ""
        };

        if (connection._connectionStarted) {
            try {
                await connection.send('SendMessage', chatMessage);
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
        <main className="main-page">
            <h3>Support Chat</h3>
            <div className='chat-block'>
                <ChatWindow chat={chat}/>
                <ChatInput sendMessage={sendMessage} />
            </div>
        </main>
    );
};