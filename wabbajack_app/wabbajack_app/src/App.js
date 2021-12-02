import './App.css';

import AddClubs from "./Pages/AddClubs";
import AddUser from "./Pages/AddUser";
import Budget from "./Pages/Budget";
import ClubPage from './Pages/ClubPage';
import CreateEvent from './Pages/CreateEvent';
import EventPage from "./Pages/EventPage";
import EventRequests from "./Pages/EventRequests";
import FollowedClubs from "./Pages/FollowedClubs";
import Home from "./Pages/Home";
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

import { BrowserRouter, Routes, Route } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Routes>
          <Route path="/Add-Clubs" element={<AddClubs />} />
          <Route path="/Add-User" element={<AddUser />} />
          <Route path="/Budget" element={<Budget />} />
          <Route path="/Club-Page" element={<ClubPage />} />
          <Route path="/Create-Event" element={<CreateEvent />} />
          <Route path="/Event-Page" element={<EventPage />} />
          <Route path="/Event-Requests" element={<EventRequests />} />
          <Route path="/Followed-Clubs" element={<FollowedClubs />} />
          <Route path="/Home" element={<Home />} />
          <Route path="/Joined-Clubs" element={<JoinedClubs />} />
          <Route exact path="/" element={<LoginPage />} />
          <Route path="/My-Club" element={<MyClub />} />
          <Route path="/My-Information" element={<MyInformation />} />
          <Route path="/See-All-Club-Members" element={<SeeAllClubMembers />} />
          <Route path="/See-All-Clubs" element={<SeeAllClubs />} />
          <Route path="/See-All-Events" element={<SeeAllEvents />} />
          <Route path="/See-All-Friends" element={<SeeAllFriends />} />
          <Route path="/See-All-Students" element={<SeeAllStudents />} />
          <Route path="/Settings" element={<Settings />} />
        </Routes>
      </div>
    </BrowserRouter>

  );
}

export default App;
