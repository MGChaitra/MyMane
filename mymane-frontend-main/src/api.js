import axios from "axios";

const API_BASE_URL = "https://localhost:7185/api/Blog"; // Ensure this matches your API

export const getData = async () => {
    try {
        const response = await axios.get(API_BASE_URL);
        console.log("API Response:", response.data); // Debugging
        return response.data;
    } catch (error) {
        console.error("Error fetching data:", error.response || error.message);
        return [];
    }
};
