import React from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import "./PageBuilder.css";
import Player from "../player/Player";

export const PageBuilder = ({ component }) => {
    return (
        <>
            <Header />
            <div className="content">
                {component}
            </div>
            <Footer />
            <Player />
        </>
    )
}