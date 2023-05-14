import { useState } from "react"
import passwordHideIcon from "../media/PasswordHide.png"
import passwordShowIcon from "../media/PasswordShow.png"

export const UserPassword = () => {
    const [errorMessage,setErrorMessage] = useState("oshibka")
    const [passwordBlock, setPasswordBlock] = useState({
        oldPassword: "",
        password: "",
        repeatPassword:""
    });
    const [passwordHide,setPasswordHide] = useState(true);
    const updatePasswordBlock = (name, value) => {
        passwordBlock[name] = value.trim();
        setPasswordBlock({ ...passwordBlock });
    }

    return (
        <div className="settings">
            
            Change nickname
            <div className="settings-block">
                    <input className="settings-input" 
                            type={"text"}
                            placeholder="Old password"
                            onChange={e => setPasswordBlock("oldPassword",e.target.value)}/>  
                      
            </div>
            <div className="settings-block">
                <input className="settings-input" 
                        type={passwordHide?"password":"text"}
                        placeholder="New password"
                        onChange={e => setPasswordBlock("password",e.target.value)}/> 
                <img style={{width:"25px"}} src={passwordHide?passwordHideIcon:passwordShowIcon} onClick={() => setPasswordHide(!passwordHide)} /> 
            </div>
            <div className="settings-block">
                <input className="settings-input" 
                        type={"password"}
                        placeholder="Repeat password"
                        onChange={e => setPasswordBlock("repeatPassword",e.target.value)}/>           
            </div>
            <div className="error-message noMargin-error-message">{errorMessage}</div>  
            <input className="save-btn" type="button" value="Save"/>
        </div>
    )
}