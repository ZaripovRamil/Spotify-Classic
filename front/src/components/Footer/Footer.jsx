import "./Footer.css";
import footerLogo from "./footer-logo.svg";

export const Footer = ({ props }) => {
  const { tracksList, setTracksList, playerConf, setPlayerConf } = props;
  return (
    <footer>
      <div className="footer">
        <div className="footer-logo">
          <img className="footer-logo-img" src={footerLogo} />
          <div>Classic music</div>
        </div>
        <div className="footer-links">
          <div className="footer-inc">© 2023 DotKek Bol’ Inc.</div>
          <a href="/contacts">Contacts</a>
          <br/>
          <a href="/chat">Support Chat</a>
        </div>
      </div>
      {tracksList && playerConf && <div className="empty-footer"></div>}
    </footer>
  );
};
