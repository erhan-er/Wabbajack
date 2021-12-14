import * as React from "react";
import { connect } from "react-redux";
import AppBar from "../Components/AppBar";
import Box from '@mui/material/Box';

import EditClub from "../Components/EditClub";
import { makeStyles } from "@mui/styles";

const style = makeStyles({
   root: {

   },

   body: {
      display: "flex",
      justifyContent: "center",
   }
});

function AddClubs () {
   
   const classes = style();

   return(
      <Box className = {classes.root}>
         <AppBar PageName = {"Add Clubs"}/>
         <Box className = {classes.body}>
            <EditClub PageName = {"Edit Club"}/>
         </Box>
      </Box>
   );
}

const mapStateToProps = state => {
   console.log(state);
};
export default connect(mapStateToProps)(AddClubs);