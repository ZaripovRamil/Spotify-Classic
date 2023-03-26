import "./Header.css"
export const Header = () => {
    return (
        <header className="header">
            <div>
                <input type="text" placeholder="Search"/>
            </div>
            <div className="avatar"></div>
        </header>
        )
}