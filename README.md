# 💆 Aesthetic Clinic Backend API

This is a backend project developed using **.NET Core**, designed to support the management needs of an **aesthetic clinic**.  
It provides a RESTful API to handle clients, appointments, services, professionals, and more.

## 🧾 Project Purpose

The main goal of this project is to streamline and digitize clinic operations, such as:

- Client registration and management
- Appointment scheduling
- Service catalog and pricing
- Professional and staff management
- Status tracking for sessions and procedures

## ⚙️ Technologies Used

- .NET Core (C#)
- Entity Framework Core
- SQL Server (or SQLite for development)
- Swagger for API documentation
- AutoMapper
- Dependency Injection
- RESTful architecture
- JWT Authentication (optional)

## 📁 Project Structure

- `Controllers/` — API endpoints  
- `Models/` — Domain models  
- `DTOs/` — Data Transfer Objects  
- `Services/` — Business logic  
- `Data/` — EF Core DbContext and migrations  
- `Configurations/` — App settings and service registrations

## 🚧 Project Status

In development — core features are being implemented and tested.

## 🧪 How to Run

1. Clone the repository  
2. Set up the database connection string in `appsettings.json`  
3. Run database migrations  
4. Start the project with `dotnet run`  
5. Access Swagger at `https://localhost:{port}/swagger`

## 📌 Notes

This project was created for learning and development purposes.  
It can be extended for real-world use in aesthetic or wellness clinics.

---

Made with 💻 using .NET Core.
