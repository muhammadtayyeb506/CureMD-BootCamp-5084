
---Day_4 Tasks


CREATE PROCEDURE AddStudent
	
	@First_NAME VARCHAR(20),
	@Last_NAME VARCHAR(20),
    @Age INT,
    @Course_ID INT
AS
BEGIN
    INSERT INTO Students(First_NAME,Last_NAME, Age, Course_ID)
    VALUES (@First_NAME,@Last_NAME, @Age, @Course_ID);
END;
GO


CREATE PROCEDURE UpdateStudentAge
    @Student_ID INT,
    @NewAge INT
AS
BEGIN
    UPDATE Students
    SET Age = @NewAge
    WHERE Student_ID = @Student_ID;
END;
Go


CREATE PROCEDURE DeleteStudent
    @Student_ID INT
AS
BEGIN
    DELETE FROM Students
    WHERE student_ID = @Student_ID;
END;
GO

CREATE PROCEDURE ListAllStudents
AS
BEGIN
    SELECT * FROM Students;
END;

GO

CREATE PROCEDURE Students_who_are_not_Enrolled_in_Corses
AS
BEGIN
	SELECT Students.Student_ID,Students.First_NAME, Students.Last_NAME FROM Students
WHERE Course_ID IS Null;
END

GO

CREATE PROCEDURE Students_Age_Above_the_AVG_Age
AS
BEGIN
	SELECT Students.student_ID,Students.First_NAME, Students.Last_NAME,Students.Age FROM Students
WHERE Students.Age>(SELECT AVG(Students.Age) FROM Students );
END

GO


CREATE PROCEDURE total_number_of_students_and_average_age_for_each_course 
AS
BEGIN
SELECT Students.Course_ID, COUNT (Students.First_NAME) AS total_Number_OF_studnets, AVG(Students.Age) AS Avg_Students_Age FROM Students
GROUP BY Course_ID
END

GO

CREATE PROCEDURE Most_Popular_Course  
AS
BEGIN
SELECT TOP 1 Students.Course_ID , COUNT (Students.Course_ID) AS REPEAT_TIME FROM Students
GROUP BY Students.Course_ID
ORDER BY REPEAT_TIME DESC;
END

GO



CREATE PROCEDURE courses_that_have_no_students_enrolled_in_them
AS
BEGIN
SELECT Courses.Course_Name FROM Courses
LEFT JOIN Students ON Courses.Course_ID=Students.Course_ID
WHERE Students.Course_ID IS NULL;
END

GO

CREATE PROCEDURE students_who_share_courses_with_a_specifi_student 
  @First_NAME VARCHAR(20)
AS
BEGIN
SELECT Students.student_ID,Students.First_NAME, Students.Last_NAME,Students.Age FROM Students
WHERE Students.Course_ID=(SELECT Students.Course_ID FROM Students Where Students.First_NAME=@First_NAME)
AND Students.First_NAME <> @First_NAME;
END

GO


CREATE PROCEDURE  list_the_youngest_and_oldest_student_in_each_course
AS
BEGIN
SELECT Courses.Course_Name 
,(SELECT TOP 1 Students.First_NAME FROM Students WHERE Students.Course_ID=Courses.Course_ID ORDER BY Students.Age ASC) AS Yougest_Student
,(SELECT TOP 1 Students.First_NAME FROM Students WHERE Students.Course_ID=Courses.Course_ID ORDER BY Students.Age DESC) AS Eldest_Student
FROM Courses;
END