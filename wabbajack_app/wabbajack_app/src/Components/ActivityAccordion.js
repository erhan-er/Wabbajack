import * as React from 'react';
import { makeStyles, styled } from '@mui/styles';
import Button from "@mui/material/Button";
import Box from "@mui/material/Box";
import Accordion from '@mui/material/Accordion';
import AccordionSummary from '@mui/material/AccordionSummary';
import AccordionDetails from '@mui/material/AccordionDetails';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import ArrowForwardIosIcon from '@mui/icons-material/ArrowForwardIos';
import { Link } from "react-router-dom";


const ModifiedAccordion = styled((props) => (
   <Accordion {...props}/>
))(({theme}) => ({
   backgroundColor: "#000080",
   borderRadius: "20px",
   '&:not(:last-child)': {
      borderRadius: "20px",
      marginBottom: "1rem",
   },
   '&:not(:first-of-type)': {
      borderRadius: "20px",
   },
}));

const ModifiedAccordionDetails = styled((props) => (
   <AccordionDetails {...props}/>
))(({theme}) => ({
   "@media screen and (max-width: 960px)": {
      padding: 0,
   },
}));

const style = makeStyles({
   accordion: {
      marginBottom: "1rem",
      //borderRadius: "20px",
      border: "2px solid #000080",
      backgroundColor: "#000080",
   },

   expand_icon: {
      color: "#ffff7f",
      fontSize: "32px",
   },

   activity_summary: {
      display: "flex",
      justifyContent: "space-between",
      color: "#ffff7f",
      width: "100%",
   },

   activity_name: {
      fontSize: "16px",
   },

   activity_date: {
      fontSize: "16px",
   },
   
   activity_budget: {
      fontSize: "16px",
      width: "200px",
   },

   activity_detail: {
      marginTop: "-8px",
      width: "90%",
      color: "#ffff7f",
      textAlign: "left",
      display: "flex",
      flexDirection: "row",
      "@media screen and (max-width: 960px)": {
         margin: 0,
         width: "90%",
         alignItems: "center",
         flexDirection: "column",
         margin: "0 auto",
      }
   },

   activity_detail_description: {
      width: "50%",
      "@media screen and (max-width: 960px)": {
         width: "100%",
         textAlign: "justify",
      }
   },

   club_name: {
      fontSize: "2rem"
   },

   information: {
      width: "35%",
      marginLeft: "5rem",
      lineHeight: "2rem",
      "@media screen and (max-width: 960px)": {
         width: "100%",
         margin: 0,
         marginTop: "15px",
      }
   },

   button_box: {
      display: "flex",
      alignItems: "end",
      "@media screen and (max-width: 960px)": {
         width: "100%",
      }
   },

   button: {
      marginTop: "5vw",
      marginLeft: "1vw",
      height: "42px",
      width: "256px",
      "@media screen and (max-width: 960px)": {
         marginBottom: "10px",
         margin: 0,
         width: "100%",
      }
   },
});

function ActivityAccordion ({id, name, description, clubID, date = 0, categoryID, placeID, imageURL, eventCost = 0, capacity = 0, PageName = "See All Events"}) {

   const classes = style();

   return (
      <ModifiedAccordion className = {classes.accordion}>
         <AccordionSummary
            expandIcon={<ExpandMoreIcon className = {classes.expand_icon}/>}
         >
            <Box className = {classes.activity_summary}>
               <Box className = {classes.activity_name}>{name}</Box>
               <Box className = {classes.activity_date}>Date: {date}</Box>
               {PageName === "Budget"? <Box className = {classes.activity_budget}>Expense: ₺{eventCost}</Box>: ""}
            </Box>
         </AccordionSummary>
         <ModifiedAccordionDetails className = {classes.activity_detail}>
            <Box className = {classes.activity_detail_description}>
               <Box className = {classes.club_name}>{clubID}</Box>
               <Box className = {classes.details}>{description}</Box>
            </Box>

            <Box className = {classes.information}>
               <Box>Place: {placeID}</Box>
               <Box>Date: {date}</Box>
               {/*<Box>Time: {Date}</Box>*/}
            </Box>
               <Link to = "/Event-Detail" state = {{id, name, description, clubID, date, categoryID, placeID, imageURL, eventCost, capacity}} className = {classes.button_box}>
                  <Button className = {classes.button} variant = "contained" color= "info" endIcon = {<ArrowForwardIosIcon />}>See Details</Button>
               </Link>
         </ModifiedAccordionDetails>
      </ModifiedAccordion>
   );
}

export default ActivityAccordion