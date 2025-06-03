# WorkShop Management Portal 

## 📖 Overview  
WorkShop Management Portal is an ASP.NET Web Form based web application that perfroms CRUD operation using ADO.NET technique.

---
<br />



## 🚀 Features  
✅ Reads structured XML files from a specified directory  
✅ Parses and validates XML content  
✅ Inserts data into the configured SQL Server database  
✅ Logs processing details for troubleshooting to a logs folder <br />
✅ Moves processed files to an archive folder <br />
✅ Sends success/failure email notification after processing 

---
<br />



## 🛠 Tech stack
- C#
- ASP.NET Web Form
- MS SQL Server (T-SQL)
- ADO.NET

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



## 🔧 Troubleshooting
1️⃣ XML File Not Found?
<ul>
  <li>Ensure the path is correct in App.config.</li>
  <li>Check if the file exists in the specified location.</li>
</ul>

2️⃣ Database Connection Issues?
<ul>
  <li>Verify App.config has the correct SQL Server credentials.</li>
  <li>Ensure the SQL Server service is running.</li>
</ul>

3️⃣ File Processing Failed?
<ul>
  <li>Check Logs/ directory for error logs.</li>
  <li>Validate XML structure using an XML validator tool.</li>
</ul>

---
<br />



## 💡 Future Enhancements
🔹 Implement multi-threading for faster processing <br />
🔹 Add support for multiple data sources like - excel, json, etc. <br />
🔹 Add support for multiple database types (MySQL, PostgreSQL) <br />

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



















