import * as React from "react";
import AppBar from "../Components/AppBar";
import {Box, Button} from '@mui/material';
import { Link } from "react-router-dom";

function MyClub () {
   
   return(
      <Box>
         <AppBar PageName = {"My Club"}/>
         <Link to = "/Edit-Club">
            <Button>Edit Club</Button>
         </Link>
      </Box>
   );
}

export default MyClub