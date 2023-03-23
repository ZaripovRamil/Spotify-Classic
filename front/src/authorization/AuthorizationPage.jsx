import React from "react";
import AuthForm from "./components/AuthorizationForm";
import "./AuthorizationPage.css";
import wheel from "./media/playing_record_wheel.png";

const AuthorizationPage = () => {
    return (
        <>
            {/* global header */}
            <header></header>
            <main>
                {/* maybe move to separate components?
                * also, this is not even a bit adaptive... */}
                <div className="circle" id="first" />
                {/* play with these circles' top, left, width and height so that they won't affect overflow */}
                <div className="circle" id="second" />
                <img src={wheel} width={909} style={{ position: "absolute", left: "-454px", filter: "contrast(.9)" }} />
                <AuthForm />
            </main>
            {/* global footer */}
            <footer></footer>
        </>
    )
}

export default AuthorizationPage;