--1.Display all the employees Data. 
Select * from Employee;


--2.Display the employee First name, last name, Salary 
-- and Department number.
SELECT Fname, Lname, salary, Dept_number FROM Employee;


--3.Display all the projects names, locations 
-- and the department which is responsible about it.
SELECT Name , location , Dept_number FROM Project;



--4.If you know that the company policy is to pay an annual 
--commission for each employee which specific percent 
--equals 10% of his/her annual salary 
--.Display each employee full name and his annual 
--commission in an ANNUAL COMM column (alias).

SELECT Fname + ' ' + Lname As FullName, (Salary * 12 * 0.10) AS "ANNUAL COMM"
FROM Employee;

--5.Display the employees Id, name who earns more than 1000 LE monthly.
SELECT SSN, Fname, Lname FROM Employee WHERE Salary > 1000;

--6.Display the employees Id, name who earns more than 10000 LE annually.
SELECT SSN, Fname, Lname FROM Employee WHERE (Salary * 12) > 10000;

--7.Display the names and salaries of the female employees 
SELECT Fname, Lname, Salary FROM Employee WHERE gender = 'F';

--8.Display each department id, name which managed by a manager with id equals 968574.
SELECT number, Name FROM Department WHERE managed_Emp_SSN = 968574;

--9.Dispaly the ids, names and locations of the projects which controled with department 10. 
SELECT number, Name, location FROM Project WHERE Dept_number = 10;

--10.Display the Id, name and location of the projects in Cairo or Alex city.
SELECT number, Name, location FROM Project
WHERE location LIKE '%Cairo%' OR location LIKE '%Alex%';

--11.Display the Projects full data of the projects with a name starts with "a" letter.
SELECT * FROM Project WHERE Name LIKE 'a%';

--12.display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
SELECT * FROM Employee WHERE Dept_number = 30
  AND Salary BETWEEN 1000 AND 2000;



