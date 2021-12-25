import * as React from "react";
import axios from "axios";
import {
   ADD_USER, ADD_CLUB, DELETE_USER, DELETE_CLUB,
   ADD_FRIEND, REMOVE_FRIEND, JOIN_CLUB, WITHDRAW_CLUB,
   FOLLOW_CLUB, UNFOLLOW_CLUB, IGNORE_CLUB, UNIGNORE_CLUB,
   JOIN_EVENT, WITHDRAW_EVENT, INVITE_FRIEND, CHANGE_EMAIL,
   CHANGE_PASSWORD, ADD_CATEGORY, FILTER_EVENTS, EDIT_CLUB
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
         "description": action.payload.description,
         "bugdet": 0,
         "ImageURL": action.payload.img,
         "ClubPresidentID": action.payload.id,
         "Whatsapplink": action.payload.whatsapp,
         "Telegramlink": action.payload.Telegram,
         "Facebooklink": action.payload.Facebook,
         "Ingstagramlink": action.payload.Ingstagram,
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
   if ( action.type === EDIT_CLUB ) {
      console.log(action.payload);
      return state;
   }

   if (action === DELETE_USER) {
      return state;
   }
   if (action === DELETE_CLUB) {
      return state;
   }
   if (action === ADD_FRIEND) {
      return state;
   }
   if (action === REMOVE_FRIEND) {
      return state;
   }
   if (action === JOIN_CLUB) {
      return state;
   }
   if (action === WITHDRAW_CLUB) {
      return state;
   }
   if (action === FOLLOW_CLUB) {
      return state;
   }
   if (action === UNFOLLOW_CLUB) {
      return state;
   }
   if (action === IGNORE_CLUB) {
      return state;
   }
   if (action === UNIGNORE_CLUB) {
      return state;
   }
   if (action === JOIN_EVENT) {
      return state;
   }
   if (action === WITHDRAW_EVENT) {
      return state;
   }
   if (action === INVITE_FRIEND) {
      return state;
   }
   if (action === CHANGE_EMAIL) {
      return state;
   }
   if (action === CHANGE_PASSWORD) {
      return state;
   }
   if (action === ADD_CATEGORY) {
      return state;
   }
   if (action === FILTER_EVENTS) {
      return state;
   }
   return state;
}

export default reducer