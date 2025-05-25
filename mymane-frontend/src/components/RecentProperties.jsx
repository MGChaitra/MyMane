import React from 'react';
import PropertyCard from './PropertyCard';

const RecentProperties = () => {
  return (
    <section className="recent">
      <h2>Recent Properties</h2>
      <div className="recent-list">
        <PropertyCard title="New Apartment Nice View" rent="850" beds={4} baths={1} size={460} />
        <PropertyCard title="Villa Garden With Pool" rent="350" beds={3} baths={1} size={350} />
        <PropertyCard title="Ely Parkway Apartment" rent="5800" beds={4} baths={1} size={560} />
      </div>
    </section>
  );
};

export default RecentProperties;
