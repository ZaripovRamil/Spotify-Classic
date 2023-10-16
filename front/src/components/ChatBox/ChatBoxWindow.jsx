import React from "react";
import { ChatBoxMessage } from "./ChatBoxMessage";

export const ChatBoxWindow = (props) => {
  const chat = props.chat.map((m, id) => (
    <ChatBoxMessage
      key={id * Math.random()}
      user={m.user}
      message={m.message}
      isOwner={m.isOwner}
    />
  ));
  return <div className="chat-messages">{chat}</div>;
};
