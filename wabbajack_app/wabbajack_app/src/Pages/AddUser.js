import * as React from "react";
import AppBar from "../Components/AppBar";
import Box from '@mui/material/Box';
import AddUserComponent from "../Components/AddUser";
import { makeStyles } from "@mui/styles";
import { connect } from "react-redux";

const style = makeStyles({
   root: {

   },

   body: {
      display: "flex",
      justifyContent: "center",
      marginTop: "10px",
   }
});

function AddUser () {
   const classes = style();

   return(
      <Box className = {classes.root}>
         <AppBar PageName = {"Add User"}/>
         <Box className = {classes.body}> 
            <AddUserComponent />
         </Box> 
      </Box>
   );
}

export default connect() (AddUser)