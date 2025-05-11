# HeroSHop

A .NET 8 C# project designed to be the backend API for any frontend WebUI. 
It provides access to an inventory of items and related data to support a Fantasy shop like you would see in an RPG. 
Initially there are Hero Classes (All, Fighter, Mage) and Items (e.g. sword, spellbook, etc) to retrieve and display.

# Item Inventory API

A .NET Web API project that provides access to a collection of inventory items. The data source can be either:
- A **local JSON file**, or
- A **SQL database** (via connection string). (NOT IMPLEMENTED)

The project is structured using a **factory pattern** to determine the data source at runtime, and it is designed for modularity and easy testing.

## 🔧 Features

- ASP.NET Core Web API
- JSON and SQL database data source support
- Factory-based data access abstraction
- Configuration via `appsettings.json`
- Unit testing using MSTest and NSubstitute
- Follows SOLID principles and clean architecture

---

## 📁 Project Structure
/Solution
/API -> Main Web API project
/Data -> Handles data access (JSON + SQL)
/Business -> Contains business logic and factories
/Tests -> Unit tests using MSTest + NSubstitute
/Data/items.json -> Sample JSON data file

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio or VS Code

## Setup Configuration
- Restore Packages if needed
