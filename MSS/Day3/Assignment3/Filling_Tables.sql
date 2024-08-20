ALTER TABLE Employee
DROP COLUMN middle;

INSERT INTO Employee (Fname, Lname, SSN, birthdate, [address], gender, salary, Superssn)
VALUES ('Ahmed', 'Ali', 112233, '1965-01-01', '15 Ali fahmy St.Giza', 'M', 1300, 223344),
('Kamel', 'Mohamed', 223344, '1970-10-15', '38 Mohy el dien abo el Ezz St.Cairo', 'M', 1800, 321654),
('Hanaa', 'Sobhy', 123456, '1973-03-18', '38 Abdel Khalik Tharwat St. Downtown.Cairo', 'F', 800, 223344),
('Amr', 'Omran', 321654, '1963-09-14', '44 Hilopolis.Cairo', 'M', 2500, 321654),
('Noha', 'Mohamed', 968574, '1975-02-01', '55 Orabi St. El Mohandiseen .Cairo', 'F', 1600, 321654),
('Edward', 'Hanna', 512463, '1972-08-19', '18 Abaas El 3akaad St. Nasr City.Cairo', 'M', 1500, 321654),
('Mariam', 'Adel', 669955, '1982-06-12', '269 El-Haram st. Giza', 'F', 750, 512463),
('Maged', 'Raoof', 521634, '1980-04-06', '18 Kholosi st.Shobra.Cairo', 'M', 1000, 968574);


INSERT INTO Department ([Name], number,[managed_Emp_SSN],[MGRSTARTDATE])
VALUES 
('DP1', 101, 223344, '2005-01-01'),
('Sales', 20, 968574, '2006-03-01'),
('DP3', 30, 512463, '2006-06-01'),
('DP3', 406, 512463, '2006-06-01');

update Employee set Dept_number = 10 where Fname in ('Ahmed','Kamel','Hanaa' ,'Amr');  
update Employee set Dept_number = 20 where Fname in ('Noha','Mariam');  
update Employee set Dept_number = 30 where Fname in ('Edward','Maged');  


INSERT INTO Project ([Name], number, [location], Dept_number)
VALUES ('AL Solimaniah', 100, 'Cairo_Alex Road', 10),
       ('Al Rabwah', 200, '6th of October City', 10),
       ('Al Rawdah', 300, 'Zaied City', 10),
       ('Al Rowad', 400, 'Cairo_Faiyom Road', 20),
       ('Al Rehab', 500, 'Nasr City', 30),
       ('Pitcho american', 600, 'Maady', 30),
       ('Ebad El Rahman', 700, 'Ring Road', 20);


INSERT INTO Works_ON (emp_SSN, proj_number, hours)
VALUES (223344, 100, 10),
       (223344, 200, 10),
       (223344, 300, 10),
       (112233, 100, 40),
       (968574, 400, 15),
       (968574, 700, 15),
       (968574, 300, 10),
       (669955, 400, 20),
       (223344, 500, 10),
       (669955, 700, 7),
       (669955, 300, 10),
       (512463, 500, 10),
       (512463, 600, 25),
       (521634, 500, 10),
       (521634, 600, 20),
       (521634, 300, 6),
       (521634, 400, 4);

INSERT INTO DEPENDENT (emp_SSN, Dependent_name, gender, BDate)
VALUES (112233, 'Hala Saied Ali', 'F', '1970-10-18'),
       (223344, 'Ahmed Kamel Shawki', 'M', '1998-03-27'),
       (223344, 'Mona Adel Mohamed', 'F', '1975-04-25'),
       (321654, 'Ramy Amr Omran', 'M', '1990-01-26'),
       (321654, 'Omar Amr Omran', 'M', '1993-03-30'),
       (321654, 'Sanaa Gawish', 'F', '1973-05-16'),
       (512463, 'Sara Edward', 'F', '2001-09-15'),
       (512463, 'Nora Ghaly', 'F', '1976-06-22');

