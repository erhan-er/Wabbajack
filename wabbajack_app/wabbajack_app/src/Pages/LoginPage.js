import * as React from 'react';
import LoginBox from "../Components/LoginBox";
function LoginPage({ setEmail, setPassword, /*handleLoginRequest*/ }) {

   return (
      <div>
         <LoginBox setEmail={setEmail} setPassword={setPassword} /*handleLoginRequest={handleLoginRequest}*/ />
      </div>
   );
}

export default LoginPage