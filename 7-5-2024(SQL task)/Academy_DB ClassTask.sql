
create database Academy_DB

create table Students(
Id int primary key identity(1,1),
FirstName nvarchar(50),
LastName  nvarchar(50),
DateOfBirth date,
Username nvarchar(50),
Password  nvarchar(100),
EnrollmentDate date
)

create table Departments(
Id int primary key identity(1,1),
DepartmentName nvarchar(100)
)
 create table Instructors(
Id int primary key identity(1,1),
FirstName nvarchar(50),
LastName  nvarchar(50),
HireDate date,
DepartmentId int  ,
Username nvarchar(50),
Password  nvarchar(100),
PIN nvarchar(100)
)



create table Groups(
Id int primary key identity(1,1),
GroupName nvarchar(100),
DepartmentId int ,
StartDate datetime,
EndDate datetime
)


create table Enrollments(
Id int primary key identity(1,1),
StudentID int,
GroupId int
)

create table Classes(
Id int primary key identity(1,1),
GroupId int,
InstructorId int,
Schedule nvarchar(150),
RoomName nvarchar(200)
)



INSERT INTO Students (FirstName, LastName, DateOfBirth, UserName, Password, EnrollmentDate)
VALUES
('John', 'Doe', '1999-05-15', 'john_doe', 'password123', '2022-09-01'),
('Alice', 'Smith', '2000-03-20', 'alice_smith', 'securepass', '2022-08-15'),
('Michael', 'Johnson', '1998-11-10', 'michaelj', 'my_password', '2021-12-30'),
('Emily', 'Brown', '2001-04-25', 'em_brown', 'pass123!', '2023-01-10'),
('James', 'Wilson', '2000-09-08', 'jw_1998', '12345678', '2022-11-20'),
('Sophia', 'Davis', '2002-02-12', 'sophia_d', 'sophia123', '2023-03-05'),
('David', 'Martinez', '1999-08-30', 'david_mtz', 'dm123456', '2021-10-10'),
('Emma', 'Garcia', '2001-06-18', 'emma_garcia', 'passw0rd!', '2023-04-22'),
('Daniel', 'Clark', '2002-12-25', 'daniel_c', 'dclark2023', '2023-02-15'),
('Olivia', 'Miller', '2000-07-14', 'olivia_m', 'olivia456', '2022-12-01');

INSERT INTO Departments (DepartmentName)
VALUES
('Computer Science'),
('Electrical Engineering'),
('Mathematics'),
('Physics'),
('Business Administration'),
('Biology'),
('Chemistry'),
('History'),
('Literature'),
('Psychology');

INSERT INTO Instructors (FirstName, LastName, HireDate, DepartmentId, UserName, Password, PIN)
VALUES
('Robert', 'Johnson', '2010-08-15', 1, 'r_johnson', 'teacher123', '123456'),
('Sarah', 'Williams', '2015-02-20', 2, 's_williams', 'pass@word', '654321'),
('Matthew', 'Brown', '2008-11-30', 3, 'm_brown', 'matt_password', '987654'),
('Jessica', 'Garcia', '2012-05-10', 4, 'jess_garcia', 'securepass!', '456789'),
('William', 'Jones', '2014-09-25', 5, 'w_jones', 'william123', '789012'),
('Sophia', 'Davis', '2017-03-15', 6, 's_davis', 'sdavis456', '345678'),
('Alexander', 'Rodriguez', '2009-07-05', 7, 'a_rodriguez', 'alex_pass', '890123'),
('Emily', 'Martinez', '2013-12-01', 8, 'emily_m', 'emily_pass', '567890'),
('Daniel', 'Young', '2016-04-20', 9, 'd_young', 'daniel123', '234567'),
('Olivia', 'Wilson', '2011-10-12', 10, 'o_wilson', 'olivia_pass', '012345');

INSERT INTO Groups (GroupName, DepartmentId, StartDate, EndDate)
VALUES
('CS101', 1, '2022-09-01', '2022-12-15'),
('EE201', 2, '2022-08-15', '2022-11-30'),
('Math301', 3, '2022-10-01', '2023-01-31'),
('PHY202', 4, '2022-09-15', '2022-12-30'),
('BA401', 5, '2022-08-20', '2022-12-10'),
('Bio102', 6, '2022-09-05', '2022-12-20'),
('Chem202', 7, '2022-09-10', '2022-12-25'),
('Hist301', 8, '2022-08-25', '2022-12-01'),
('Lit201', 9, '2022-09-08', '2022-12-31'),
('Psych401', 10, '2022-09-03', '2022-12-18');

INSERT INTO Enrollments(GroupId, StudentId)
VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4),
(3, 5),
(3, 6),
(4, 7),
(4, 8),
(5, 9),
(5, 10);

INSERT INTO Classes (GroupId, InstructorId, Schedule, RoomName)
VALUES
(1, 1, 'MWF 10:00-11:30', 'Room A101'),
(2, 2, 'TTh 13:00-14:30', 'Room B202'),
(3, 3, 'MWF 09:00-10:30', 'Room C303'),
(4, 4, 'TTh 11:00-12:30', 'Room D404'),
(5, 5, 'MWF 14:00-15:30', 'Room E505'),
(6, 6, 'TTh 10:00-11:30', 'Room F606'),
(7, 7, 'MWF 11:00-12:30', 'Room G707'),
(8, 8, 'TTh 14:00-15:30', 'Room H808'),
(9, 9, 'MWF 13:00-14:30', 'Room I909'),
(10, 10, 'TTh 09:00-10:30', 'Room J1010');




select * from Classes
select * from Departments
select * from Enrollments
select * from Groups
select * from Instructors
select * from Students





select S.Id,S.FirstName,S.LastName,G.GroupName,C.Schedule,C.RoomName from Students S 
inner join Enrollments E on s.id=e.StudentID
inner join Groups G on G.Id=E.GroupId
inner join Classes C on C.GroupId = G.Id
where S.Id=1