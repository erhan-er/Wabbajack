import './App.css';

import LoginPage from "./Pages/LoginPage";
import Home from "./Pages/Home";
import SeeAllStudents from './Pages/SeeAllStudents';
import SeeAllClubMembers from "./Pages/SeeAllClubMembers";
import AppBar from "./Components/AppBar";
import TestPage from "./Pages/TestPage";
import { Outlet } from "react-router-dom";
import LoginBox from "./Components/LoginBox";
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
        </Routes>
      </div>
    </BrowserRouter>

  );
}

export default App;
