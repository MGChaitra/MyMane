import React, { useState } from 'react';
import '../styles/Register.css'; // Make sure this file exists at the right path
import { FcGoogle } from 'react-icons/fc';
import { FaApple } from 'react-icons/fa';

const Register = () => {
  const [formData, setFormData] = useState({
    name: '',
    mobile: '',
    email: '',
    password: '',
    agreeToTerms: false
  });

  const [errors, setErrors] = useState({});

  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: type === 'checkbox' ? checked : value
    }));
  };

  const validate = () => {
    const newErrors = {};
    if (!formData.name) newErrors.name = 'Name is required';
    if (!formData.mobile.match(/^\d{10}$/)) newErrors.mobile = 'Enter a valid 10-digit number';
    if (!formData.email.includes('@')) newErrors.email = 'Email is invalid';
    if (formData.password.length < 6) newErrors.password = 'Password must be at least 6 characters';
    if (!formData.agreeToTerms) newErrors.agreeToTerms = 'You must agree to terms';
    return newErrors;
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const validationErrors = validate();
    if (Object.keys(validationErrors).length > 0) {
      setErrors(validationErrors);
    } else {
      setErrors({});
      console.log('Form Data Submitted', formData);
      // Add submission logic here
    }
  };

  return (
    <div className="register-container">
      <div className="left-pane">
        <img src="/src/assets/Logo.png" alt="mymane logo" className="logo" />
        <h1 className="title">Get Started Now</h1>
        <form className="register-form" onSubmit={handleSubmit}>
          <div className="input-group">
            <label htmlFor="name" className="input-label">Name</label>
            <input
              id="name"
              name="name"
              value={formData.name}
              onChange={handleChange}
              className="input-field"
              placeholder="Enter your name"
            />
            {errors.name && <p className="error-text">{errors.name}</p>}
          </div>

          <div className="input-group">
            <label htmlFor="mobile" className="input-label">Mobile Number</label>
            <input
              id="mobile"
              name="mobile"
              value={formData.mobile}
              onChange={handleChange}
              className="input-field"
              placeholder="Enter Mobile Number"
            />
            {errors.mobile && <p className="error-text">{errors.mobile}</p>}
          </div>

          <div className="input-group">
            <label htmlFor="email" className="input-label">Email Address</label>
            <input
              id="email"
              name="email"
              type="email"
              value={formData.email}
              onChange={handleChange}
              className="input-field"
              placeholder="Email"
            />
            {errors.email && <p className="error-text">{errors.email}</p>}
          </div>

          <div className="input-group">
            <label htmlFor="password" className="input-label">Password</label>
            <input
              id="password"
              name="password"
              type="password"
              value={formData.password}
              onChange={handleChange}
              className="input-field"
              placeholder="Password"
            />
            {errors.password && <p className="error-text">{errors.password}</p>}
          </div>

          <div className="checkbox-container">
            <input
              id="agreeToTerms"
              name="agreeToTerms"
              type="checkbox"
              checked={formData.agreeToTerms}
              onChange={handleChange}
              className="checkbox"
            />
            <label htmlFor="agreeToTerms" className="checkbox-label">
              I agree to the <a href="/terms">terms & policy</a>
            </label>
          </div>
          {errors.agreeToTerms && <p className="error-text">{errors.agreeToTerms}</p>}

          <button type="submit" className="submit-button">Signup</button>

          <p className="signin-prompt">
            Have an account? <a href="/login">Sign In</a>
          </p>
        </form>

        <div className="social-buttons">
          <button className="social-button">
            <FcGoogle size={20} /> Sign in with Google
          </button>
          <button className="social-button">
            <FaApple size={20} /> Sign in with Apple
          </button>
        </div>
      </div>

      <div className="right-pane" role="presentation" aria-label="Karnataka monument image" />
    </div>
  );
};

export default Register;
