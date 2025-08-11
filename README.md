# WorkShop Management System 

## 📖 Overview  
An ASP.NET Web Forms application for managing workshops, registrations, and users with role-based access. <br />
IIS URL - http://localhost:8080/

---
<br />


## 📘 Project Overview
This system allows:
- Admins to create and manage workshops.
- Users to register and view available workshops.
- Role-based access control (Admin and User roles).
- Secure user registration and login functionality.
- Responsive UI with Bootstrap for a clean and modern look.

---
<br />


## 🛠 Technology used
- ASP.NET Web Forms (.NET Framework 4.7.2)
- C#
- SQL Server (Database: WorkshopDB)
- ADO.NET for data access
- Bootstrap 4 for responsive UI
- IIS for local hosting and deployment

---
<br />


## 🚀 Features  
✅ User registration and login with password hashing. <br />
✅ Admin dashboard to add, edit, and delete workshops. <br />
✅ Workshop listing with registration buttons. <br />
✅ Users can view their registrations. <br />
✅ Role-based UI changes (e.g., only admins see workshop management options). <br />
✅ Session management for user authentication. <br />
✅ Application built using a 3-tier architecture for separation of concerns: Presentation layer (UI), Business logic layer, Data access layer. <br />

---
<br />


## 🎓 Project structure
```
│── WorkshopManagementSystem\
    │── packages
    │── WorkshopManagementSystem.BLL (Class Library)
        │── bin\
        │── obj\
        │── Properties\
        │── RegistrationService.cs
        │── UserService.cs
        │── WorkshopService.cs
        │── WorkshopManagementSystem.BLL.csproj

    │── WorkshopManagementSystem.DAL (Class Library)
        │── bin\
        │── obj\
        │── Properties\
        │── DbHelper.cs
        │── UserRepository.cs
        │── RegistrationRepository.cs
        │── WorkshopRepository.cs
        │── WorkshopManagementSystem.DAL.csproj

    │── WorkshopManagementSystem.Models (Class Library)
        │── bin\
        │── obj\
        │── Properties\
        │── User
        │── Role
        │── Registration
        │── Workshop
        │── WorkshopManagementSystem.Models.csproj

    │── WorkshopManagementSystem.UI (ASP.NET Web Form)
        │── bin\
        │── obj\
        │── Properties\
        │── AppData\
        │── AppStart\
        │── Connected Services\
        │── Content\
        │── Script\
        │── Register.aspx
        │── Login.aspx
        │── Default.aspx
        │── Site.Master
        │── Global.asax
        │── Web.config
        │── WorkshopManagementSystem.UI.csproj
        │── WorkshopManagementSystem.UI.csproj.user

    │── WorkshopManagementSystem.sln
    
│── DbScript.sql
│── Readme.md
```

---
<br />



## 💡 Future Enhancements
🔹 Implement email notifications for registration. <br />
🔹 Add pagination and search on workshop listings. <br />
🔹 Improve security by implementing OAuth or JWT authentication. <br />
🔹 Enhance UI/UX with modern frontend frameworks. <br />

---
<br />



## ▶️ How to run the project ?
1️⃣ Clone the Repository - <b>git clone https://github.com/Sachin-4-5/workshop-management-system.git</b> <br />
2️⃣ Execute the provided SQL script to create WorkshopDB with necessary tables and seed data. <br>
3️⃣ Open WorkshopManagementSystem.sln in Visual Studio (recommended version: 2017 or later). <br />
4️⃣ Update the connection string in web.config with your SQL Server instance details and authentication mode. <br />
5️⃣ Set the UI project as the startup project. <br >
6️⃣ Build the entire solution to restore DLL references. <br />
7️⃣ Publish the WorkshopManagementSystem.UI project to a local folder (e.g., C:\inetpub\wwwroot\WorkshopManagementSystem). <br />
8️⃣ Press F5 or click Start to run the application through VS built-in IIS Server. <b>or</b> <br />
9️⃣ IIS Setup: <br />
    🔹Create a new site in IIS pointing to the published folder. <br />
    🔹Assign an application pool with .NET CLR Version v4.0 and set identity with appropriate DB access. <br />
    🔹Set folder permissions for the app pool identity. <br />
🔟 Access the site via your configured URL and port.

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













