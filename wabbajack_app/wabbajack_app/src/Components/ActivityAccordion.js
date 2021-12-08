import * as React from 'react';
import { makeStyles } from '@mui/styles';
import { styled } from '@mui/material/styles';
import Button from "@mui/material/Button";
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

const style = makeStyles({
   accordion: {
      marginBottom: "1rem",
      //borderRadius: "20px",
      border: "2px solid #000080",
      backgroundColor: "#000080",
   },

   expand_icon: {
      color: "#ffff7f",
      fontSize: "3rem",
   },

   activity_summary: {
      display: "flex",
      justifyContent: "space-between",
      color: "#ffff7f",
      width: "90%",
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
      borderRadius: "0 0 15px 15px",
      color: "#ffff7f",
      textAlign: "left",
      display: "flex",
      flexDirection: "row",
      position: "relative",
   },

   activity_detail_part1: {
      width: "50%",
   },

   club_name: {
      fontSize: "2rem"
   },

   information: {
      width: "35%",
      marginLeft: "5rem",
      lineHeight: "2rem",
   },

   button_box: {
      display: "flex",
      alignItems: "end",
   },

   button: {
      
      marginTop: "5rem",
      marginLeft: "1rem",
      height: "3rem",
      width: "12.5rem",
   },
});

function ActivityAccordion ({activityName, place, date, time, PageName, expense}) {

   const classes = style();

   return (
      <ModifiedAccordion className = {classes.accordion}>
         <AccordionSummary
            expandIcon={<ExpandMoreIcon className = {classes.expand_icon}/>}
         >
            <div className = {classes.activity_summary}>
               <div className = {classes.activity_name}>{activityName}</div>
               <div className = {classes.activity_date}>Date: {date}</div>
               {PageName === "Budget"? <div className = {classes.activity_budget}>Expense: ₺{expense}</div> : <div className = {classes.activity_budget}></div>}
            </div>
         </AccordionSummary>
         <AccordionDetails className = {classes.activity_detail}>
            <div className = {classes.activity_detail_part1}>
               <div className = {classes.club_name}>Club Name</div>
               <div className = {classes.details}>
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse
                  malesuada lacus ex, sit amet blandit leo lobortis eget.
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse
                  malesuada lacus ex, sit amet blandit leo lobortis eget.
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse
                  malesuada lacus ex, sit amet blandit leo lobortis eget.
               </div>
            </div>

            <div className = {classes.information}>
               <div>Place: {place}</div>
               <div>Date: {date}</div>
               <div>Time: {time}</div>
            </div>
            <Link to = "/Event-Page">
               <div className = {classes.button_box}>
                  <Button className = {classes.button} variant = "contained" color= "info" endIcon = {<ArrowForwardIosIcon />}>See Details</Button>
               </div>
            </Link>
         </AccordionDetails>
      </ModifiedAccordion>
   );
}

export default ActivityAccordion