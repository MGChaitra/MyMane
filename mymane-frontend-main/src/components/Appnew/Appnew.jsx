import { useEffect, useState } from "react";
import { getData } from "../../api";

function Appnew() {
    const [data, setData] = useState([]);

    useEffect(() => {
        getData().then(response => {
            if (response) {
                console.log("Setting data:", response);
                setData(response);
            }
        }).catch(error => console.error("Error fetching data:", error));
    }, []);

    return (
        <div>
            <h1>API Data</h1>
            {data.length > 0 ? (
                data.map((item) => (
                    <div key={item.id}>
                        <h2>{item.heading}</h2>
                        <p>{item.content}</p>
                        <p><strong>Author:</strong> {item.authorName}</p>
                        {item.imageUrl && item.imageUrl.startsWith("http") ? (
                            <img src={item.imageUrl} alt="Blog" style={{ width: "200px", height: "auto" }} />
                        ) : (
                            <p>No Image Available</p>
                        )}
                        <hr />
                    </div>
                ))
            ) : (
                <p>Loading...</p>
            )}
        </div>
    );
}

export default Appnew;
