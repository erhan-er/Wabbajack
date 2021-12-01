import * as React from 'react';
import { styled, alpha } from '@mui/material/styles';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import List from '@mui/material/List';
import Divider from '@mui/material/Divider';
import ListItem from '@mui/material/ListItem';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import { Outlet, Link } from "react-router-dom";

function Menu ({open, setIsOpen, userType}) {
   
   var studentMenu = ["Create Event", "Followed Clubs" , "Home", "Joined Clubs", "My Information",
                     "See All Clubs", "See All Events", "See All Students", "See All Friends",
                     "Settings"];

   var presidentMenu = ["Budget", "Create Event", "Followed Clubs", "Home", "Joined Clubs",
                        "My Club", "My Information", "See All Club Members", "See All Clubs",
                        "See All Events", "See All Students", "See All Friends", "Settings"];

   function ChooseUserType ( userType ) {
      if (userType === "Student")
         return studentMenu;
      else
         return presidentMenu;
   }

   function list () {
      return (
         <Box
            sx={{ width: 250 }}
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
                     <Link to = {"/" + text.replace(/ /g, "-")}  style = {{textDecoration: "none", color: "black"}}>
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
               anchor = "right"
               open = {open}
               onClose = {() => {setIsOpen(false)}}
            >
               {list(open)}
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