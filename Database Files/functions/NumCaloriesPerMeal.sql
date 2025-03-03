create or alter function dbo.NumCaloriesPerMeal(@MealId int)
returns int
as
begin
	declare @value int = 0
	select @value = sum(r.numcalories)
	from recipe r
	join mealcourserecipe mcr
	on mcr.recipeid = r.recipeid
	join mealcourse mc
	on mc.mealcourseid = mcr.mealcourseid
	join meal m
	on m.mealid = mc.mealid
	where m.mealid = @mealid

	return @value
end
go
select mealname, NumCaloriesPerMeal = dbo.numcaloriespermeal(mealid)
from meal