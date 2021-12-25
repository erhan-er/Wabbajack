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
      width: "20%",
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

function EmailPasswordChange({dispatch}) {
   const classes = style();

   var text;

   function handleClick() {
      dispatch({type: CHANGE_PASSWORD, payload: {newPassword: document.getElementById("newPassword").value, currentPassword: document.getElementById("confirmPassword").value, email: document.getElementById("email").value}});
   }

   return (
      <Box className = {classes.root}>
         <Box className = {classes.header}>
            <Box className = {classes.text}>{text} Change</Box>
         </Box>
         <Box className = {classes.body}>
            <input type = "email" placeholder = "Current Email" id = "email" className = {classes.input}/>
            <input type = "password" placeholder = "New Password" id = "newPassword" className = {classes.input}/>
            <input type = "password" placeholder = "Confirm Password" id = "confirmPassword" className = {classes.input}/>
            <Button variant = "contained" color = "info" className = {classes.button} onClick = {() => handleClick()}>Change {text}</Button>
         </Box>
      </Box>
   );
}

const mapStateToProps = state => {
   return { myInfo: state.myInfo }
}
export default connect(mapStateToProps)(EmailPasswordChange)