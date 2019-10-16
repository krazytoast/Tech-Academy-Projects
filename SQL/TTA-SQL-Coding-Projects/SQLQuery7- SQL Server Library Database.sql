/* THIS CODE IS USED TO CREATED TO LIBRARY DATABASE */
Create Database db_library;

/*THIS IS USED TO SELECT THE db_library AS CURRENTLY USED DATABASE */
Use db_library;

/* THIS SECTION IS FOR CREATING EACH OF THE TABLES AND ASSIGNING THE APPROPRIATE PK's AND FK's
Create for each of the Tables and the columns - Primary Keys and foreign keys */
Create table tbl_Library (
	libranch_BranchID INT Primary Key NOT NULL Identity (1,1),
	libranch_BranchName varchar(40) NOT NULL,
	libranch_Address varchar(40) NOT NULL
);

Create Table tbl_Publisher (
	publish_PublisherName varchar(40) Primary Key NOT NULL,
	publish_Address varchar(40) NOT NULL,
	publish_Phone varchar(40) NOT NULL
);

Create table tbl_Books (
	bks_BookID INT Primary Key NOT NULL Identity (1000,1),
	bks_Title varchar(40) NOT NULL,
	bks_PublisherName varchar(40) NOT NULL Constraint fk_bks_PublisherName FOREIGN KEY REFERENCES tbl_Publisher(publish_PublisherName) ON UPDATE CASCADE ON DELETE CASCADE
);

