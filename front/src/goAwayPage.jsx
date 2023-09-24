import { useEffect } from "react";
import { useNavigate } from "react-router-dom";

const GoAwayPage = () => {
    const navigate = useNavigate();
    useEffect(() => navigate('/main'),  [navigate]);
}

export default GoAwayPage;