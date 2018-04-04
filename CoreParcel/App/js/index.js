import React from 'react';
import ReactDom from 'react-dom';

const App = () => {
    return (
        <div>Hello World from HMR!</div>
    );
}

ReactDom.render(<App />, document.getElementById("container"));