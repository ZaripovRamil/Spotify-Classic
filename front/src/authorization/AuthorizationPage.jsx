import React from "react";
import AuthForm from "./components/AuthorizationForm";
import "./AuthorizationPage.css";
import wheel from "./media/playing_record_wheel.png";

export const AuthorizationPage = () => {
    return (
        <>
            <main className="main-auth">
                {/* maybe move to separate components?
                * also, this is not even a bit adaptive... */}
                <div className="circle" id="first" />
                {/* play with these circles' top, left, width and height so that they won't affect overflow */}
                <div className="circle" id="second" />
                <div className="wheel-container" >
                    <img alt="" className="wheel-img" src={wheel} />
                </div>

                <AuthForm />

            </main>
        </>
    )
}
