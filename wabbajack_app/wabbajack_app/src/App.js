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
import { useState } from 'react';

function App() {

  const dataStore = {
    myInfo: 0,
    clubs: [],
    students: [],
    events: [],
  };

  const store = createStore(rootReducer, dataStore);

  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [submitted, setSubmitted] = useState(false);

  async function handleLoginRequest() {
    setSubmitted(true)
    console.log(email)
    console.log(password)
    axios.post('http://localhost:5000/api/auth/login', {

      "mail": email,
      "password": password

    })
      .then(function (response) {
        if (response.status === 200) {
          setSubmitted(false)
          // setScreenNoNavbar("others")
        } else {
          console.log("Something went wrong")
        }

      })
      .catch(function (error) {
        console.log(error)
        setSubmitted(false)
      })
  }

  return (
    <Provider store={store}>
      <BrowserRouter>
        <Box className="App">
          <Routes>
            <Route path="/Add-Clubs" element={<AddClubs />} />
            <Route path="/Add-User" element={<AddUser />} />
            <Route path="/Budget" element={<Budget />} />
            <Route path="/Club-Page" element={<ClubPage />} />
            <Route path="/Create-Event" element={<CreateEvent />} />
            <Route path="/Edit-Club" element={<EditClubs />} />
            <Route path="/Event-Page" element={<EventPage />} />
            <Route path="/Event-Requests" element={<EventRequests />} />
            <Route path="/Followed-Clubs" element={<FollowedClubs />} />
            <Route path="/Home" element={<Home />} />
            <Route path="/Ignored-Clubs" element={<IgnoredClubs />} />
            <Route path="/Joined-Clubs" element={<JoinedClubs />} />
            <Route exact path="/" element={<LoginPage setEmail={setEmail} setPassword={setPassword} handleLoginRequest={handleLoginRequest} />} />
            <Route path="/My-Club" element={<MyClub />} />
            <Route path="/My-Information" element={<MyInformation />} />
            <Route path="/See-All-Club-Members" element={<SeeAllClubMembers />} />
            <Route path="/See-All-Clubs" element={<SeeAllClubs />} />
            <Route path="/See-All-Events" element={<SeeAllEvents />} />
            <Route path="/See-All-Friends" element={<SeeAllFriends />} />
            <Route path="/See-All-Students" element={<SeeAllStudents />} />
            <Route path="/Settings" element={<Settings />} />
          </Routes>
        </Box>
      </BrowserRouter>
    </Provider>
  );
}

export default App;
