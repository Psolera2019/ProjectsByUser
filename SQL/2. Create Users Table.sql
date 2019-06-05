-- Create a new table called 'Users' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
   DROP TABLE dbo.Users;
GO
-- Create the table in the specified schema
CREATE TABLE dbo.Users
(
    Id  int NOT NULL PRIMARY KEY, -- primary key column
    FirstName   varchar(50) NOT NULL,
    LastName    varchar(50) NOT NULL
);
GO