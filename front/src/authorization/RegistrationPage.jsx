import React from "react";
import { RegisterForm } from "./components/RegistrationForm"
import "./AuthorizationPage.css"
import wheel from "./media/playing_record_wheel.png";

export const RegistrationPage = () => {
    return (
        <>
            <main>
                <div className="circle" id="first" /> 
                <div className="circle" id="second" />
                <div className="wheel-container" >
                    <img className="wheel-img" src={wheel}  />
                </div>
                
                <RegisterForm />

            </main>
        </>
    )
}