import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import Photo from "../Images/image.jpg";
import * as React from "react";

const style = makeStyles({
   root: {
      width: "45%", 
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      height: "220px",
      display: "flex",
      alignItems: "center",
      justifyContent: "center",
      paddingLeft: "5px",
      paddingRight: "5px",
      "@media screen and (max-width: 1080px)": {
         width: "100%",
      },
      "@media screen and (max-width: 600px)": {
         height: "270px",
      },
   },

   body: {
      width: "100%",
      display: "flex",
      justifyContent: "space-between",
      
      "@media screen and (max-width: 600px)": {
         flexWrap: "wrap",
      }
   },

   image: {
      width: "150px",
      height: "200",
      borderRadius: "10px",
   },

   info_box: {
      display: "flex",
      width: "65%",
      justifyContent: "space-between",
      "@media screen and (max-width: 600px)": {
         width: "100%",
      }
   },

   info: {
      width: "50%",
      display: "flex",
      flexDirection: "column",
      justifyContent: "space-evenly",
      alignItems: "flex-start",
      "@media screen and (max-width: 600px)": {
         width: "60%",
      }
   },

   button_box: {
      display: "flex",
      alignItems: "center",
      justifyContent: "center",
      width: "35%",
      "@media screen and (max-width: 600px)": {
         width: "100%",
      }
   },

   button: {
      "@media screen and (max-width: 600px)": {
         marginTop: "10px",
         width: "100%",
      }
   },

});

function EventDetailJoinedUsers() {
   const classes = style();
   return(
      <Box className = {classes.root}>
         <Box className = {classes.body}>
            <Box className = {classes.info_box}>
               <img src={Photo} alt={"Name"} className = {classes.image}/>
               <Box className = {classes.info}>
                  <Box><strong>Name: </strong>Erhan Er</Box>
                  <Box><strong>ID: </strong>2180000000</Box>
               </Box>
            </Box>
            <Box className = {classes.button_box}>
               <Button variant = "contained" color = "success" className = {classes.button}>Joined to Event</Button>
            </Box>
         </Box>
      </Box>
   );
}

export default EventDetailJoinedUsers