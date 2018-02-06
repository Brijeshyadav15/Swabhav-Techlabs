USE Techlabs

Select * from dbo.organizers;
Select * from dbo.exhibitions;

Insert into dbo.exhibitions(Exhibition_id,Exhibition_location,Exhibition_name,Organizer_id)
Values(1,'Ahmedabad','TEST',1);

Insert into dbo.exhibitions(Exhibition_id,Exhibition_location,Exhibition_name,Organizer_id)
Values(3,'Mumbai','TEST',4);