USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'UserProjectDB'
)
   CREATE DATABASE [UserProjectDB];
GO
IF SERVERPROPERTY('ProductVersion') > '12'
    ALTER DATABASE [UserProjectDB] SET QUERY_STORE=ON;
GO