import * as React from 'react';
import { makeStyles, styled } from '@mui/styles';
import Button from "@mui/material/Button";
import Box from "@mui/material/Box";
import Photo from "../Images/image.jpg"
import { Link } from "react-router-dom";


const style = makeStyles({
    root: {

    },
    body: {
       margin: "0 auto",
       marginTop: "25px",
       width: "90%",
    },
 
    detail: {
       display: "flex",
       justifyContent: "space-between",
       "@media screen and (max-width: 1080px)": {
          flexDirection: "column",
          alignItems: "center"
       }
    },

    personImage: {
        margin: "0 auto",
        marginLeft: "10px",
        width: "150px",
        height: "150px",
        display: "flex",
        alignItems: "center"
        
     },

     area:{
        marginLeft: "10px",

     },
     txt:{
        marginTop: "15px",
        marginBottom: "15px",
        color: "#000080",
        width: "100px",
     },

     acceptButton:{
        marginLeft: "10px",
        marginTop: "10px",
        width: "300px",
        display: "flex",
        alignItems: "center"
    },
  
    declineButton:{
        marginLeft: "10px",
        marginTop: "20px",
        width: "300px",
        display: "flex",
        alignItems: "center"
     },

     buttonBox:{
        margin: "0 auto",
        marginTop: "10px",
        marginLeft: "150px",
     },

});




function PersonBox(){
    const classes = style();
    

    return(
        <Box className = {classes.root}>
            <Box className = {classes.body}>
                <Box className = {classes.detail}>
                    <img src={Photo} alt="Club Name" className = {classes.personImage}/>
                    <Box className={classes.area}>
                        <div className={classes.txt}>Name</div>
                        <div >Mustafa Yusa Babademez</div>
                        <div className={classes.txt}>ID</div>
                        <div >217217217</div>
                    </Box>
                    <Box className={classes.buttonBox}>
                        <Button variant = "contained" color = "primary" className = {classes.acceptButton}>Accept</Button>
                        <Button variant = "contained" color = "error" className = {classes.declineButton}>Decline</Button>
                    </Box>
                    
                </Box>
            </Box>
        </Box>
    );
}

export default PersonBox