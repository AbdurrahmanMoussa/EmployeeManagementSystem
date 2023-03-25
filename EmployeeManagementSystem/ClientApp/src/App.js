import { useEffect, useState } from "react";

const App = () => {
  const [employees, setEmployees] = useState([]);

  useEffect(() => {
    const data = fetch("api/employee/GetEmployees").then((res) => {
      return res.json();
    });
    console.log(data, "DATA");
    //   .then((data) => {
    //     setEmployees(data);
    //   });
  }, []);

  return (
    <div className="container">
      <h1>Employees</h1>
      <div className="row">
        <div>
          <table className="table table-striped">
            <thead>
              <tr>
                <th>Employee</th>
                <th>Name</th>
                <th>Email</th>
                <th>Address</th>
                <th>Phone</th>
              </tr>
            </thead>
            <tbody>
              {employees.map((item) => (
                <tr>
                  <td>{item.idEmployee}</td>
                  <td>{item.name}</td>
                  <td>{item.email}</td>
                  <td>{item.address}</td>
                  <td>{item.phone}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default App;
