import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import * as React from "react";
import { connect } from "react-redux";
const style = makeStyles({
   root: {
      margin: "0 auto",
      marginBottom: "25px",
      marginTop: "25px",
      width: "90%",
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
      width: "100%",
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

function EmailID({Type, myInfo}) {
   const classes = style();

   var text;

   if ( Type === "Email")
      text = "mail"
   else
      text = "id"

   return (
      <Box className = {classes.root}>
         <Box className = {classes.header}>
            <Box className = {classes.text}>{Type}</Box>
         </Box>
         <Box className = {classes.body}>
            <input type = {Type} placeholder = {myInfo.text} id = {Type} className = {classes.input} value = {text === "mail"? myInfo.mail: myInfo.id}/>
         </Box>
      </Box>
   );
}
const mapStateToProps= state => {
   return { myInfo: state.myInfo }
}
export default connect(mapStateToProps)(EmailID)