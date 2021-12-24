import * as React from 'react';
import LoginBox from "../Components/LoginBox";
function LoginPage({ setEmailPassword, setSignin, handleLoginRequest }) {

   return (
      <div>
         <LoginBox setEmailPassword={setEmailPassword} setSignin = {setSignin} handleLoginRequest={handleLoginRequest} />
      </div>
   );
}

export default LoginPage