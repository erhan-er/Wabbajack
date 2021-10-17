import { useState, useEffect } from "react";


const Page = () => {

   const [number, setNumber] = useState(0);

   const handleChange = () => {
      let newNumber = number + 1;
      setNumber(newNumber);
   }
   
   return (
      <div>
         <p>Number {number}</p>
         <button onClick = {() => handleChange()}>Increase</button>
      </div>
   );
}

export default Page