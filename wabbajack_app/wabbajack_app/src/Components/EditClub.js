import { makeStyles } from "@mui/styles";
import { borderRadius, Box } from "@mui/system";
import * as React from "react";
import TextField from '@mui/material/TextField';
import Button from "@mui/material/Button";
import WhatsAppIcon from '@mui/icons-material/WhatsApp';
import LinkedInIcon from '@mui/icons-material/LinkedIn';
import TwitterIcon from '@mui/icons-material/Twitter';
import TelegramIcon from '@mui/icons-material/Telegram';
import InstagramIcon from '@mui/icons-material/Instagram';
import FacebookIcon from '@mui/icons-material/Facebook';
import { connect } from "react-redux";
import { EDIT_CLUB } from "../Reducer/actions";

const style = makeStyles({
   root: {
      marginTop: "5vw",
      width: "90%",
   },

   club_name: {
      height: "56px",
      width: "100%",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      fontFamily: "inherit"
   },
   
   description: {
      marginTop: "2vw",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      maxWidth: "100%",
      resize: "none",
      height: "120px",
      fontFamily: "inherit",
   },

   bottom_body: {
      marginTop: "2vw",
      display: "flex",
      justifyContent: "space-between",
      flexDirection: "row",
      "@media screen and (max-width: 960px)": {
         flexDirection: "column",
      },
   },

   image: {
      width: "40%",
      borderRadius: "10px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      height: "480px",
      "@media screen and (max-width: 960px)": {
         width: "100%",
      },
   },

   image_header: {
      margin: "0 auto",
      width: "90%",
      marginTop: "5px",
      fontSize: "16px",
      color: "rgba(0, 0, 0, 0.5)",
   },

   image_input: {
      width: "90%",
      height: "24px",
   },

   preview_button: {
      marginTop: "2vw",
      marginBottom: "2vw",
   },

   image_preview: {
      maxWidth: "480px",
      maxHeight: "480px",
      borderRadius: "10px",
   },

   links: {
      width: "50%",
      borderRadius: "10px",
      border: "solid 1px rgba(0, 0, 0, 0.5)", 
      height: "480px",
      "@media screen and (max-width: 960px)": {
         marginTop: "2vw",
         width: "100%",
         height: "720px",
      },
      display: "flex",
      flexDirection: "column",
   },

   social_media_header: {
      display: "flex",
      justifyContent: "center",
      marginTop: "10px",
      fontSize: "20px",
      color: "rgba(0, 0, 0, 0.5)",
      width: "100%",
      height: "20px",
      
   },

   link_outer_box: {
      marginTop: "10px",
      width: "100%",
      display: "flex",
      justifyContent: "space-evenly",
      height: "100%",
      flexWrap: "wrap",
      "@media screen and (max-width: 960px)": {
         justifyContent: "center",
         flexDirection: "row",
      },
   },

   link_box: {
      width: "45%",
      height: "96px",
      border: "solid 1px rgba(0, 0, 0, 0.5)",
      borderRadius: "10px",
      "@media screen and (max-width: 960px)": {
         width: "90%",
      },
   },

   link_box_header: {
      fontSize: "16px",
      color: "rgba(0, 0, 0, 0.5)",
      marginTop: "5px",
      marginLeft: "5px",
      textAlign: "start",
      margin: "0",
      display: "flex",
      flexDirection: "row",
   },
   
   link: {
      border: "none",
      maxWidth: "98%",
      height: "100%",
      resize: "none",
      "&:focus": {
         border: "none",
         outline: "none",
      },
   },

});

