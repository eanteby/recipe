create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0, 
	@All bit = 0, 
	@Message varchar(500) = '' output 
)
as
begin
	declare @return int = 0
	
	select @RecipeId = isnull(@RecipeId, 0)

	select r.RecipeId, r.HeartyHearthUserId, r.CuisineId, r.RecipeName, r.RecipeStatus, h.UserName, r.NumCalories, NumIngredients = count(ri.IngredientId), r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipePic
	from Recipe r
	join HeartyHearthUser h
	on r.HeartyHearthUserId = h.HeartyHearthUserId
	left join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	where @All = 1
	or r.RecipeId = @RecipeId
	group by r.RecipeId, r.HeartyHearthUserId, r.CuisineId, r.RecipeName, r.RecipeStatus, h.UserName, r.NumCalories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipePic
	order by r.RecipeStatus desc
	return @return
end
go


