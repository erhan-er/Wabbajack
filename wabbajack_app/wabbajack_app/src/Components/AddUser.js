import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import * as React from "react";
import { useState } from "react";

const style = makeStyles({
   root: {
      width: "90%",
      marginTop: "5vw",

   },

   top_body: {
      display: "flex",
      flexDirection: "row",
      width: "100%",
      "@media screen and (max-width: 840px)": {
         flexDirection: "column",
         justifyContent: "space-evenly",
         alignItems: "center",
         minHeight: "720px",
      }
   },

   left_side: {
      display: "flex",
      flexDirection: "column",
      width: "50%",
      justifyContent: "space-between",
      alignItems:"center",
      "@media screen and (max-width: 840px)": {
         width: "100%",
         minHeight: "300px",
      }
   },

   right_side: {
      display: "flex",
      flexDirection: "column",
      width: "50%",
      justifyContent: "space-between",
      alignItems:"center",
      "@media screen and (max-width: 840px)": {
         width: "100%",
         minHeight: "300px",
      }
   },

   name: {
      width: "90%",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },

   id: {
      width:  "90%",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },

   email: {
      width: "90%",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },

   image_url: {
      width: "90%",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },
   
   image_box: {
      height: "262px",
      width: "262px",
      display: "flex",
      justifyContent: "center",
      alignItems: "center",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },

   image: {
      maxWidth: "252px",
      maxHeight: "252px",
      borderRadius: "10px",
   },

   preview_button: {
      width: "90%",
   },

   add_button: {
      width: "50%",
      marginTop: "2vw",
      marginBottom: "5vw",
      "@media screen and (max-width: 840px)": {
         marginTop: "-5vw",
      }
   }
});

function AddUserComponent() {
   const classes = style();

   const [imageUrl, setImageUrl] = useState("");

   function preview( url ) {
      document.getElementById("image").src = url;
   }
   
   return(
      <Box className = {classes.root}>
         <Box className = {classes.top_body}>
            <Box className = {classes.left_side}>
               <input type="text" className = {classes.name} placeholder = "Name"/>
               <input type="number" className = {classes.id} placeholder = "ID"/>
               <input type="email" className = {classes.email} placeholder = "Email"/>
               <input type="url" id = "imgUrl" placeholder = "Image URL" className = {classes.image_url} />
               <Button variant = "contained" className = {classes.preview_button} onClick = {() => preview(document.getElementById("imgUrl").value)}>Preview</Button>
            </Box>
            <Box className = {classes.right_side}>
               <Box className = {classes.image_box}><img alt="Enter a URL" id = "image" className = {classes.image}/></Box>
            </Box>
         </Box>
         <Button variant = "contained" color = "success" className = {classes.add_button}>Add User</Button>
      </Box>
   );
}

export default AddUserComponent