import * as React from 'react';
import { useState } from "react";
import AppBar from "../Components/AppBar";
import FriendBox from "../Components/FriendBox";
import Box from '@mui/material/Box';
import Photo from "../Images/image.jpg"
import { makeStyles } from '@mui/styles';
import Pagination from '@mui/material/Pagination';

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

   pagination: {
      marginTop: "20px",
      width: "90%",
      display: "flex",
      justifyContent: "center",
   },
})

function SeeAllFriends() {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);
   const handleChange = (event, value) => {
      setPage(value);
   };

   var student1 = { PersonImage: Photo, Name: "Erhan Er", Id: "21800000", PageName: "SeeAllFriends" };

   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Students"} />
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
            <Box className = {classes.pagination}>
               <Pagination 
                  count={10} 
                  color="primary" 
                  size = "large" 
                  showFirstButton 
                  showLastButton 
                  siblingCount={2} 
                  page={page} 
                  onChange={handleChange}
               />
            </Box>
         </Box>
      </Box >
   )
}
export default SeeAllFriends