create or alter proc dbo.HeartyHearthUserDelete(
@HeartyHearthUserId int = 0,
@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @HeartyHearthUserId = isnull(@HeartyHearthUserId, 0)

	begin try
		begin tran
		delete mcr 
		from MealCourseRecipe mcr 
		join Recipe r 
		on mcr.RecipeId = r.RecipeId
		where r.HeartyHearthUserId = @HeartyHearthUserId

		delete mcr 
		from MealCourseRecipe mcr 
		join MealCourse mc 
		on mcr.MealCourseId = mc.MealCourseId
		join Meal m  
		on m.MealId = mc.MealId
		where m.HeartyHearthUserId = @HeartyHearthUserId

		delete ri
		from RecipeIngredient ri
		join Recipe r 
		on ri.RecipeId = r.RecipeId
		where r.HeartyHearthUserId = @HeartyHearthUserId

		delete d 
		from Direction d 
		join Recipe r 
		on d.RecipeId = r.RecipeId
		where r.HeartyHearthUserId = @HeartyHearthUserId

		delete cbr 
		from CookBookRecipe cbr 
		join Recipe r 
		on cbr.RecipeId = r.RecipeId
		where r.HeartyHearthUserId = @HeartyHearthUserId

		delete cbr 
		from CookBookRecipe cbr 
		join CookBook cb 
		on cbr.CookBookId = cb.CookBookId
		where cb.HeartyHearthUserId = @HeartyHearthUserId

		delete CookBook where HeartyHearthUserId = @HeartyHearthUserId

		delete recipe where HeartyHearthUserId = @HeartyHearthUserId

		delete mc 
		from MealCourse mc 
		join Meal m 
		on mc.MealId = m.MealId 
		where m.HeartyHearthUserId = @HeartyHearthUserId

		delete Meal where HeartyHearthUserId = @HeartyHearthUserId

		delete HeartyHearthUser where HeartyHearthUserId = @HeartyHearthUserId

		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @Return

end