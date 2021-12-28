import * as React from "react";
import Appbar from "../Components/AppBar";
import Photo from "../Images/Bilkent.png"
import { Box, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import JoinedUsers from "../Components/EventDetailJoinedUsers";
import { useLocation } from "react-router-dom";
import { connect } from "react-redux";
import { JOIN_EVENT, WITHDRAW_EVENT } from "../Reducer/actions";
import { useEffect } from "react";

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

   image: {
      width: "350px",
      height: "350px",
      //backgroundColor: "#f1f2f3",
      //border: "solid 1px rgba(0, 0, 0, 0.5)",
      //borderRadius: "10px",
   },

   description_box: {
      width: "75%",
      textAlign: "left",
      lineHeight: "32px",
      "@media screen and (max-width: 1080px)": {
         width: "100%"
      }
   },

   club_name: {
      fontSize: "24px",
   },

   activity_name: {

   },

   description: {

   },

   info: {

   },

   date: {

   },

   time: {

   },

   place: {

   },

   category: {

   },

   button_box: {
      display: "flex",
      justifyContent: "end",
      marginBottom: "10px",
      "@media screen and (max-width: 1080px)": {
         flexDirection: "column"
      }
   },

   button: {
      marginLeft: "10px",
      width: "256px",
      "@media screen and (max-width: 1080px)": {
         width: "100%",
         marginTop: "15px",
         marginLeft: 0,
      }
   },

   border: {
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      marginBottom: "25px",
   },

   users: {
      display: "flex",
      flexDirection: "column",
   },

   students: {
      marginTop: "10px",
      display: "flex",
      flexDirection: "row",
      flexWrap: "wrap",
      justifyContent: "space-between",
   },

   search_box: {
      width: "100%",
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
      "@media screen and (max-width: 1080px)": {
         flexDirection: "column",
      }
   },

   search: {
      width: "40%",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      "@media screen and (max-width: 1080px)": {
         width: "100%",
         marginBottom: "10px",
      }
   },

   student: {
      marginTop: "10px",
   }

});

function EventDetail({ joinedEvents, students, myInfo, dispatch }) {
   const classes = style();
   const location = useLocation();

   function printJoinedUser() {
      var joined = [];
      joinedEvents.filter((item) => item.eventId === location.state.id).map((event, index) => {
         var i;
         for (i = 0; i < students.length; i++) {
            if (students[i].id === event.id)
               joined.push(students[i]);
         }
      })
      return (
         joined.map((user, index) => {
            return <JoinedUsers {...user} />
         })
      );

   }

   function joinedUsers() {
      if (myInfo.discriminator === "ClubPresident") {
         return (
            <Box className={classes.users}>
               <Box className={classes.search_box}>
                  <input type="search" name="Name" id="SearchByName" placeholder="Search By Name" className={classes.search} />
                  <input type="search" name="ID" id="SearchById" placeholder="Search By ID" className={classes.search} />
               </Box>
               <Box className={classes.students}>
                  {
                     printJoinedUser()
                  }
               </Box>
            </Box>
         );
      }
   }

   function isJoined() {
      var isJoin = false;
      for (var i = 0; i < joinedEvents.length; i++) {
         if (joinedEvents[i].userId === myInfo.id && joinedEvents[i].eventId === location.state.id) {
            isJoin = true;
            break;
         }
      }

      if (!isJoin)
         return (
            <Button
               variant="contained"
               color="primary"
               className={classes.button}
               onClick={() => { dispatch({ type: JOIN_EVENT, payload: { ID: location.state.id } }); }}
            >
               Join
            </Button >
         );
      else
         return (
            <Button
               variant="contained"
               color="error"
               className={classes.button}
               onClick={() => { dispatch({ type: WITHDRAW_EVENT, payload: { ID: location.state.id } }) }}
            >
               Withdraw
            </Button>
         );
   }

   useEffect(() => { }, [joinedEvents]);

   return (
      <Box className={classes.root}>
         <Appbar PageName={"Event Detail"} />
         <Box className={classes.body}>
            <Box className={classes.detail}>
               <img src={location.state.imageURL} alt={location.state.clubName} className={classes.image} />
               <Box className={classes.description_box}>
                  <Box className={classes.club_name}><strong>{location.state.clubName}</strong></Box>
                  <Box className={classes.activity_name}><strong>{location.state.name}</strong></Box>
                  <Box className={classes.description}><strong>Description: </strong>{location.state.description}</Box>
                  <Box className={classes.info}>
                     <Box className={classes.date}><strong>Date: </strong>{location.state.date}</Box>
                     <Box className={classes.place}><strong>Place: </strong>{location.state.placeID}</Box>
                     <Box className={classes.category}><strong>Category: </strong>{location.state.categoryName}</Box>
                  </Box>
               </Box>
            </Box>
            <Box className={classes.button_box}>
               <Button variant="contained" color="success" className={classes.button}>Invite Friends</Button>
               {isJoined()}
            </Box>
            <Box className={classes.border}></Box>
            {joinedUsers()}
         </Box>

      </Box>
   );
}

const mapToStateToProps = state => {
   return { joinedEvents: state.joinedEvents, students: state.students, myInfo: state.myInfo }
}
export default connect(mapToStateToProps)(EventDetail)