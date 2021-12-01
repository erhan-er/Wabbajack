import * as React from 'react';
import AppBar from "../Components/AppBar";
import Accordion from "../Components/ActivityAccordion";
import Box from '@mui/material/Box';
import { makeStyles } from '@mui/styles';
import Button from "@mui/material/Button";


const style = makeStyles({
    root: {
 
    },
    remaining_budget:{
        margin: "0 auto",
        
    },
    budget_box: {
        margin: "0 auto",
        marginTop: "10px",
        marginLeft: "90px",
        width: "400px",
        height: "80px",
        border: "2px solid #000080",
        borderRadius: "15px",
        display: "flex",
        alignItems: "center"
    },

    amount_text:{
        margin: "0 auto",
        color: "white",

    },

    amount_box:{
        margin: "0 auto",
        backgroundColor: "#000080",
        width: "100px",
        height: "40px",
        border: "2px solid #000080",
        borderRadius: "5px",
        display: "flex",
        alignItems: "center"

    },

    old_events:{
        margin: "0 auto",
        marginTop: "15px",
        marginLeft: "6rem",
        fontSize: "40px",
        display: "flex",
        color: "#000080",
    },
 
    activity_box: {
       margin: "0 auto",
       width: "90%",
       marginTop: "2rem",
       
    },
 
 });

function Budget(){
    const classes = style();
    var activity1 = { activityName: "Activity 1", place: "B Building", date: "20/11/2021", time: "18:00", expense: "5000" };
    var activity2 = { activityName: "Activity 2", place: "A Building", date: "30/11/2021", time: "20:00" };
    var activity3 = { activityName: "Activity 3", place: "EA Building", date: "31/12/2021", time: "22:00" };
    var budget = "9999₺";

    return(
        <Box className={classes.root}>
             <AppBar PageName={"Budget"} />
             <Box className={classes.budget_box}>
                 <div className={classes.remaining_budget}>Remaining Budget: </div>
                 <Box className={classes.amount_box}>
                    <Box className={classes.amount_text}>{budget} </Box>
                 </Box>
             </Box>
            <div className={classes.old_events}>Old Events...</div>
            <Box className={classes.activity_box}>
                <Accordion {...activity1} PageName = {"Budget"}/>
                <Accordion {...activity2} />
                <Accordion {...activity3} />
             </Box>
        </Box>
    );
}


export default Budget