create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(250)
as
begin
	declare @value varchar(250) = ''
	;
	with ns as(
	select recipeid = r.recipeid, numsteps = count(d.directionid)
	from recipe r
	join direction d 
	on r.recipeid = d.recipeid
	group by r.recipeid
	)
		select @value = concat(r.recipename, ' (', c.cuisinetype, ') has ', count(ri.ingredientid), ' ingredients and ', case when ns.numsteps > 0 then ns.numsteps else 0 end, ' steps.')
		from recipe r
		join cuisine c 
		on r.cuisineid = c.cuisineid
		left join RecipeIngredient ri
		on r.recipeid = ri.recipeid
		left join ingredient i
		on i.ingredientid = ri.ingredientid
		left join ns
		on ns.recipeid = r.recipeid
		where r.recipeid = @RecipeId
		group by r.recipename, c.cuisinetype, ns.numsteps
	return @value
end
go

select recipedesc = dbo.recipedesc(recipeid), *
from recipe



