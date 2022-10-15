import * as React from 'react';
import {AppBar, Toolbar, IconButton, Typography, Stack, Button} from '@mui/material';
import DashboardIcon from '@mui/icons-material/Dashboard';

const NavigationBar = ()=> {
    return (
        <>
        <AppBar position='static'>
            <Toolbar>
                <IconButton size="large" edge="start" color="inherit">
                    <DashboardIcon />
                </IconButton>
            </Toolbar>
            <Typography variant='h6' component='div' sx={{flexGrow:1}}>CLOUD APP</Typography>
            <Stack direction='row' spacing={2}>
                <Button color='inherit'>Features</Button>
                <Button color='inherit'>Pricing</Button>
                <Button color='inherit'>About</Button>
                <Button color='inherit'>Login</Button>
            </Stack>
        </AppBar>
        </>
    )
}

export default NavigationBar;
