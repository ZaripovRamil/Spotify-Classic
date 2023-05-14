class AuthorizationErrors {
    static needMoreCharacters = (chars) => `Enter at least ${chars} characters`;
    static wrongEmailFormat = "Enter correct email";
    static emailIsAlreadyTaken = "This email is already taken";
    static loginIsAlreadyTaken = "This login is already taken";
    static incorrectName = "Only latin characters and digits are allowed";
    static wrongLoginOrPassword = "Wrong login or password";
}

export default AuthorizationErrors;