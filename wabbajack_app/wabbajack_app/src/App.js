import './App.css';

import LoginPage from "./Pages/LoginPage";
import Home from "./Pages/Home";
import SeeAllStudents from './Pages/SeeAllStudents';
import AppBar from "./Components/AppBar";
import SeeAllEvents from './Pages/SeeAllEvents';
import SeeAllClubMembers from "./Pages/SeeAllClubMembers";
import ClubPage from './Pages/ClubPage';
import TestPage from "./Pages/TestPage";
import { Outlet } from "react-router-dom";
import LoginBox from "./Components/LoginBox";
import Budget from "./Pages/Budget";
import { BrowserRouter, Routes, Route } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Routes>
          <Route exact path="/" element={<LoginPage />} />
          <Route path="/Home" element={<Home />} />
          <Route path="/See-All-Students" element={<SeeAllStudents />} />
          <Route path="/See-All-Club-Members" element={<SeeAllClubMembers />} />
          <Route path="/See-All-Events" element={<SeeAllEvents />} />
          <Route path="/See-All-Club-Members" element={<SeeAllClubMembers />} />
          <Route path="/Budget" element={<Budget />} />
          <Route path="/Club-Page" element={<ClubPage />} />
        </Routes>
      </div>
    </BrowserRouter>

  );
}

export default App;
