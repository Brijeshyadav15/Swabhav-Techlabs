CREATE TABLE organizers
(
Organizer_id int,
Organizer_name varchar(50),
Organizer_contact varchar(50)
PRIMARY KEY (Organizer_id),
);

CREATE TABLE exhibitions
(
Exhibition_id int,
Exhibition_name varchar(50),
Exhibition_date varchar(50),
Exhibition_location varchar(50),
PRIMARY KEY (Exhibition_id),
Organizer_id int FOREIGN KEY REFERENCES organizers(Organizer_id),
);

Select * from organizers;
Select * from exhibitions;