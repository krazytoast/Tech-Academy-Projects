/* Instructing the use of db_zoo for running the drills 1-6 */
USE db_zoo

/*SQL Page 68 Drill 1: Compose a SELECT statement that queries for: All information from the habitat table.*/
SELECT * FROM tbl_habitat;

/*SQL Page 69 Drill 2: Compose a SELECT statement that queries the following: Retrieve all names from the species_name column that have a species_order value of 3.*/
SELECT species_name FROM tbl_species WHERE species_order = 3;

/*SQL Page 70 Drill 3: Compose a SELECT statement that queries: Retrieve only the nutrition_type from the nutrition table that have a nutrition_cost of 600.00 or less.*/
SELECT nutrition_type FROM tbl_nutrition WHERE nutrition_cost <= 600;

/*SQL Page 71 Drill 4: Compose a SELECT statement that queries: Retrieve all species_names with the nutrition_id between 2202 and 2206 from the nutrition table.*/
SELECT species_name FROM tbl_species WHERE species_nutrition BETWEEN 2202 AND 2206;

/*SQL Page 72 Drill 5: Compose a SELECT statement that queries: Retrieve all names within the species_name column using the alias "Species Name:" 
from the species table and their corresponding nutrition_type under the alias "Nutrition Type:" from the nutrition table.*/
SELECT
	a1.species_name AS "Species Name:", a2.nutrition_type AS "Nutrition Type:"
	FROM tbl_species a1
	INNER JOIN tbl_nutrition a2 ON a2.nutrition_id = a1.species_nutrition
;

/*SQL Page 73 Drill 6: Compose a SELECT statement that queries: From the specialist table, 
retrieve the first and last name and contact number of those that provide care for the penguins from the species table.*/
SELECT
	a1.specialist_fname AS "Specialist First Name:", 
	a1.specialist_lname AS "Specialist Last Name:", 
	a1.specialist_contact AS "Specialist Contact:"
	FROM tbl_specialist a1
	INNER JOIN tbl_care a5 ON a5.care_specialist = a1.specialist_id
	INNER JOIN tbl_species a4 ON a4.species_care = a5.care_id
	WHERE species_name = 'penguin'
;

/* Used for testing each individual tbl */
SELECT * FROM tbl_species;
SELECT * FROM tbl_care;
SELECT * FROM tbl_specialist;
SELECT * FROM tbl_habitat;

/* SQL Page 74 DRILL 7: Creating your own tables: Build a select statement that queries for the following information:
➤ Create a database with two tables. Assign a foreign key constraint on one table that shares related data with the primary key on the second table. 
Finally, create a statement that queries data from both tables.
If you need advice...How about a table with a first and last name column and a second table that has a phone number and address column?
When submitting DRILL 7 be sure to include the table creation code along with your INSERT statements and query. */

/* Create Database */
CREATE DATABASE db_drill7

/*Use Database for drill 7 */
USE db_drill7

/*Create first table and assign primary key to names_id */
CREATE TABLE tbl_names (
	names_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	names_first VARCHAR(50) NOT NULL,
	names_last VARCHAR(50) NOT NULL
);

/* INSERT data into the table */
INSERT INTO tbl_names
	(names_first, names_last)
	VALUES
	('Bob', 'Smith'),
	('Tom', 'Black'),
	('Sally', 'Rodgers'),
	('Jimbo', 'Rice'),
	('Veronica', 'Steel'),
	('Kevin', 'Loggins')
;

/* Create 2nd table and assign foreign key to address_id that shares data with tbl_names(names_id) */
CREATE TABLE tbl_address (
	address_street VARCHAR(50) PRIMARY KEY NOT NULL,
	address_city VARCHAR(50) NOT NULL,
	address_id INT NOT NULL CONSTRAINT fk_address_id FOREIGN KEY REFERENCES tbl_names(names_id) ON UPDATE CASCADE ON DELETE CASCADE
);

/* Insert data into tbl_address */
INSERT INTO tbl_address
	(address_street, address_city, address_id)
	VALUES
	('123 Topview', 'BrightCity', '1'),
	('5505 RoundTurn', 'Boston', '2'),
	('4875 BumbleBee', 'Aurora', '3'),
	('984 Lincoln', 'Gilbert', '4'),
	('3487 Campbell Way', 'Warren', '5'),
	('116 Mason St', 'Cheyenne', '6')
;

/* Select names_first using alias "NAME:" and address_street using alias "Street:" 
from tbl_names and JOIN tbl_address using address_id that is connected to names_id in order to display related address. */
SELECT
	a1.names_first AS "Name:", a2.address_street AS "Street:"
	FROM tbl_names a1
	INNER JOIN tbl_address a2 ON a2.address_id = a1.names_id
;

/* for testing each table idividually */
SELECT * FROM tbl_names;
SELECT * FROM tbl_address;