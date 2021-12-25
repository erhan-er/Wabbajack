import { Box, Select, MenuItem, FormControl, InputLabel } from "@mui/material";
import { makeStyles } from "@mui/styles";
import * as React from "react";
import { useState } from "react";

const style = makeStyles({
   root: {
      width: "90%", 
      marginTop: "25px",
   },

   body: {

   },

   body_top: {
      width: "100%",
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
   },

   body_top_left: {
      width: "70%",
      display: "flex",
      flexDirection: "column",
      justifyContent: "space-between",
      height: "360px",
   },

   body_top_right: {
      width: "25%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      //height: "360px",
   },

   name: {
      height: "42px",
      //width: "100%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      fontFamily: "inherit",
   },

   description: {
      //width: "100%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      fontFamily: "inherit",
      resize: "none",
   },

   building: {
      //border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      width: "100%",
   },

   body_bottom: {
      width: "100%",
      display: "flex",
      flexDirection: "row",
      marginTop: "25px",
      justifyContent: "space-between",
   },

   body_bottom_left: {
      width: "70%",
      border: "solid 1px"

   },

   body_bottom_left_top: {
      width: "100%",
   },

   body_bottom_left_bottom: {

   },

   body_bottom_right: {
      width: "25%",
      border: "solid 1px"
   },

});
function CreateEventComponent() {
   const classes = style();
   const [building, setBuilding] = useState("");
   const [place, setPlace] = useState("");

   const handleBuilding = (event) => {
      setBuilding(event.target.value);
      console.log(building);
   }

   const handleClass = (event) => {
      setPlace(event.target.value);
      console.log(place);
   }
   return(
      <Box className = {classes.root}>
         <Box className = {classes.body}>
            <Box className = {classes.body_top}>
               <Box className = {classes.body_top_left}>
                  <input type="text" id="Name" placeholder="Name of The Event" className = {classes.name}/>
                  <textarea name="Description" id="Description" cols="30" rows="10" className = {classes.description} placeholder="Description"/>
                  <FormControl className = {classes.building}>
                     <InputLabel>Building</InputLabel>
                     <Select
                        id = "Building"
                        value = {building}
                        label= "Building"
                        onChange = {handleBuilding}
                     >
                        <MenuItem value="A">A Building</MenuItem>
                        <MenuItem value="B">B Building</MenuItem>
                        <MenuItem value="EA">EA Building</MenuItem>
                        <MenuItem value="EE">EE Building</MenuItem>
                        <MenuItem value="H">H Building</MenuItem>
                        <MenuItem value="V">V Building</MenuItem>
                     </Select>
                  </FormControl>
               </Box>   
               <Box className = {classes.body_top_right}>

               </Box>
            </Box>
            <Box className = {classes.body_bottom}>
               <Box className = {classes.body_bottom_left}>
                  <Box className = {classes.body_bottom_left_top}>
                     <FormControl className = {classes.building}>
                        <InputLabel>Class</InputLabel>
                        <Select
                           id = "Place"
                           value = {place}
                           label= "Classes"
                           onChange = {handleClass}
                        >
                           <MenuItem value="Z01">Z01</MenuItem>
                           <MenuItem value="Z02">Z02</MenuItem>
                           <MenuItem value="Z03">Z03</MenuItem>
                           <MenuItem value="Z04">Z04</MenuItem>
                           <MenuItem value="Z05">Z05</MenuItem>
                           <MenuItem value="Z06">Z06</MenuItem>
                        </Select>
                     </FormControl>
                  </Box>
                  <Box className = {classes.body_bottom_left_bottom}>
                     <Box className = {classes.body_bottom_left_bottom_left}>
                        <Box className = {classes.date}>
                           <input type="date" id="Date" placeholder="Date"/>
                           <input type="time" name="Time" id="Time" />
                        </Box>
                        <Box className = {classes.time}></Box>
                     </Box>
                     <Box className = {classes.body_bottom_left_bottom_right}></Box>
                  </Box>
               </Box>
               <Box className = {classes.body_bottom_right}></Box>
            </Box>
         </Box>
      </Box>
   );
}

export default CreateEventComponent