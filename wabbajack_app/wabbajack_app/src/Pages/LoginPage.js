import * as React from 'react';
import LoginBox from "../Components/LoginBox";
import { Outlet } from "react-router-dom";
function LoginPage () {

   return (
      <div>
         <LoginBox />
      </div>      
   );
}

export default LoginPage