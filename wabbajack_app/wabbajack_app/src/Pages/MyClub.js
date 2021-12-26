import * as React from "react";
import AppBar from "../Components/AppBar";
import {Box, Button} from '@mui/material';
import { Link } from "react-router-dom";
import { makeStyles } from '@mui/styles';
import Photo from "../Images/Bilkent.png";
import Accordion from "../Components/ActivityAccordion";
import PersonBox from "../Components/PersonBox";



const style = makeStyles({
   root: {

   },
   body: {
      margin: "0 auto",
      marginLeft:"20px",
      marginTop: "25px",
      width: "90%",
   },
   detailHor: {
      display: "flex",
      justifyContent: "space-between",
      "@media screen and (max-width: 1080px)": {
         flexDirection: "column",
         alignItems: "center"
      }
   },

   detailVer: {
      
   },

   clubLogo: {
      margin: "0 auto",
      marginTop: "10px",
      marginLeft: "10px",
      width: "150px",
      height: "150px",
      display: "flex",
      alignItems: "center"
      
   },

   budget_box: {
      margin: "0 auto",
      marginTop: "10px",
      marginLeft: "10px",
      width: "400px",
      height: "80px",
      border: "2px solid #000080",
      borderRadius: "15px",
      display: "flex",
      alignItems: "center"
   },

  amount_text:{
      margin: "0 auto",
      color: "white",

   },

  request_box:{
      marginTop: "10px",
      marginLeft: "10px",
      width: "800px",
      height: "350px",
      border: "2px solid #000080",
      borderRadius: "15px",
      display: "flex",
      alignItems: "center"
   },

  amount_box:{
      margin: "0 auto",
      backgroundColor: "#000080",
      width: "100px",
      height: "40px",
      border: "2px solid #000080",
      borderRadius: "5px",
      display: "flex",
      alignItems: "center"

  },
  remaining_budget:{
   margin: "0 auto",
   
  },

  goBudgetButton:{
      marginLeft: "10px",
      marginTop: "10px",
      width: "400px",
      display: "flex",
      alignItems: "center"
  },

  goMemberListButton:{
      marginLeft: "10px",
      marginTop: "10px",
      width: "400px",
      display: "flex",
      alignItems: "center"
  },

  old_events:{
   margin: "0 auto",
   marginTop: "15px",
   marginLeft: "10px",
   fontSize: "40px",
   display: "flex",
   color: "#000080",
   },

   upcoming_events:{
      margin: "0 auto",
      marginTop: "50px",
      marginLeft: "10px",
      fontSize: "40px",
      display: "flex",
      color: "#000080",
      },

   activity_box: {
      margin: "0 auto",
      width: "100%",
      marginTop: "10px",
      
   },

   new_join:{
      marginTop: "10px",
   },
   

});


function MyClub ({ events }) {
   const classes = style();
   var activity1 = { activityName: "Activity 1", place: "B Building", date: "20/11/2021", time: "18:00"};
   var activity2 = { activityName: "Activity 2", place: "A Building", date: "30/11/2021", time: "20:00" };
   var activity3 = { activityName: "Activity 3", place: "EA Building", date: "31/12/2021", time: "22:00" };
   var budget = "9999₺";


   return(
      <Box className = {classes.root}>
         <AppBar PageName = {"My Club"}/>
         <Box className = {classes.body}> 
            <Box className = {classes.detailHor}>
               <Box className = {classes.detailVer}>
                  <img src={Photo} alt="Club Name" className = {classes.clubLogo}/>
                  <Box className={classes.budget_box}>
                     <div className={classes.remaining_budget}>Remaining Budget: </div>
                     <Box className={classes.amount_box}>
                        <Box className={classes.amount_text}>{budget} </Box>
                     </Box>
                  </Box>
                  <Link to = "/Budget">
                     <Button variant = "contained" color = "success" className = {classes.goBudgetButton}>Go to Budget</Button>
                  </Link>
                  <Link to = "/See-All-Club-Members">
                     <Button variant = "contained" color = "primary" className = {classes.goMemberListButton}>Go to Member List</Button>
                  </Link>
                  
               </Box> 
               <Box className = {classes.request_box}>
                   <Box className = {classes.detailVer}>
                     <div className={classes.new_join}> New Join Requests</div>
                     <PersonBox/>
                     
                  </Box>
               </Box>
            </Box>
            <div className={classes.upcoming_events}>Upcoming Events</div>
            <Box className={classes.activity_box}>
               <Accordion {...activity1} />
               <Accordion {...activity2} />
               <Accordion {...activity3} />
            </Box>
            <div className={classes.old_events}>Old Events</div>
            <Box className={classes.activity_box}>
               <Accordion {...activity1} />
               <Accordion {...activity2} />
               <Accordion {...activity3} />
            </Box> 
         </Box>
      </Box>
   );
}

export default MyClub