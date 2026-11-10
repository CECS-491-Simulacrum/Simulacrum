import { TopBar } from './components/TopBar'
import { Sidebar } from './components/Sidebar'
import './App.css'

function App() {
  

  return (
    <>
    <div className = "parent">
      <Sidebar/> 
      <TopBar/>
      <main className="mainContent">Temp Main</main>
      
    </div>
    
    </>
  )
}

export default App
