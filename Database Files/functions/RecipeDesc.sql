create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(250)
as
begin
	declare @value varchar(250) = ''
		select @value = concat(r.recipename, ' (', c.cuisinetype, ') has ', count(distinct ri.ingredientid), ' ingredients and ', count(distinct d.directionid), ' steps.')
		from recipe r
		join cuisine c 
		on r.cuisineid = c.cuisineid
		left join RecipeIngredient ri
		on r.recipeid = ri.recipeid
		left join ingredient i
		on i.ingredientid = ri.ingredientid
		left join direction d
		on d.RecipeId = r.RecipeId
		where r.recipeid = @RecipeId
		group by r.recipename, c.cuisinetype
	return @value
end
go

select recipedesc = dbo.recipedesc(recipeid), *
from recipe



