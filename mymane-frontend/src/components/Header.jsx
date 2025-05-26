import React, { useState } from 'react';
import '../styles/style.css';
import logo from '/src/assets/Logo.png';

const Header = () => {
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  return (
    <header className="header">
      {/* Mobile: Hamburger (left) */}
      <button
        className="mobile-menu-button"
        onClick={() => setIsMenuOpen(!isMenuOpen)}
        aria-label="Toggle Menu"
      >
        ☰
      </button>

      {/* Center Logo (both desktop and mobile) */}
      <div className="logo-container">
        <img src={logo} alt="Logo" className="logo-img" />
      </div>

      {/* Right: Profile Icon */}
      <div className="mobile-profile-wrapper">
        <button className="profile-icon" aria-label="User Profile">
          <span className="material-symbols-outlined">person</span>
        </button>
      </div>

      {/* Desktop Navigation */}
      <nav className="nav-center">
        <a href="#">Home</a>
        <a href="#">Blog</a>
        <a href="#">About Us</a>
        <a href="#">Contact Us</a>
      </nav>

      <div className="header-right">
        <button className="post-btn">Post Property</button>
        <button className="profile-icon" aria-label="User Profile">
          <span className="material-symbols-outlined">person</span>
        </button>
      </div>

      {/* Mobile Dropdown */}
      {isMenuOpen && (
        <div className="mobile-nav">
          <a href="#">Home</a>
          <a href="#">Blog</a>
          <a href="#">About Us</a>
          <a href="#">Contact Us</a>
          <button className="post-btn full">Post Property</button>
        </div>
      )}
    </header>
  );
};

export default Header;
