
import ReactDOM from "react-dom/client"; 
import App from "./App.jsx"; 

var elementId = "reactRootPanel";
const rootElement = document.getElementById(elementId);
const shadow = rootElement.attachShadow({mode:'open'})
var root = ReactDOM.createRoot(shadow)
root.render(<App />)


