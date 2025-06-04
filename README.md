# WorkShop Management Portal 

## 📖 Overview  
A web-based ASP.NET application to manage workshops, trainers, students, materials, and approvals.  
This solution follows a **layered architecture**—ensuring separation of concerns, maintainability, and scalability. It demonstrates the practical implementation of a real-world system using **ASP.NET Web Forms** and **ADO.NET** for database operations.

---
<br />


## 📘 Description
This project was developed as part of a comprehensive Udemy training course titled **“ASP.NET Web Forms Live Project”**.  
The goal was to simulate a real-time **Workshop Management System**, where admins, students, and trainers interact with the application based on their roles and permissions.

The course focused on building enterprise-grade web applications by applying a **multi-tier architecture**.  
The solution includes the following layers:
- Business Logic Layer (BLL) – Contains core business rules and logic  
- Business Object Layer (BO) – Defines object models for data transfer  
- Data Access Layer (DAL) – Handles all database interactions via ADO.NET  
- Presentation Layer (UI) – Built using ASP.NET Web Forms (Web UI)

---
<br />


## 🚀 Features  
✅ Admins and students access features based on assigned roles and permissions. <br />
✅ Admins can create, update, and delete workshop details such as title, date, duration, and topics. <br/>
✅ Admins can upload training materials in `.zip` format. Students can download materials after approval.<br/>
✅ Admins and students can change their passwords; Admins can reset student passwords.<br/>
✅ Students can register for workshops. Admins can view and approve/reject registrations.<br/>
✅ Student can view, edit and delete their own details and can change their password, download material and view the status of request.<br/>
✅ Complete Create, Read, Update, and Delete functionality implemented using ADO.NET and Web Forms.<br/>
✅ Application follows a multi-tier structure for separation of concerns: Presentation layer, Business logic layer, Business object layer and Data access layer.

---
<br />



## 🎓 Project Plan (stpe-by-step implementation)  
✅ Gathering requirements. <br />
✅ Defining the roles and responsibilities. <br/>
✅ Identifyin the objects.<br/>
✅ Creating the relationships.<br/>
✅ Implementing the database.<br/>
✅ Inserting few dummy records.<br/>
✅ Designing project architecture.<br/>
✅ Creating ASP.NET Web Form Empty Solution and adding projects (class library - .dll) to it.<br/>
✅ Creating business object (defining classes with same name for each tables).<br/>
✅ Creating presentation layer (defining table, gridview, buttons, etc.,).<br/>
✅ Creating business logic layer.<br/>
✅ Creating data access layer (CRUD operation in database using ADO.NET).<br/>
✅ Form validation.<br/>
✅ Business rule validation.<br/>
✅ Authentication <br/>
✅ Authorization <br/>
✅ AJAX implementation (to overcome reload) <br/>
✅ Publishing the project <br/>

---
<br />



## 🛠 Tech stack
- C#
- ASP.NET Web Form
- MS SQL Server (T-SQL)
- ADO.NET
- AJAX

---
<br />



## Project structure
```
│── DataLoader\
    │── DataLoader\
        │── \bin
        │── \obj
        │── \Properties
        │── App.config
        │── Program.cs
        │── PreProcessor.cs
        │── DataLoadTemplate.cs
        │── DataLoadInfo.cs
        │── DataLoader.cs
        │── Enumeration.cs
        │── Archive.cs
        │── DataLoader.csproj
    │── ErrorLogger
    │── Mailer
    │── DataLoader.sln

│── ProdData\  
    │── Archive
    │── Incoming
    │── Logs
    
│── ProdApps\
    │── Executable
    │── Maestro
    │── Templates
    
│── script.sql
│── Readme.md
```

---
<br />



## 💡 Future Enhancements
🔹 Responsive UI with Bootstrap. <br />
🔹 Email Notifications on registration, workshop approvals, and password changes. <br />
🔹 Enable downloading of workshop participation certificates in PDF format. <br />
🔹 Visual calendar for scheduling and viewing upcoming workshops. <br />
🔹 Deployment - Host the project on IIS or Azure App Service for online access.

---
<br />



## ▶️ How to run the project ?
1️⃣ Clone the Repository - <b>git clone https://github.com/Sachin-4-5/workshop-management-portal.git</b> <br />
2️⃣ Open WorkshopManagementPortal.sln in Visual Studio (recommended version: 2017 or later). <br />
3️⃣ Execute the SQL scripts provided under the /Database folder to create tables and relationships. <br />
4️⃣ Open Web.config in the UI project - update the ConnectioString as per your need. <br />
5️⃣ Build the entire solution to restore DLL references. <br />
6️⃣ Set the UI project as the startup project. <br >
7️⃣ Press F5 or click Start to run the application.

---
<br />



## 🤝 Contribution
Pull requests are welcome! To contribute:

1️⃣ Fork the repo <br />
2️⃣ Create a feature branch (git checkout -b feature-xyz) <br />
3️⃣ Commit changes (git commit -m "Added feature xyz") <br />
4️⃣ Push to your branch (git push origin feature-xyz) <br />
5️⃣ Create a pull request 

---
<br />
<br />



















