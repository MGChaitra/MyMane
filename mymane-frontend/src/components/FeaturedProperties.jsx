import React from 'react';
import PropertyCard from './PropertyCard';

const FeaturedProperties = () => {
  return (
    <section className="featured">
      <h2>Featured Properties</h2>
      <div className="property-slider">
        <PropertyCard title="North Dillard Street" rent="250" beds={4} baths={2} size={400} />
        <PropertyCard title="Skyper Apartment" rent="380000" beds={4} baths={2} size={450} sale />
      </div>
    </section>
  );
};

export default FeaturedProperties;
