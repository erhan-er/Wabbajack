import * as React from "react";
import { useState, useEffect } from "react";
import { makeStyles, styled } from "@mui/styles";
import { Box, Button, Backdrop, Chip } from "@mui/material";
import MoreClub from "./MoreClub";

const style = makeStyles({
   root: {
      width: "100%",
   },

   header: {
      
      borderBottom: "solid 2px rgba(0, 0, 0, 0.5)",

      "@media screen and (max-width: 960px)": {
         textAlign: "center",
      },
   },

   header_text: {
      fontSize: "24px",
      textAlign: "left",
      marginBottom: "10px",
      marginLeft: "5px",
      color: "#000080",

      "@media screen and (max-width: 960px)": {
         margin: 0,
      },
   },

   body: {
      marginTop: "10px",
      display: "flex",
      flexDirection: "row",
      justifyContent: "center",
   },

   box: {
      width: "100%",
      height: "192px",
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

   button: {
      width: "100%",
      marginTop: "25px",
      height: "42px",
   }, 
});
function ChipBox({ Type }) {
   // variables
   const classes = style();
   const [pageSize, setPageSize] = useState(9);
   const [screenSize, setScreenSize] = useState(window.innerWidth);
   const [open, setOpen] = useState(false);
   var buttonText;
   var headerText;

   useEffect(() => {
      window.addEventListener("resize", checkSize);
      pageSizeController();
      return () => {
         window.removeEventListener("resize", checkSize);
      };
   });

   function checkSize() {
      setScreenSize(window.innerWidth);
   }

   function pageSizeController() {
      if ( screenSize <= 852 && screenSize > 686 )
         setPageSize(7);
      else if ( screenSize <= 686 && screenSize > 520 )
         setPageSize(5);
      else if ( screenSize <= 520 )
         setPageSize(3);
      else
         setPageSize(9);
   }

   // Database gelince buraları sil
   const Clubs = [];
   var activity1 = { clubName: "Club 1" };
   var activity2 = { clubName: "Club 2" };
   var activity3 = { clubName: "Club 3" };

   for (let i = 0; i < 20; i++) {
      if (i % 2 === 0)
         Clubs[i] = activity2;
      else if (i % 3 === 0)
         Clubs[i] = activity3;
      else
         Clubs[i] = activity1;
   }
   // buraya kadar
   
   // Initial set of button and header text \\
   if ( Type === "Ignore") {
      buttonText = "Ignore More";
      headerText = "Ignored Clubs";
   }
   else if ( Type === "Follow") {
      buttonText = "Follow More";
      headerText = "Followed Clubs";
   }
   else if ( Type === "Join") {
      buttonText = "Join More";
      headerText = "Joined Clubs";
   }
   // -------------------------------------- \\

   function handleClick() {
      console.log("Click");
   }

   function handleDelete() {
      console.log("Delete");
   }

   function clubList() {
      if ( Clubs.length > 0 ) {
         return(
            Clubs.map((club, index) => {
               if (index >= 0 && index < pageSize) {
                  return (
                     <Chip className = {classes.chip} label = {club.clubName} onClick = {() => handleClick()} onDelete = {() => handleDelete()} key = {index}/>
                  );
               }
            })
         );
      }
      else
         return <Box>You have not any {headerText}</Box>
   }

   return(
      //{Type()}
      <Box className = {classes.root}>
         <Backdrop 
            open = {open} 
            sx={{ color: '#fff', zIndex: (theme) => theme.zIndex.drawer + 1 }}
         >
            <MoreClub Clubs = {Clubs} setOpen = {setOpen}/>
         </Backdrop>
         <Box className = {classes.header}>
            <Box className = {classes.header_text}>{Type} Clubs</Box>
         </Box>
         <Box className = {classes.body}>
            <Box className = {classes.box}>
               {clubList()}
               <Chip className = {classes.chip} label = "See More" onClick = {() => setOpen(true)}/>
            </Box>
         </Box>
         <Button color = "primary" variant = "contained" className = {classes.button}>{buttonText}</Button>
         
      </Box>
   );
}

export default ChipBox