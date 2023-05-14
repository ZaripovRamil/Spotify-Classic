import { useState } from "react"

export const UserSettings =() => {
    const [nickname,setNickname] = useState("nickname")
    const [errorMessage,setErrorMessage] = useState("oshibka")
    return(
        <div className="settings">
            E-mail
            <div className="email">
                #######@####.##
            </div> 
            Change Nickname
            <div className="nickname-block">
                <div className="settings-block">
                    <input className="settings-input" 
                            type="text"
                            value={nickname}
                            placeholder="input nickname"
                            onChange={e => setNickname(e.target.value)}/>     
                </div>
                <div className="error-message">{errorMessage}</div>   
            </div>
                
            <input className="save-btn" type="button" value="Save"/>
        </div>
    )
}