USE OnlineShop

CREATE TABLE Students(
Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
[Name] NVARCHAR(255) NOT NULL,
Birthdate DATE NOT NULL
);

CREATE TABLE Projects(
Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
[Name] NVARCHAR(500) NOT NULL UNIQUE,
Deadline DATETIME
);

CREATE TABLE Student_Project(
Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Student_Id INT,
Project_Id INT,
UNIQUE(Student_Id, Project_Id),
FOREIGN KEY (Student_Id) REFERENCES Students(Id) ON DELETE CASCADE,
FOREIGN KEY (Project_Id) REFERENCES Projects(Id) ON DELETE CASCADE
);

DROP TABLE Student_Project