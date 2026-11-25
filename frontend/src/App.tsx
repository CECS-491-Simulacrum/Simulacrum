import { TopBar } from './components/TopBar'
import { Sidebar } from './components/Sidebar'
import { useState } from 'react'
import './App.css'

function App() {
  
  const [currentPage, setCurrentPage] = useState("Dashboard")

  return (
    <>
    <div className = "parent">
      <Sidebar/> 
      <div className='workspace'>
        <TopBar/>

        <main className="mainContent">Temp Main </main>
      </div>
    </div>
    
    </>
  )
}

export default App
