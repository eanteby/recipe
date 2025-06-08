create or alter procedure dbo.RecipeDelete(
	@RecipeId int, 
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	if exists(select * from recipe r where (r.RecipeStatus = 'published' or (r.RecipeStatus = 'archived' and datediff(day, r.DateArchived, getdate()) <30)) and r.RecipeId = @RecipeId)
	begin
		select @return = 1, @message = 'cannot delete recipe unless drafted or archived for 30+ days'
		goto finished
	end

	begin try
		begin tran
			delete RecipeIngredient where RecipeId =@RecipeId
			delete Direction where RecipeId = @RecipeId
			delete CookbookRecipe where RecipeId = @RecipeId
			delete MealCourseRecipe where RecipeId = @RecipeId
			delete recipe where RecipeId =@RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go

