# MediTrack API

**MediTrack** is a secure and scalable backend solution for managing patient records, appointments, prescriptions, and clinic operations.  
Built with **ASP.NET Core** and following **Clean Architecture** principles, it’s ideal for small medical centers and barangay health units.

## Tech Stack

- **C#** with **ASP.NET Core Web API**
- **Entity Framework Core** for ORM
- **SQL Server** as the relational database
- **Clean Architecture** with a layered solution structure

### Solution Structure

- **MediTrack.API**  --> Entry point (Web API)
- **MediTrack.Application**  --> Business logic, DTOs, interfaces
- **MediTrack.Domain**  --> Core entities and domain models
- **MediTrack.Persistence**  --> Database context and migrations
- **MediTrack.Infrastructure** --> External services (e.g., logging, emailing)

#### Prerequisites

- **.NET 8 SDK**(https://dotnet.microsoft.com/en-us/download)
- **SQL Server**(https://www.microsoft.com/en-us/sql-server/)
- (Optional) **Visual Studio 2022+**(https://visualstudio.microsoft.com/)