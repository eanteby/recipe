create or alter proc dbo.CookbookListGet(
@CookbookId int = 0 output,
@All bit = 0,
@Message varchar(500) = ''
)
as
begin 
declare @return int = 0

select c.CookbookId, c.CookBookName, h.UserName, NumRecipes = count(cr.RecipeId), c.CookbookPrice
from Cookbook c
left join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
left join HeartyHearthUser h
on h.HeartyHearthUserId = c.HeartyHearthUserId
where c.CookbookId = @CookbookId
or @All = 1
group by c.CookbookId, c.CookBookName, h.UserName, c.CookbookPrice
order by c.CookbookName

return @return

end

select * from cookbookrecipe