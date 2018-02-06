Use Techlabs

BEGIN TRY
		update Merchant 
		Set balance = balance + 250;

		update Customer 
		Set balance = balance ;
		
		Select * from Merchant;
		Select * from Customer;
END TRY


BEGIN CATCH
	ROLLBACK TRANSACTION;
END CATCH

		Select * from Merchant;
		Select * from Customer;
	
	COMMIT TRANSACTION;
GO