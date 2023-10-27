import React, { useState } from "react";

export const ChatBoxInput = (props) => {
  const [message, setMessage] = useState("");

  const onSubmit = (e) => {
    e.preventDefault();
    let mes = message.trim();
    setMessage(mes);
    const isMessageProvided = mes && mes !== "";

    if (isMessageProvided) {
      props.sendMessage(" ", message);
      setMessage("");
    } else {
      alert("Please insert a message.");
    }
  };

  const onMessageUpdate = (e) => {
    setMessage(e.target.value);
  };

  return (
    <form className="chat-end" onSubmit={onSubmit}>
      <textarea
        id="message"
        className="message-input"
        name="message"
        value={message}
        onChange={onMessageUpdate}
        placeholder="Message to support"
      />
      <input type="submit" className="send-button" value={"Sent"} />
    </form>
  );
};
