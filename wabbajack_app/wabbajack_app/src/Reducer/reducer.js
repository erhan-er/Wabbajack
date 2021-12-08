import * as React from "react";
import { ADD_USER, ADD_CLUB, DELETE_USER, DELETE_CLUB, 
         ADD_FRIEND, REMOVE_FRIEND, JOIN_CLUB, WITHDRAW_CLUB, 
         FOLLOW_CLUB, UNFOLLOW_CLUB, IGNORE_CLUB, UNIGNORE_CLUB, 
         JOIN_EVENT, WITHDRAW_EVENT, INVITE_FRIEND, CHANGE_EMAIL, 
         CHANGE_PASSWORD, ADD_CATEGORY, FILTER_EVENTS } from "./actions";

function reducer(state, action) {

   if ( action === ADD_USER ) {
      return state;
   }
   if ( action === ADD_CLUB ) {
      return state;
   }
   if ( action === DELETE_USER ) {
      return state;
   }
   if ( action === DELETE_CLUB ) {
      return state;
   }
   if ( action === ADD_FRIEND ) {
      return state;
   }
   if ( action === REMOVE_FRIEND ) {
      return state;
   }
   if ( action === JOIN_CLUB ) {
      return state;
   }
   if ( action === WITHDRAW_CLUB ) {
      return state;
   }
   if ( action === FOLLOW_CLUB ) {
      return state;
   }
   if ( action === UNFOLLOW_CLUB ) {
      return state;
   }
   if ( action === IGNORE_CLUB ) {
      return state;
   }
   if ( action === UNIGNORE_CLUB ) {
      return state;
   }
   if ( action === JOIN_EVENT ) {
      return state;
   }
   if ( action === WITHDRAW_EVENT ) {
      return state;
   }
   if ( action === INVITE_FRIEND ) {
      return state;
   }
   if ( action === CHANGE_EMAIL ) {
      return state;
   }
   if ( action === CHANGE_PASSWORD ) {
      return state;
   }
   if ( action === ADD_CATEGORY ) {
      return state;
   }
   if ( action === FILTER_EVENTS ) {
      return state;
   }
   return state;
}

export default reducer