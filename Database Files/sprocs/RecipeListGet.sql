create or alter procedure dbo.RecipeListGet(@Message varchar(500) = '' output )
as
begin
	declare @return int = 0
	select r.RecipeId, r.RecipeName, r.RecipeStatus, h.UserName, r.NumCalories, NumIngredients = count(ri.IngredientId)  
	from Recipe r
	join HeartyHearthUser h
	on r.HeartyHearthUserId = h.HeartyHearthUserId
	left join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	group by r.RecipeId, r.RecipeName, r.RecipeStatus, h.UserName, r.NumCalories
	order by r.RecipeStatus desc
	return @return
end
go
exec RecipeListGet

