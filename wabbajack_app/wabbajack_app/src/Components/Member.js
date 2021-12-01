import * as React from "react";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";


const style = makeStyles({
   root: {
      
   },

   member_box: {
      width: "80%",
      height: "232px",
      border: "2px solid black",
      borderRadius: "15px",
      margin: "0 auto",
      display: "flex",
      flexDirection: "row",

   },

   image: {
      display: "flex",
      width: "182px",
      marginLeft: "16px",
      alignItems: "center",
   },

   person_details_box: {
      width: "60%",
      height: "100%",
      display: "flex",
      flexWrap: "wrap",
      fontSize: "1.5rem",
      color: "rgba(0, 0, 0, 0.75)"
   },

   person_details_inner_box: {
      marginTop: "1rem",
      height: "2rem",
      width: "40%",
      marginLeft: "1rem",
   },

   person_detail_header : {
      textAlign: "left",
   },

   person_detail : {
      width: "80%",
      height: "50px",
      paddingTop: "0.5rem",
      borderTop: "2px solid rgba(0, 0, 0, 0.30)",
      textAlign: "left",
      //padding: "1rem",
      //marginBottom: "3rem",
   },

   button_group: {
      width: "30%",
      display: "flex",
      flexDirection: "column",
      justifyContent: "center",
      alignItems: "center",
   },

   button: {
      width: "12rem",
      height: "42px",
      marginTop: "1rem",
      marginBottom: "1rem",
      borderRadius: "10px",
   },
});

function Member ({PersonImage, Name, Id, Role}) {
   const classes = style();

   return (
      <Box className = {classes.root}>
         <Box className = {classes.member_box}>
            <Box className = {classes.image}>
               <img src={PersonImage} alt={Name} style ={{width: "150px", height: "200px", borderRadius: "15px"}}/>
            </Box>
            <Box className = {classes.person_details_box}>
               <Box className = {classes.person_details_inner_box}>
                  <Box className = {classes.person_detail_header}>Name</Box>
                  <Box className = {classes.person_detail}>{Name}</Box>
               </Box>
               <Box className = {classes.person_details_inner_box}>
                  <Box className = {classes.person_detail_header}>Id</Box>
                  <Box className = {classes.person_detail}>{Id}</Box>
               </Box>
               <Box className = {classes.person_details_inner_box}>
                  <Box className = {classes.person_detail_header}>Role</Box>
                  <Box className = {classes.person_detail}>{Role}</Box>
               </Box>
            </Box>
            <Box className = {classes.button_group}>
               <Button className = {classes.button} variant = "contained" color = "info">Change The Role</Button>
               <Button className = {classes.button} variant = "contained" color = "error">Dismiss</Button>
            </Box>
         </Box>
      </Box>
   );
}
export default Member