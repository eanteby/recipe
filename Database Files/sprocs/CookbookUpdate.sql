create or alter proc dbo.CookbookUpdate(
@CookbookId int = 0  output,
@HeartyHearthUserId int = 0,
@CookbookName varchar(200) = '',
@CookbookPrice decimal = 0,
@IsActive bit = 0,
@DateCreated datetime = '' output,
@Message varchar(500) = '' output
)
as
begin

declare @return int = 0
select @CookbookId = isnull(@CookbookId, 0), @IsActive = isnull(@IsActive, 0)

if (@CookbookId = 0)
	begin 
		insert Cookbook(HeartyHearthUserId, CookbookName, CookbookPrice, IsActive, DateCreated)
		values(@HeartyHearthUserId, @CookbookName, @CookbookPrice, @IsActive, GETDATE())

		select @CookbookId = SCOPE_IDENTITY(), @DateCreated = DateCreated from Cookbook where CookbookId = SCOPE_IDENTITY()
	end

else
	begin
		update Cookbook
		set 
		HeartyHearthUserId = @HeartyHearthUserId, 
		CookbookName = @CookbookName, 
		CookbookPrice = @CookbookPrice, 
		IsActive = @IsActive, 
		DateCreated = @DateCreated
		from Cookbook 
		where CookbookId = @CookbookId

	end

return @return

end

select * from Cookbook

