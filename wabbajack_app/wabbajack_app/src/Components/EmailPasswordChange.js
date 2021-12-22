import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import * as React from "react";

const style = makeStyles({
   root: {
      marginBottom: "25px",

   },

   header: {
      borderBottom: "solid 2px rgba(0, 0, 0, 0.5)",
      marginBottom: "10px",
   },

   text: {
      marginLeft: "5px",
      fontSize: "24px",
      textAlign: "left",
      color: "#000080",
      marginBottom: "10px",
   },

   body: {
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
      "@media screen and (max-width: 686px)": {
         flexDirection: "column",
         alignItems: "center",
         height: "160px",
      },
   },

   input: {
      height: "42px",
      width: "30%",
      borderRadius: "10px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      "@media screen and (max-width: 686px)": {
         width: "100%",
      }
   },
   
   button: {
      width: "192px",
      "@media screen and (max-width: 686px)": {
         width: "100%",
      }
   },
});

function EmailPasswordChange({Type}) {
   const classes = style();

   var text;

   if ( Type === "email")
      text = "Email"
   else
      text = "Password"

   function handleClick() {
      console.log(Type);
      console.log(document.getElementById(Type).value);
      console.log(document.getElementById(text).value);
   }

   return (
      <Box className = {classes.root}>
         <Box className = {classes.header}>
            <Box className = {classes.text}>{text} Change</Box>
         </Box>
         <Box className = {classes.body}>
            <input type = {Type} placeholder = {text} id = {Type} className = {classes.input}/>
            <input type = "password" placeholder = "Current Password" id = {text} className = {classes.input}/>
            <Button variant = "contained" color = "info" className = {classes.button} onClick = {() => handleClick()}>Change {text}</Button>
         </Box>
      </Box>
   );
}

export default EmailPasswordChange