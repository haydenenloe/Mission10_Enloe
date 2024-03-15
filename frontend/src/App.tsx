import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Welcome to the Bowler Society" />
      <BowlerList />
    </div>
  );
}

export default App;
