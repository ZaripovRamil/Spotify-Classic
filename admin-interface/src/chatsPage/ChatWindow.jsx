import React from 'react';
import { Message } from './Message';

export const ChatWindow = (props) => {
    const chat = props.chat
        .map((m,id) => <Message 
            key={id * Math.random()}
            user={m.user}
            message={m.message}
            isOwner={m.isOwner}/>);
    return(
        <div className='messages-block'>
            {chat}
        </div>
    )
};