import { useState } from 'react'
import './Medias.css'
import { SearchContainer } from '../../containers/SearchContainer/SearchContainer'
import { getMedias } from '../../redux/actions/medias/medias'
import Box from '@mui/material/Box';
import Tab from '@mui/material/Tab';
import TabContext from '@mui/lab/TabContext';
import TabList from '@mui/lab/TabList';
import TabPanel from '@mui/lab/TabPanel';
import { MediasList } from './MediasList';

export const Medias = () => {
    const [searchValue, setSearchValue] = useState("")
    const [value, setValue] = useState('movie');

    const handleSearchChange = (e) => {
        setSearchValue(e.target.value)
    }

    const handleChange = (event, newValue) => {
        setValue(newValue);
    }

    return (
        <div className="medias">
            <SearchContainer
                value={searchValue}
                name="searchValue"
                handleChange={handleSearchChange}
                searchAction={getMedias}
                tabValue={value}
            />
            <Box sx={{ width: '100%', typography: 'body1' }}>
                <TabContext value={value}>
                    <Box sx={{ borderBottom: 1, borderColor: 'divider', display: 'flex', justifyContent: 'center' }}>
                        <TabList onChange={handleChange} aria-label="lab API tabs example">
                            <Tab label="Movies" value="movie" />
                            <Tab label="Shows" value="show" />
                        </TabList>
                    </Box>
                    <TabPanel sx={{backgroundColor:"#c0c2c0"}} value="movie"><MediasList mediaType="movie" /></TabPanel>
                    <TabPanel sx={{backgroundColor:"#c0c2c0"}} value="show"><MediasList mediaType="show" /></TabPanel>
                </TabContext>
            </Box>
        </div>
    )
}
