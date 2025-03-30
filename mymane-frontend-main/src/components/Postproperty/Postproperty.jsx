import React from 'react'

function Postproperty() {
  return (
    <div class="container mx-auto mt-10">
        <div class="flex flex-col md:flex-row gap-8">
          <div class="w-full md:w-1/4 bg-gray-100 p-6 rounded-lg shadow-md hidden lg:block">
              <h2 class="text-xl font-bold mb-4">Navigation</h2>
                <ul>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">My Properties</a></li>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">Add Properties</a></li>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">My Favourites</a></li>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">Reviews</a></li>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">Notification</a></li>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">My Packages</a></li>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">My Payment</a></li>
                    <li><a href="#" class="block py-2 px-4 rounded-md hover:bg-gray-200">My Profile</a></li>
                    <li><a href="#" class="block py-2 px- 4 rounded-md hover:bg-gray-200">Settings</a></li>
                </ul>
          </div>
          <div class="w-full md:w-3/4 bg-white p-6 rounded-lg shadow-md text-left">
          <h2 class="text-2xl font-bold mb-4 text-left">Property Information</h2>

          <div class="grid grid-cols-2 gap-4 text-left">
            <div className='col-span-2'>
              <label for="property-title" class="block text-gray-700 font-bold mb-2">Property Title</label>
              <input type="text" id="property-title" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Property Title"/>
            </div>
            <div>
              <label for="property-type" class="block text-gray-700 font-bold mb-2">Property Type</label>
              <div class="relative">
                <select id="property-type" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline">
                  <option value="">Select Type</option>
                  <option value="apartment">Apartment</option>
                  <option value="house">House</option>
                  <option value="condo">Condo</option>
                  <option value="villa">Villa</option>
                </select>
                <div class="pointer-events-none absolute inset-y-0 right-0 flex items-center px-2 text-gray-700">
                  <svg class="fill-current h-4 w-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20"><path d="M9.293 12.95l.707.707L15.657 8l-1.414-1.414L10 10.828 5.757 6.586 4.343 8z"/></svg>
                </div>
              </div>
            </div>
            <div>
              <label for="property-status" class="block text-gray-700 font-bold mb-2">Property Status</label>
              <input type="text" id="property-status" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Property Status"/>
            </div>
            <div>
              <label for="property-price" class="block text-gray-700 font-bold mb-2">Property Price</label>
              <input type="number" id="property-price" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Property Price"/>
            </div>
            <div>
              <label for="square-feet" class="block text-gray-700 font-bold mb-2">Square Feet</label>
              <input type="number" id="square-feet" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Square Feet"/>
            </div>
            <div>
              <label for="bedrooms" class="block text-gray-700 font-bold mb-2">Bedrooms</label>
              <input type="number" id="bedrooms" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Number of Bedrooms"/>
            </div>
            <div>
              <label for="bathrooms" class="block text-gray-700 font-bold mb-2">Bathrooms</label>
              <input type="number" id="bathrooms" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Number of Bathrooms"/>
            </div>
            <div className='col-span-2'>
              <label for="property-image" class="block text-gray-700 font-bold mb-2">Property Image</label>
              <input type="file" id="property-image" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"/>
            </div>
            <div class="col-span-2">
              <label for="property-description" class="block text-gray-700 font-bold mb-2">Property Description</label>
              <textarea id="property-description" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Property Description"></textarea>
            </div>
          </div>
          <div class="mt-4">
            <h3 class="text-xl font-semibold mb-2">Other Features</h3>
            <div class="flex items-center ">
              <input type="checkbox" id="air-conditioning" class="mr-2"/>
              <label for="air-conditioning" class="text-gray-700">Air Conditioning</label>
            </div>
            <div class="flex items-center">
              <input type="checkbox" id="parking" class="mr-2"/>
              <label for="parking" class="text-gray-700">Parking</label>
            </div>
            <div class="flex items-center">
              <input type="checkbox" id="bedding" class="mr-2"/>
              <label for="bedding" class="text-gray-700">Bedding</label>
            </div>
            <div class="flex items-center">
              <input type="checkbox" id="heating" class="mr-2"/>
              <label for="heating" class="text-gray-700">Heating</label>
            </div>
            <div class="flex items-center">
              <input type="checkbox" id="microwave" class="mr-2"/>
              <label for="microwave" class="text-gray-700">Microwave</label>
            </div>
            <div class="flex items-center">
              <input type="checkbox" id="balcony" class="mr-2"/>
              <label for="balcony" class="text-gray-700">Balcony</label>
            </div>
            <div class="flex items-center">
              <input type="checkbox" id="terrace" class="mr-2"/>
              <label for="terrace" class="text-gray-700">Terrace</label>
            </div>
            <div class="flex items-center">
              <input type="checkbox" id="internet" class="mr-2"/>
              <label for="internet" class="text-gray-700">Internet</label>
            </div>
          </div>
          <div class="mt-4 text-left ">
            <h3 class="text-xl font-semibold mb-2 ">Location Details</h3>
            <div class="grid grid-cols-2 gap-4 ">
              <div>
                <label for="address" class="block text-gray-700 font-bold mb-2">Address</label>
                <input type="text" id="address" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Address"/>
              </div>
              <div>
                <label for="city" class="block text-gray-700 font-bold mb-2">City</label>
                <input type="text" id="city" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter City"/>
              </div>
              <div>
                <label for="locality" class="block text-gray-700 font-bold mb-2">Locality</label>
                <input type="text" id="locality" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter Locality"/>
              </div>
              <div>
                <label for="district" class="block text-gray-700 font-bold mb-2">District</label>
                <input type="text" id="district" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter District"/>
              </div>
              <div>
                <label for="district" class="block text-gray-700 font-bold mb-2">State</label>
                <input type="text" id="district" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder="Enter State"/>
              </div>
            </div>
          </div>
          <div class="mt-4 text-left">
            <h3 class="text-xl font-semibold mb-2">Contact Information</h3>
            <div class="grid grid-cols-2 gap-4 ">
              <div>
                <label for="name" class="block text-gray-700 font-bold mb-2">Name</label>
                <input type="text" id="name" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder=""/>
              </div>
              <div>
                <label for="email" class="block text-gray-700 font-bold mb-2">City</label>
                <input type="text" id="email" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder=""/>
              </div>
              <div>
                <label for="Number" class="block text-gray-700 font-bold mb-2">Contact Number</label>
                <input type="text" id="Number" class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" placeholder=""/>
              </div>
            </div>
          </div>
          <div class="mt-6">
            <button class="bg-orange-500 hover:bg-orange-700 text-white font-bold py-2 px-4 rounded">Add Property</button>
          </div>
          </div>
        </div>
    </div>
  )
}

export default Postproperty