import * as React from "react";
import axios from "axios";
import {
   ADD_USER, ADD_CLUB, DELETE_USER, DELETE_CLUB,
   ADD_FRIEND, REMOVE_FRIEND, JOIN_CLUB, WITHDRAW_CLUB,
   FOLLOW_CLUB, UNFOLLOW_CLUB, IGNORE_CLUB, UNIGNORE_CLUB,
   JOIN_EVENT, WITHDRAW_EVENT, INVITE_FRIEND, CHANGE_PASSWORD,
   ADD_CATEGORY, FILTER_EVENTS, EDIT_CLUB, CREATE_EVENT,
   CLUB_FILTER, STUDENT_CREATE_EVENT, RESET_PASSWORD
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
      // how to use ownProps
      // action.payload.ownProps.id
      // action.payload.ownProps.name
      // action.payload.ownProps.mail
      // action.payload.ownProps.department
      // It represents the whole props of a function.
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
   if (action.type === CHANGE_PASSWORD) {
      console.log(action.payload);
      axios.post('http://localhost:5000/api/users/' + state.myInfo.id + '/changepassword', {

         "mail": action.payload.email,
         "password": action.payload.newPassword,
         "confirmpassword": action.payload.confirmPassword,
         "oldpassword": action.payload.currentPassword

      })
         .then(function (response) {
            if (response.status === 201) {
               console.log("Password changed!")
            } else {
               console.log("Something went wrong")
            }

         })
         .catch(function (error) {
            console.log(error)
         })
      console.log(state.myInfo);
      return state;
   }
   if (action.type === ADD_CATEGORY) {
      return state;
   }
   if (action.type === FILTER_EVENTS) {
      return state;
   }
   if (action.type === CREATE_EVENT) {
      console.log("geldin");
      console.log(state.myInfo.id)
      var link = "";
      if (state.myInfo.discriminator === "Student") {
         link = "users/create/"
      }
      else {
         link = "events/create"
      }
      axios.post('http://localhost:5000/api/' + link, {
         "clubID": action.payload.clubId,
         "eventCost": action.payload.budget,
         "capacity": action.payload.capacity,
         "userId": state.myInfo.id,
         "placeName": action.payload.building + "-" + action.payload.room,
         "date": action.payload.date + " " + action.payload.time + ":00",
         "categoryName": action.payload.category,
         "clubname": action.payload.clubName,
         "imageURL": action.payload.img,
         "name": action.payload.name,
         "description": action.payload.description

      }).then(function (response) {
         if (response.status === 201) {
            console.log("Event added!")
         } else {
            console.log("Something went wrong")
         }

      }).catch(function (error) {
         console.log(error)
      })
      console.log(action.payload);
      return state;
   }
   if (action.type === CLUB_FILTER) {
      var newFilteredEvents = state.filteredEvents.filter((event) => event.clubID === action.payload.id);
      return { ...state, filteredEvents: newFilteredEvents }
   }
   if (action.type === STUDENT_CREATE_EVENT) {
      return state;
   }
   if (action.type === RESET_PASSWORD) {
      console.log(action.payload);
      axios.post('http://localhost:5000/api/auth/login/resetpassword', {

         "mail": action.payload.email
      })
         .then(function (response) {
            if (response.status === 201) {
               console.log("New Password Sent!")
            } else {
               console.log("Something went wrong")
            }

         })
         .catch(function (error) {
            console.log(error)
         })
      return state;
   }
   return state;
}

export default reducer