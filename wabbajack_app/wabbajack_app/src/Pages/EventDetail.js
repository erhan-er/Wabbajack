import * as React from "react";
import Appbar from "../Components/AppBar";
import Photo from "../Images/Bilkent.png"
import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import JoinedUsers from "../Components/EventDetailJoinedUsers";

const style = makeStyles({
   root: {

   },
   body: {
      margin: "0 auto",
      marginTop: "25px",
      width: "90%",
   },

   detail: {
      display: "flex",
      justifyContent: "space-between",
      "@media screen and (max-width: 1080px)": {
         flexDirection: "column",
         alignItems: "center"
      }
   },

   image: {
      width: "350px",
      height: "350px",
      //backgroundColor: "#f1f2f3",
      //border: "solid 1px rgba(0, 0, 0, 0.5)",
      //borderRadius: "10px",
   },

   description_box: {
      width: "75%",
      textAlign: "left",
      lineHeight: "32px",
      "@media screen and (max-width: 1080px)": {
         width: "100%"
      }
   },

   club_name: {
      fontSize: "24px",
   },

   activity_name: {

   },

   description: {

   },

   info: {

   },

   date: {

   },

   time: {

   },

   place: {

   },

   category: {

   },

   button_box: {
      display: "flex",
      justifyContent: "end",
      marginBottom: "10px",
      "@media screen and (max-width: 1080px)": {
         flexDirection: "column"   
      }
   },

   button: {
      marginLeft: "10px",
      width: "256px",
      "@media screen and (max-width: 1080px)": {
         width: "100%",
         marginTop: "15px",
         marginLeft: 0,
      }
   },

   border: {
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      marginBottom: "25px",
   },

   users: {
      display: "flex",
      flexDirection: "column",
   },

   students: {
      marginTop: "10px",
      display: "flex",
      flexDirection: "row",
      flexWrap: "wrap",
      justifyContent: "space-between",
   },

   search_box: {
      width: "100%",
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
      "@media screen and (max-width: 1080px)": {
         flexDirection: "column",
      }
   },

   search: {
      width: "40%",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      "@media screen and (max-width: 1080px)": {
         width: "100%",
         marginBottom: "10px",
      }
   },

   student: {
      marginTop: "10px",
   }

});

function EventDetail() {
   const classes = style();

   return(
      <Box className = {classes.root}>
         <Appbar PageName = {"Event Detail"}/>
         <Box className = {classes.body}>
            <Box className = {classes.detail}>
               <img src={Photo} alt="Club Name" className = {classes.image}/>
               <Box className = {classes.description_box}>
                  <Box className = {classes.club_name}><strong>Club Name</strong></Box>
                  <Box className = {classes.activity_name}><strong>Activity Name</strong></Box>
                  <Box className = {classes.description}><strong>Description: </strong>description description description description description 
                  description description description description description description 
                  description description description description description description 
                  description description description description description description 
                  description description description description description description </Box>
                  <Box className = {classes.info}>
                     <Box className = {classes.date}><strong>Date: </strong>24/12/2021</Box>
                     <Box className = {classes.time}><strong>Time: </strong>19:00</Box>
                     <Box className = {classes.place}><strong>Place: </strong>B Building, BZ-01</Box>
                     <Box className = {classes.category}><strong>Category: </strong>Sport</Box>
                  </Box>
               </Box>
            </Box>
            <Box className = {classes.button_box}>
               <Button variant = "contained" color = "success" className = {classes.button}>Invite Friends</Button>
               <Button variant = "contained" color = "primary" className = {classes.button}>Join</Button>
            </Box>
            <Box className = {classes.border}></Box>
            <Box className = {classes.users}>
               <Box className = {classes.search_box}>
                  <input type="search" name="Name" id="SearchByName" placeholder="Search By Name" className = {classes.search}/>
                  <input type="search" name="ID" id="SearchById" placeholder="Search By ID" className = {classes.search}/>
               </Box>
               <Box className = {classes.students}>
                  <JoinedUsers />
                  <JoinedUsers />
                  <JoinedUsers />
               </Box>
            </Box>
         </Box>
         
      </Box>
   );
}

export default EventDetail