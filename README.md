#  Student Management System

## 📌 Overview
This is a simple **Student Management System** built with **ASP.NET Core MVC**.  
It allows users to **add, update, delete, and view students**.  

## 🚀 Features
- 📝 Create, Read, Update, and Delete (CRUD) students  
- 🔍 View student details  
- 📋 Display students in a table format  

## 🛠️ Technologies Used
- **ASP.NET Core MVC** for the web application  
- **Entity Framework Core** for database interactions  
- **C#** as the programming language  
- **SQL Server** as the database  
- **Bootstrap** for UI design  

## 🏗️ Design Pattern Used
This project follows the **Repository Pattern**, which separates the data access logic from the business logic.  
- **Generic Repository**: A reusable class (`GenericRepository<T>`) to handle CRUD operations.  
- **Dependency Injection**: The repository is injected into the controller for better maintainability.  
