import * as React from 'react';
import { useState } from "react";
import AppBar from "../Components/AppBar";
import ActivityAccordion from "../Components/ActivityAccordion";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Pagination from '@mui/material/Pagination';
import { connect } from "react-redux";

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

function SeeAllEvents({ filteredEvents }) {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);

   const handleChange = (event, value) => {
      setPage(value);
   };

   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Events"} />
         <Box className={classes.activity_box}>
            {filteredEvents.map((item, index) => {
               console.log(item);
               if ( index >= ((page - 1) * pageSize) && index < (page * pageSize)) {
                  return (
                     <ActivityAccordion key = {index} {...item} PageName = {"See All Events"}/>
                  );
               }
            })}
            <ActivityAccordion id={"5"} name={"name"} description={"aeıvonıa"} clubID={"5"} clubName={"club 1"} date={"8492"} categoryID={"5"} placeID={"63"} placeName={"aıeovnıpo"} imageURL={"aeuvnaı"} eventCost={"79348"} capacity = {"732"} PageName = {"See All Events"}/>
            <Box className = {classes.pagination}>
               <Pagination 
                  count={filteredEvents.length / pageSize} 
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
const mapStateToProps = state => {
   return { filteredEvents: state.filteredEvents }
}
export default connect(mapStateToProps)(SeeAllEvents)