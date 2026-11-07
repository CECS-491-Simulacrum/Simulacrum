## Overview
Simulacrum is a desktop application designed for Game Masters to organize TTRPG world building information.

## Tech Stack
**Current:** `.NET 10` · `ASP.NET Core` · `Vite` · `React` 
**Planned:** `Electron` · `SignalR` · `PostgreSQL` · `Supabase` · `Entity Framework Core`

## Prerequisites
- [Node.js](https://nodejs.org/) and npm
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
  
## Installation
Install the prerequisites above, then clone the repository:
```bash
git clone https://github.com/Skrikch/Simulacrum.git
cd Simulacrum
```

## Run the Frontend
Open a terminal at the repository root:
```bash
cd frontend
npm ci
npm run dev
```
Vite development server currently runs at http://localhost:5173

## Run the Backend
Open another terminal at the repository root:
```bash
cd backend
dotnet run --project Simulacrum.Api
```
ASP.NET Core API currently runs at http://localhost:5296
