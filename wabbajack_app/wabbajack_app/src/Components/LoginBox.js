import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";
import { Link } from "react-router-dom";
import axios from "axios";
import { useEffect } from 'react';

const style = makeStyles({
   outer_box: {
      margin: "0 auto",
   },
   login_text: {
      margin: "0 auto",
      marginTop: "50px",
      width: "25%",
      fontSize: "8vw",
      color: "#000080",
      "@media screen and (min-width: 1080px)": {
         fontSize: "6vw"
      },
   },
   login_box: {
      margin: "0 auto",
      width: "90%",
      border: "2px solid #000080",
      borderRadius: "15px",
      display: "flex",
      flexDirection: "column",

      "@media screen and (min-width: 1080px)": {
         width: "50%",
      },
   },
   text_field_box: {
      display: "flex",
      alignItems: "center",
      flexDirection: "column",
      width: "100%",
   },
   text_field: {
      width: "90%",
      height: "42px",

   },
   forget_password: {
      marginTop: "2rem",
   },
   button_box: {
      width: "90%",
      margin: "0 auto",
      marginTop: "2rem",
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-evenly",

   },
   button: {
      width: "100px",
      height: "42px",
   },

});

function LoginBox({ setEmail, setPassword, handleLoginRequest }) {
   const classes = style();
   var Email;
   var Password;
   function handleClick() {
      Email = document.getElementById("Email").value;
      Password = document.getElementById("Password").value;
      console.log(Email);
      console.log(Password);
   }

   function handleLogin() {
      setEmail(document.getElementById("Email").value);
      setPassword(document.getElementById("Password").value);

      handleLoginRequest();
   }

   return (
      <Box className={classes.outer_box}>
         <div className={classes.login_text}>LOGIN</div>
         <Box className={classes.login_box}>
            <Box className={classes.text_field_box}>
               <TextField className={classes.text_field} id="Email" margin="normal" label="Email" type="email" required />
               <TextField className={classes.text_field} id="Password" margin="normal" label="Password" type="password" required />
            </Box>
            <Box className={classes.button_box}>
               {/*<Link to="/Home">*/}
               <Button variant="contained" color="warning" className={classes.button} onClick={() => handleLogin()}>Sign in</Button>
               {/*</Link>*/}
               <Button variant="contained" color="info" className={classes.button}>About</Button>
            </Box>
            <Box>
               <Button variant="text" color="error" className={classes.forget_password}>Forget Password?</Button>
            </Box>
         </Box>
      </Box>
   );
}

export default LoginBox