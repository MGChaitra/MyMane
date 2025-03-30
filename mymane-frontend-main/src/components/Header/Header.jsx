import React from "react";
import { Link, NavLink } from "react-router-dom";
export default function Header() {
    return (
      
        <nav className="max-w-full">
        <div className="container mx-auto px-2 py-3 flex justify-between items-center">
          {/* Logo */}
          <div className="flex items-center">
            <img
              src='src/assets/main-logo.png' // Update this with the correct path to your logo image
              alt="Logo"
              className="w-20 h-10 mr-2" // Adjust width and height as needed
            />
            
          </div>
          {/* Navigation Links */}
          <ul className="hidden md:flex space-x-6 text-gray-600">
            <li >
            <NavLink
                                to="/"
                                    className={({isActive}) =>
                                        `block py-2 pr-4 pl-3 duration-200 ${isActive ? "text-orange-500 text-decoration-line: underline" : "text-gray-600"} border-b  lg:hover:bg-transparent lg:border-0 hover:text-blue-500 lg:p-0`
                                    }
                                >
                                    Home
                                </NavLink>
            </li>
            <li>
            <NavLink
              to="/postproperty"
              className={({isActive}) =>
              `block py-2 pr-4 pl-3 duration-200 ${isActive ? "text-orange-500 text-decoration-line: underline" : "text-gray-600"} border-b  lg:hover:bg-transparent lg:border-0 hover:text-blue-500 lg:p-0`
              }
              >
              Post Property
              </NavLink>
            </li>
            <li className="hover:text-blue-500">
            <NavLink
              to="/blog"
              className={({isActive}) =>
              `block py-2 pr-4 pl-3 duration-200 ${isActive ? "text-orange-500 text-decoration-line: underline" : "text-gray-600"} border-b  lg:hover:bg-transparent lg:border-0 hover:text-blue-500 lg:p-0`
              }
              >
              Blogs
              </NavLink>
            </li>
          </ul>
          {/* Login/Signup Buttons */}
          <div className="hidden md:flex space-x-4">
            {/* <a href="#" className="text-gray-600 hover:text-blue-500">
              Login
            </a> */}
            <Link className="text-gray-600 hover:text-blue-500" to='/login'>Login</Link>
            <a href="/signup" className="text-gray-600 hover:text-blue-500">
              Signup
            </a>
          </div>
          {/* Mobile Menu */}
          <div className="md:hidden">
            <button className="text-gray-600 hover:text-blue-500">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                fill="none"
                viewBox="0 0 24 24"
                strokeWidth="2"
                stroke="currentColor"
                className="w-6 h-6"
              >
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  d="M4 6h16M4 12h16m-7 6h7"
                />
              </svg>
            </button>
          </div>
        </div>
      </nav>
      
    );
}

