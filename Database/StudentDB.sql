CREATE DATABASE StudentDB;
GO

USE StudentDB;
Create Table Students
( 
ID int primary key Identity(1,1) ,
St_NAME varchar(100) not null,
Age int not null ,
Grade float not null,
);

Create View view_Students
AS
Select ID ,St_NAME , Age , Grade
fROM Students

Create Procedure AddStudent
@St_Name varchar(100),
@Age int ,
@Grade float
AS 
Begin
insert into Students (St_NAME,Age ,Grade)
values(@St_Name,@Age,@Grade)
END

CREATE PROCEDURE DeleteStudent
@St_Name varchar(100)
AS
BEGIN
DELETE FROM Students
WHERE St_NAME = @St_Name
END

EXEC AddStudent 'shahd',21,90;

 Select * From view_Students;
 SELECT * FROM Students;

