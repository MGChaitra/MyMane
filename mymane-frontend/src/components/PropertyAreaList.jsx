import React from 'react';

const areas = [
  { name: 'Tilakwadi', count: 8 },
  { name: 'Sadashiv Nagar', count: 0 },
  { name: 'Bhagyya Nagar', count: 2 }
];

const PropertyAreaList = () => {
  return (
    <section className="areas">
      <h2>Find Properties In These Areas</h2>
      <div className="area-cards">
        {areas.map((area, index) => (
          <div className="area-card" key={index}>
            <div className="area-image"></div>
            <p>{area.name}</p>
            <span>{area.count} Properties</span>
          </div>
        ))}
      </div>
    </section>
  );
};

export default PropertyAreaList;
