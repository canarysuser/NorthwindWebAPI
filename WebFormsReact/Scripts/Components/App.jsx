
function App() {
    return ( 
        <h1> From React APP</h1>
    )
}

var rootElement = document.getElementById("root")
var reactRoot = ReactDOM.createRoot(rootElement); 
reactRoot.render(<App/>)
