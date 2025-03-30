import React from 'react';

const properties = [
  {
    id: 1,
    image: 'https://via.placeholder.com/350x250',
    title: 'MS Northbound, Peachfield Road, Uk',
    price: 22567,
    beds: 3,
    baths: 2
  },
  {
    id: 2,
    image: 'https://via.placeholder.com/350x250',
    title: 'Luxury Villa, California',
    price: 45000,
    beds: 4,
    baths: 3
  },
  {
    id: 3,
    image: 'https://via.placeholder.com/350x250',
    title: 'Modern Apartment, New York',
    price: 35000,
    beds: 2,
    baths: 2
  }
];

const PropertyCard = ({ property }) => {
  return (
    <div className="bg-white rounded-lg shadow-md overflow-hidden transform transition-all duration-300 hover:scale-105">
      {/* Property Image */}
      <div className="relative">
        <img 
          src={property.image} 
          alt={property.title} 
          className="w-full h-48 object-cover"
        />
      </div>

      {/* Property Details */}
      <div className="p-4">
        <h3 className="text-lg font-bold text-gray-800 mb-2">
          {property.title}
        </h3>

        <div className="flex justify-between items-center mb-2">
          <span className="text-green-600 font-semibold text-xl">
            ${property.price.toLocaleString()}
          </span>
        </div>

        {/* Property Features */}
        <div className="flex justify-between mt-4">
          {/* Beds */}
          <div className="flex items-center space-x-2">
            <svg 
              xmlns="http://www.w3.org/2000/svg" 
              className="h-5 w-5 text-green-500" 
              viewBox="0 0 24 24" 
              fill="none" 
              stroke="currentColor"
            >
              <path 
                strokeLinecap="round" 
                strokeLinejoin="round" 
                strokeWidth={2} 
                d="M4.5 12.75l6.5-6.5 6.5 6.5M12 12l8 8m-8-8l8-8M12 12l-8 8m8-8l-8-8" 
              />
            </svg>
            <span className="text-gray-600">{property.beds} Bed</span>
          </div>

          {/* Baths */}
          <div className="flex items-center space-x-2">
            <svg 
              xmlns="http://www.w3.org/2000/svg" 
              className="h-5 w-5 text-green-500" 
              viewBox="0 0 24 24" 
              fill="none" 
              stroke="currentColor"
            >
              <path 
                strokeLinecap="round" 
                strokeLinejoin="round" 
                strokeWidth={2} 
                d="M4.5 12.75l6.5-6.5 6.5 6.5M12 12l8 8m-8-8l8-8M12 12l-8 8m8-8l-8-8" 
              />
            </svg>
            <span className="text-gray-600">{property.baths} Bath</span>
          </div>
        </div>
      </div>
    </div>
  );
};

const MostViewedProperties = () => {
  return (
    <div className="container mx-auto px-4 py-8">
        <p className='font-extrabold text-orange-500 text-sm text-center my-10'>POPULAR</p>
      <h2 className="text-3xl font-bold text-center mb-8 text-gray-800 text-decoration-line: underline">
        Most Viewed Properties
      </h2>

      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        {properties.map((property) => (
          <PropertyCard key={property.id} property={property} />
        ))}
      </div>
      <button type="button" class="text-black hover:text-white border border-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center me-2 mb-2 dark:border-blue-500 dark:text-blue-500 dark:hover:text-white dark:hover:bg-blue-500 dark:focus:ring-blue-800 my-10">View More</button>

    </div>
  );
};

export default MostViewedProperties;