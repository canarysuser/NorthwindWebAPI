import { Grommet, Heading, Form, FormField,Paragraph } from "grommet";
import { hpe } from "grommet-theme-hpe";
import PageHeader from "./PageHeader.jsx";
import { useState, useEffect, Component } from "react";
import withShadowRoot from "./withShadowRoot.jsx";


class AppFn extends Component {
    constructor(props) {
        super(props);
        this.state = {
            Name: '',
            Age: '',
            items: [],
            selected: {},
            serverTime:''
        }
        this.initializePageFromWebForms();
    }
    initializePageFromWebForms() {
        if (this.state.Name.length == 0) {
            let ctrl = this.props.getHostControl("input[id='Name']");
            let value = ctrl?.value;
            this.state.Name = value || '';
        }
        if (this.state.Age.length == 0) {
            let value = this.props.getHostControl("input[id='Age']")?.value;
            this.state.Age = value || '0';
        }
        let options = this.props.getHostControl("#Country").options; 

        for (let option of options)
            this.state.items.push(option);

        this.state.selected = this.state.items[0];
        let time = this.props.getHostControl("#lblTime").innerText;
        this.state.serverTime = time;
    }
    componentDidMount() {
       
    }
  

    

    formSubmit = (e) => {
        this.props.getHostControl("#Name").value = this.state.Name;
        this.props.getHostControl("#Age").value = this.state.Age;
        this.props.getHostControl("#Country").value = this.state.selected;
        console.log(this.state.selected);
        let btn = this.props.getHostControl("#btnSubmit");
        window.__doPostBack(btn.name, '');
        e.preventDefault();
    }

    render() {
        return (
            <Grommet theme={hpe}>
                <PageHeader />
                <Heading level="1">Welcome</Heading>
                <Paragraph>Time: {this.state.serverTime}</Paragraph>
               
                <Form onSubmit={this.formSubmit}>
                    <div className="card">
                        <div className="header bg-primary pad2">
                            <h2>React Panel</h2>
                        </div>
                        <div className="body-content">
                            <div className="form-group">
                                <FormField label="Name" name="Name"
                                    value={this.state.Name}
                                />
                            </div>
                            <div className="form-group">
                                <FormField label="Age" name="Age"
                                    value={this.state.Age}
                                />
                            </div>
                            <div className="form-group">
                                <label className="label-success" htmlFor="Country">Country</label>
                                <select name="Country" id="Country" className="form-control"
                                    value={this.state.selected}
                                    onChange={(e) => {
                                        console.log(e.target.option, e.target.value)
                                        this.setState({...this.state, selected:e.target.value})
                                    }}
                                >
                                    {
                                        this.state.items && this.state.items.map((v, index) => (
                                            <option key={index} value={v.value}>{v.text}</option>
                                        ))
                                    }
                                </select>
                            </div>
                            <button id="btnSubmit" name="btnSubmit"
                                type="submit" className="btn btn-secondary">Submit</button>
                            <button id="btnGetTime" name="btnGetTime" onClick={
                                (e) => {
                                    let btn = this.props.getHostControl("#btnGetTime");
                                    window.__doPostBack(btn.name, '');
                                } }
                                type="button" className="btn btn-secondary">Fetch</button>
                        </div>
                    </div>
                </Form>
            </Grommet>
        );
    }
}

const App = withShadowRoot(AppFn, "reactRootPanel");
export default App;