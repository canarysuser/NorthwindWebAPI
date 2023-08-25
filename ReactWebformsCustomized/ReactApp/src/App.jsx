import { Grommet, Heading } from "grommet";
import { hpe } from "grommet-theme-hpe";
import PageHeader from "./PageHeader.jsx";

export default function App() {
    return (
        <Grommet theme={hpe} full>
            <PageHeader />
            <Heading level="1">Welcome</Heading>
        </Grommet>
    );
}