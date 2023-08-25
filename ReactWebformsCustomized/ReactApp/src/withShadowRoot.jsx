import React from "react"; 


const withShadowRoot = (WrappedComponent, panelId) => {

    class WithShadowRoot extends React.Component {
        state = {
            shadowRoot: document.querySelector("#" + panelId).shadowRoot, 
            shadowParent: document.querySelector("#" + panelId).shadowRoot.host 
        }
        getControlId(controlId) { 
            return this.state.shadowParent.querySelector(controlId);
        }
        render() { 
            return (
                <WrappedComponent
                    {...this.props}
                    {...this.state }
                    getHostControl={this.getControlId.bind(this)}
                />  
            )
        }
    }
    WithShadowRoot.displayname = `withShadowRoot(${WrappedComponent.displayname || WrappedComponent.name})`;
    return WithShadowRoot;

}

export default withShadowRoot;