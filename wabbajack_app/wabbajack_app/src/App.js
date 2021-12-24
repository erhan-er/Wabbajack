import './App.css';

import AddClubs from "./Pages/AddClubs";
import AddUser from "./Pages/AddUser";
import Budget from "./Pages/Budget";
import ClubPage from './Pages/ClubPage';
import CreateEvent from './Pages/CreateEvent';
import EditClubs from "./Pages/EditClubs";
import EventPage from "./Pages/EventPage";
import EventRequests from "./Pages/EventRequests";
import FollowedClubs from "./Pages/FollowedClubs";
import Home from "./Pages/Home";
import IgnoredClubs from "./Pages/IgnoredClubs";
import JoinedClubs from "./Pages/JoinedClubs";
import LoginPage from "./Pages/LoginPage";
import MyClub from "./Pages/MyClub";
import MyInformation from "./Pages/MyInformation";
import SeeAllClubMembers from "./Pages/SeeAllClubMembers";
import SeeAllClubs from './Pages/SeeAllClubs';
import SeeAllEvents from './Pages/SeeAllEvents';
import SeeAllFriends from './Pages/SeeAllFriends';
import SeeAllStudents from './Pages/SeeAllStudents';
import Settings from "./Pages/Settings";
import Box from "@mui/material/Box";
import axios from 'axios';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import rootReducer from "./Reducer/reducer";
import { createStore } from "redux";
import { Provider } from "react-redux";
import { useEffect, useState } from 'react';
import ProtectedRoute from "./ProtectedRoute";

function App() {

  const dataStore = {
    myInfo: 0,
    clubs: [],
    students: [],
    events: [],
  };

  const store = createStore(rootReducer, dataStore);

  var email = "";
  var password = "";
  var loginSuccessfull = false;
  const [signin, setSignin] = useState(false);
  const [submitted, setSubmitted] = useState(false);

  function setEmailPassword(newEmail, newPassword) {
    email = newEmail;
    password = newPassword;
    loginSuccessfull = true;
    console.log(loginSuccessfull);
  }
  
  async function handleLoginRequest() {
    setSubmitted(true)
    console.log(email)
    console.log(password)
    console.log(loginSuccessfull);
    /*
    axios.post('http://localhost:5000/api/auth/login', {

      "mail": email,
      "password": password

    })
      .then(function (response) {
        if (response.status === 200) {
          setSubmitted(false)
          loginSuccessfull = true;
        } else {
          console.log("Something went wrong")
        }

      })
      .catch(function (error) {
        console.log(error)
        setSubmitted(false)
      })*/
  } 
  
  return (
    <Provider store={store}>
      <BrowserRouter>
        <Box className="App">
          <Routes>
            <Route path="/Add-Clubs" element={<ProtectedRoute authed = {signin}><AddClubs /></ProtectedRoute>} />
            <Route path="/Add-User" element={<ProtectedRoute authed = {signin}><AddUser /></ProtectedRoute>} />
            <Route path="/Budget" element={<ProtectedRoute authed = {signin}><Budget /></ProtectedRoute>} />
            <Route path="/Club-Page" element={<ProtectedRoute authed = {signin}><ClubPage /></ProtectedRoute>} />
            <Route path="/Create-Event" element={<ProtectedRoute authed = {signin}><CreateEvent /></ProtectedRoute>} />
            <Route path="/Edit-Club" element={<ProtectedRoute authed = {signin}><EditClubs /></ProtectedRoute>} />
            <Route path="/Event-Page" element={<ProtectedRoute authed = {signin}><EventPage /></ProtectedRoute>} />
            <Route path="/Event-Requests" element={<ProtectedRoute authed = {signin}><EventRequests /></ProtectedRoute>} />
            <Route path="/Followed-Clubs" element={<ProtectedRoute authed = {signin}><FollowedClubs /></ProtectedRoute>} />
            <Route path="/Home" element={<ProtectedRoute authed = {signin}> <Home /> </ProtectedRoute>} />
            <Route path="/Ignored-Clubs" element={<ProtectedRoute authed = {signin}><IgnoredClubs /></ProtectedRoute>} />
            <Route path="/Joined-Clubs" element={<ProtectedRoute authed = {signin}><JoinedClubs /></ProtectedRoute>} />
            <Route exact path="/" element={<LoginPage setEmailPassword={setEmailPassword} setSignin = {setSignin} handleLoginRequest={handleLoginRequest} />}/>
            <Route path="/My-Club" element={<ProtectedRoute authed = {signin}><MyClub /></ProtectedRoute>} />
            <Route path="/My-Information" element={<ProtectedRoute authed = {signin}><MyInformation /></ProtectedRoute>} />
            <Route path="/See-All-Club-Members" element={<ProtectedRoute authed = {signin}><SeeAllClubMembers /></ProtectedRoute>} />
            <Route path="/See-All-Clubs" element={<ProtectedRoute authed = {signin}><SeeAllClubs /></ProtectedRoute>} />
            <Route path="/See-All-Events" element={<ProtectedRoute authed = {signin}><SeeAllEvents /></ProtectedRoute>} />
            <Route path="/See-All-Friends" element={<ProtectedRoute authed = {signin}><SeeAllFriends /></ProtectedRoute>} />
            <Route path="/See-All-Students" element={<ProtectedRoute authed = {signin}><SeeAllStudents /></ProtectedRoute>} />
            <Route path="/Settings" element={<ProtectedRoute authed = {signin}><Settings /></ProtectedRoute>} />
          </Routes>
        </Box>
      </BrowserRouter>
    </Provider>
  );
}

export default App;
