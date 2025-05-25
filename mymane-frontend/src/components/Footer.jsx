import React from 'react';

const Footer = () => {
  return (
    <footer className="footer">
      <div className="footer-brand"> <span className="logo-orange">my</span>mane </div>
      <div className="footer-columns">
        <div>
          <h4>Popular Search</h4>
          <p>Apartment for Sale</p>
          <p>Offices for Rent</p>
        </div>
        <div>
          <h4>Quick Links</h4>
          <p>Privacy Policy</p>
          <p>Terms of Use</p>
        </div>
        <div>
          <h4>Discovery</h4>
          <p>Los Angeles</p>
          <p>New York</p>
        </div>
        <div>
          <h4>Contact Us</h4>
          <p>help@justhome.com</p>
          <p>(123) 456-7890</p>
        </div>
      </div>
    </footer>
  );
};

export default Footer;
