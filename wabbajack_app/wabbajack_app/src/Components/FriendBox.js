import * as React from "react";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";
import { connect } from "react-redux";
import { ADD_FRIEND } from "../Reducer/actions";
import PersonImage from "../Images/image.jpg"

const style = makeStyles({
   box: {
      width: "186px",
      height: "317px",
      backgroundColor: "#000080",
      borderRadius: "15px",
      marginLeft: "100px",
   },

   img: {
      width: "150px",
      height: "200px",
      borderRadius: "10px",
      marginTop: "18px",
   },

   info_box: {
      marginTop: "6px",
      height: "90px",
   },

   name: {
      marginLeft: "18px",
      color: "#ffff7f",
      textAlign: "start",
   },

   button_box: {
      marginTop: "24px",
   },

   button: {
      width: "150px",
      height: "36px",
   }
});

function FriendBox ({name, id, mail, department, PageName}) {
   function ButtonType(PageName){
      if (PageName === "SeeAllFriends"){
         return <Button className = {classes.button} variant = "contained" color = "error">Remove</Button>
      }
      else{
         return <Button className = {classes.button} variant = "contained" color = "success">Add Friend</Button>
      }
   }
   const classes = style();

   return (
      <Box className = {classes.box}>
         <img src={PersonImage} alt={name} className = {classes.img}/>
         <Box className = {classes.info_box}>
            <Box className = {classes.name}>
               {name}
            </Box>
            <Box className = {classes.button_box}>
               {ButtonType(PageName)}
            </Box>
         </Box>
      </Box>
   );
}

const mapDispatchToProps = (dispatch, ownProps) => {
   return { add: () => dispatch({type: ADD_FRIEND, payload: { ownProps }})}
}

export default connect(null, mapDispatchToProps)(FriendBox)