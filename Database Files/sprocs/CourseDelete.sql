create or alter proc dbo.CourseDelete(
@CourseId int = 0,
@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @CourseId = isnull(@CourseId, 0)

	begin try
		begin tran
		delete mcr
		from MealCourseRecipe mcr
		join MealCourse mc
		on mc.MealCourseId = mcr.MealCourseId
		where mc.CourseId = @CourseId

		delete MealCourse where CourseId = @CourseId
		delete Course where CourseId = @CourseId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @Return

end