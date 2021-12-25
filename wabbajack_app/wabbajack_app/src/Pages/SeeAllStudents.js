import * as React from 'react';
import { useState } from "react";
import AppBar from "../Components/AppBar";
import FriendBox from "../Components/FriendBox";
import Box from '@mui/material/Box';
import Photo from "../Images/image.jpg"
import Photo2 from "../Images/bingus.jpg"
import { makeStyles } from '@mui/styles';
import Pagination from '@mui/material/Pagination';
import { connect } from "react-redux";

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

function SeeAllStudents({ students }) {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);
   const handleChange = (event, value) => {
      setPage(value);
   };

   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Students"} />
         <Box className={classes.flex_box}>
            {students.map((student, item) => {
               return (
                  <Box className={classes.friend_box}><FriendBox {...student} PageName = {"See All Friends"}/></Box>
               );
              
            })}
            <Box className = {classes.pagination}>
               <Pagination 
                  count={students.length / pageSize} 
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

const mapStateToProps = state => {
   return { students: state.students }
}
export default connect(mapStateToProps)(SeeAllStudents)