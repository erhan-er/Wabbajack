import './App.css';

import AddClubs from "./Pages/AddClubs";
import AddUser from "./Pages/AddUser";
import Budget from "./Pages/Budget";
import ClubPage from './Pages/ClubPage';
import CreateEvent from './Pages/CreateEvent';
import EditClubs from "./Pages/EditClubs";
import EventDetail from "./Pages/EventDetail";
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
import StudentCreateEvent from "./Pages/StudentCreateEvent";
import ForgetPassword from "./Pages/ForgetPassword";

import Box from "@mui/material/Box";
import axios from 'axios';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import rootReducer from "./Reducer/reducer";
import { createStore } from "redux";
import { Provider } from "react-redux";
import { useEffect, useState } from 'react';
import ProtectedRoute from "./ProtectedRoute";

function App() {

  var email = "";
  var password = "";
  const [signin, setSignin] = useState(false);
  const [submitted, setSubmitted] = useState(false);
  const [myInfo, setMyInfo] = useState(0);
  const [clubs, setClubs] = useState([]);
  const [students, setStudents] = useState([]);
  const [events, setEvents] = useState([]);
  const [categories, setCategories] = useState([]);
  const [places, setPlaces] = useState([]);
  const [buildings, setBuildings] = useState([]);
  const [mail, setMail] = useState("");

  const dataStore = {
    myInfo: myInfo,
    clubs: clubs,
    students: students,
    events: events,
    categories: categories,
    places: places,
    buildings: buildings,
    filteredEvents: events,
    filteredClubs: clubs,
    signin: signin
  };

  const store = createStore(rootReducer, dataStore);

  function setEmailPassword(newEmail, newPassword) {
    setMail(newEmail);
    email = newEmail;
    password = newPassword;
    //setSignin(true); // delete this
    console.log(signin);
  }

  async function handleLoginRequest() {
    setSubmitted(true)

    axios.post('http://localhost:5000/api/auth/login', {

      "mail": email,
      "password": password

    })
      .then(function (response) {
        if (response.status === 200) {
          setSubmitted(false)
          setSignin(true);
        } else {
          console.log("Something went wrong")
          setSignin(false);
        }

      })
      .catch(function (error) {
        console.log(error)
        setSubmitted(false)
      })
  }

  function fetchClubs() {
    axios.get("http://localhost:5000/api/clubs").then((res) => {
      setClubs(new Array(res.data.length).fill(0));
      const newClubs = res.data.map((club, index) => {
        return club
      });

      setClubs(newClubs);
    });
  }

  function fetchUsers() {
    axios.get("http://localhost:5000/api/users").then((res) => {
      setStudents(new Array(res.data.length).fill(0));
      const newStudents = res.data.map((student, index) => {
        return student
      });

      setStudents(newStudents);
    });
  }

  function fetchEvents() {
    axios.get("http://localhost:5000/api/events").then((res) => {
      setEvents(new Array(res.data.length).fill(0));
      const newEvents = res.data.map((event, index) => {
        return event
      });


      setEvents(newEvents);
    });
  }

  function fetchUserInfo() {
    axios.get("http://localhost:5000/api/users/mail/" + mail).then((res) => {
      console.log(mail);
      console.log(res.data);
      setMyInfo(res.data);
    });
  }

  function fetchCategories() {
    axios.get("http://localhost:5000/api/categories").then((res) => {
      setCategories(new Array(res.data.length).fill(0));
      const newCategories = res.data.map((category, index) => {
        return category
      });


      setCategories(newCategories);
    });
  }

  function fetchPlaces() {
    axios.get("http://localhost:5000/api/places").then((res) => {
      setPlaces(new Array(res.data.length).fill(0));
      const newBuildings = [];

      const newPlaces = res.data.map((place, index) => {
        newBuildings.push(place.building);
        return place
      });

      let uniqueBuildings = [...new Set(newBuildings)];
      let newUniquesBuildings = uniqueBuildings.sort();
      setBuildings(uniqueBuildings);
      setPlaces(newPlaces);
    });
  }

  function fetchJoinedClubs() {

  }

  useEffect(() => {
    fetchClubs();
    fetchUsers();
    fetchEvents();
    fetchUserInfo();
    fetchCategories();
    fetchPlaces();
    console.log(places);
    console.log(buildings);
  }, [signin === true]);

  return (
    <Provider store={store}>
      <BrowserRouter>
        <Box className="App">
          <Routes>
            <Route path="/Add-Clubs" element={<ProtectedRoute><AddClubs /></ProtectedRoute>} />
            <Route path="/Add-User" element={<ProtectedRoute><AddUser /></ProtectedRoute>} />
            <Route path="/Budget" element={<ProtectedRoute><Budget /></ProtectedRoute>} />
            <Route path="/Club-Page" element={<ProtectedRoute><ClubPage /></ProtectedRoute>} />
            <Route path="/Create-Event" element={<ProtectedRoute><CreateEvent /></ProtectedRoute>} />
            <Route path="/Edit-Club" element={<ProtectedRoute><EditClubs /></ProtectedRoute>} />
            <Route path="/Event-Detail" element={<ProtectedRoute><EventDetail /></ProtectedRoute>} />
            <Route path="/Event-Page" element={<ProtectedRoute><EventPage /></ProtectedRoute>} />
            <Route path="/Event-Requests" element={<ProtectedRoute><EventRequests /></ProtectedRoute>} />
            <Route path="/Followed-Clubs" element={<ProtectedRoute><FollowedClubs /></ProtectedRoute>} />
            <Route path="/Home" element={<ProtectedRoute> <Home /> </ProtectedRoute>} />
            <Route path="/Ignored-Clubs" element={<ProtectedRoute><IgnoredClubs /></ProtectedRoute>} />
            <Route path="/Joined-Clubs" element={<ProtectedRoute><JoinedClubs /></ProtectedRoute>} />
            <Route exact path="/" element={<LoginPage setEmailPassword={setEmailPassword} handleLoginRequest={handleLoginRequest} />} />
            <Route path="/My-Club" element={<ProtectedRoute><MyClub /></ProtectedRoute>} />
            <Route path="/My-Information" element={<ProtectedRoute><MyInformation /></ProtectedRoute>} />
            <Route path="/See-All-Club-Members" element={<ProtectedRoute><SeeAllClubMembers /></ProtectedRoute>} />
            <Route path="/See-All-Clubs" element={<ProtectedRoute><SeeAllClubs /></ProtectedRoute>} />
            <Route path="/See-All-Events" element={<ProtectedRoute><SeeAllEvents /></ProtectedRoute>} />
            <Route path="/See-All-Friends" element={<ProtectedRoute><SeeAllFriends /></ProtectedRoute>} />
            <Route path="/See-All-Students" element={<ProtectedRoute><SeeAllStudents /></ProtectedRoute>} />
            <Route path="/Settings" element={<ProtectedRoute><Settings /></ProtectedRoute>} />
            <Route path="/Student-Create-Event" element={<ProtectedRoute><StudentCreateEvent /></ProtectedRoute>} />
            <Route path="/Forget-Password" element={<ForgetPassword />}></Route>
          </Routes>
        </Box>
      </BrowserRouter>
    </Provider>
  );
}

export default App;
