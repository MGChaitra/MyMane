import React, { useState } from 'react';
import '../styles/Register.css'; // Reuse existing styles
import Logo from '../assets/Logo.png'; // Replace with actual path
import { FcGoogle } from 'react-icons/fc';
import { FaApple } from 'react-icons/fa';

const Login = () => {
  const [formData, setFormData] = useState({ emailOrMobile: '', password: '' });
  const [errors, setErrors] = useState({});

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const validate = () => {
    const newErrors = {};
    if (!formData.emailOrMobile.trim()) {
      newErrors.emailOrMobile = 'Email or mobile number is required.';
    }
    if (!formData.password.trim()) {
      newErrors.password = 'Password is required.';
    }
    return newErrors;
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const validationErrors = validate();
    setErrors(validationErrors);

    if (Object.keys(validationErrors).length === 0) {
      console.log('Login successful:', formData);
      // Login logic here
    }
  };

  return (
    <div className="register-container">
      <div className="left-pane">
        <img src={Logo} alt="mymane logo" className="logo" />
        <h2 className="title">Welcome back!</h2>
        <p className="verify-subtitle">Enter your Credentials to access your account</p>

        <form className="register-form" onSubmit={handleSubmit}>
          <div className="input-group">
            <label htmlFor="emailOrMobile" className="input-label">Email address/Mobile Number</label>
            <input
              type="text"
              id="emailOrMobile"
              name="emailOrMobile"
              placeholder="Enter your email"
              value={formData.emailOrMobile}
              onChange={handleChange}
              className="input-field"
              aria-invalid={!!errors.emailOrMobile}
              aria-describedby="emailOrMobile-error"
            />
            {errors.emailOrMobile && (
              <div id="emailOrMobile-error" className="error-text">{errors.emailOrMobile}</div>
            )}
          </div>

          <div className="input-group">
            <label htmlFor="password" className="input-label">Password <a href="#" className="forgot-link">forgot password</a></label>
            <input
              type="password"
              id="password"
              name="password"
              placeholder="Name"
              value={formData.password}
              onChange={handleChange}
              className="input-field"
              aria-invalid={!!errors.password}
              aria-describedby="password-error"
            />
            {errors.password && (
              <div id="password-error" className="error-text">{errors.password}</div>
            )}
          </div>

          <div className="checkbox-container">
            <input type="checkbox" id="remember" name="remember" />
            <label htmlFor="remember">Remember for 30 days</label>
          </div>

          <button type="submit" className="submit-button">Login</button>

          <div className="divider">Or</div>

          <div className="social-buttons">
                    <button className="social-button">
                      <FcGoogle size={20} /> Sign in with Google
                    </button>
                    <button className="social-button">
                      <FaApple size={20} /> Sign in with Apple
                    </button>
                  </div>
          <p className="footer-text">
            Don’t have an account? <a href="/register" className="link">Sign Up</a>
          </p>
        </form>
      </div>

      <div
        className="right-pane"
        role="presentation"
        aria-label="Karnataka monument image"
      ></div>
    </div>
  );
};

export default Login;
