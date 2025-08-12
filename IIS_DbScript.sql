
-- Script for db access (read/write) in IIS for windows


USE [master];
CREATE LOGIN [IIS APPPOOL\WorkshopManagementSystem] FROM WINDOWS;
GO

USE WorkshopDB;
CREATE USER [IIS APPPOOL\WorkshopManagementSystem] FOR LOGIN [IIS APPPOOL\WorkshopManagementSystem];
ALTER ROLE db_datareader ADD MEMBER [IIS APPPOOL\WorkshopManagementSystem];
ALTER ROLE db_datawriter ADD MEMBER [IIS APPPOOL\WorkshopManagementSystem];
GO