function EditClub ({ClubName = "Club Name", Description = "Description", Links, PageName, dispatch}) {

   const classes = style();
   function preview( url ) {
      document.getElementById("image").src = url;
   }

   return (
      <Box className = {classes.root}>
         <Box>
            <form action="">
               <input type="text" id = "ClubName" placeholder = {ClubName} className = {classes.club_name}/>
               <textarea 
                  name="Description" 
                  id="Description" 
                  cols = "500"
                  className = {classes.description} 
                  placeholder = {Description}/>
            </form>
         </Box>
         <Box className = {classes.bottom_body}>
            <Box className = {classes.image}>
               <Box className = {classes.image_header}>
                  Enter An Image URL: If the image is not uploaded, Bilkent's logo will be shown to users.
               </Box>
               <Box sx = {{marginTop: "20px"}}>
                  <input type="url" id = "imageURL" className = {classes.image_input}/>
                  <Button variant = "contained" color = "primary" className = {classes.preview_button} onClick = {() => preview(document.getElementById("imageURL").value)}>Preview</Button>
               </Box>
               <img  alt="Enter An URL" id = "image" className = {classes.image_preview}/>
            </Box>
            <Box className = {classes.links}>
               <Box className = {classes.social_media_header}>Social Media</Box>
               <Box className = {classes.link_outer_box}>
                  <Box className = {classes.link_box}>
                     <Box className = {classes.link_box_header}>
                        <Box>WhatsApp</Box>
                        <Box><WhatsAppIcon sx = {{fontSize: "20px", marginLeft: "5px"}}/></Box>
                     </Box>
                     <Box>
                        <textarea id="WhatsApp" cols="3000" className = {classes.link}/>
                     </Box>
                  </Box>
                  <Box className = {classes.link_box}>
                     <Box className = {classes.link_box_header}>
                        <Box>Linked In</Box>
                        <Box><LinkedInIcon sx = {{fontSize: "20px", marginLeft: "5px"}}/></Box>
                     </Box>
                     <Box>
                        <textarea id="Linkedin" cols="3000" className = {classes.link}/>
                     </Box>
                  </Box>
                  <Box className = {classes.link_box}>
                     <Box className = {classes.link_box_header}>
                        <Box>Telegram</Box>
                        <Box><TelegramIcon sx = {{fontSize: "20px", marginLeft: "5px"}}/></Box>
                     </Box>
                     <Box>
                        <textarea id="Telegram" cols="3000" className = {classes.link}/>
                     </Box>
                  </Box>
                  <Box className = {classes.link_box}>
                     <Box className = {classes.link_box_header}>
                        <Box>Twitter</Box>
                        <Box><TwitterIcon sx = {{fontSize: "20px", marginLeft: "5px"}}/></Box>
                     </Box>
                     <Box>
                        <textarea id="Twitter" cols="3000" className = {classes.link}/>
                     </Box>
                  </Box>
                  <Box className = {classes.link_box}>
                     <Box className = {classes.link_box_header}>
                        <Box>Instagram</Box>
                        <Box><InstagramIcon sx = {{fontSize: "20px", marginLeft: "5px"}}/></Box>
                     </Box>
                     <Box>
                        <textarea id="Instagram" cols="3000" className = {classes.link}/>
                     </Box>
                  </Box>
                  <Box className = {classes.link_box}>
                     <Box className = {classes.link_box_header}>
                        <Box>Facebook</Box>
                        <Box><FacebookIcon sx = {{fontSize: "20px", marginLeft: "5px"}}/></Box>
                     </Box>
                     <Box>
                        <textarea id="Facebook" cols="3000" className = {classes.link}/>
                     </Box>
                  </Box>
               </Box>
            </Box>
         </Box>
         <Button 
            variant = "contained" 
            color = "success" 
            sx = {{marginTop: "2vw", marginBottom: "5vw", width: "100%", height: "42px",}}
            onClick = {() => dispatch({type: EDIT_CLUB, payload: {name: document.getElementById("ClubName").value, 
                                                                  description: document.getElementById("Description").value,
                                                                  img: document.getElementById("imageURL").value,
                                                                  whatsapp: document.getElementById("WhatsApp").value,
                                                                  Telegram: document.getElementById("Telegram").value,
                                                                  Facebook: document.getElementById("Facebook").value,
                                                                  Ingstagram: document.getElementById("Instagram").value,
                                                                  Twitter: document.getElementById("Twitter").value,
                                                                  Linkedin: document.getElementById("Linkedin").value}})}
         >
            {PageName === "Edit Club"? "Edit Club" : "Add Club"}
         </Button>
      </Box>     
   );
}

const mapStateToProps = state => {
   return { state }
}

export default connect(mapStateToProps)(EditClub)