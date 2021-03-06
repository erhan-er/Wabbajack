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

function JoinedClubs ({ joinedClubs, myInfo, clubs }) {
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
            {joinedClubs.filter((item) => item.userId === myInfo.id).map((club, index) => {
               var i;
               for ( i = 0; i < clubs.length; i++ ) {
                  if ( clubs[i].id === club.clubId ) 
                     break;
               }
               return <Accordion {...clubs[i]} key = {index} />
            })}
            <Box className={classes.pagination}>
               <Pagination
                  count={joinedClubs.filter((item) => item.userId === myInfo.id).length / pageSize}
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
   return { joinedClubs: state.joinedClubs, myInfo: state.myInfo, clubs: state.clubs }
}
export default connect(mapStateToProps)(JoinedClubs)