import * as React from 'react';
import { useState } from "react";
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ActivityAccordion";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Pagination from '@mui/material/Pagination';

const style = makeStyles({
   root: {

   },

   activity_box: {
      margin: "0 auto",
      width: "90%",
      marginTop: "5rem",
   },

   see_all_button: {
      width: "100%",
      height: "42px",
      alignItems: "center",
   },

   pagination: {
      display: "flex",
      justifyContent: "center",
   },
});

function SeeAllEvents() {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);
   const handleChange = (event, value) => {
      setPage(value);
   };

   const activityArr = [];
   var activity1 = { activityName: "Activity 1", place: "B Building", date: "20/11/2021", time: "18:00", expense: "5000" };
   var activity2 = { activityName: "Activity 2", place: "A Building", date: "30/11/2021", time: "20:00" };
   var activity3 = { activityName: "Activity 3", place: "EA Building", date: "31/12/2021", time: "22:00" };
   
   for (let i = 0; i < 20; i++) {
      if ( i % 2 === 0 )
         activityArr[i] = activity2;
      else if ( i % 3 === 0 )
         activityArr[i] = activity3;
      else
         activityArr[i] = activity1;
   }

   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Events"} />
         <Box className={classes.activity_box}>
            {activityArr.map((item, index) => {
               if ( index >= ((page - 1) * pageSize) && index < (page * pageSize)) {
                  return (
                     <Accordion {...item} />
                  );
               }
               return (
                  <Accordion {...item} />
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
         
      </Box>
   );
}

export default SeeAllEvents