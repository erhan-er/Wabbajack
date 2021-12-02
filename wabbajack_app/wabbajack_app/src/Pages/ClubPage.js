import { Box } from "@mui/system";
import { useLocation } from "react-router-dom";
import * as React from "react";
import Photo from "../Images/Bilkent.png";
import Member from "../Components/Member";
import AppBar from "../Components/AppBar";
import { makeStyles } from "@mui/styles";
import { Link } from "react-router-dom";
import Button from "@mui/material/Button";
import ActivityAccordion from "../Components/ActivityAccordion";
import { fabClasses } from "@mui/material";
import IconButton from '@mui/material/IconButton';
import FacebookIcon from '@mui/icons-material/Facebook';
import WhatsAppIcon from '@mui/icons-material/WhatsApp';
import TwitterIcon from '@mui/icons-material/Twitter';
import LinkedInIcon from '@mui/icons-material/LinkedIn';
import InstagramIcon from '@mui/icons-material/Instagram';

const style = makeStyles({
   root: {

   },

   img: {
      width: "350px",
      height: "350pxpx",
      borderRadius: "10px",
      marginTop: "1rem",
      marginLeft: "4.2rem",
   },

   activity_box: {
      margin: "0 auto",
      width: "90%",
   },

   see_all_button: {
      width: "300px",
      height: "42px",
      alignItems: "center",
      textDecorationLine: "none"
   },

   text_field: {
      width: "250px",
      height: "42px",
      textDecoration: "none",
      fontSize: "25px",
      color: "#000080",
      alignItems: "center",
      display: "flex"
   },

   description_field: {
      width: "500px",
      marginTop: "2rem",
      textDecoration: "none",
      fontSize: "18px",
      textAlign: "left",
   },

   social_media_text: {
      width: "300px",
      marginTop: "2rem",
      textDecoration: "none",
      fontSize: "18px",
      textAlign: "center",
   },

   flex_box: {
      width: "90%",
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
      marginLeft: "5.9rem",
      marginTop: "2rem",
      marginBottom: "1rem",
      alignItems: "center",
   },
});

function ClubPage() {
   const classes = style();
   const location = useLocation();
   console.log(location.state);
   var activity1 = { activityName: "Activity 1", place: "B Building", date: "20/11/2021", time: "18:00", expense: "5000" };
   var activity2 = { activityName: "Activity 2", place: "A Building", date: "30/11/2021", time: "20:00" };
   var activity3 = { activityName: "Activity 3", place: "EA Building", date: "31/12/2021", time: "22:00" };
   return (
      <Box className={classes.root}>
         <AppBar PageName={"Club's Page"} />
         {/**IMAGE AND DESCRIPTION*/}
         <Box className={classes.flex_box}>
            <img src={Photo} className={classes.img}></img>
            <Box>
               <Box className={classes.text_field}><strong> {location.state.clubName} </strong></Box>
               <Box className={classes.description_field}>
                  <strong>Description:</strong> {location.state.description}
               </Box>
               <Box className={classes.description_field}>
                  <strong>President:</strong> Erhan Er
               </Box>
            </Box>
            <Box>
               <Box className={classes.social_media_text}><strong>Social Media Accounts</strong></Box>
               <IconButton size="large"><FacebookIcon fontSize="large" /></IconButton>
               <IconButton size="large"><WhatsAppIcon fontSize="large" /></IconButton>
               <IconButton size="large"><TwitterIcon fontSize="large" /></IconButton>
               <IconButton size="large"><LinkedInIcon fontSize="large" /></IconButton>
               <IconButton size="large"><InstagramIcon fontSize="large" /></IconButton>
            </Box>
         </Box>
         {/**UPCOMING EVENTS*/}
         <Box className={classes.flex_box}>
            <div className={classes.text_field} > Upcoming Events </div>
            <div>
               <Link to="/See-All-Events">
                  <Button variant="contained" color="info" className={classes.see_all_button}>See All Upcoming Events</Button>
               </Link>
            </div>
         </Box>
         <Box className={classes.activity_box}>
            <ActivityAccordion {...activity1} />
            <ActivityAccordion {...activity2} />
            <ActivityAccordion {...activity3} />
         </Box>
         {/**OLD EVENTS*/}
         <Box className={classes.flex_box}>
            <div className={classes.text_field} > Old Events </div>
            <div>
               <Link to="/See-All-Events">
                  <Button variant="contained" color="info" className={classes.see_all_button}>See All Old Events</Button>
               </Link>
            </div>
         </Box>
         <Box className={classes.activity_box}>
            <ActivityAccordion {...activity1} />
            <ActivityAccordion {...activity2} />
            <ActivityAccordion {...activity3} />
         </Box>
      </Box >
   );
}

export default ClubPage