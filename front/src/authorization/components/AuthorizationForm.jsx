import React from "react";
import "./Authorization.css";

const AuthForm = () => {
    return (
        <form className="auth-form">
            <div className="auth-header">
                Authorization
            </div>
            <div className="credentials-input">
                <div>
                    <div className="error-text error-email">Incorrect e-mail</div>
                    <input type="email" placeholder="e-mail" />
                </div>

                <div>
                    <div className="error-text error-password">Incorrect password</div>
                    <input type="password" placeholder="password" />
                </div>


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