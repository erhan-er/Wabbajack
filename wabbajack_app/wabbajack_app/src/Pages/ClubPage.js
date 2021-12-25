import { Box } from "@mui/system";
import { useLocation } from "react-router-dom";
import * as React from "react";
import Photo from "../Images/Bilkent.png";
import AppBar from "../Components/AppBar";
import { makeStyles } from "@mui/styles";
import { Link } from "react-router-dom";
import Button from "@mui/material/Button";
import ActivityAccordion from "../Components/ActivityAccordion";
import IconButton from '@mui/material/IconButton';
import FacebookIcon from '@mui/icons-material/Facebook';
import WhatsAppIcon from '@mui/icons-material/WhatsApp';
import TwitterIcon from '@mui/icons-material/Twitter';
import LinkedInIcon from '@mui/icons-material/LinkedIn';
import InstagramIcon from '@mui/icons-material/Instagram';
import { connect } from "react-redux";

const style = makeStyles({
   root: {
   },

   body: {
      marginTop: "50px",
      margin: "0 auto",
      width: "90%",
      display: "flex",
      alignItems: "center",
      flexDirection: "column",
   },

   club_info: {
      width: "100%",
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
      "@media screen and (max-width: 1080px)": {
         flexDirection: "column",
         alignItems: "center",
      },
   }, 

   image: {
      width: "250px",
      height: "250px",
   },

   club_description_box: {
      marginLeft: "25px",
      display: "flex",
      flexDirection: "column",
      justifyContent: "space-between",
      "@media screen and (max-width: 1080px)": {
         marginLeft: 0,
         marginTop: "25px",
      },
   },

   club_description: {
      width: "100%",
      textAlign: "justify",
      "@media screen and (max-width: 1080px)": {
         textAlign: "center",
      },
   },

   club_social_media: {
      width: "100%",
      marginTop: "25px",
   },

   link_box: {
      display: "flex",
      flexDirection: "row",
      justifyContent: "center"
   },

   upcoming_events: {
      marginTop: "25px",
   },

   old_events: {
      marginTop: "25px",
   },

   event_box_header: {
      display: "flex",
      justifyContent: "space-between",
      marginBottom: "10px",
   },

   event_box_header_title: {
      fontSize: "24px",
      color: "#000080",
   }
});

function ClubPage() {

   const classes = style();
   const location = useLocation();

   return (
      <Box className={classes.root}>
         <AppBar PageName={"Club's Page"} />
         <Box className = {classes.body}>
            <Box className = {classes.club_info}>
               <img src = {Photo} alt = {location.state.clubName} className = {classes.image} />
               <Box className = {classes.club_description_box}>
                  <Box className = {classes.club_description}>
                     <Box sx = {{fontSize: "36px"}}><strong> {location.state.clubName} </strong></Box>
                     <Box><strong>Description:</strong> {location.state.description}</Box>
                     <Box sx = {{fontSize: "18px", marginTop: "5px"}}><strong>President:</strong> Erhan Er</Box>
                  </Box>
                  <Box className = {classes.club_social_media}>
                     <Box sx = {{display: "flex", justifyContent: "center"}}><strong>Social Media Accounts</strong></Box>
                     <Box className = {classes.link_box}>
                        <IconButton size="large"><FacebookIcon fontSize="large" /></IconButton>
                        <IconButton size="large"><WhatsAppIcon fontSize="large" /></IconButton>
                        <IconButton size="large"><TwitterIcon fontSize="large" /></IconButton>
                        <IconButton size="large"><LinkedInIcon fontSize="large" /></IconButton>
                        <IconButton size="large"><InstagramIcon fontSize="large" /></IconButton>
                     </Box>
                  </Box>
               </Box>
            </Box>

            <Box className = {classes.upcoming_events}>
               <Box className = {classes.event_box_header}>
                  <Box className = {classes.event_box_header_title}>Upcoming Events</Box>
                  <Box>
                     <Link to="/See-All-Events">
                        <Button variant="contained" color="info" size = "large">See All Upcoming Events</Button>
                     </Link>
                  </Box>
               </Box>
               <Box>
                  
               </Box>   
            </Box>
            <Box className = {classes.old_events}>
               <Box className = {classes.event_box_header}>
                  <Box className = {classes.event_box_header_title}> Old Events </Box>
                  <Box>
                     <Link to="/See-All-Events">
                        <Button variant="contained" color="info" size = "large">See All Old Events</Button>
                     </Link>
                  </Box>
               </Box>
               <Box>
                  {/*<ActivityAccordion {...activity1} />
                  <ActivityAccordion {...activity2} />
   <ActivityAccordion {...activity3} />*/}
               </Box>
               
            </Box>
            
         </Box>
      </Box >
   );
}

export default connect()(ClubPage)