USE [5084-db]

SELECT * FROM Courses;
SELECT * FROM Students;
DROP TABLE Courses;
DROP TABLE Students;


--task 1.1 create table Students

                                      
CREATE TABLE Students(                       
 Student_ID INT PRIMARY KEY IDENTITY (1,1),
First_NAME VARCHAR(20),
Last_NAME VARCHAR(20),
Age int,
Course_ID INT ,
);


--task 1.2 create table Courses

CREATE TABLE Courses                  
(Course_ID INT PRIMARY KEY,
Course_Name VARCHAR(20),
);



ALTER TABLE students
ADD FOREIGN KEY (Course_ID)
REFERENCES Courses (Course_ID)
ON DELETE SET NULL;


--task 3.1 insert data

INSERT INTO Courses(Course_ID, Course_Name)
VALUES (1, 'Bio'),
       (2, 'Math'),
	   (3, 'Physics'),
       (4, 'Chemistry'),
	   (5, 'Computer');






INSERT INTO students  (First_NAME,Last_NAME,Age,Course_ID)
VALUES
       ( 'TAYYEB', 'TAHIR', 22 ,Null ),
       ( 'UMER', 'AMIR' , 23 , Null),
	   ( 'AKMAL', 'SAMEER', 24 , 3),
       ( 'SAMEER', 'TALHA', 24 , 3),
	   ('TALHA' , 'TAHIR', 32,3),
	   ( 'AQSA', 'TAZEEM' , 22, 2),
       ( 'AISHA' , 'UMER', 42, 1),
	   ( 'SHAHZAL' , 'TAZEEM', 22,1),
       ( 'TAZEEM', 'TAZEEM', 21, Null),
	   ('SADAAN' , 'TAHIR', 32, Null);

ALTER TABLE Students
ADD CONSTRAINT FK_courses
FOREIGN KEY (Course_ID) REFERENCES courses(Course_ID);


SELECT Courses.Course_ID,Courses.Course_Name FROM Courses 
INNER JOIN Students
ON Courses.Course_ID = Students.Course_ID;


-- updating the Course_ID According to the couse

UPDATE Students
SET Course_ID= 2
WHERE Student_ID =  5;


--task4.1 updatintg student age
UPDATE  Students 
SET Age=4
WHERE student_ID=3;

--task4.2  deledting student  whoes student id is 6
DELETE FROM Students
WHERE student_ID=6;


--task 5 

SELECT * FROM Students
WHERE Age < 27;

SELECT Students.First_NAME,Students.Last_NAME, Courses.Course_Name FROM Students
JOIN Courses
ON Students.Course_ID=Courses.Course_ID
WHERE Students.Course_ID = 5;


-- task 6

SELECT COUNT(*) FROM Students;


SELECT AVG(Age) FROM Students;


--section7-task1

SELECT Students.Student_ID,Students.First_NAME, Students.Last_NAME FROM Students
WHERE Course_ID IS Null;


--section7-task2
SELECT TOP 1 Students.Course_ID , COUNT (Students.Course_ID) AS REPEAT_TIME FROM Students
GROUP BY Students.Course_ID
ORDER BY REPEAT_TIME DESC;

--task 7.3 list the students who are older than the average age of students.

SELECT Students.student_ID,Students.First_NAME, Students.Last_NAME,Students.Age FROM Students
WHERE Students.Age>(SELECT AVG(Students.Age) FROM Students );

--TAKS 7.4 	Find the total number of students and average age for each course.

SELECT Students.Course_ID, COUNT (Students.First_NAME) 
AS total_Number_OF_studnets,
AVG(Students.Age) AS Avg_Students_Age FROM Students
GROUP BY Course_ID

--task 7.5

SELECT Courses.Course_Name FROM Courses
LEFT JOIN Students ON Courses.Course_ID=Students.Course_ID
WHERE Students.Course_ID IS NULL;

--task 7.6 Find The Students who Share Courses with AQSA

SELECT Students.student_ID,Students.First_NAME, Students.Last_NAME,Students.Age FROM Students
WHERE Students.Course_ID=(SELECT Students.Course_ID FROM Students Where Students.First_NAME='SAMEER'
)
AND Students.First_NAME <> 'SAMEER';

--task 7.7  list the youngest and oldest student of each course


SELECT Courses.Course_Name 
,(SELECT TOP 1 Students.First_NAME FROM Students WHERE Students.Course_ID=Courses.Course_ID ORDER BY Students.Age ASC) AS Yougest_Student
,(SELECT TOP 1 Students.First_NAME FROM Students WHERE Students.Course_ID=Courses.Course_ID ORDER BY Students.Age DESC) AS Eldest_Student
FROM Courses;
