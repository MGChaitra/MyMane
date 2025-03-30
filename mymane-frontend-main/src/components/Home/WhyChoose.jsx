import React from 'react';

function WhyChoose() {
  return (
    <div className="my-10">
      <h2 className="text-2xl font-semibold text-center mb-8 text-decoration-line: underline">Why Choose</h2>
      <p className="text-gray-500 text-center mb-10">
        Lorem Ipsum is simply dummy text printing and type setting industry Lorem Ipsum been industry
      </p>
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8 ">
        <div className="bg-blue-50 p-6 rounded-tr-3xl  shadow-md">
          <div className="flex items-center justify-center mb-4 ">
            <img src="/src/assets/trust.png" alt="" srcset="" />
            
          </div>
          <h3 className="text-xl font-bold mb-2">Trusted</h3>
          <p className="text-gray-500">
            Lorem Ipsum is simply dummy text printing and type setting industry Lorem Ipsum been industry standard dummy text ever a galley.
          </p>
        </div>
        <div className="bg-blue-50 p-6 rounded-tr-3xl  shadow-md">
          <div className="flex items-center justify-center mb-4">
          <img src="/src/assets/easyfinance.png" alt="" srcset="" />
          </div>
          <h3 className="text-xl font-bold mb-2">Easy Finance</h3>
          <p className="text-gray-500">
            Lorem Ipsum is simply dummy text printing and type setting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.
          </p>
        </div>
        <div className="bg-blue-50 p-6 rounded-tr-3xl  shadow-md">
          <div className="flex items-center justify-center mb-4">
          <img src="/src/assets/support.png" alt="" srcset="" />
          </div>
          <h3 className="text-xl font-bold mb-2">Support</h3>
          <p className="text-gray-500">
            Lorem Ipsum is simply dummy text printing and type setting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.
          </p>
        </div>
        <div className="bg-blue-50 p-6 rounded-tr-3xl  shadow-md">
          <div className="flex items-center justify-center mb-4">
          <img src="/src/assets/satisfaction.png" alt="" srcset="" />
          </div>
          <h3 className="text-xl font-bold mb-2">Satisfaction</h3>
          <p className="text-gray-500">
            Lorem Ipsum is simply dummy text printing and type setting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.
          </p>
        </div>
      </div>
    </div>
  );
}

export default WhyChoose;