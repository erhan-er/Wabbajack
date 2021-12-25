import * as React from "react";
import { useState } from "react";
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ClubAccordion";
import Photo from "../Images/Bilkent.png";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Pagination from '@mui/material/Pagination';
import { connect } from "react-redux";
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

function JoinedClubs ({ clubs, myInfo }) {
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
               let count = 0;
               for ( let i = 0; i < item.studentsClubMembers.length; i++ ) {
                  if ( myInfo.id === item.studentsClubMembers[i].id ) {
                     count++;
                     return <Accordion {...item} key = {index} />
                  }
               }
               if ( count === 0 ) {
                  return <Box>You have not joined to any club!</Box>
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