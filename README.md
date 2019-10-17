# CibDigiTechWebApp
Dotnet core web api 2.1 Application using Entity Framework, Repository Pattern, Dependency Injection and Postgres Database


Scripts for DB

CREATE TABLE EntryBook
(
	person_id SERIAL PRIMARY KEY Not NULL,
    person_name character varying(50) NOT NULL,
    phone_no integer,
	phone_book_id integer References PhoneBook(phone_book_id)
)

CREATE TABLE PhoneBook
(
	phone_book_id SERIAL PRIMARY KEY NOT NULL,
    phone_book_name character varying(50) NOT NULL,
)


INSERT INTO entrybook(
	person_id, person_name, phone_no, phone_book_id)
	VALUES 
	(1, 'John', 56886, 1),
	 (2, 'Marie', 658769, 3),
	 (3, 'Khatija', 217972, 4),
	 (4, 'Leeza', 25699, 1),
	 (5, 'John', 56886, 4),
	 (6, 'Huzefa', 658769, 3),
	 (7, 'Philip', 217972, 4),
	 (8, 'John', 56886, 6),
	 (9, 'Marie', 658769, 3),
	 (10, 'Amel', 217972, 4),
	 (11, 'Leeza', 25699, 4)

INSERT INTO PhoneBook(
	phone_book_id, phone_book_name)
	VALUES (1, 'Home'),
	(2, 'Kitty'),
	(3, 'Club'),
	(4, 'School'),
	(5, 'Work')
	
