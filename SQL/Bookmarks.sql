Use Techlabs
GO

Create Table BookMarkUsers
(
id int,
name varchar(30),
email varchar(30),
password varchar(20),
);


Insert into BookMarkUsers Values(1, '@name','@email','@password')

Delete from BookMarkUsers where id = 2

Create Table Bookmarks
(
id int PRIMARY KEY,
name varchar(30),
userId int FOREIGN KEY REFERENCES BookMarkUsers(id),
date datetime,
url varchar(255),
);


ALTER TABLE Bookmarks ALTER COLUMN date date not null

Select * from BookMarkUsers;
Select * from Bookmarks;

Delete from BookMarkUsers where id = 5

TRUNCATE TABLE BookMarkUsers;

Insert into Bookmarks Values(1, 'adaname',1, GETDATE(),'@url')