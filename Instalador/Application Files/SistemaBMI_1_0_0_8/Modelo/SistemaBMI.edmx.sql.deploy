
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2021 16:38:40
-- Generated from EDMX file: C:\Users\mejia\Documents\WorldSkill\Timer\SistemaBMI\Vista\Modelo\SistemaBMI.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO

CREATE DATABASE [sistemaBMI];
GO

USE [sistemaBMI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'usuario'
CREATE TABLE [dbo].[usuario] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NOMBRES] varchar(100)  NOT NULL,
    [APELLIDOS] varchar(100)  NOT NULL,
    [FECHA_NACIMIENTO] datetime  NULL,
    [GENERO] varchar(100)  NOT NULL,
    [PESO] decimal(6,2)  NULL,
    [ESTATURA] decimal(6,2)  NULL,
    [BMI] decimal(6,2)  NULL,
    [BMR] decimal(6,2)  NULL,
    [NIVEL_DE_ACTIVIDAD] varchar(1000)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [PK_usuario]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------