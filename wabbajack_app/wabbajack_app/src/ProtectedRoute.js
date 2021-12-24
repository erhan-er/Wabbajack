import { Route, Navigate } from "react-router-dom";

const ProtectedRoute = ({ children, authed, ...rest }) => {
   console.log(authed);
   return(
         authed === true
            ? children
            : <Navigate to = {{pathname: "/"}} />
         )
}
export default ProtectedRoute