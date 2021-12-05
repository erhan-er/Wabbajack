import * as React from 'react';
import { useState, useEffect } from "react";
import { makeStyles } from '@mui/styles';
import { styled, alpha } from '@mui/material/styles';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import List from '@mui/material/List';
import Divider from '@mui/material/Divider';
import ListItem from '@mui/material/ListItem';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import { Outlet, Link } from "react-router-dom";

const style = makeStyles({
   root: {

   },

   drawer: {
      //height: "20px",
      //maxHeight: "2vw",
      "@media screen and (max-width: 720px)": {
         maxHeight: "40vw",
      },
   },
});

function Menu ({open, setIsOpen, userType}) {
   
   const classes = style();
   const [size, setSize] = useState(window.innerWidth);

   const checkSize = () => {
      setSize(window.innerWidth);
   }

   useEffect (() => {
      window.addEventListener("resize", checkSize);
      return () => {
         window.removeEventListener("resize", checkSize);
      };
   });

   var studentMenu = ["Create Event", "Followed Clubs" , "Home", "Joined Clubs", "My Information",
                     "See All Clubs", "See All Events", "See All Students", "See All Friends",
                     "Settings", "Logout"];

   var presidentMenu = ["Budget", "Create Event", "Followed Clubs", "Home", "Joined Clubs",
                        "My Club", "My Information", "See All Club Members", "See All Clubs",
                        "See All Events", "See All Students", "See All Friends", "Settings", "Logout"];

   var adminMenu = ["Add User", "Add Clubs", "Event Requests", "Settings", "Logout"];

   var allMenu = ["Add Clubs", "Add User", "Budget", "Create Event", "Event Requests", 
                  "Followed Clubs", "Home", "Joined Clubs", "My Club", "My Information", 
                  "See All Club Members", "See All Clubs", "See All Events", "See All Students", 
                  "See All Friends", "Settings", "Logout"];

   function ChooseUserType ( userType ) {
      if (userType === "Student")
         return studentMenu;
      else if ( userType === "President")
         return presidentMenu;
      else if ( userType === "Admin")
         return adminMenu;
      else
         return allMenu;
   }

   function list (size, open) {
      return (
         <Box
            className = {classes.drawer}
            sx={{ width: size < 720? "auto" : 350 }}
            role="presentation"
            onClick={() => {setIsOpen(false)}}
            onKeyDown={() => {setIsOpen(false)}}
         >
            <List>
               <ListItem>
                  Menu
               </ListItem>
               <Divider />
               { ChooseUserType( userType ).map((text, index) => (
                  <Box>
                     <Link to = {text === "Logout"? "/" : "/" + text.replace(/ /g, "-")}  style = {{textDecoration: "none", color: "black"}}>
                        <ListItem button key={text}>
                           <ListItemText primary={text} />
                        </ListItem>
                     </Link>
                     <Divider />
                  </Box>
               ))}
            </List>
         </Box>
      );
   }

   function showMenu (open) {
      if ( open ) {
         return (
            <Drawer 
               className = {classes.drawer}
               anchor = { size >= 720? "right" : "top"}
               open = {open}
               onClose = {() => {setIsOpen(false)}}
            >
               {list(size, open)}
            </Drawer>
         );
      }
   }

   
   return (
      <div>
         {
            showMenu(open)
         }
         
      </div>
   );
}

export default Menu