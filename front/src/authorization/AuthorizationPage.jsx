import React from "react";
import AuthForm from "./components/AuthorizationForm";
import "./AuthorizationPage.css";
import wheel from "./media/playing_record_wheel.png";

const AuthorizationPage = () => {
    return (
        <>
            <header></header>
            <main>
                <img src={wheel} width={909} style={{ position: "absolute", left: "-454px" }} />
                <AuthForm />
            </main>
            <footer></footer>
        </>
    )
}

export default AuthorizationPage;