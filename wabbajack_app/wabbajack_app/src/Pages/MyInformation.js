import * as React from "react";
import AppBar from "../Components/AppBar";
import Box from '@mui/material/Box';
import EmailID from "../Components/EmailID";

function MyInformation () {
   
   return(
      <Box>
         <AppBar PageName = {"My Information"}/>
         <EmailID Type = {"Email"} />
         <EmailID Type = {"ID"} />
      </Box>
   );
}

export default MyInformation