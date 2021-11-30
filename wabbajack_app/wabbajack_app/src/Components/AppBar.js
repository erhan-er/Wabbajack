import * as React from 'react';
import { useState} from "react";
import { styled, alpha } from '@mui/material/styles';
import Appbar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import InputBase from '@mui/material/InputBase';
import Badge from '@mui/material/Badge';
import MenuIcon from '@mui/icons-material/Menu';
import SearchIcon from '@mui/icons-material/Search';
import NotificationsIcon from '@mui/icons-material/Notifications';
import Menu from "./Menu";

const ModifiedAppBar = styled((props) => (
   <Appbar {...props}/>
))(({theme}) => ({
   backgroundColor: "#000080",
   color: "#ffff7f",
   fontSize: "2rem",
}));

const Search = styled('div')(({ theme }) => ({
   position: 'relative',
   borderRadius: theme.shape.borderRadius,
   backgroundColor: alpha(theme.palette.common.white, 1),
   '&:hover': {
      backgroundColor: alpha(theme.palette.common.white, 0.75),
   },
   marginRight: theme.spacing(2),
   marginLeft: 0,
   color: "#000080",
   width: '100%',
   [theme.breakpoints.up('sm')]: {
      marginLeft: theme.spacing(3),
      width: 'auto',
   },
}));

const SearchIconWrapper = styled('div')(({ theme }) => ({
   color: "#000080",
   padding: theme.spacing(0, 2),
   height: '100%',
   position: 'absolute',
   pointerEvents: 'none',
   display: 'flex',
   alignItems: 'center',
   justifyContent: 'center',
}));

const StyledInputBase = styled(InputBase)(({ theme }) => ({
   color: 'inherit',
   '& .MuiInputBase-input': {
      padding: theme.spacing(1, 1, 1, 0),
      // vertical padding + font size from searchIcon
      paddingLeft: `calc(1em + ${theme.spacing(4)})`,
      transition: theme.transitions.create('width'),
      width: '100%',
      [theme.breakpoints.up('md')]: {
         width: '20ch',
      },
   },
}));

function AppBar ({PageName = "Wabbajack"}) {

   const [isOpen, setIsOpen] = useState(false);

   function searchBar (PageName) {
      if ( PageName === "Home" 
         | PageName === "EventDetail" 
         | PageName === "Budget" 
         | PageName === "Settings") {
         return;
      }
      else if ( PageName === "AllEvents") {
         return (
            <Search>
               <SearchIconWrapper>
                  <SearchIcon />
               </SearchIconWrapper>
               <StyledInputBase />
            </Search>
         );
      }
   }

   return (
      <Box> 
         <ModifiedAppBar position = "static">
            <Toolbar>
               <Typography>
                  {PageName}
               </Typography>
               <Box />
               <Box sx={{ flexGrow: 1 }} />
               {
                  searchBar(PageName)
               }
               <Box sx = {{display: {xs: "none", md: "flex"}}}>
                  <IconButton
                     size="large"
                     aria-label="show 17 new notifications"
                     color="inherit"
                  >
                     <Badge badgeContent={9} color="error">
                        <NotificationsIcon />
                     </Badge>
                  </IconButton>
                  <IconButton
                     size = "large"
                     edge = "end"
                     color = "inherit"
                     aria-label = "open menu"
                     onClick = {() => setIsOpen(true)}
                  >
                     <MenuIcon />
                  </IconButton>
               </Box>
            </Toolbar>
         </ModifiedAppBar>
         <Menu open = {isOpen} setIsOpen = {setIsOpen} userType = {"President"}/>
      </Box>
   );
}

export default AppBar