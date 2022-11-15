import "./App.css";
import Jobs from "./Components/Jobs/Jobs";

function App() {
  return (
    <div className="App">
      <h1 className="Logo">Quick Jobs</h1>
      //
      <ul className="circles">
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
      </ul>
      <Jobs></Jobs>
    </div>
  );
}

export default App;
