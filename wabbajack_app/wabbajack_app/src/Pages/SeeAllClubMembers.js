import { Box } from "@mui/system";
import * as React from "react";
import Photo from "../Images/image.jpg";
import Member from "../Components/Member";
import AppBar from "../Components/AppBar";
import { makeStyles } from "@mui/styles";

const style = makeStyles({
   root: {},

   member_box: {
      width: "90%"
   },

   member: {
      marginTop: "2.5rem",
   },
});

function SeeAllMembers() {
   const classes = style();
   const member = { PersonImage: Photo, Name: "Erhan Er", Id: "21800000", Role: "Student" }
   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Members"} />
         <Box className={classes.member_box}>
            <Box className={classes.member}><Member  {...member} /></Box>
            <Box className={classes.member}><Member  {...member} /></Box>
            <Box className={classes.member}><Member  {...member} /></Box>
         </Box>
      </Box>
   );
}

export default SeeAllMembers