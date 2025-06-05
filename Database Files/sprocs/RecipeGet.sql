create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(150) = '' )
as
begin
	
	select @RecipeId = isnull(@RecipeId, 0)

	select r.RecipeId, r.HeartyHearthUserId, r.CuisineId, r.RecipeName, r.NumCalories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic, 
	RecipeDesc = dbo.RecipeDesc(r.recipeid)
	from Recipe r
	where @All = 1
	or r.RecipeId = @RecipeId
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
end
go

/*
exec RecipeGet --should be blank

exec RecipeGet @All = 1 --full result set

exec RecipeGet @RecipeName = 'g'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from recipe r
exec RecipeGet @RecipeId = @RecipeId
*/
