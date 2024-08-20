Create database Company;

CREATE TABLE Employee (
    Fname VARCHAR(50),
    Lname VARCHAR(50),
    middle VARCHAR(50),
    address VARCHAR(100),
    birthdate DATE,
    SSN INT PRIMARY KEY,
	SUPERSSN INT,
    salary DECIMAL,
    gender CHAR(1),
    Dept_number INT,
	FOREIGN KEY (SUPERSSN) REFERENCES Employee(SSN)
);

CREATE TABLE Department (
    Name VARCHAR(50),
    number INT PRIMARY KEY,
    managed_Emp_SSN INT,
	MGRSTARTDATE DATE,
    FOREIGN KEY (managed_Emp_SSN) REFERENCES Employee(SSN)
);

ALTER TABLE Employee
ADD CONSTRAINT fk_dept_number
FOREIGN KEY (Dept_number) REFERENCES Department(number);


CREATE TABLE Project (
    Name VARCHAR(50),
    number INT PRIMARY KEY,
    location VARCHAR(50),
    Dept_number INT,
    FOREIGN KEY (Dept_number) REFERENCES Department(number)
);

CREATE TABLE DEPENDENT (
    Dependent_name VARCHAR(50),
    gender CHAR(1),
    Relationship VARCHAR(50),
    BDate DATE,
    emp_SSN INT,
    FOREIGN KEY (emp_SSN) REFERENCES Employee(SSN),
    PRIMARY KEY (emp_SSN, Dependent_name)
);


CREATE TABLE Dept_loc (
    number INT,
    location VARCHAR(100),
    FOREIGN KEY (number) REFERENCES Department(number),
    PRIMARY KEY (number, location)
);


CREATE TABLE Works_ON (
    emp_SSN INT,
    proj_number INT,
    hours DECIMAL,
    FOREIGN KEY (emp_SSN) REFERENCES Employee(SSN),
    FOREIGN KEY (proj_number) REFERENCES Project(number),
    PRIMARY KEY (emp_SSN, proj_number)
);