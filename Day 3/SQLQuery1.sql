GO
USE 5084_DB;


DROP TABLE Students;


GO



CREATE TABLE Courses
(Course_ID INT PRIMARY KEY,
Course_Name VARCHAR(20),
);


SELECT * FROM Students;


CREATE TABLE Students(
 student_ID INT  PRIMARY KEY,
First_NAME VARCHAR(20),
Last_NAME VARCHAR(20),
Age int,
Course_ID INT ,
-- FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
);



GO




INSERT INTO Courses(Course_ID, Course_Name)
VALUES (1, 'Bio'),
       (2, 'Math'),
	   (3, 'Physics'),
       (4, 'Chemistry'),
	   (5, 'Computer');




INSERT INTO students  (student_ID,First_NAME,Last_NAME,Age,Course_ID)
VALUES
       (1, 'TAYYEB', 'TAHIR', 22 ,3 ),
       (2, 'UMER', 'AMIR' , 23 , 3),
	   (3, 'AKMAL', 'SAMEER', 24 , 3),
       (4, 'SAMEER', 'TALHA', 24 , 5),
	   (5, 'TALHA' , 'TAHIR', 32, 4),
	   (6, 'AQSA', 'TAZEEM' , 22, 3),
       (7, 'AISHA' , 'UMER', 42, 4),
	   (8, 'SHAHZAL' , 'TAZEEM', 22,3),
       (9, 'TAZEEM', 'TAZEEM', 21, 4),
	   (10, 'SADAAN' , 'TAHIR', 32, 5);

ALTER TABLE Students
ADD CONSTRAINT FK_courses
FOREIGN KEY (Course_ID) REFERENCES courses(Course_ID);


UPDATE  Students 
SET Age=4
WHERE student_ID=3;


DELETE FROM Students
WHERE student_ID=6;


SELECT * FROM Students
WHERE Age < 20;

SELECT * FROM Students
WHERE Course_ID = 4;




SELECT COUNT(*) FROM Students;

SELECT AVG(Age)
FROM Students;


--section7-task1

SELECT * FROM Students
WHERE Course_ID> 5;


--section7-task2
SELECT Age FROM Students
WHERE SUM(Age)/Age;


SELECT*FROM Students
WHERE Course_ID=4;

--Zist the students who are older than the average age of students.

