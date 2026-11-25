import "./TopBarStyle.css"
import { useState } from "react"

export const TopBar = () =>{

    

    return (
        <nav className="TopBar">
            <button > Simmulacrum </button>
            <button onClick={() => setCurrentPage("Dashboard")}> Dashboard </button>
            <button onClick={() => setCurrentPage("Character")}> Character </button>

            <p>Current page = {currentPage}</p>
        </nav>
    )
}