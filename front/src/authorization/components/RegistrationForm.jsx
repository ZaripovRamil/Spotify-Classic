import "./Authorization.css";
import React from "react";
export const RegisterForm = () => {
    return (
        <form className="register-form">
            <div className="register-header">
                Registration
            </div>
            <div className="credentials-input">
            <div>
                    <div className="error-text error-nickname">Enter more than 8 characters</div>
                    <input type="text" placeholder="nickname" />
                </div>
                <div>
                    <div className="error-text error-email">Enter correct email</div>
                    <input type="email" placeholder="e-mail" />
                </div>
                
                <div>
                    <div className="error-text error-password">Enter more than 8 characters</div>
                    <input type="password" placeholder="password" />
                </div>
            </div>
            <div className="submit-btn">
                <input type="submit" value="OK" />
            </div>
        </form>
    )
}
