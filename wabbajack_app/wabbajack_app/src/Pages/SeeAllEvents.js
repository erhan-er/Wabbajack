import * as React from 'react';
import { useState } from "react";
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ActivityAccordion";
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

function SeeAllEvents({ events, companies}) {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);

   const handleChange = (event, value) => {
      setPage(value);
   };

   companies.map((company, index) => {
      console.log(company.account);
   });
   console.log(events);
   console.log(companies);
   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Events"} />
         <Box className={classes.activity_box}>
            {events.map((item, index) => {
               if ( index >= ((page - 1) * pageSize) && index < (page * pageSize)) {
                  return (
                     <Accordion PageName = {"See All Events"} {...item} />
                  );
               }
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
const mapStateToProps = state => {
   return { events: state.events, companies: state.companies }
}
export default connect(mapStateToProps)(SeeAllEvents)