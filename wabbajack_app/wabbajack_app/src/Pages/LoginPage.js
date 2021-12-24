import * as React from 'react';
import LoginBox from "../Components/LoginBox";
function LoginPage({ setEmailPassword, handleLoginRequest }) {

   return (
      <div>
         <LoginBox setEmailPassword={setEmailPassword} handleLoginRequest={handleLoginRequest} />
      </div>
   );
}

export default LoginPage