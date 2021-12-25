import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import * as React from "react";
import { connect } from "react-redux";
import { CHANGE_PASSWORD } from "../Reducer/actions";

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
      flexDirection: "column",
      justifyContent: "space-between",
      "@media screen and (max-width: 686px)": {
         alignItems: "center",
         height: "160px",
      },
   },

   input: {
      height: "42px",
      width: "40%",
      borderRadius: "10px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      "@media screen and (max-width: 686px)": {
         width: "100%",
      }
   },
   
   top: {
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
      marginBottom: "20px",
   }, 

   bottom: {
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between"
   },

   button: {
      marginTop: "20px",
      width: "100%",
   },
});

function EmailPasswordChange({dispatch}) {
   const classes = style();

   var text;

   function handleClick() {
      dispatch({type: CHANGE_PASSWORD, payload: {
                                                confirmPassword: document.getElementById("confirmPassword").value,
                                                newPassword: document.getElementById("newPassword").value, 
                                                currentPassword: document.getElementById("currentPassword").value, 
                                                email: document.getElementById("email").value}});
   }

   return (
      <Box className = {classes.root}>
         <Box className = {classes.header}>
            <Box className = {classes.text}>{text} Change</Box>
         </Box>
         <Box className = {classes.body}>
            <Box className = {classes.top}>
               <input type = "email" placeholder = "Email" id = "email" className = {classes.input}/>
               <input type = "password" placeholder = "Current Password" id = "currentPassword" className = {classes.input}/>
            </Box>
            <Box className = {classes.bottom}>
               <input type = "password" placeholder = "New Password" id = "newPassword" className = {classes.input}/>
               <input type = "password" placeholder = "Confirm Password" id = "confirmPassword" className = {classes.input}/>
            </Box>
            <Button variant = "contained" color = "info" className = {classes.button} onClick = {() => handleClick()}>Change {text}</Button>
         </Box>
      </Box>
   );
}

const mapStateToProps = state => {
   return { myInfo: state.myInfo }
}
export default connect(mapStateToProps)(EmailPasswordChange)