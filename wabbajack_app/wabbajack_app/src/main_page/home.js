import * as React from 'react';

import Accordion from "../Components/activity_accordion";

const home = () => {
   var activity1 = {place: "B Building", date: "20/11/2021", time: "18:00"};
   var activity2 = {place: "A Building", date: "30/11/2021", time: "20:00"};
   var activity3 = {place: "EA Building", date: "31/12/2021", time: "22:00"};
   return (
      <div>
         <Accordion {...activity1}/>
         <Accordion {...activity2}/>
         <Accordion {...activity3}/>
      </div>
   );
}

export default home