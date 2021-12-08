import * as React from "react";
import { connect } from "react-redux";
import AppBar from "../Components/AppBar";
import Box from '@mui/material/Box';

function AddClubs () {
   
   return(
      <Box>
         <AppBar PageName = {"Add Clubs"}/>
         
      </Box>
   );
}

const mapStateToProps = state => {
   console.log(state);
};
export default connect(mapStateToProps)(AddClubs);