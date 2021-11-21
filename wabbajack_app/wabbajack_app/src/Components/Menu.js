import * as React from 'react';
import { styled, alpha } from '@mui/material/styles';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import List from '@mui/material/List';
import Divider from '@mui/material/Divider';
import ListItem from '@mui/material/ListItem';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';

function Menu ({open, setIsOpen}) {
   
   function list () {
      return (
         <Box
            sx={{ width: 250 }}
            role="presentation"
            onClick={() => {setIsOpen(false)}}
            onKeyDown={() => {setIsOpen(false)}}
         >
            <List>
            {['Inbox', 'Starred', 'Send email', 'Drafts'].map((text, index) => (
               <ListItem button key={text}>
                  <ListItemText primary={text} />
               </ListItem>
            ))}
            </List>
            <Divider />
            <List>
            {['All mail', 'Trash', 'Spam'].map((text, index) => (
               <ListItem button key={text}>
                  <ListItemText primary={text} />
               </ListItem>
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