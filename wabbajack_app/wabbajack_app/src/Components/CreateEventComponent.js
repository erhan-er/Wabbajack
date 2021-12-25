import { Box, Select, MenuItem, FormControl, InputLabel, Button } from "@mui/material";
import { makeStyles } from "@mui/styles";
import * as React from "react";
import { useState, useEffect } from "react";
import { connect } from "react-redux";
import { CREATE_EVENT } from "../Reducer/actions";

const style = makeStyles({
   root: {
      width: "90%",
      marginTop: "25px",
   },

   body: {

   },

   body_top: {
      width: "100%",
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
   },

   body_top_left: {
      width: "70%",
      display: "flex",
      flexDirection: "column",
      justifyContent: "space-between",
      height: "360px",
   },

   body_top_right: {
      width: "25%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      //height: "360px",
   },

   name: {
      height: "42px",
      //width: "100%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      fontFamily: "inherit",
   },

   description: {
      //width: "100%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      fontFamily: "inherit",
      resize: "none",
   },

   building: {
      //border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      width: "100%",
   },

   body_bottom: {
      width: "100%",
      display: "flex",
      flexDirection: "row",
      marginTop: "25px",
      justifyContent: "space-between",
   },

   body_bottom_left: {
      width: "70%",
   },

   body_bottom_left_top: {
      width: "100%",
   },

   body_bottom_left_bottom: {
      display: "flex",
      flexDirection: "row",
      justifyContent: "space-between",
      marginTop: "20px",

   },

   body_bottom_left_bottom_right: {
      width: "60%",
   },

   budget: {
      width: "99%",
      resize: "none",
      fontFamily: "inherit",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },

   body_bottom_left_bottom_left: {
      width: "35%",
      display: "flex",
      flexDirection: "column",
      justifyContent: "space-between",
   },

   date: {
      width: "50%",
      marginBottom: "20px",
      margin: "0 auto",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
   },

   time: {
      width: "50%",
      marginBottom: "20px",
      margin: "0 auto",
      height: "42px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
   },

   body_bottom_right: {
      width: "25%",
   },

   space: {
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      height: "120px",
   },

   space_description: {
      marginBottom: "10px",
      marginTop: "10px",
      color: "rgba(0, 0, 0, 0.5)",
   },

   number: {
      width: "80%",
      marginTop: "5px",
      height: "36px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
   },

   img: {
      marginTop: "30px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      height: "120px",
   },
});
function CreateEventComponent({ buildings, places, categories, clubs, myInfo, dispatch}) {
   const classes = style();
   //var building = "";
   //var place = "";
   //var category = "";
   const [building, setBuilding] = useState("");
   const [place, setPlace] = useState("");
   const [category, setCategory] = useState("");

   const handleBuilding = (event) => {
      building = event.target.value;
      setBuilding(event.target.value);
      console.log(building);
   }

   const handleClass = (event) => {
      place = event.target.value;
      setPlace(event.target.value);
      console.log(place);
   }

   const handleCategory = (event) => {
      category = event.target.value;
      setCategory(event.target.value);
      console.log(category);
   }

   useEffect(() => {
      console.log(building);
   }, [building, place, category])
   

   function PlacePrinter() {
      if ( building === "" ) {
         places.map((filterPlace, index) => {
            return <MenuItem value={filterPlace.room} key = {index}>{filterPlace.room}</MenuItem>
         })
      }
      else if ( building !== "" ) {
         places.filter((place) => place.building === building).map((filterPlace, index) => {
            return <MenuItem value={filterPlace} key = {index}>{filterPlace}</MenuItem>
         });
      }
      else {
         return 0;
      }
   }

   function handleCreate() {
      var clubName = "";
      var clubId = "";
      for ( let i = 0; i < clubs.length; i++ ) {
         if ( clubs[i].clubPresidentID === myInfo.id )
            clubId = clubs[i].id;
            clubName = clubs[i].name;
      }
      dispatch({type: CREATE_EVENT, payload: {name: document.getElementById("Name").value, 
                                             clubName: clubName,
                                             clubId: clubId,
                                             presidentId: myInfo.id,
                                             description: document.getElementById("Description").value, 
                                             building: building, 
                                             room: place, 
                                             date: document.getElementById("Date").value,
                                             time: document.getElementById("Time").value,
                                             category: category, 
                                             budget: document.getElementById("Budget").value,
                                             capacity: document.getElementById("space").value,
                                             img: document.getElementById("image").value}})
   }

   return (
      <Box className={classes.root}>
         <Box className={classes.body}>
            <Box className={classes.body_top}>
               <Box className={classes.body_top_left}>
                  <input type="text" id="Name" placeholder="Name of The Event" className={classes.name} />
                  <textarea name="Description" id="Description" cols="30" rows="10" className={classes.description} placeholder="Description" />
                  <FormControl className={classes.building}>
                     <InputLabel>Building</InputLabel>
                     <Select
                        id="Building"
                        value={buildings}
                        label="Building"
                        onChange={handleBuilding}
                     >
                        {
                           buildings.map((building, index) => {
                              console.log(building);
                              return(
                                 <MenuItem value={building} key = {index}>{building}</MenuItem>
                              );
                           })
                        }
                     </Select>
                  </FormControl>
               </Box>
               <Box className={classes.body_top_right}>

               </Box>
            </Box>
            <Box className={classes.body_bottom}>
               <Box className={classes.body_bottom_left}>
                  <Box className={classes.body_bottom_left_top}>
                     <FormControl className={classes.building}>
                        <InputLabel>Class</InputLabel>
                        <Select
                           id="Place"
                           value={places}
                           label="Classes"
                           onChange={handleClass}
                        >
                           {
                              PlacePrinter()
                           }
                        </Select>
                     </FormControl>
                  </Box>
                  <Box className={classes.body_bottom_left_bottom}>
                     <Box className={classes.body_bottom_left_bottom_left}>
                        <Box className={classes.category}>
                           <FormControl className={classes.building}>
                              <InputLabel>Category</InputLabel>
                              <Select
                                 id="Category"
                                 value={categories}
                                 label="Category"
                                 onChange={handleCategory}
                              >
                                 {
                                    categories.map((category, index) => {
                                       return <MenuItem value={category.categoryName} key = {index}>{category.categoryName}</MenuItem>
                                    })
                                 }
                              </Select>
                           </FormControl>
                        </Box>
                        <input type="date" id="Date" placeholder="Date" className={classes.date} />
                        <input type="time" name="Time" id="Time" className={classes.time} />
                     </Box>
                     <Box className={classes.body_bottom_left_bottom_right}>
                        <textarea name="Budget" id="Budget" cols="30" rows="15" placeholder="Budget Description" className={classes.budget} />
                     </Box>
                  </Box>
               </Box>
               <Box className={classes.body_bottom_right}>
                  <Box className={classes.space}>
                     <Box className={classes.space_description}>Number of Seats: If the number of seats is determined as 0, there will be no limits to seats.</Box>
                     <input type="number" name="space" id="space" className={classes.number} />
                  </Box>
                  <Box className={classes.img}>
                     <Box className={classes.space_description}>Upload Image: If the image is not uploaded, the club's logo will be shown to students.</Box>
                     <input type="url" name="image" id="image" className={classes.number} />
                     <Button variant="contained" color="primary" sx={{ marginTop: "50px" }} onClick = {() => handleCreate()}
                     >
                        Create Event
                     </Button>
                  </Box>
               </Box>
            </Box>
         </Box>
      </Box>
   );
}
const mapToStateToProps = state => {
   return { buildings: state.buildings, places: state.places, categories: state.categories, clubs: state.clubs, myInfo: state.myInfo }
}
export default connect(mapToStateToProps)(CreateEventComponent)