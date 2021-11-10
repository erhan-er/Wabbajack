import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';

const login_page = () => {

   return (
      <Box>
         <TextField label="Email" color="secondary" />
         <TextField label="Password" />
      </Box>
   );
}

export default login_page