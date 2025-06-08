create or alter proc dbo.MealListGet(
	@MealId int = 0,
	@All bit = 1,
	@Message varchar(500) = '' output
)
as
begin

	declare @return int = 0

	select m.MealId, m.MealName, h.UserName, NumCalories = sum(r.NumCalories), NumCourses = count(distinct mc.MealCourseId), NumRecipes = count(r.RecipeId)
	from Meal m
	join HeartyHearthUser h
	on m.HeartyHearthUserId = h.HeartyHearthUserId
	join MealCourse mc
	on mc.MealId = m.MealId
	join MealCourseRecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	join Recipe r
	on mcr.RecipeId = r.RecipeId
	where @All = 1
	or m.MealId = @MealId
	group by m.MealId, m.MealName, h.UserName
	order by m.MealName

	return @return
end

go
--exec MealListGet

--select * from Meal where mealname = 'winner dinner'
--select * from mealcourse where mealid = 1
--select * from mealcourserecipe where mealcourseid = 12