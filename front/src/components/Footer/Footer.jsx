import "./Footer.css"
import footerLogo from "./footer-logo.svg";
export const Footer = () => {
    return (
        <footer >
            <div className="footer">
            <div  className="footer-logo">
                <img className="footer-logo-img"  src={footerLogo}/>
                <div>Classic music</div>
            </div>
            <div className="footer-inc" >© 2023 DotKek Bol’ Inc.</div>
            </div>
            <div className="empty-footer"></div>
        </footer>
    )
}