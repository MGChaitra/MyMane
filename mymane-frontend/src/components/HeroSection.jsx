import React from 'react';
import '../styles/style.css';

const HeroSection = () => {
  return (
    <div
      className="hero"
      style={{ backgroundImage: "url('/src/assets/suvarna-soudhahome.png')" }}
    >
      <div className="hero-overlay"></div>
      <div className="hero-content">
        <h1>Revolutionizing Real Estate in Belagavi</h1>
        <p>Helping you find the property of your dreams.</p>
        <div className="hero-form">
          <input type="text" placeholder="Enter Location" />
          <select>
            <option>Type</option>
          </select>
          <input type="number" placeholder="$0" />
          <input type="number" placeholder="$5800" />
          <button>Search</button>
        </div>
      </div>
    </div>
  );
};

export default HeroSection;
