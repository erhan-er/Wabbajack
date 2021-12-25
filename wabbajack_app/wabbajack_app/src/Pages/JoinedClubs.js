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

function JoinedClubs ({ clubs }) {
   const classes = style();
   const [pageSize, setPageSize] = useState(10);
   const [page, setPage] = React.useState(1);
   const handleChange = (event, value) => {
      setPage(value);
   };

   return (
      <Box className={classes.root}>
         <AppBar PageName={"Joined Clubs"} />
         <Box className={classes.club_box}>
            {clubs.map((item, index) => {
               for ( let i = 0; i < item.studentsClubMembers.length; i++ ) {
                  if ( myInfo.id === )
               } 
               if (index >= ((page - 1) * pageSize) && index < (page * pageSize)) {
                  return (
                     <Accordion {...item} key = {index}/>
                  );
               }
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
const mapStateToProps = state => {
   return { clubs: state.clubs, myInfo: state.myInfo }
}
export default connect(mapStateToProps)(JoinedClubs)