import React from 'react';

const PropertyCard = ({ title, rent, beds, baths, size, sale }) => {
  return (
    <div className="property-card">
      <div className="card-img"></div>
      <div className="card-details">
        <h4>{title}</h4>
        <p>${rent}{sale ? '' : '/month'}</p>
        <span>{beds} Beds • {baths} Baths • {size} sqft</span>
      </div>
    </div>
  );
};

export default PropertyCard;