Create table tbl_BkAuthors (
	auth_BookID INT NOT NULL Constraint fk_auth_BookID FOREIGN KEY REFERENCES tbl_Books(bks_BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	auth_AuthorName varchar(40) NOT NULL
);

Create table tbl_BkCopies (
	bkcop_BookID INT NOT NULL Constraint fk_bkcop_BookID FOREIGN KEY REFERENCES tbl_Books(bks_BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	bkcop_BranchID INT NOT NULL Constraint fk_bkcop_BranchID FOREIGN KEY REFERENCES tbl_Library(libranch_BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	bkcop_NumOfCop INT NOT NULL
);

Create table tbl_Borrower (
	bow_CardNo INT PRIMARY KEY NOT NULL Identity (10000,1),
	bow_Name varchar(40) NOT NULL,
	bow_Address varchar(40) NOT NULL,
	bow_Phone varchar(40) NOT NULL
);

Create table tbl_BkLoans (
	bkloan_BookID INT NOT NULL Constraint fk_bkloan_BookID FOREIGN KEY REFERENCES tbl_Books(bks_BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	bkloan_BranchID INT NOT NULL Constraint fk_bkloan_BranchID FOREIGN KEY REFERENCES tbl_Library(libranch_BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	bkloan_CardNo INT NOT NULL Constraint fk_bkloan_CardNo FOREIGN KEY REFERENCES tbl_Borrower(bow_CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	bkloan_DateOut DATE NOT NULL,
	bkloan_DateDue DATE NOT NULL
);


/* THIS SECTION IS USED FOR QUERYING THAT THE CREATED TABLES AND INSERTED DATA HAS BEEN DONE CORRECTLY
These commands are to test the Tables */
SELECT * FROM tbl_Library;
SELECT * FROM tbl_Publisher;
SELECT * FROM tbl_Books;
SELECT * FROM tbl_BkAuthors;
SELECT * FROM tbl_BkCopies;
SELECT * FROM tbl_BkLoans;
SELECT * FROM tbl_Borrower;

SELECT * FROM tbl_Library;
SELECT * FROM tbl_BkCopies;
SELECT * FROM tbl_Books;


/* THIS SECTION IS FOR INSERTING DATA INTO COLUMNS OF TABLES
Insert data into tables */
Insert INTO tbl_Library
	(libranch_BranchName, libranch_Address)
	VALUES
	('Northside', '345 Northside Blvd'),
	('Southside', '456 Southside Ct'),
	('Sharpstown', '567 Sharpstown Dr'),
	('Central', '678 Central Ln')
;

Insert INTO tbl_Publisher
	(publish_PublisherName, publish_Address, publish_Phone)
	VALUES
	('Publish House', '123 Publish House Ave', '555-123-5555'),
	('Publish King', '234 Publish King St', '555-234-5555'),
	('Publish Noble', '345 Publish Noble Way', '555-345-5555')
;

Insert INTO tbl_Books
	(bks_Title, bks_PublisherName)
	VALUES
	('IT', 'Publish House'),
	('Pet Sematary', 'Publish House'),
	('The Stand', 'Publish House'),
	('The Shining', 'Publish House'),
	('Carrie', 'Publish House'),
	('Misery', 'Publish House'),
	('The Outsider', 'Publish House'),
	('Salems Lot', 'Publish House'),
	('The Long Walk', 'Publish House'),
	('The Eyes of The Dragon', 'Publish House'),
	('The Green Mile', 'Publish House'),
	('Cujo', 'Publish House'),
	('The Body', 'Publish House'),
	('The Dark Tower', 'Publish House'),
	('Christine', 'Publish House'),
	('Under The Dome', 'Publish House'),
	('The Dead Zone', 'Publish House'),
	('Mr. Mercedes', 'Publish House'),
	('Revival', 'Publish House'),
	('Doctor Sleep', 'Publish House'),
	('Different Seasons', 'Publish House'),
	('Night Shift', 'Publish House'),
	('Desperation', 'Publish House'),
	('Insomnia', 'Publish House'),
	('Dreamcatcher', 'Publish House'),
	('Needful Things', 'Publish House'),
	('Shawshank Redemption', 'Publish House'),
	('Geralds Game', 'Publish House'),
	('The Talisman', 'Publish House'),
	('Firestarter', 'Publish House'),
	('The Lost Tribe', 'Publish King'),
	('The House That Fell From The Sky', 'Publish Noble'),
	('Dantes Wicked World', 'Publish Noble'),
	('Dantes Tower of Terror', 'Publish Noble'),
	('The Cat in the Hat', 'Publish King'),
	('Green Eggs and Ham', 'Publish King'),
	('How the Grinch Stole Christmas', 'Publish King'),
	('One Fish Two Fish Red Fish Blue Fish', 'Publish King'),
	('Game of Thrones', 'Publish King'),
	('Clash of Kings', 'Publish King'),
	('A Storm of Swords', 'Publish King'),
	('A Feast for Crows', 'Publish King'),
	('A Dance of Dragons', 'Publish King'),
	('The Hobbit', 'Publish King'),
	('Born to Rock', 'Publish King'),
	('Golden in Death', 'Publish King'),
	('The Stars Below', 'Publish King'),
	('Neon Prey', 'Publish King')
;

Insert INTO tbl_BkAuthors
	(auth_BookID, auth_AuthorName)
	VALUES
	(1000, 'Stephen King'),
	(1001, 'Stephen King'),
	(1002, 'Stephen King'),
	(1003, 'Stephen King'),
	(1004, 'Stephen King'),
	(1005, 'Stephen King'),
	(1006, 'Stephen King'),
	(1007, 'Stephen King'),
	(1008, 'Stephen King'),
	(1009, 'Stephen King'),
	(1010, 'Stephen King'),
	(1011, 'Stephen King'),
	(1012, 'Stephen King'),
	(1013, 'Stephen King'),
	(1014, 'Stephen King'),
	(1015, 'Stephen King'),
	(1016, 'Stephen King'),
	(1017, 'Stephen King'),
	(1018, 'Stephen King'),
	(1019, 'Stephen King'),
	(1020, 'Stephen King'),
	(1021, 'Stephen King'),
	(1022, 'Stephen King'),
	(1023, 'Stephen King'),
	(1024, 'Stephen King'),
	(1025, 'Stephen King'),
	(1026, 'Stephen King'),
	(1027, 'Stephen King'),
	(1028, 'Stephen King'),
	(1029, 'Stephen King'),
	(1030, 'Matthew Caldwell'),
	(1031, 'Patrick Delaney'),
	(1032, 'Patrick Delaney'),
	(1033, 'Patrick Delaney'),
	(1034, 'Theodr Seuss Geisel'),
	(1035, 'Theodr Seuss Geisel'),
	(1036, 'Theodr Seuss Geisel'),
	(1037, 'Theodr Seuss Geisel'),
	(1038, 'George R.R. Martin'),
	(1039, 'George R.R. Martin'),
	(1040, 'George R.R. Martin'),
	(1041, 'George R.R. Martin'),
	(1042, 'George R.R. Martin'),
	(1043, 'J.R.R. Tolkien'),
	(1044, 'James Patterson'),
	(1045, 'J D Robb'),
	(1046, 'David Baldacci'),
	(1047, 'John Sandford')
;

Insert INTO tbl_BkCopies
	(bkcop_BookID, bkcop_BranchID, bkcop_NumOfCop)
	VALUES
	(1000, 1, 10),
	(1001, 1, 10),
	(1002, 1, 10),
	(1003, 1, 10),
	(1004, 1, 10),
	(1005, 1, 10),
	(1006, 1, 10),
	(1007, 1, 10),
	(1008, 1, 10),
	(1009, 1, 10),
	(1010, 1, 10),
	(1011, 1, 10),
	(1012, 1, 10),
	(1013, 1, 10),
	(1014, 1, 10),
	(1015, 1, 10),
	(1016, 1, 10),
	(1017, 1, 10),
	(1018, 1, 10),
	(1019, 1, 10),
	(1020, 1, 10),
	(1021, 1, 10),
	(1022, 1, 10),
	(1023, 1, 10),
	(1024, 1, 10),
	(1025, 1, 10),
	(1026, 1, 10),
	(1027, 1, 10),
	(1028, 1, 10),
	(1029, 1, 10),
	(1030, 1, 10),
	(1031, 1, 10),
	(1032, 1, 10),
	(1033, 1, 10),
	(1034, 1, 10),
	(1035, 1, 10),
	(1036, 1, 10),
	(1037, 1, 10),
	(1038, 1, 10),
	(1039, 1, 10),
	(1040, 1, 10),
	(1041, 1, 10),
	(1042, 1, 10),
	(1043, 1, 10),
	(1044, 1, 10),
	(1045, 1, 10),
	(1046, 1, 10),
	(1047, 1, 10),
	(1000, 2, 10),
	(1001, 2, 10),
	(1002, 2, 10),
	(1003, 2, 10),
	(1004, 2, 10),
	(1005, 2, 10),
	(1006, 2, 10),
	(1007, 2, 10),
	(1008, 2, 10),
	(1009, 2, 10),
	(1010, 2, 10),
	(1011, 2, 10),
	(1012, 2, 10),
	(1013, 2, 10),
	(1014, 2, 10),
	(1015, 2, 10),
	(1016, 2, 10),
	(1017, 2, 10),
	(1018, 2, 10),
	(1019, 2, 10),
	(1020, 2, 10),
	(1021, 2, 10),
	(1022, 2, 10),
	(1023, 2, 10),
	(1024, 2, 10),
	(1025, 2, 10),
	(1026, 2, 10),
	(1027, 2, 10),
	(1028, 2, 10),
	(1029, 2, 10),
	(1030, 2, 10),
	(1031, 2, 10),
	(1032, 2, 10),
	(1033, 2, 10),
	(1034, 2, 10),
	(1035, 2, 10),
	(1036, 2, 10),
	(1037, 2, 10),
	(1038, 2, 10),
	(1039, 2, 10),
	(1040, 2, 10),
	(1041, 2, 10),
	(1042, 2, 10),
	(1043, 2, 10),
	(1044, 2, 10),
	(1045, 2, 10),
	(1046, 2, 10),
	(1047, 2, 10),
	(1000, 3, 10),
	(1001, 3, 10),
	(1002, 3, 10),
	(1003, 3, 10),
	(1004, 3, 10),
	(1005, 3, 10),
	(1006, 3, 10),
	(1007, 3, 10),
	(1008, 3, 10),
	(1009, 3, 10),
	(1010, 3, 10),
	(1011, 3, 10),
	(1012, 3, 10),
	(1013, 3, 10),
	(1014, 3, 10),
	(1015, 3, 10),
	(1016, 3, 10),
	(1017, 3, 10),
	(1018, 3, 10),
	(1019, 3, 10),
	(1020, 3, 10),
	(1021, 3, 10),
	(1022, 3, 10),
	(1023, 3, 10),
	(1024, 3, 10),
	(1025, 3, 10),
	(1026, 3, 10),
	(1027, 3, 10),
	(1028, 3, 10),
	(1029, 3, 10),
	(1030, 3, 10),
	(1031, 3, 10),
	(1032, 3, 10),
	(1033, 3, 10),
	(1034, 3, 10),
	(1035, 3, 10),
	(1036, 3, 10),
	(1037, 3, 10),
	(1038, 3, 10),
	(1039, 3, 10),
	(1041, 3, 10),
	(1042, 3, 10),
	(1043, 3, 10),
	(1044, 3, 10),
	(1045, 3, 10),
	(1046, 3, 10),
	(1047, 3, 10),
	(1000, 4, 10),
	(1001, 4, 10),
	(1002, 4, 10),
	(1003, 4, 10),
	(1004, 4, 10),
	(1005, 4, 10),
	(1006, 4, 10),
	(1007, 4, 10),
	(1008, 4, 10),
	(1009, 4, 10),
	(1010, 4, 10),
	(1011, 4, 10),
	(1012, 4, 10),
	(1013, 4, 10),
	(1014, 4, 10),
	(1015, 4, 10),
	(1016, 4, 10),
	(1017, 4, 10),
	(1018, 4, 10),
	(1019, 4, 10),
	(1020, 4, 10),
	(1021, 4, 10),
	(1022, 4, 10),
	(1023, 4, 10),
	(1024, 4, 10),
	(1025, 4, 10),
	(1026, 4, 10),
	(1027, 4, 10),
	(1028, 4, 10),
	(1029, 4, 10),
	(1030, 4, 10),
	(1031, 4, 10),
	(1032, 4, 10),
	(1033, 4, 10),
	(1034, 4, 10),
	(1035, 4, 10),
	(1036, 4, 10),
	(1037, 4, 10),
	(1038, 4, 10),
	(1039, 4, 10),
	(1040, 4, 10),
	(1041, 4, 10),
	(1042, 4, 10),
	(1043, 4, 10),
	(1044, 4, 10),
	(1045, 4, 10),
	(1046, 4, 10),
	(1047, 4, 10)
;

/* Book loan must be inserted after borrowers insert to reference cardID of connected borrower*/
Insert INTO tbl_BkLoans
	(bkloan_BookID, bkloan_BranchID, bkloan_CardNo, bkloan_DateOut, bkloan_DateDue)
	VALUES
	(1000, 1, 10000, '2019-05-20', '2019-06-20'),
	(1001, 1, 10000, '2019-05-20', '2019-06-20'),
	(1002, 1, 10000, '2019-05-20', '2019-06-20'),
	(1003, 1, 10000, '2019-05-20', '2019-06-20'),
	(1004, 1, 10000, '2019-05-20', '2019-06-20'),
	(1005, 1, 10001, '2019-05-20', '2019-06-20'),
	(1006, 1, 10001, '2019-05-20', '2019-06-20'),
	(1007, 1, 10001, '2019-05-20', '2019-06-20'),
	(1008, 1, 10001, '2019-05-20', '2019-06-20'),
	(1009, 1, 10001, '2019-05-20', '2019-06-20'),
	(1010, 1, 10002, '2019-05-20', '2019-06-20'),
	(1011, 1, 10002, '2019-05-20', '2019-06-20'),
	(1012, 1, 10002, '2019-05-20', '2019-06-20'),
	(1013, 1, 10002, '2019-05-20', '2019-06-20'),
	(1014, 1, 10002, '2019-05-20', '2019-06-20'),
	(1015, 1, 10003, '2019-05-20', '2019-06-20'),
	(1016, 1, 10003, '2019-05-20', '2019-06-20'),
	(1017, 1, 10003, '2019-05-20', '2019-06-20'),
	(1018, 1, 10003, '2019-05-20', '2019-06-20'),
	(1019, 1, 10003, '2019-05-20', '2019-06-20'),
	(1020, 1, 10004, '2019-05-20', '2019-06-20'),
	(1021, 1, 10004, '2019-05-20', '2019-06-20'),
	(1022, 1, 10004, '2019-05-20', '2019-06-20'),
	(1023, 1, 10004, '2019-05-20', '2019-06-20'),
	(1024, 1, 10004, '2019-05-20', '2019-06-20'),
	(1025, 1, 10005, '2019-05-20', '2019-06-20'),
	(1026, 1, 10005, '2019-05-20', '2019-06-20'),
	(1027, 1, 10005, '2019-05-20', '2019-06-20'),
	(1028, 1, 10005, '2019-05-20', '2019-06-20'),
	(1029, 1, 10005, '2019-05-20', '2019-06-20'),
	(1030, 1, 10006, '2019-05-20', '2019-06-20'),
	(1031, 1, 10006, '2019-05-20', '2019-06-20'),
	(1032, 1, 10006, '2019-05-20', '2019-06-20'),
	(1033, 1, 10006, '2019-05-20', '2019-06-20'),
	(1034, 1, 10006, '2019-05-20', '2019-06-20'),
	(1035, 1, 10006, '2019-05-20', '2019-06-20'),
	(1036, 1, 10006, '2019-05-20', '2019-06-20'),
	(1037, 1, 10006, '2019-05-20', '2019-06-20'),
	(1038, 1, 10006, '2019-05-20', '2019-06-20'),
	(1039, 1, 10006, '2019-05-20', '2019-06-20'),
	(1040, 1, 10006, '2019-05-20', '2019-06-20'),
	(1041, 1, 10006, '2019-05-20', '2019-06-20'),
	(1042, 1, 10006, '2019-05-20', '2019-06-20'),
	(1043, 1, 10006, '2019-05-20', '2019-06-20'),
	(1044, 1, 10006, '2019-05-20', '2019-06-20'),
	(1045, 1, 10006, '2019-05-20', '2019-06-20'),
	(1046, 1, 10006, '2019-05-20', '2019-06-20'),
	(1047, 1, 10006, '2019-05-20', '2019-06-20'),
	(1000, 2, 10000, '2019-05-20', '2019-06-20'),
	(1001, 2, 10000, '2019-05-20', '2019-06-20'),
	(1002, 2, 10000, '2019-05-20', '2019-06-20'),
	(1003, 2, 10000, '2019-05-20', '2019-06-20'),
	(1004, 2, 10000, '2019-05-20', '2019-06-20'),
	(1005, 2, 10001, '2019-05-20', '2019-06-20'),
	(1006, 2, 10001, '2019-05-20', '2019-06-20'),
	(1008, 2, 10001, '2019-05-20', '2019-06-20')
;

-- Adding additional books loaned by Sharpstown and Central
Insert INTO tbl_BkLoans
	(bkloan_BookID, bkloan_BranchID, bkloan_CardNo, bkloan_DateOut, bkloan_DateDue)
	VALUES
	(1000, 3, 10000, '2019-05-20', '2019-06-20'),
	(1001, 3, 10000, '2019-05-20', '2019-06-20'),
	(1002, 3, 10000, '2019-05-20', '2019-06-20'),
	(1003, 3, 10000, '2019-05-20', '2019-06-20'),
	(1004, 3, 10000, '2019-05-20', '2019-06-20'),
	(1005, 3, 10001, '2019-05-20', '2019-06-20'),
	(1006, 3, 10001, '2019-05-20', '2019-06-20'),
	(1007, 3, 10001, '2019-05-20', '2019-06-20'),
	(1008, 3, 10001, '2019-05-20', '2019-06-20'),
	(1009, 3, 10001, '2019-05-20', '2019-06-20'),
	(1010, 3, 10002, '2019-05-20', '2019-06-20'),
	(1011, 3, 10002, '2019-05-20', '2019-06-20'),
	(1012, 3, 10002, '2019-05-20', '2019-06-20'),
	(1013, 3, 10002, '2019-05-20', '2019-06-20'),
	(1014, 3, 10002, '2019-05-20', '2019-06-20'),
	(1015, 3, 10003, '2019-05-20', '2019-06-20'),
	(1016, 3, 10003, '2019-05-20', '2019-06-20'),
	(1017, 3, 10003, '2019-05-20', '2019-06-20'),
	(1018, 3, 10003, '2019-05-20', '2019-06-20'),
	(1019, 3, 10003, '2019-05-20', '2019-06-20'),
	(1020, 3, 10004, '2019-05-20', '2019-06-20'),
	(1021, 3, 10004, '2019-05-20', '2019-06-20'),
	(1022, 3, 10004, '2019-05-20', '2019-06-20'),
	(1023, 3, 10004, '2019-05-20', '2019-06-20'),
	(1024, 3, 10004, '2019-05-20', '2019-06-20'),
	(1025, 3, 10005, '2019-05-20', '2019-06-20'),
	(1026, 3, 10005, '2019-05-20', '2019-06-20'),
	(1027, 3, 10005, '2019-05-20', '2019-06-20'),
	(1028, 3, 10005, '2019-05-20', '2019-06-20'),
	(1029, 3, 10005, '2019-05-20', '2019-06-20'),
	(1030, 3, 10006, '2019-05-20', '2019-06-20'),
	(1031, 3, 10006, '2019-05-20', '2019-06-20'),
	(1032, 3, 10006, '2019-05-20', '2019-06-20'),
	(1033, 3, 10006, '2019-05-20', '2019-06-20'),
	(1034, 3, 10006, '2019-05-20', '2019-06-20'),
	(1035, 3, 10006, '2019-05-20', '2019-06-20'),
	(1036, 3, 10006, '2019-05-20', '2019-06-20'),
	(1037, 3, 10006, '2019-05-20', '2019-06-20'),
	(1038, 3, 10006, '2019-05-20', '2019-06-20'),
	(1039, 3, 10006, '2019-05-20', '2019-06-20'),
	(1040, 3, 10006, '2019-05-20', '2019-06-20'),
	(1041, 3, 10006, '2019-05-20', '2019-06-20'),
	(1042, 3, 10006, '2019-05-20', '2019-06-20'),
	(1043, 3, 10006, '2019-05-20', '2019-06-20'),
	(1044, 3, 10006, '2019-05-20', '2019-06-20'),
	(1045, 3, 10006, '2019-05-20', '2019-06-20'),
	(1046, 3, 10006, '2019-05-20', '2019-06-20'),
	(1047, 3, 10006, '2019-05-20', '2019-06-20'),
	(1000, 4, 10000, '2019-05-20', '2019-06-20'),
	(1001, 4, 10000, '2019-05-20', '2019-06-20'),
	(1002, 4, 10000, '2019-05-20', '2019-06-20'),
	(1003, 4, 10000, '2019-05-20', '2019-06-20'),
	(1004, 4, 10000, '2019-05-20', '2019-06-20'),
	(1005, 4, 10001, '2019-05-20', '2019-06-20'),
	(1006, 4, 10001, '2019-05-20', '2019-06-20'),
	(1008, 4, 10001, '2019-05-20', '2019-06-20')
;

/* Borrower info insert before Book loans insert to establish cardID */
Insert INTO tbl_Borrower
	(bow_Name, bow_Address, bow_Phone)
	VALUES
	('Bob', '123 Bob St', '555-123-5555'),
	('Steve', '234 Steve Ln', '555-234-5555'),
	('Jen', '345 Jen Way', '555-345-5555'),
	('Patrick', '456 Pat Rd', '555-456-5555'),
	('Matt', '567 Matt Ct', '555-567-5555'),
	('Sara', '678 Sara Blvd', '555-678-5555'),
	('Rex', '789 Rex Ave', '555-789-5555'),
	('Roxy', '890 Roxy St', '555-890-5555')
;








/* THIS SECTION IS ONLY TO BE USED FOR SEVERE EDITING -- ENTIRE DATABASE AND TABLE AND INFO MUST BE RECREATED
WARNING ONLY FOR COMPLETE REBUILD OF ENTIRE DATABASE
Used for severe editing only
Only use in emergency for wiping and recreating tables*/



/* THIS IS USED TO DROP THE LIBRARY DATABASE
THIS CAN ONLY BE DROPPED IF ANOTHER DATABASE IS SELECTED (see line 498)
WARNING --- DROPPING THE DATABASE WILL PERMANENTLY DELETE THE DATABASE */
-- Drop database db_library;



/* THIS IS USED TO DELETE/DROP EACH INDIVIDUAL TABLE WITHIN THE DATABASE
THIS CAN BE USED FOR TROUBLE SHOOTING EACH TABLE BUT CAN CREATE MAJOR ISSUES DUE TO PK's AND FK's THAT ARE CONNECTED
drop table tbl_Library;
drop table tbl_Publisher;
drop table tbl_Books;
drop table tbl_Book_Authors;
drop table tbl_Book_Copies;
drop table tbl_BkLoans;
drop table tbl_Borrower;
*/


/* Only use other db when severe editing is needed to drop db_library */
-- Use db_drill7;



/* THIS SECTION IS FOR TESTING QUERIES FOR THE ASSIGNMENT */
SELECT * FROM tbl_Library;
SELECT * FROM tbl_Publisher;
SELECT * FROM tbl_Books;
SELECT * FROM tbl_BkAuthors;
SELECT * FROM tbl_BkCopies;
SELECT * FROM tbl_BkLoans;
SELECT * FROM tbl_Borrower;



/* 1.) How many copies of the book titled "The Lost Tribe" are owned by the 
library branch whose name is "Sharpstown"? */
SELECT 
	a1.bkcop_NumOfCop AS "Book Copies: "
	,a2.Libranch_BranchName AS "Branch: "
	,a3.bks_Title AS "Book Title: "
	FROM tbl_BkCopies a1
	INNER JOIN tbl_Library a2 ON a2.libranch_BranchID = a1.bkcop_BranchID
	INNER JOIN tbl_Books a3 ON a3.bks_BookID = a1.bkcop_BookID
	WHERE bks_Title = 'The Lost Tribe' AND libranch_BranchName = 'Sharpstown'
;


/* 2.) How many copies of the book titled "The Lost Tribe" are owned by each library branch? */
SELECT 
	a1.bkcop_NumOfCop AS "Book Copies: "
	,a2.Libranch_BranchName AS "Branch: "
	,a3.bks_Title AS "Book Title: "
	FROM tbl_BkCopies a1
	INNER JOIN tbl_Library a2 ON a2.libranch_BranchID = a1.bkcop_BranchID
	INNER JOIN tbl_Books a3 ON a3.bks_BookID = a1.bkcop_BookID
	WHERE bks_Title = 'The Lost Tribe'
;


/* 3.) Retrieve the names of all borrowers who do not have any books checked out. */
SELECT
	a1.bow_Name AS "Borrowers with no books on loan"
	FROM tbl_Borrower a1
	FULL OUTER JOIN tbl_BkLoans a2 ON a2.bkloan_CardNo = a1.bow_CardNo
	WHERE a2.bkloan_CardNo IS NULL;
;


/* 4.) For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today,
retrieve the book title, the borrower's name, and the borrower's address. */
SELECT
	a1.bks_Title
	,a2.bow_Name
	,a2.bow_Address
	-- ,libranch_BranchName
	-- ,bkloan_DateDue
	FROM tbl_Books a1
	INNER JOIN tbl_BkLoans a3 ON bkloan_BookID = a1.bks_BookID
	INNER JOIN tbl_Library a4 ON libranch_BranchID = a3.bkloan_BranchID
	INNER JOIN tbl_Borrower a2 ON a2.bow_CardNo = a3.bkloan_CardNo
	WHERE a3.bkloan_DateDue = '2019-06-20' AND libranch_BranchName = 'Sharpstown';
;

-- For testing
USE db_library;
SELECT * FROM tbl_Bkloans;


/* 5.) For each library branch, retrieve the branch name and the total number of books loaned
out from that branch. */
SELECT
	a1.libranch_BranchName
	,COUNT(*) 'Books on Loan' 
	FROM tbl_Library a1
	INNER JOIN tbl_BkLoans a2 ON a2.bkloan_BranchID = a1.libranch_BranchID
	GROUP BY
	a1.libranch_BranchName
;

-- FOR TESTING
SELECT * FROM tbl_BkLoans;
SELECT * FROM tbl_Library;


/* 6.) Retrieve the names, addresses, and the number of books checked out for all borrowers who
have more than five books checked out. */
SELECT
	a1.bow_Name 'Borrower Name'
	,COUNT (*) 'Borrowed Books'
	,a1.bow_Address
	FROM tbl_Borrower a1
	INNER JOIN tbl_BkLoans a2 ON a2.bkloan_CardNo = a1.bow_CardNo
	GROUP BY
	a1.bow_Name
	,a1.bow_Address
	HAVING COUNT (*) > 5
;

-- FOR TESTING
SELECT * FROM tbl_Borrower;
SELECT * FROM tbl_BkLoans;


/* 7.) For each book authored (or co-authored) by "Stephen King", retrieve the title and the 
number of copies owned by the library branch whose name is "Central". */
/* STILL NEEDS WORK!!! NEED ADDITIONAL INFORMATION
*/
SELECT
	a1.bkcop_NumOfCop --'Number of Copies'
	,a2.bks_Title
	FROM tbl_BkCopies a1
	INNER JOIN tbl_Books a2 ON a2.bks_BookID = a1.bkcop_BookID
	INNER JOIN tbl_Library a3 ON a3.libranch_BranchID = a1.bkcop_BranchID
	INNER JOIN tbl_BkAuthors a4 ON a4.auth_BookID = a1.bkcop_BookID
	WHERE a3.libranch_BranchName = 'Central' AND a4.auth_AuthorName = 'Stephen King';
;

-- FOR TESTING
SELECT * FROM tbl_Books;
SELECT * FROM tbl_BkLoans;


















-- HELP FROM TTA
-- DONE make NumOfCop INT 
-- DONE remove all quotes from INT
-- DONE Q#3 needs to be changed to a FULL OUTER JOIN
-- DONE For Q#4 add books loaned by sharpstown and central library
-- DONE Q#7 & Q#6 helped with COUNT and GROUP BY clauses
-- DONE Update Q#5 column return 'Books on Loan' was incorrectly named