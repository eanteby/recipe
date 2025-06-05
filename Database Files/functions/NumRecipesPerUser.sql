create or alter function dbo.NumRecipesPerUser(@UserId int)
returns int
as
begin
	declare @value int = 0
	select @value = count(r.RecipeId)
	from Recipe r
	where r.HeartyHearthUserId  = @UserId

	return @value
end
go
