import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";
import { Link } from "react-router-dom";

const style = makeStyles({
   outer_box: {
      margin: "0 auto",
   },
   login_text: {
      margin: "0 auto",
      marginTop: "50px",
      width: "25%",
      height: "150px",
      fontSize: "100px",
      color: "#000080",
   },
   login_box: {
      margin: "0 auto",
      width: "1000px",
      height: "300px",
      border: "2px solid #000080",
      borderRadius: "15px",
      display: "flex"
   },
   text_field_box: {
      display: "flex",
      alignItems: "center",
      flexDirection: "column",
      width: "60%",
      margin: "0",
      position: "relative",
   },
   text_field: {
      width: "90%",
      height: "42px",
      marginTop: "200px",
   },
   forget_password: {
      marginTop: "20px",
      position: "absolute",
      left: "24px",
      bottom: "60px",
      textDecoration: "underline",
   },
   button_box: {
      width: "40%",
      display: "flex",
      alignItems: "center",
      flexDirection: "column",
      
   },
   button: {
      width: "100px",
      height: "42px",
      marginTop: "45px",
   },

});

function LoginBox () {
   const classes = style();

   return (
      <Box className = {classes.outer_box}>
         <div className = {classes.login_text}>LOGIN</div>
         <Box className = {classes.login_box}>
            <Box className = {classes.text_field_box}>
               <TextField className = {classes.text_field} margin = "normal" label = "Email" type = "email" required/>
               <TextField className = {classes.text_field} margin = "normal" label = "Password" type = "password" required />
               <Button variant = "text" className = {classes.forget_password}>Forget Password?</Button>
            </Box>
            <Box className = {classes.button_box}>
               <Link to = "/Home">
                  <Button variant = "contained" color = "success" className = {classes.button}>Sign in</Button>
               </Link>
               <Button variant = "contained" color = "info" className = {classes.button}>About</Button>
            </Box>
         </Box>
      </Box>
   );
}

export default LoginBox