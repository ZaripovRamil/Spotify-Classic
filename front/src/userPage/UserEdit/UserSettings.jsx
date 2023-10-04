import { useEffect, useState } from "react"
import Ports from "../../constants/Ports";
import { getFetcher } from "../../axios/AxiosInstance";

const fetcher = getFetcher(Ports.AuthApi);
export const UserSettings =({userInfo}) => {

    const [nickname,setNickname] = useState(userInfo.name)
    const [errorMessage,setErrorMessage] = useState("")
    const [successMessage,setSuccessMessage] = useState("")

    useEffect(()=>{
        console.log(userInfo)
    },[])
    const handleSubmitForm = (event) => {
        event.preventDefault();
        setSuccessMessage("")
        setErrorMessage("")
        fetcher.put(`User/update/username/${nickname}`)
            .then(res => {setSuccessMessage("Никнейм сменен"); })
            .catch(err => {console.log(err); setErrorMessage("что то пошло не так(")});
    };

    return(
        <div className="settings">
            E-mail
            <div className="email">
                {userInfo.email}
            </div> 
            Change Nickname
            <form onSubmit={handleSubmitForm}>
                <div className="nickname-block">
                    <div className="settings-block">
                            <input className="settings-input" 
                                    type="text"
                                    value={nickname}
                                    placeholder="input nickname"
                                    onChange={e => setNickname(e.target.value)}/> 
                        
                            
                    </div>
                    <div className="message noMargin-error-message">{successMessage}</div>  
                    <div className="error-message">{errorMessage}</div>  
                    <input className="save-btn" type="submit" value="Save"/> 
                </div>
            </form>
                
            
        </div>
    )
}