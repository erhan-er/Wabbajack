import * as React from "react";
import { useState } from "react";
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ClubAccordion";
import Photo from "../Images/Bilkent.png";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Pagination from '@mui/material/Pagination';

const style = makeStyles({
   root: {

   },

   club_box: {
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

function IgnoredClubs() {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);
   const handleChange = (event, value) => {
      setPage(value);
   };

   const activityArr = [];
   var activity1 = { clubName: "Club 1", clubImage: Photo, description: "description of club 1" };
   var activity2 = { clubName: "Club 2", clubImage: Photo, description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." };
   var activity3 = { clubName: "Club 3", clubImage: Photo, description: "description of club 3" };

   for (let i = 0; i < 20; i++) {
      if (i % 2 === 0)
         activityArr[i] = activity2;
      else if (i % 3 === 0)
         activityArr[i] = activity3;
      else
         activityArr[i] = activity1;
   }

   return (
      <Box className={classes.root}>
         <AppBar PageName={"Ignored Clubs"} />
         <Box className={classes.club_box}>
            {activityArr.map((item, index) => {
               if (index >= ((page - 1) * pageSize) && index < (page * pageSize)) {
                  return (
                     <Accordion {...item} key = {index}/>
                  );
               }
               return (
                  <Accordion {...item} key = {index}/>
               );
            })}
            <Box className={classes.pagination}>
               <Pagination
                  count={10}
                  color="primary"
                  size="large"
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

export default IgnoredClubs