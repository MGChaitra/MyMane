import React from 'react';


const categories = [
  'Independent Houses',
  'Apartments',
  'PGs',
  'Commercial',
];

const CategoryList = () => {
  return (
    <section className="categories">
      <h2>Featured Categories</h2>
      <div className="category-grid">
        {categories.map((cat, i) => (
          <div className="category-card" key={i}>{cat}</div>
        ))}
      </div>
    </section>
  );
};

export default CategoryList;
