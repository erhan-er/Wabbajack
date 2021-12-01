import * as React from 'react';
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ActivityAccordion";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";

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
   }
});

function SeeAllEvents() {
   const classes = style();
   var activity1 = { place: "B Building", date: "20/11/2021", time: "18:00" };
   var activity2 = { place: "A Building", date: "30/11/2021", time: "20:00" };
   var activity3 = { place: "EA Building", date: "31/12/2021", time: "22:00" };
   return (
      <Box className={classes.root}>
         <AppBar PageName={"All Events"} />
         <Box className={classes.activity_box}>
            <Accordion {...activity1} />
            <Accordion {...activity2} />
            <Accordion {...activity3} />
            <Accordion {...activity1} />
            <Accordion {...activity2} />
            <Accordion {...activity3} />
            <Accordion {...activity1} />
            <Accordion {...activity2} />
            <Accordion {...activity3} />
            <Accordion {...activity1} />
            <Accordion {...activity2} />
            <Accordion {...activity3} />
            <Accordion {...activity1} />
            <Accordion {...activity2} />
            <Accordion {...activity3} />
         </Box>
      </Box>
   );
}

export default SeeAllEvents