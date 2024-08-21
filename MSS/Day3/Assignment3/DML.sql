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


  --13.Display the Department id, name and id and the name of its manager.
SELECT 
    D.number, 
    D.Name, 
    Employee.SSN, 
    Employee.Fname+ ' '+ Employee.Lname AS "Manager Name"
FROM 
    Department D
JOIN 
    Employee ON D.managed_Emp_SSN = Employee.SSN;


  --14.Display the name of the departments and the name of the projects 
  --under its control.
SELECT 
    Department.Name , 
    Project.Name 
FROM 
    Department
JOIN 
    Project ON Department.number = Project.Dept_number;


  --15.Display the full data about all the dependence associated with the name of the employee they depend on him/her.
  SELECT 
    DEPENDENT.Dependent_name,
    DEPENDENT.gender,
    DEPENDENT.Relationship,
    DEPENDENT.BDate,
    CONCAT(Employee.Fname, ' ', Employee.Lname) AS "Employee Name",
    Employee.SSN
FROM 
    DEPENDENT
JOIN 
    Employee ON DEPENDENT.emp_SSN = Employee.SSN;


 --16.Display (Using Union Function)
--a. The name and the gender of the dependence that's gender is Female 
--and depending on Female Employee.
SELECT 
    DEPENDENT.Dependent_name, 
    DEPENDENT.gender
FROM 
    DEPENDENT
JOIN 
    Employee ON DEPENDENT.emp_SSN = Employee.SSN
WHERE 
    DEPENDENT.gender = 'F' 
    AND Employee.gender = 'F'

UNION
--b. And the male dependence that depends on Male Employee.
SELECT 
    DEPENDENT.Dependent_name, 
    DEPENDENT.gender
FROM 
    DEPENDENT
JOIN 
    Employee ON DEPENDENT.emp_SSN = Employee.SSN
WHERE 
    DEPENDENT.gender = 'M' 
    AND Employee.gender = 'M';

  --17.Display the full data of the employees who is managing any of the company's departments.
SELECT * FROM Employee
WHERE SSN IN (SELECT managed_Emp_SSN FROM Department);

  --18.Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
SELECT 
    Employee.Fname, 
    Employee.Lname
FROM 
    Employee
JOIN 
    Works_ON ON Employee.SSN = Works_ON.emp_SSN
JOIN 
    Project ON Works_ON.proj_number = Project.number
WHERE 
    Employee.Dept_number = 10 
    AND Project.Name = 'Al Rabwah'
    AND Works_ON.hours >= 10;


  --19.Find the names of the employees who directly supervised with Kamel Mohamed.
SELECT 
    Employee.Fname, 
    Employee.Lname
FROM 
    Employee
WHERE 
    Employee.SUPERSSN = (
        SELECT SSN 
        FROM Employee 
        WHERE Fname = 'Kamel' 
        AND Lname = 'Mohamed'
    );

  --20.For each project, list the project name and the total hours per week (for all employees) spent on that project.
SELECT 
    Project.Name, 
    SUM(Works_ON.hours)
FROM 
    Project
JOIN 
    Works_ON ON Project.number = Works_ON.proj_number
GROUP BY 
    Project.Name;

  --21.Retrieve the names of all employees who work in every project sorted.
SELECT 
    Employee.Fname, 
    Employee.Lname
FROM 
    Employee
WHERE 
    NOT EXISTS (
        SELECT * 
        FROM Project 
        WHERE NOT EXISTS (
            SELECT * 
            FROM Works_ON 
            WHERE Works_ON.emp_SSN = Employee.SSN 
            AND Works_ON.proj_number = Project.number
        )
    )
ORDER BY 
    Employee.Lname, Employee.Fname;

  -- 22.Display the data of the department which has the smallest employee ID over all employees' ID.
SELECT 
    Department.number,
    Department.Name,
    Department.managed_Emp_SSN,
    Department.MGRSTARTDATE
FROM 
    Department
JOIN 
    Employee ON Department.number = Employee.Dept_number
WHERE 
    Employee.SSN = (
        SELECT MIN(SSN) 
        FROM Employee
    );

  --23.For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
SELECT 
    Department.Name AS "Department Name",
    MAX(Employee.Salary) AS "Maximum Salary",
    MIN(Employee.Salary) AS "Minimum Salary",
    AVG(Employee.Salary) AS "Average Salary"
FROM 
    Department
JOIN 
    Employee ON Department.number = Employee.Dept_number
GROUP BY 
    Department.Name;


  -- 24.List the last name of all managers who have no dependents.
SELECT 
    Employee.Lname
FROM 
    Employee
JOIN 
    Department ON Employee.SSN = Department.managed_Emp_SSN
LEFT JOIN 
    DEPENDENT ON Employee.SSN = DEPENDENT.emp_SSN
WHERE 
    DEPENDENT.emp_SSN IS NULL;

  -- 25.For each department-- if its average salary is less than the average salary of all departments-- display its number, name and number of its employees.

  -- 26.Retrieve a list of employees and the projects they are working on ordered by department and within each department, 
  --ordered alphabetically by last name, first name.
SELECT 
    Employee.Lname,
    Employee.Fname,
    Project.Name,
    Employee.Dept_number
FROM 
    Employee
JOIN 
    Works_ON ON Employee.SSN = Works_ON.emp_SSN
JOIN 
    Project ON Works_ON.proj_number = Project.number
ORDER BY 
    Employee.Dept_number, 
    Employee.Lname, 
    Employee.Fname;

  --27.For each project located in Cairo City , find the project number, the controlling department name ,
  --the department manager last name ,address and birthdate. 
SELECT 
    Project.number,
    Department.Name,
    Manager.Lname,
    Manager.address,
    Manager.birthdate
FROM 
    Project
JOIN 
    Department ON Project.Dept_number = Department.number
JOIN 
    Employee AS Manager ON Department.managed_Emp_SSN = Manager.SSN
WHERE 
    Project.location = 'Cairo'
ORDER BY 
    Project.number;

  -- 28.Make a list of all projects’ numbers for projects that involve an employee whose last name is Mohamed,
  --either as a worker or as a manager of the department that controls the project.(solve it with nested Q or union function )
-- Query to find projects involving Mohamed as a worker


  --29.Display the employee number and name who has no dependent on him/her (use exists).
SELECT 
    Employee.SSN,
    Employee.Lname,
    Employee.Fname
FROM 
    Employee
WHERE 
    NOT EXISTS (
        SELECT 1
        FROM DEPENDENT
        WHERE DEPENDENT.emp_SSN = Employee.SSN
    );
