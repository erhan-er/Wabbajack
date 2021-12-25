import { Route, Navigate } from "react-router-dom";
import { connect } from "react-redux";
const ProtectedRoute = ({ children, signin }) => {
   console.log(signin);
   return(
         signin === true
            ? children
            : <Navigate to = {{pathname: "/"}} />
         )
}
const mapStateToProps = state => {
   return { signin: state.signin }
}
export default connect(mapStateToProps)(ProtectedRoute)