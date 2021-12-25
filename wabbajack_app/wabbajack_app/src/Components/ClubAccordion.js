import * as React from 'react';
import { makeStyles } from '@mui/styles';
import { styled } from '@mui/material/styles';
import Button from "@mui/material/Button";
import Box from "@mui/material/Box";
import Accordion from '@mui/material/Accordion';
import AccordionSummary from '@mui/material/AccordionSummary';
import AccordionDetails from '@mui/material/AccordionDetails';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import ArrowForwardIosIcon from '@mui/icons-material/ArrowForwardIos';
import { Link } from "react-router-dom";

const ModifiedAccordion = styled((props) => (
   <Accordion {...props} />
))(({ theme }) => ({
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
   padding: 5,
}));

const style = makeStyles({
   accordion: {
      marginBottom: "10px",
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
      justifyContent: "space-between",
      "@media screen and (max-width: 960px)": {
         margin: 0,
         width: "90%",
         alignItems: "center",
         flexDirection: "column",
         textAlign: "justify",
         margin: "0 auto",
      }
   },

   club_detail_box: {
      width: "75%",
      "@media screen and (max-width: 960px)": {
         marginTop: "10px",
         width: "100%",
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
      marginTop: "20px",
      marginLeft: "10px",
      height: "42px",
      width: "192px",
      "@media screen and (max-width: 960px)": {
         margin: 0,
         marginTop: "10px",
         width: "100%",
      }
   },

   club_logo: {
      width: "200px",
      height: "100%",
      display: "flex",
      justifyContent: "center",
      alignItems: "center",
   },
});

function ClubAccordion({ clubPresidentID, name, clubDescription, facebookLink, id, instagramLink, linkedinLink, telegramLink, whatsappLink, imageURL}) {

   const classes = style();

   return (
      <ModifiedAccordion className={classes.accordion}>
         <AccordionSummary
            expandIcon={<ExpandMoreIcon className={classes.expand_icon} />}
         >
            <div className={classes.club_summary}>
               <div className={classes.club_name}>{name}</div>
            </div>
         </AccordionSummary>
         <ModifiedAccordionDetails className={classes.club_detail}>
            <Box className={classes.club_logo}><img src={imageURL} alt={name} style = {{height: "150px", width: "150px"}}/></Box>
            <div className={classes.club_detail_box}>
               <div className={classes.details}>
                  <strong>Description:</strong>{clubDescription}
               </div>
            </div>
            <Link to= "/Club-Page" state= {{clubPresidentID, name, clubDescription, facebookLink, id, instagramLink, linkedinLink, telegramLink, whatsappLink, imageURL}} className={classes.button_box}>
               <Button className={classes.button} variant="contained" color="info" endIcon={<ArrowForwardIosIcon />}>See Details</Button>
            </Link>
         </ModifiedAccordionDetails>
      </ModifiedAccordion >
   );
}

export default ClubAccordion