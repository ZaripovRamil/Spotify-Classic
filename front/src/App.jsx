import "./App.css";
import React from "react";
import Player from "./player/Player";
import { Header } from "./components/Header/Header";
import { Footer } from "./components/Footer/Footer";
import { AuthorizationPage } from "./authorization/AuthorizationPage";
import { RegistrationPage } from "./authorization/RegistrationPage";

function App() {
    return (
        <>
            <Header/>
                <div className="content">
                    {/* <Player /> */}
                    {/* <AuthorizationPage/> */}
                    <RegistrationPage/>
                
                </div>
            <Footer/>
        </>
    );
}

export default App;
