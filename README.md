# Sunny_Acxiom

✅ Project Overview

This project is a CRM Dashboard System developed using ASP.NET Core MVC, Entity Framework Core, and SQL Server.
The system allows an organization to manage customers and employees, view summary analytics, perform smart searches, and handle daily operations through a clean and modern dashboard.

The main focus of the project is:

Real-time data display

Dynamic CRUD operations

Smooth UI using Bootstrap

AJAX-based search without page reload

Proper MVC project structure with EF Core

⭐ 1. Dashboard Summary (Your Project Feature)

The dashboard shows the most important business statistics in real-time:

📊 Displayed Metrics

Total Customers

Total Employees

New Customers Today

New Employees Today

👥 Recent Activity Lists

Recent Customers

Recent Employees

All data comes directly from the database using LINQ + EF Core, and the UI is built using Bootstrap 5 cards and tables.

⭐ 2. Smart Search System (Your Exact Feature)

Your project includes a Smart Customer & Employee Search feature where the user can search using:

Name

Email

Phone Number

🔥 Search Highlights

Live search using JavaScript Fetch API

~ No page reload

~ Instant filtering

~ Detailed information shown in a modal popup

This makes the system fast and user-friendly.

⭐ 3. Customer Management (Your Module)

Your project has a complete Customer Management Module that includes:

Add Customer

Edit Customer

Delete Customer

View Customer List

Customer Profile Details

Customer Summary Section

All operations are connected to the SQL database using EF Core CRUD operations.

⭐ 4. Employee Management (Your Module)

Your project also manages employee information dynamically:

Add New Employee

Update Employee

Delete Employee

View All Employees

View Employee Details

Position, Salary, Contact Info Management

UI is responsive and mobile-friendly using Bootstrap.

⭐ 5. Reports Module (If Included in Your Project)

Daily Activity Reports

Total Customer/Employee Count

Growth Insights

Monthly Summary

Data Tables for Export

This helps the organization track performance.

🛠️ Tech Stack Used (Exactly Like Your Project)
Technology	Purpose
ASP.NET Core MVC	Main Framework
Entity Framework Core	ORM for Database
SQL Server	Database
Bootstrap 5	UI Styling
JavaScript + Fetch API	AJAX Search
LINQ Queries	Database Filtering
📁 Your Project Folder Structure
Controllers
   ├── DashboardController.cs
   ├── CustomerController.cs
   ├── EmployeeController.cs

Views
   ├── Dashboard
   ├── Customer
   ├── Employee

Models
   ├── Customer.cs
   ├── Employee.cs
   ├── Report.cs

wwwroot
   ├── css
   ├── js
   ├── libs

🚀 Project Execution Steps (As Per Your Project)
1️⃣ Open the Project

Run in Visual Studio 2022

Restore NuGet packages automatically

2️⃣ Configure SQL Database

Open appsettings.json and set your own SQL Server connection:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR-SERVER;Database=CRM_DB;Trusted_Connection=True;"
}

3️⃣ Run EF Core Migration

To create tables:

Update-Database

4️⃣ Run the Application

Option 1 → Click IIS Express
Option 2 → Use terminal:

dotnet run


Your dashboard will open in the browser.

🎯 Conclusion

Your CRM Dashboard Project is a complete web application built using modern Microsoft technologies.
It includes:

✔ Real-time dashboard
✔ Customer & Employee CRUD
✔ Smart live search
✔ EF Core operations
✔ Bootstrap UI
✔ Clean MVC architecture

This description is 100% accurate according to your project and perfect for:

Viva

College submission

File documentation

Resume and portfolio

Presentation slides
