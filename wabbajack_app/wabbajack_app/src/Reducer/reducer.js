import * as React from "react";
import axios from "axios";
import {
   ADD_USER, ADD_CLUB, DELETE_USER, DELETE_CLUB,
   ADD_FRIEND, REMOVE_FRIEND, JOIN_CLUB, WITHDRAW_CLUB,
   FOLLOW_CLUB, UNFOLLOW_CLUB, IGNORE_CLUB, UNIGNORE_CLUB,
   JOIN_EVENT, WITHDRAW_EVENT, INVITE_FRIEND, CHANGE_EMAIL,
   CHANGE_PASSWORD, ADD_CATEGORY, FILTER_EVENTS, EDIT_CLUB, 
   CREATE_EVENT
} from "./actions";

function reducer(state, action) {

   if (action.type === ADD_USER) {
      axios.post('http://localhost:5000/api/auth/register', {

         "name": action.payload.name,
         "password": action.payload.id,
         "mail": action.payload.email,
         "department": action.payload.img

      })
         .then(function (response) {
            if (response.status === 201) {
               console.log("User added!")
            } else {
               console.log("Something went wrong")
            }

         })
         .catch(function (error) {
            console.log(error)
         })
      // Payload contains: name, id, email, img
      // You can reach them by writing action.payload.name for example.
      console.log(action.payload); // You can also see the payloads in console
      return state; // do not change this. Redux wants a return.
   }
   if (action.type === ADD_CLUB) {
      console.log(action.payload);
      axios.post('http://localhost:5000/api/clubs/add', {
         "name": action.payload.name,
         "ClubDescription": action.payload.description,
         "bugdet": 0,
         "ImageURL": action.payload.img,
         "ClubPresidentID": action.payload.id,
         "Whatsapplink": action.payload.whatsapp,
         "Telegramlink": action.payload.Telegram,
         "Facebooklink": action.payload.Facebook,
         "Instagramlink": action.payload.Ingstagram,
         "Twitterlink": action.payload.Twitter,
         "Linkedinlink": action.payload.Linkedin

      })
         .then(function (response) {
            if (response.status === 201) {
               console.log("Club added!")
            } else {
               console.log("Something went wrong")
            }

         })
         .catch(function (error) {
            console.log(error)
         })
      return state;
   }
   if (action.type === EDIT_CLUB) {
      console.log(action.payload);
      axios.post('http://localhost:5000/api/clubs/edit', {
         "name": action.payload.name,
         "ClubDescription": action.payload.description,
         "bugdet": 0,
         "ImageURL": action.payload.img,
         "ClubPresidentID": action.payload.id,
         "Whatsapplink": action.payload.whatsapp,
         "Telegramlink": action.payload.Telegram,
         "Facebooklink": action.payload.Facebook,
         "Instagramlink": action.payload.Ingstagram,
         "Twitterlink": action.payload.Twitter,
         "Linkedinlink": action.payload.Linkedin

      })
         .then(function (response) {
            if (response.status === 201) {
               console.log("Club edited!")
            } else {
               console.log("Something went wrong")
            }

         })
         .catch(function (error) {
            console.log(error)
         })
      return state;
   }
   if (action.type === DELETE_USER) {
      axios.post('http://localhost:5000/api/users/delete', {

         "mail": action.payload.email
      })
         .then(function (response) {
            if (response.status === 201) {
               console.log("User deleted!")
            } else {
               console.log("Something went wrong")
            }

         })
         .catch(function (error) {
            console.log(error)
         })
      return state;
   }
   if (action.type === DELETE_CLUB) {
      axios.post('http://localhost:5000/api/clubs/delete', {
         "name": action.payload.name,

      })
         .then(function (response) {
            if (response.status === 201) {
               console.log("Club deleted!")
            } else {
               console.log("Something went wrong")
            }

         })
         .catch(function (error) {
            console.log(error)
         })
      return state;
   }
   if (action.type === ADD_FRIEND) {
      return state;
   }
   if (action.type === REMOVE_FRIEND) {
      return state;
   }
   if (action.type === JOIN_CLUB) {
      return state;
   }
   if (action.type === WITHDRAW_CLUB) {
      return state;
   }
   if (action.type === FOLLOW_CLUB) {
      return state;
   }
   if (action.type === UNFOLLOW_CLUB) {
      return state;
   }
   if (action.type === IGNORE_CLUB) {
      return state;
   }
   if (action.type === UNIGNORE_CLUB) {
      return state;
   }
   if (action.type === JOIN_EVENT) {
      console.log(action.payload);
      
      return state;
   }
   if (action.type === WITHDRAW_EVENT) {
      return state;
   }
   if (action.type === INVITE_FRIEND) {
      return state;
   }
   if (action.type === CHANGE_EMAIL) {
      return state;
   }
   if (action.type === CHANGE_PASSWORD) {
      return state;
   }
   if (action.type === ADD_CATEGORY) {
      return state;
   }
   if (action.type === FILTER_EVENTS) {
      return state;
   }
   if (action.type === CREATE_EVENT) {
      return state;
   } 
   return state;
}

export default reducer