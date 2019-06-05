-- Create a new table called 'UserProject' in schema 'dbo'
-- Drop the table if it already exists
USE UserProjectDB

GO

IF OBJECT_ID('dbo.UserProject', 'U') IS NOT NULL
   DROP TABLE dbo.UserProject;
GO
-- Create the table in the specified schema
CREATE TABLE dbo.UserProject
(
    UserId          int NOT NULL FOREIGN KEY REFERENCES Users (Id),
    ProjectId       int NOT NULL FOREIGN KEY REFERENCES Project (Id),
    IsActive        BIT NOT NULL,
    AssignedDate    DATETIME NOT NULL
    CONSTRAINT PK_UserProject PRIMARY KEY NONCLUSTERED (UserId,ProjectId),
);
GO