import React from "react";
import "./AuthorizationForm.css";

const AuthForm = () => {
    return (
        <form className="auth-form">
            <div className="auth-header">
                Authorization
            </div>
            <div className="credentials-input">
                <input type="email" placeholder="e-mail" />
                <input type="password" placeholder="password" />
                <div className="remember-me-span">
                    <input type="checkbox" id="remember-me" />
                    <label htmlFor="remember-me">Remember me</label>
                </div>
            </div>
            <div className="submit-btn">
                <input type="submit" value="OK" />
            </div>
        </form>
    )
}

export default AuthForm;