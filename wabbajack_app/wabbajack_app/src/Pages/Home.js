import * as React from 'react';
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ActivityAccordion";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";
import { Link } from 'react-router-dom';

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

function Home() {
   const classes = style();
   var activity1 = { activityName: "Activity 1", place: "B Building", date: "20/11/2021", time: "18:00", expense: "5000" };
   var activity2 = { activityName: "Activity 2", place: "A Building", date: "30/11/2021", time: "20:00" };
   var activity3 = { activityName: "Activity 3", place: "EA Building", date: "31/12/2021", time: "22:00" };
   return (
      <Box className={classes.root}>
         <AppBar PageName={"Home"} />
         <Box className={classes.activity_box}>
            <Box className = {classes.accordion_box}>
               <Accordion {...activity1} PageName = {"Home"}/>
               <Accordion {...activity2} />
               <Accordion {...activity3} />
            </Box>
            <Link to="/See-All-Events">
               <Button variant="contained" color="info" className={classes.see_all_button}>See All Events</Button>
            </Link>
         </Box>
      </Box >
   );
}

export default Home