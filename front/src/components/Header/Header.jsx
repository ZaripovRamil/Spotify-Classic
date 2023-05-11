import "./Header.css"
import { Link } from 'react-router-dom';
export const Header = () => {
    return (
        <header className="header">
            <div>
                <input type="text" placeholder="Search"/>
            </div>
            <Link to="/authorize"><div className="avatar"></div></Link>
        </header>
        )
}