import React, { useState, useEffect, useRef } from "react";
import { HttpTransportType, HubConnectionBuilder } from "@microsoft/signalr";
import { ChatBoxInput } from "./ChatBoxInput";
import { ChatBoxWindow } from "./ChatBoxWindow";
import "./ChatBox.css";
import { getFetcher } from "../../axios/AxiosInstance";
import Ports from "../../constants/Ports";

const fetcher = getFetcher(Ports.ChatApi);
export const ChatBox = ({ props }) => {
  const [connection, setConnection] = useState(null);
  const [chat, setChat] = useState([]);
  const latestChat = useRef(null);
  const [chatBoxStyle, setChatBoxStyle] = useState("none");
  const [chatButtonStyle, setChatButtonStyle] = useState("block");

  function toggleChat() {
    console.log("я тут");
    if (chatBoxStyle === "none") {
      setChatBoxStyle("block");
      setChatButtonStyle("none");
    } else {
      setChatBoxStyle("none");
      setChatButtonStyle("block");
    }
  }

  latestChat.current = chat;

  function updateHistory() {
    fetcher
      .get("/chat/history")
      .then((result) => setChat(result.data))
      .catch((ex) => console.log(ex));
  }

  useEffect(() => {
    const authToken = localStorage.getItem("access-token") ?? "";
    const newConnection = new HubConnectionBuilder()
      .withUrl(`https://localhost:${Ports.ChatApi}/chat`, {
        transport: HttpTransportType.WebSockets,
        skipNegotiation: true,
        accessTokenFactory: () => `${authToken}`,
      })
      .withAutomaticReconnect()
      .build();
    setConnection(newConnection);
    updateHistory();
  }, []);

  useEffect(() => {
    if (connection) {
      connection
        .start()
        .then((result) => {
          console.log("Connected!");
          connection.send("AddToGroup");

          connection.on("ReceiveMessage", (message) => {
            const updatedChat = [...latestChat.current];
            updatedChat.push(message);
            setChat(updatedChat);
          });
        })
        .catch((e) => console.log("Connection failed: ", e));
    }
  }, [connection]);

  const sendMessage = async (user, message) => {
    const chatMessage = {
      user: user,
      message: message,
      isOwner: true,
      groupName: "",
    };

    if (connection._connectionStarted) {
      try {
        await connection.send("SendMessage", chatMessage);
      } catch (e) {
        console.log(e);
      }
    } else {
      alert("No connection to server yet.");
    }
  };

  return (
    <div className="chat">
      <button
        style={{ display: chatButtonStyle }}
        className="chat-button"
        id="chat-button"
        onClick={toggleChat}
      >
        Chat
      </button>
      <div style={{ display: chatBoxStyle }} className="chat-box" id="chat-box">
        <div className="chat-header">
          <h2>Chat</h2>
          <button
            className="close-button"
            id="close-button"
            onClick={toggleChat}
          >
            X
          </button>
        </div>
        <div className="chat">
          <ChatBoxWindow chat={chat} />
          <ChatBoxInput sendMessage={sendMessage} />
        </div>
      </div>
    </div>
  );
};

// import { useState } from "react";
// import "./ChatBox.css";

// export const ChatBox = () => {
//   const [chatBoxStyle, setChatBoxStyle] = useState("none");
//   const [chatButtonStyle, setChatButtonStyle] = useState("block");
//   function toggleChat() {
//     if (chatBoxStyle === "none") {
//       setChatBoxStyle("block");
//       setChatButtonStyle("none");
//     } else {
//       setChatBoxStyle("none");
//       setChatButtonStyle("block");
//     }
//   }

//   function sendMessage(sender) {
//     // var messageInput = document.getElementById("message-input");
//     // var message = messageInput.value.trim();
//     // if (message !== "") {
//     //   var chatMessages = document.getElementById("chat-messages");
//     //   var newMessage = document.createElement("div");
//     //   if (sender === "me") {
//     //     newMessage.className = "my-message";
//     //   } else {
//     //     newMessage.className = "opponent-message";
//     //   }
//     //   newMessage.textContent = message;
//     //   chatMessages.appendChild(newMessage);
//     //   messageInput.value = "";
//     //   chatMessages.scrollTop = chatMessages.scrollHeight;
//     // }
//   }

//   return (
//     <div className="chat">
//       <button
//         style={{ display: chatButtonStyle }}
//         className="chat-button"
//         id="chat-button"
//         onclick={toggleChat()}
//       >
//         Chat
//       </button>
//       <div style={{ display: chatBoxStyle }} className="chat-box" id="chat-box">
//         <div className="chat-header">
//           <h2>Classical Music Chat</h2>
//           <button
//             className="close-button"
//             id="close-button"
//             onclick={toggleChat()}
//           >
//             X
//           </button>
//         </div>
//         <div className="chat">
//           <div className="chat-messages" id="chat-messages"></div>
//           <div className="chat-end">
//             <input
//               type="text"
//               className="message-input"
//               id="message-input"
//               placeholder="Type your message."
//             />
//             <button
//               className="send-button"
//               id="send-button"
//               onclick={sendMessage()}
//             >
//               Send
//             </button>
//           </div>
//         </div>
//       </div>
//     </div>
//   );
// };
