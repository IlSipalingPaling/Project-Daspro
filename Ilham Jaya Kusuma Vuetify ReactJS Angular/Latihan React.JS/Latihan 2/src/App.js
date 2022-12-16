import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";
import logo from './logo-unri.webp';
import './App.css';
import Account from "./components/Account";
import Blog from "./components/Blog";
import User from "./components/User";

class App extends Component {
  render() {
    return (
      <Router>
        <div>
          <Link to="/">| Home </Link>
          <Link to="/Account">| Account </Link>
          <Link to="/Blog">| Blog |</Link>
          <hr />
          <img src={logo} className="App-Logo" alt="logo" />
          <Routes>
            <Route exact path="/" element={<User />} />
            <Route path="account" element={<Account />} />
            <Route path="blog" element={<Blog />} />
          </Routes>
        </div>
      </Router>
    )
  }
}


export default App;
