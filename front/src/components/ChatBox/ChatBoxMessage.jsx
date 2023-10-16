import React from "react";

export const ChatBoxMessage = (props) => {
  return (
    <>
      <div
        className={
          props.isOwner
            ? "message-block message-block-owner"
            : "message-block message-block-no-owner"
        }
      >
        <p>
          <strong className="chat-user">{props.user}</strong>
        </p>
        <div className={props.isOwner ? "message message-owner" : "message "}>
          <p className={"message-text"}>{props.message}</p>
        </div>
      </div>
    </>
  );
};
