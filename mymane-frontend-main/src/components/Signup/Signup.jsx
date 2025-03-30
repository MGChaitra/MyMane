import React, { useState } from "react";
import { Link } from "react-router-dom";

const Signup = () => {
  const [formData, setFormData] = useState({
    Name: "",
    Email: "",
    PhoneNumber: "",
    Address: "",
    Password: "",
    confirmPassword: "",
    UserInfoNumber: ""
  });

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (formData.Password !== formData.confirmPassword) {
      alert("Passwords do not match!");
      return;
    }

    const userData = {
      id: 0,
      Name: formData.Name,
      PhoneNumber: formData.PhoneNumber,
      Address: formData.Address,
      Email: formData.Email,
      Password: formData.Password,
      UserInfoNumber: formData.UserInfoNumber
    };

    try {
      const response = await fetch("https://localhost:7185/api/User/register", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(userData)
      });

      if (response.ok) {
        const responseData = await response.json();
        const userId = responseData.id;

        if (userId) {
          const updatedUserInfo = { UserInfoNumber: `U${userId}` };
          await fetch(`https://localhost:7185/api/User/update/${userId}`, {
            method: "PUT",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(updatedUserInfo)
          });
          alert("Account created successfully!");
        }
      } else {
        const errorData = await response.text();
        console.error("API Error:", errorData);
        alert("Error creating account: " + errorData);
      }
    } catch (error) {
      console.error("Fetch Error:", error);
      alert("Failed to connect to server.");
    }
  };

  return (
    <div className="max-w-screen-xl bg-white border shadow sm:rounded-lg flex justify-center flex-1">
      <div className="flex-1 bg-blue-100 text-center hidden md:flex">
        <div className="m-12 xl:m-16 w-full bg-contain bg-center bg-no-repeat" style={{ backgroundImage: "url('/src/assets/register.png')"}}></div>
      </div>
      <div className="lg:w-1/2 xl:w-5/12 p-6 sm:p-12">
        <div className="flex flex-col items-center">
          <div className="text-center">
            <h1 className="text-2xl xl:text-4xl font-extrabold text-blue-600">Register Your Account</h1>
            <p className="mt-6 text-xs text-gray-600 text-center">
              Already have an account? <Link to='/login'><span className="text-blue-800 font-semibold">Sign in</span></Link>
            </p>
          </div>
          <form onSubmit={handleSubmit} className="w-full flex-1 mt-8 mx-auto max-w-xs flex flex-col gap-4">
            <input className="w-full px-5 py-3 rounded-lg font-medium bg-gray-100 border border-gray-200 placeholder-gray-500 text-sm focus:outline-none focus:border-gray-400 focus:bg-white" type="text" name="Name" placeholder="Enter your name" onChange={handleChange} required />
            <input className="w-full px-5 py-3 rounded-lg font-medium bg-gray-100 border border-gray-200 placeholder-gray-500 text-sm focus:outline-none focus:border-gray-400 focus:bg-white" type="email" name="Email" placeholder="Enter your email" onChange={handleChange} required />
            <input className="w-full px-5 py-3 rounded-lg font-medium bg-gray-100 border border-gray-200 placeholder-gray-500 text-sm focus:outline-none focus:border-gray-400 focus:bg-white" type="tel" name="PhoneNumber" placeholder="Enter your phone" onChange={handleChange} required />
            <input className="w-full px-5 py-3 rounded-lg font-medium bg-gray-100 border border-gray-200 placeholder-gray-500 text-sm focus:outline-none focus:border-gray-400 focus:bg-white" type="text" name="Address" placeholder="Enter your address" onChange={handleChange} required />
            <input className="w-full px-5 py-3 rounded-lg font-medium bg-gray-100 border border-gray-200 placeholder-gray-500 text-sm focus:outline-none focus:border-gray-400 focus:bg-white" type="password" name="Password" placeholder="Password" onChange={handleChange} required />
            <input className="w-full px-5 py-3 rounded-lg font-medium bg-gray-100 border border-gray-200 placeholder-gray-500 text-sm focus:outline-none focus:border-gray-400 focus:bg-white" type="password" name="confirmPassword" placeholder="Confirm Password" onChange={handleChange} required />
            <button className="mt-5 tracking-wide font-semibold bg-orange-500 text-gray-100 w-full py-3 rounded-lg hover:bg-orange-600 transition-all duration-300 ease-in-out flex items-center justify-center focus:shadow-outline focus:outline-none" type="submit">
              <span>Register</span>
            </button>
          </form>
        </div>
      </div>
    </div>
  );
};

export default Signup;
