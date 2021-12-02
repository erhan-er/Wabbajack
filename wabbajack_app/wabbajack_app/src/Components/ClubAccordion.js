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
import { height } from '@mui/system';

const ModifiedAccordion = styled((props) => (
   <Accordion {...props} />
))(({ theme }) => ({
   backgroundColor: "#000080",
   borderRadius: "20px",
   '&:not(:last-child)': {
      borderRadius: "20px",
      marginBottom: "1rem",
   },
   '&:not(:first-child)': {
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

   club_summary: {
      display: "flex",
      justifyContent: "space-between",
      color: "#ffff7f",
      width: "90%",
   },

   club_name: {
      fontSize: "16px",
   },

   club_date: {
      fontSize: "16px",
   },

   club_budget: {
      fontSize: "16px",
      width: "200px",
   },

   club_detail: {
      marginTop: "-8px",
      width: "95%",
      borderRadius: "0 0 15px 15px",
      color: "#ffff7f",
      textAlign: "left",
      display: "flex",
      flexDirection: "row",
      position: "relative",
      justifyContent: "space-between"
   },

   club_detail_part1: {
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

   club_logo: {
      width: "150px",
      height: "150px",

   },
});

function ClubAccordion({ clubName, description, clubImage }) {

   const classes = style();

   return (
      <ModifiedAccordion className={classes.accordion}>
         <AccordionSummary
            expandIcon={<ExpandMoreIcon className={classes.expand_icon} />}
         >
            <div className={classes.club_summary}>
               <div className={classes.club_name}>{clubName}</div>
            </div>
         </AccordionSummary>
         <AccordionDetails className={classes.club_detail}>
            <img src={clubImage} alt={clubName} className={classes.club_logo} />
            <div className={classes.club_detail_part1}>
               <div className={classes.details}>
                  <strong>Description:</strong>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse
                  malesuada lacus ex, sit amet blandit leo lobortis eget.
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse
                  malesuada lacus ex, sit amet blandit leo lobortis eget.
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse
                  malesuada lacus ex, sit amet blandit leo lobortis eget.
               </div>
            </div>
            <Link to="../Club-Page">
               <div className={classes.button_box}>
                  <Button className={classes.button} variant="contained" color="info" endIcon={<ArrowForwardIosIcon />}>See Details</Button>
               </div>
            </Link>
         </AccordionDetails>
      </ModifiedAccordion >
   );
}

export default ClubAccordion