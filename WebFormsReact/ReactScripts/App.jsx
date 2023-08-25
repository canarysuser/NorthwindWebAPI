
class App extends React.Component {
    constructor(props) { 
        super(props)
        this.state = { ...props };
        this.handleChange = this.handleChange.bind(this); 
        this.click = this.click.bind(this);
    }
    handleChange(e) { 
        this.setState({ ...this.state, [e.target.name]: e.target.value });
    }
    click() {
       // if (window) {
            window.alert('Button clicked');
        //}
    }
    render() { 
        return (
            <div className="card shadow mt-6 m-auto w-50">
                <div className="card-header bg-primary">
                </div>
                <div className="card-body">
                    <p> Welcome to React App.</p>
                    <p> {this.state.Id}</p>
                    <p> {this.state.Name}</p>
                </div>
                <form>
                    <label htmlFor="Id">Id</label>
                    <input type="text" name="Id" id="Id"
                        value={this.state.Id}
                        onChange={this.handleChange}/>
                        <br />
                    <label htmlFor="Name">Name</label>
                    <input type="text" name="Name" id="Name"
                        value={this.state.Name}
                        onChange={this.handleChange} />
                    <button type="button" onClick={this.click}> Submit</button>
                </form>
            </div>
        )
    }
}