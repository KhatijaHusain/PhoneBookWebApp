CREATE TABLE EntryBook
(
	person_id SERIAL PRIMARY KEY,
    person_name character varying(50) NOT NULL,
    phone_no integer,
	phone_book_id integer References PhoneBook(phone_book_id)
)
