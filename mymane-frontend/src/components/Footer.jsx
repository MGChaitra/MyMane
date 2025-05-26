import React from 'react';
import {
  FaFacebookF,
  FaTwitter,
  FaInstagram,
  FaLinkedinIn,
} from 'react-icons/fa';
import '../styles/style.css'; // Import the CSS file

const Footer = () => {
  return (
    <footer className="footer">
      <div className="footer-container">
        {/* Logo & Social */}
        <div className="footer-section">
          <div className="logo">
            <span className="logo-blue">my</span>
            <span className="logo-orange">mane</span>
          </div>
          <p className="tagline">Your Home Journey</p>
          <div>
            <p className="social-label">Follow Us:</p>
            <div className="social-icons">
              <FaFacebookF className="social-icon fb" />
              <FaTwitter className="social-icon tw" />
              <FaInstagram className="social-icon ig" />
              <FaLinkedinIn className="social-icon li" />
            </div>
          </div>
        </div>

        
        {/* Popular Search */}
        <div className="footer-section">
          <h3 className="footer-heading">Popular Search</h3>
          <ul className="footer-list">
            <li><a href="#">Apartment for Sale</a></li>
            <li><a href="#">Apartment for Rent</a></li>
            <li><a href="#">Offices for Sale</a></li>
            <li><a href="#">Offices for Rent</a></li>
          </ul>
        </div>

        {/* Quick Links */}
        <div className="footer-section">
          <h3 className="footer-heading">Quick Links</h3>
          <ul className="footer-list">
            <li><a href="#">Terms of Use</a></li>
            <li><a href="#">Privacy Policy</a></li>
            <li><a href="#">Our Services</a></li>
            <li><a href="#">Contact</a></li>
            <li><a href="#">Careers</a></li>
            <li><a href="#">FAQs</a></li>
          </ul>
        </div>

        {/* Discovery */}
        <div className="footer-section">
          <h3 className="footer-heading">Discovery</h3>
          <ul className="footer-list">
            <li><a href="#">Chicago</a></li>
            <li><a href="#">Los Angeles</a></li>
            <li><a href="#">New Jersey</a></li>
            <li><a href="#">New York</a></li>
            <li><a href="#">California</a></li>
          </ul>
        </div>

        {/* Contact */}
        <div className="footer-section">
          <h3 className="footer-heading">Contact Us</h3>
          <p className="contact-info">
            <a href="mailto:hi@justhome.com">hi@justhome.com</a>
          </p>
          <p className="contact-info">
            <a href="tel:+11234567890">(123) 456–7890</a>
          </p>
        </div>

      </div>
    </footer>
  );
};

export default Footer;
