import React, { useEffect, useState } from "react";
import { GoogleMap, LoadScript } from "@react-google-maps/api";
 
const MapViewer = () => {
  const [coordinates, setCoordinates] = useState(null); // Start with null
 
  useEffect(() => {
    // Simulate fetching coordinates from API
    const fetchCoordinates = async () => {
      const response = await fetch("https://localhost:7185/api/map/geocode", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ address: "Ankola" }),
      });
 
      const data = await response.json();
      if (data && data.lat && data.lng) {
        setCoordinates({ lat: data.lat, lng: data.lng });
      }
    };
 
    fetchCoordinates();
  }, []);
 
  return (
<div style={{ height: "100vh", width: "100%" }}>
<h2 style={{ textAlign: "center", padding: "10px" }}>Google Map Page</h2>
<LoadScript googleMapsApiKey="AIzaSyCXKK_9pfkZRQraB7HvadoCk_lDbsRcHys">
        {coordinates && (
<GoogleMap
            mapContainerStyle={{ height: "90%", width: "100%" }}
            center={coordinates}
            zoom={12}
          />
        )}
</LoadScript>
</div>
  );
};
 
export default MapViewer;