import * as React from 'react';
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ActivityAccordion";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";
import { Link } from 'react-router-dom';
import { connect } from "react-redux"; 
const style = makeStyles({
   root: {

   },

   activity_box: {
      margin: "0 auto",
      width: "90%",
      marginTop: "5rem",
   },

   accordion_box: {
      marginBottom: "2rem",
   },

   see_all_button: {
      width: "100%",
      height: "42px",
      textDecorationLine: "none",

   }
});

function Home({ events }) {
   const classes = style();

   return (
      <Box className={classes.root}>
         <AppBar PageName={"Home"} />
         <Box className={classes.activity_box}>
            <Box className = {classes.accordion_box}>
               {
                  events.map((event, index) => {
                     if ( index < 5 ) {
                        return <Accordion {...event} PageName = {"Home"}/>
                     }
                  })
               }
            </Box>
            <Link to="/See-All-Events">
               <Button variant="contained" color="info" className={classes.see_all_button}>See All Events</Button>
            </Link>
         </Box>
      </Box >
   );
}

const mapStateToProps = state => {
   console.log(state);
   return { events: state.events};
}
export default connect(mapStateToProps)(Home);