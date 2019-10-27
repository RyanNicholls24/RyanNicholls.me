import * as React from "react";
import { render } from "react-dom";

import "./styles.css";

function App() {
  return (
    <div className="App">
      <div className="Header">
        <div className="HeaderButtons">
          <div className="linkedin">
            <a
              href="https://www.linkedin.com/in/ryan-nicholls-a25ab374"
              target="_blank"
              rel="noopener noreferrer"
            >
              <input type="submit" name="" value="" />
            </a>
          </div>
          <div className="github">
            <a
              href="https://github.com/RyanNicholls24"
              target="_blank"
              rel="noopener noreferrer"
            >
              <input type="submit" name="" value="" />
            </a>
          </div>
          <div className="resume">
            <a href="img/resume.pdf" target="_blank">
              <input type="submit" name="" value="" />
            </a>
          </div>
          <div className="email">
            <a href="mailto:ryannicholls24@gmail.com?Subject=RyanNicholls.me">
              <input type="submit" name="" value="" />
            </a>
          </div>
        </div>
      </div>
      <div className="Navbar">
        <ul>
          <li>
            <a href="#home">Home</a>
          </li>
          <li>
            <a href="#projects">Projects</a>
          </li>
        </ul>
      </div>
      <h2>My Projects</h2>
      <div className="project-grid">
        <div className="project">
          <a href="prj\tictactoe\index.html">
            <input type="submit" className="project-title" />
          </a>
        </div>
        <div className="project" />
        <div className="project" />
        <div className="project" />
        <div className="project" />
        <div className="project" />
      </div>
    </div>
  );
}

const rootElement = document.getElementById("root");
render(<App />, rootElement);
