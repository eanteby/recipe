create or alter procedure dbo.RecipeDelete(@RecipeId int)
as
begin
	begin try
		begin tran
		delete RecipeIngredient where RecipeId =@RecipeId
		delete Direction where RecipeId = @RecipeId
		delete recipe where RecipeId =@RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go