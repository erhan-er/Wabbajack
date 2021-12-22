import * as React from "react";
import { Box, IconButton } from "@mui/material";
import CloseIcon from '@mui/icons-material/Close';
import { makeStyles } from "@mui/styles";
import ClubBox from "./ClubBox";

const style = makeStyles({
   root: {
      width: "90%",
      height: "90%",
      backgroundColor: "white"
   },

   header: {
      display: "flex",
      justifyContent: "end",
   },

   body: {
      width: "100%",
      height: "100%",
      
   },
});

function MoreClub({Clubs, setOpen}) {
   const classes = style();

   return(
      <Box className = {classes.root}>
         <Box className = {classes.header}>
            <IconButton onClick = {() => setOpen(false)}><CloseIcon sx = {{fontSize: "36px"}}/></IconButton>
         </Box>
         <Box className = {classes.body}> 
            <ClubBox Clubs = {Clubs} />
         </Box>
      </Box>
   );
}

export default MoreClub