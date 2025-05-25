import React from 'react';
import '../styles/style.css';
import logo from '/src/assets/Logo.png'; // Adjust path if needed

const Header = () => {
  return (
    <header className="header">
      <div className="logo-container">
        <img src={logo} alt="Logo" className="logo-img" />
      </div>
       <nav className="nav-links">
        <a href="#">Home</a>
        <a href="#">Blogs</a>
        <a href="#">About Us</a>
        <a href="#">Contact Us</a>
      </nav>

      <div className="right-actions">
        <button className="post-btn">Post Property</button>
        <button  className="profile-icon">
          <span className="material-symbols-outlined">person</span>
        </button>
        </div>
    </header>
  );
};

export default Header;
