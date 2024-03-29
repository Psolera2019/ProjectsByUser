Use UserProjectDB

GO
/*********************************************
-- FIRST TABLE 'Users'
*********************************************/
DELETE FROM Users

-- Insert rows into table 'Users'
INSERT INTO Users
    ([Id], [FirstName], [LastName])
VALUES
    ( 1, 'Orlando', 'Australia'),
    ( 2, 'Keith', 'India'),
    ( 3, 'Donna', 'Germany')

-- Select rows from table 'Users'
SELECT * FROM Users;

/*********************************************
-- SECOND TABLE 'Project'
*********************************************/
DELETE FROM Project

-- Insert rows into table 'Project'
INSERT INTO Project
    ([Id], [StartDate], [EndDate], [Credits])
VALUES
    ( 1, '2019-05-25 00:00:00','2019-11-23 23:59:59',5),
    ( 2, '2019-05-05 00:00:00','2019-12-25 23:59:59',5),
    ( 3, '2019-06-05 00:00:00','2019-06-15 23:59:59',5),
    ( 4, '2019-03-01 00:00:00','2020-01-15 23:59:59',5),
    ( 5, '2019-06-01 00:00:00','2020-06-01 23:59:59',5),
    ( 6, '2019-04-08 00:00:00','2019-09-15 23:59:59',5),
    ( 7, '2019-07-01 00:00:00','2019-12-10 23:59:59',5),
    ( 8, '2019-01-01 00:00:00','2019-08-23 23:59:59',5),
    ( 9, '2019-06-14 00:00:00','2019-07-15 23:59:59',5),
    ( 10,'2019-06-04 00:00:00','2019-10-21 23:59:59',5)

-- Select rows from table 'Project'
SELECT * FROM Project;

/*********************************************
-- THIRD TABLE 'UserProject'
*********************************************/

DELETE FROM UserProject

-- Insert rows into table 'Project'
INSERT INTO UserProject
    ([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES
    ( 1, 1, 1, '2019-06-04 00:00:00'),
    ( 1, 2, 1, '2019-06-04 00:00:00'),
    ( 1, 3, 0, '2019-06-04 00:00:00'),
    ( 1, 4, 1, '2019-06-04 00:00:00'),
    ( 1, 5, 0, '2019-06-04 00:00:00'),
    ( 2, 6, 1, '2019-06-04 00:00:00'),
    ( 2, 7, 1, '2019-06-04 00:00:00'),
    ( 2, 8, 0, '2019-06-04 00:00:00'),
    ( 2, 9, 1, '2019-06-04 00:00:00'),
    ( 2, 10, 0, '2019-06-04 00:00:00'),
    ( 3, 1, 1, '2019-06-04 00:00:00'),
    ( 3, 6, 1, '2019-06-04 00:00:00'),
    ( 3, 3, 1, '2019-06-04 00:00:00'),
    ( 3, 8, 1, '2019-06-04 00:00:00'),
    ( 3, 5, 0, '2019-06-04 00:00:00')
    
-- Select rows from table 'UserProject'
SELECT * FROM UserProject;