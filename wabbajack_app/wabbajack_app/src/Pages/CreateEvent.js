import * as React from "react";
import AppBar from "../Components/AppBar";
import Box from '@mui/material/Box';
import CreateEventComponent from "../Components/CreateEventComponent";
import { makeStyles } from "@mui/styles";

const style = makeStyles({
   root: {

   },

   body: {
      display: "flex",
      justifyContent: "center",
   }
});

function CreateEvent () {
   
   const classes = style();

   return(
      <Box>
         <AppBar PageName = {"Create Event"}/>
         <Box className = {classes.body}>
            <CreateEventComponent />
         </Box>
      </Box>
   );
}

export default CreateEvent