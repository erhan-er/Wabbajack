import * as React from "react";
import { useState, useEffect } from "react";
import { makeStyles } from "@mui/styles";
import { Box, Chip } from "@mui/material";

const style = makeStyles({
   root: {
      margin: "0 auto",
      width: "90%",
      height: "90%",
   },

   body: {
      marginTop: "10px",
      height: "90%",
      display: "flex",
      flexDirection: "row",
      justifyContent: "center",
   },

   box: {
      width: "100%",
      height: "100%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      display: "flex",
      flexDirection: "row",
      flexWrap: "wrap",
      justifyContent: "space-evenly",
      alignItems: "center",
   },

   chip_box: {
      width: "100%",
      marginTop: "10px",
   },

   chip: {
      width: "17%",
      "@media screen and (max-width: 960px)": {
         width: "150px",
      }
      //display: "flex",
      //justifyContent: "space-between"
   },
});

function ClubBox({Clubs}) {

   const classes = style();

   function handleClick() {
      console.log("Click");
   }

   function handleDelete() {
      console.log("Delete");
   }

   function clubList() {
      return(
         Clubs.map((club, index) => {
            return (
               <Chip className = {classes.chip} label = {club.clubName} onClick = {() => handleClick()} onDelete = {() => handleDelete()} key = {index}/>
            );
         })
      );
   }

   return(
      <Box className = {classes.root}>
         <Box className = {classes.body}>
            <Box className = {classes.box}>
               {clubList()}
            </Box>
         </Box>
      </Box>
   );
}

export default ClubBox