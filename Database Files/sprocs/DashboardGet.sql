create or alter proc dbo.DashboardGet(
	@message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0
		select Type = 'Recipes', Number = count(*)
		from Recipe 
		union select 'Meals', count(*)
		from Meal
		union select 'Cookbooks', count(*)
		from Cookbook

	return @return
end
go
