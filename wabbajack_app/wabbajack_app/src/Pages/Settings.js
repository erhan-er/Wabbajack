import * as React from "react";
import { useState } from "react";
import AppBar from "../Components/AppBar";
import { Box, Backdrop } from "@mui/material";
import ChipBox from "../Components/ChipBox";
import { makeStyles } from "@mui/styles";
import EmailPasswordChange from "../Components/EmailPasswordChange";

const style = makeStyles({
   root: {
   },

   body: {
      margin: "0 auto",
      marginTop: "25px",
      width: "90%",
      display: "flex",
      flexDirection: "column",
      justifyContent: "space-between",
   },

   chip_box: {
      marginTop: "25px",
   }

});

function Settings () {
   const classes = style();
   
   return(
      <Box>
         <AppBar PageName = {"Settings"}/>
         <Box className = {classes.body}>

            <Box>
               <EmailPasswordChange />
            </Box>
            <Box><ChipBox Type = {"Ignore"}/></Box>
            <Box className = {classes.chip_box}><ChipBox Type = {"Follow"}/></Box>
            <Box className = {classes.chip_box}><ChipBox Type = {"Join"}/></Box>
            
         </Box>
         
      </Box>
   );
}

export default Settings