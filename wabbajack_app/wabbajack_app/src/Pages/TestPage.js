import * as React from "react";
import FriendBox from "../Components/FriendBox";
import Photo from "../Images/image.jpg";
import AppBar from "../Components/AppBar"

function TestPage () {


   return (
      <FriendBox PersonImage = {Photo} Name = {"Erhan Er"} Id = {8}/>
      //<AppBar />
   );
}

export default TestPage