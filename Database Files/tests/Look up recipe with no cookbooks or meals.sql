

select *
from recipe r 
left join mealcourserecipe mcr
on mcr.recipeid = r.recipeid
left join cookbookrecipe cbr
on cbr.recipeid = r.recipeid
where mcr.mealcourseid is null
and cbr.cookbookrecipeid is null
