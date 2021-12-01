import * as React from 'react';
import AppBar from "../Components/AppBar";
import FriendBox from "../Components/FriendBox";
import Box from '@mui/material/Box';
import Photo from "../Images/image.jpg"
import { makeStyles } from '@mui/styles';
import { margin } from '@mui/system';


const style = makeStyles({
   root: {

   },

   flex_box: {
      margin: "0 auto",
      width: "80%",
      display: "flex",
      flexDirection: "row",
      flexWrap: "wrap",
   },
   friend_box: {
      marginTop: "1rem",
   },

})

function SeeAllStudents() {
   const classes = style();
   var student1 = { PersonImage: Photo, Name: "Erhan Er", Id: "21800000" };

   return (
      <Box className={classes.root}>
         <AppBar PageName = {"See All Students"}/>
         <Box className={classes.flex_box}>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
            <Box className={classes.friend_box}><FriendBox {...student1} /></Box>
         </Box>
      </Box >
   )
}
export default SeeAllStudents