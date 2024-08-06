# Contacts manager using ASP.NET Core for backend, SQLServer and EF for database, and Angular for frontend

## This is backend project.

## REQUIRED: 
### A database named "Contacts" in SQL server 2014 with one table "Contact"
`CREATE TABLE [dbo].[Contact] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50)  NOT NULL,
    [Email]    NVARCHAR (150) NULL,
    [Phone]    NVARCHAR (50)  NOT NULL,
    [Favorite] BIT            CONSTRAINT [DF_Contact_Favorite] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([Id] ASC)
);
`

## Scaffolding:
Use `Scaffold-DbContext "server=.\;database=Contacts;Trusted_Connection=True; Encrypt=False;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data`
