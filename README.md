# Warhammer 40k Game Scheduler

A lightweight web application built with ASP.NET Core Razor Pages and SQLite to help schedule Warhammer 40,000 games between friends and local players.

---

## 🛠 Features

- 📅 Schedule a new game: specify time, faction, points, and notes
- 👥 Add players to scheduled games
- 🔍 Browse upcoming games
- 📖 View past game history

---

## 📸 Screenshots (coming soon!)

---

## 💻 Tech Stack

- ASP.NET Core Razor Pages (.NET 8)
- SQLite (EF Core)
- Entity Framework Core for data access
- Razor Pages for UI

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/)
- SQLite viewer (optional)

### Run it locally

```bash
git clone https://github.com/YOUR_USERNAME/WarhammerScheduler.git
cd WarhammerScheduler

# Restore packages
dotnet restore

# Run migrations and create the database
dotnet ef database update

# Run the app
dotnet run
