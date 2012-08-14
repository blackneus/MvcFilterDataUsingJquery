
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 08/14/2012 16:30:01
-- Generated from EDMX file: C:\Users\sumit_000\Documents\GitHub\MvcFilterDataUsingJquery\MVC3_MasterDetailsUI_Filter\MVC3_MasterDetailsUI\Models\CompanyEDMX.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Company];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Employee_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Department];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[EmployeeIdentity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeIdentity];
GO
IF OBJECT_ID(N'[dbo].[EmployeeInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeInfo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [DeptNo] int  NOT NULL,
    [Dname] varchar(50)  NOT NULL,
    [Location] varchar(50)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EmpNo] int  NOT NULL,
    [EmpName] varchar(50)  NOT NULL,
    [Salary] int  NOT NULL,
    [DeptNo] int  NOT NULL
);
GO

-- Creating table 'EmployeeIdentities'
CREATE TABLE [dbo].[EmployeeIdentities] (
    [EmpNo] int IDENTITY(1,1) NOT NULL,
    [EmpName] varchar(50)  NOT NULL
);
GO

-- Creating table 'EmployeeInfoes'
CREATE TABLE [dbo].[EmployeeInfoes] (
    [EmpNo] int IDENTITY(1,1) NOT NULL,
    [EmpName] varchar(50)  NOT NULL,
    [Salary] decimal(18,0)  NOT NULL,
    [DeptName] varchar(50)  NOT NULL,
    [Designation] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DeptNo] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([DeptNo] ASC);
GO

-- Creating primary key on [EmpNo] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EmpNo] ASC);
GO

-- Creating primary key on [EmpNo] in table 'EmployeeIdentities'
ALTER TABLE [dbo].[EmployeeIdentities]
ADD CONSTRAINT [PK_EmployeeIdentities]
    PRIMARY KEY CLUSTERED ([EmpNo] ASC);
GO

-- Creating primary key on [EmpNo] in table 'EmployeeInfoes'
ALTER TABLE [dbo].[EmployeeInfoes]
ADD CONSTRAINT [PK_EmployeeInfoes]
    PRIMARY KEY CLUSTERED ([EmpNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptNo] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employee_Department]
    FOREIGN KEY ([DeptNo])
    REFERENCES [dbo].[Departments]
        ([DeptNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_Department'
CREATE INDEX [IX_FK_Employee_Department]
ON [dbo].[Employees]
    ([DeptNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------