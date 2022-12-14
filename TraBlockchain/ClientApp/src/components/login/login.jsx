import React from "react";
import loginImg from "../../login.svg";
import Axios from "axios";

export class Login extends React.Component {
  params;
  
  constructor(props) {
    super(props);
  }

  async handleData() {

    var username = document.getElementsByName("username")
    var password = document.getElementsByName("password")

    this.params = {
      username,
      password
    }

    await axios.post('http://localhost:5500/userlogin/', this.params)
    
    
  }
  render() {
    return (
      <div className="base-container" ref={this.props.containerRef}>
        <div className="header">Login</div>
        <div className="content">
          <div className="image">
            <img src={loginImg} />
          </div>
          <div className="form">
            <div className="form-group">
              <label htmlFor="username">Username</label>
              <input type="text" name="username" placeholder="username" />
            </div>
            <div className="form-group">
              <label htmlFor="password">Password</label>
              <input type="password" name="password"  placeholder="password" />
            </div>
          </div>
        </div>
        <div className="footer">
          <button type="button" className="btn" onClick={this.handleData}>
            Login
          </button>
        </div>
      </div>
    );
  }
}
