import * as React from 'react';
import AppBar from "../Components/AppBar";
import FriendBox from "../Components/FriendBox";
import Box from '@mui/material/Box';
import Photo from "../Images/image.jpg"
import { makeStyles } from '@mui/styles';

const style = makeStyles({
    root: {
 
    },
 
    flex_box: {
       width: "50%",
       display: "flex",
       flexDirection: "row",
       flexWrap: "wrap"
    }
    
    
 })
 
 function SeeAllFriends() {
    const classes = style();
    var student1 = { PersonImage: Photo, Name: "Erhan Er", Id: "21800000", PageName: "SeeAllFriends" };
 
    return (
       <Box className={classes.root}>
          <AppBar />
          <Box className={classes.flex_box}>
            <FriendBox {...student1}  /> 
             <FriendBox {...student1} />
             <FriendBox {...student1} />
             <FriendBox {...student1} />
             <FriendBox {...student1} />
             <FriendBox {...student1} />
             <FriendBox {...student1} />
             <FriendBox {...student1} />
             <FriendBox {...student1} />
             <FriendBox {...student1} />
          </Box>
       </Box>
    )
 }
 export default SeeAllFriends