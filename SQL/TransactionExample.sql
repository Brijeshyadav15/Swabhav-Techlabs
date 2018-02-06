Create table Merchant(
balance int
);

Create table Customer(
balance int
);

insert into merchant(balance)
Values(100000);

insert into customer(balance)
Values(1000);

Select * from merchant;
Select * from Customer;


BEGIN TRY
	BEGIN TRANSACTION
		update Merchant 
		Set balance = balance + 250;

		Select * from Merchant;
		Select * from Customer;

		update Customer 
		Set balance = balance - 'acv';
		
		COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK;
	PRINT 'INTO CATCH BLOCK';
END CATCH

		Select * from Merchant;
		Select * from Customer;
GO