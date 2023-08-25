import { Box, Anchor, Nav, Header, Text, Select } from 'grommet'
import { AppsRounded, Home, List, Filter, Storage } from 'grommet-icons'

export default function PageHeader(props) {
    return (

        <Header background='brand' pad="small">
            <Box direction='row' align='center' gap='small'>
                <Anchor color='white' href='/home'>Grommet App</Anchor>
            </Box>
        </Header>
    );
}