import * as React from 'react';
import { useState } from "react";
import AppBar from "../Components/AppBar";
import FriendBox from "../Components/FriendBox";
import Box from '@mui/material/Box';
import Photo from "../Images/image.jpg"
import Photo2 from "../Images/bingus.jpg"
import { makeStyles } from '@mui/styles';
import { margin } from '@mui/system';
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

function SeeAllStudents() {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);
   const handleChange = (event, value) => {
      setPage(value);
   };

   var student1 = { PersonImage: Photo, Name: "Friend 1", Id: "21800000", PageName: "SeeAllStudents" };
   var student2 = { PersonImage: Photo2, Name: "Friend 2", Id: "21800000", PageName: "SeeAllStudents" };
   var student3 = { PersonImage: Photo, Name: "Friend 3", Id: "21800000", PageName: "SeeAllStudents" };
   var student4 = { PersonImage: Photo2, Name: "Friend 4", Id: "21800000", PageName: "SeeAllStudents" };
   var student5 = { PersonImage: Photo, Name: "Friend 5", Id: "21800000", PageName: "SeeAllStudents" };

   var studentArr = [student1, student2, student3, student4, student5, student1, student2, student3, student4, student5];

   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Students"} />
         <Box className={classes.flex_box}>
            {studentArr.map((student, item) => {
               return (
                  <Box className={classes.friend_box}><FriendBox {...student} /></Box>
               );
              
            })}
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
export default SeeAllStudents