create or alter proc dbo.CookbookGet(
	@CookbookId int = 0 output,
	@All bit = 0,
	@Message varchar(500) = ''
)
as
begin 
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId, 0)

	select c.CookbookId, h.HeartyHearthUserId, c.CookbookName, h.UserName, NumRecipes = count(cr.RecipeId), c.CookbookPrice, c.IsActive, c.DateCreated
	from Cookbook c
	left join CookbookRecipe cr
	on c.CookbookId = cr.CookbookId
	left join HeartyHearthUser h
	on h.HeartyHearthUserId = c.HeartyHearthUserId
	where c.CookbookId = @CookbookId
	or @All = 1
	group by c.CookbookId, h.HeartyHearthUserId, c.CookBookName, h.UserName, c.CookbookPrice, c.IsActive, c.DateCreated
	order by c.CookbookName

	return @return

end

