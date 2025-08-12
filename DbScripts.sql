-- =======================
-- Author: Sachin Kumar
-- Created on: 2025-08-09
-- Purpose: DB script for Workshop Management System
-- Note: 
-- =======================


CREATE DATABASE WorkshopDB
GO

USE WorkshopDB;
GO

CREATE TABLE Roles (
    RoleID INT PRIMARY KEY IDENTITY,
    RoleName NVARCHAR(50) NOT NULL
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    RoleID INT FOREIGN KEY REFERENCES Roles(RoleID)
);

CREATE TABLE Workshops (
    WorkshopID INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX),
    Date DATE NOT NULL,
    Capacity INT NOT NULL
);

CREATE TABLE Registrations (
    RegistrationID INT PRIMARY KEY IDENTITY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    WorkshopID INT FOREIGN KEY REFERENCES Workshops(WorkshopID),
    RegistrationDate DATETIME DEFAULT GETDATE()
);

INSERT INTO Roles (RoleName) VALUES ('Admin'), ('User');

INSERT INTO Users (FullName, Email, PasswordHash, RoleID)
VALUES ('Admin User', 'admin@example.com', 'admin123', 1);

INSERT INTO Workshops (Title, Description, Date, Capacity)
VALUES 
('ASP.NET Basics', 'Introductory session', '2025-08-15', 30),
('Advanced SQL', 'Deep dive into SQL queries', '2025-08-20', 25);



--select * from Roles
--select * from Users
--select * from Workshops
--select * from Registrations