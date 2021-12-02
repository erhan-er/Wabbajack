import { Box } from "@mui/system";
import * as React from "react";
import Photo from "../Images/image.jpg";
import Photo2 from "../Images/bingus.jpg"
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

function SeeAllClubMembers() {
   const classes = style();
   const member = { PersonImage: Photo, Name: "Member 1", Id: "21800000", Role: "Student" }
   const member2 = { PersonImage: Photo2, Name: "Member 2", Id: "21800000", Role: "Board Member" }
   const member3 = { PersonImage: Photo, Name: "Member 3", Id: "21800000", Role: "Student" }
   
   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Members"} />
         <Box className={classes.member_box}>
            <Box className={classes.member}><Member  {...member} /></Box>
            <Box className={classes.member}><Member  {...member2} /></Box>
            <Box className={classes.member}><Member  {...member3} /></Box>
         </Box>
      </Box>
   );
}

export default SeeAllClubMembers