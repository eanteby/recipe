create or alter proc dbo.CookbookGet(
	@CookbookId int = 0 output,
	@Message varchar(500) = ''
)
as
begin 
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId, 0)

	select c.CookbookId, h.HeartyHearthUserId, c.CookBookName, c.CookbookPrice, c.IsActive, c.DateCreated
	from Cookbook c
	join HeartyHearthUser h
	on h.HeartyHearthUserId = c.HeartyHearthUserId
	left join CookbookRecipe cr
	on c.CookbookId = cr.CookbookId
	where c.CookbookId = @CookbookId

	return @return

end
go


