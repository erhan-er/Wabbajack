import * as React from "react";
import { connect } from "react-redux";
import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import { RESET_PASSWORD } from "../Reducer/actions";
const style = makeStyles({
   root: {
      marginTop: "100px",
      width: "100%",
   },

   body: {
      width: "90%",
      display: "flex",
      flexDirection: "column",
      alignItems: "center"
   },

   input: {
      marginBottom: "25px",
      width: "50%",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },

   button: {
      width: "256px",
      height: "42px",
   },
});

function ForgetPassword({ dispatch }) {
   const classes = style();

   return(
      <Box className = {classes.root}>
         <Box className = {classes.body}>
            <input type="email" id="email" placeholder = "Please Enter Your Email to Reset Your Password" className = {classes.input}/>
            <Button variant = "contained" color = "primary" onClick = {() => dispatch({type: RESET_PASSWORD, payload: {email: document.getElementById("email").value}})}>reset password</Button>
         </Box>
      </Box>
   );
}

const mapStateToProps = state => {
   return { state }
}
export default connect(mapStateToProps)(ForgetPassword)