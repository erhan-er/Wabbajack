import * as React from 'react';
import { useState } from "react";
import { styled, alpha } from '@mui/material/styles';
import { makeStyles } from '@mui/styles';
import Appbar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import Badge from '@mui/material/Badge';
import MenuIcon from '@mui/icons-material/Menu';
import SearchIcon from '@mui/icons-material/Search';
import NotificationsIcon from '@mui/icons-material/Notifications';
import Menu from "./Menu";
import { Link } from "react-router-dom";

const ModifiedAppBar = styled((props) => (
   <Appbar {...props}/>
))(({theme}) => ({
   width: "100%",
   backgroundColor: "#000080",
   color: "#ffff7f",
   fontSize: "1rem",
}));

const ModifiedIconButton = styled((props) => (
   <IconButton {...props}/>
))(({theme}) => ({
   ":hover" : {
      backgroundColor: "#ffff7f"
   }
}));

const style = makeStyles({
   root: {

   },

   page_name: {
      color: "#ffff7f",
      textDecoration: "none"
   },
});

function AppBar ({PageName = "Wabbajack"}) {
   const classes = style();
   const [isOpen, setIsOpen] = useState(false);

   return (
      <Box sx = {{flexGrow: 1}}> 
         <ModifiedAppBar position = "static">
            <Toolbar>
               <Typography className = {classes.page_name}>
                  <Link to = "/Home" style={{color: "#ffff7f", textDecoration: "none", fontSize: "1.5rem"}}>{PageName}</Link>
               </Typography>
               <Box />
               <Box sx={{ flexGrow: 1 }} />
               <Box sx = {{display: { xs: "flex"}, justifyContent: "space-between"}}>
                  <ModifiedIconButton
                     size = "large"
                     color = "inherit"
                     sx = {{marginRight: "2.5vw", backgroundColor: "#f1f2f3"}}
                  >
                     <SearchIcon sx = {{color: "#000080"}}/>
                  </ModifiedIconButton>
                  <ModifiedIconButton
                     size="large"
                     aria-label="show 17 new notifications"
                     color="inherit"
                     sx = {{marginRight: "2.5vw", backgroundColor: "#f1f2f3"}}
                  >
                     <Badge badgeContent={9} color="warning">
                        <NotificationsIcon sx = {{color: "#000080"}}/>
                     </Badge>
                  </ModifiedIconButton>
                  <ModifiedIconButton
                     size = "large"
                     edge = "end"
                     color = "inherit"
                     aria-label = "open menu"
                     sx = {{marginRight: "1vw", backgroundColor: "#f1f2f3"}}
                     onClick = {() => setIsOpen(true)}
                  >
                     <MenuIcon sx = {{color: "#000080"}}/>
                  </ModifiedIconButton>
               </Box>
            </Toolbar>
         </ModifiedAppBar>
         <Menu open = {isOpen} setIsOpen = {setIsOpen} userType = {"All Menu"}/>
      </Box>
   );
}

export default AppBar