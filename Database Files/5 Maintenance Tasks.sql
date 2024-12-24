--AS Great job! 100% 
use HeartyHearthDB
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete mcr 
from MealCourseRecipe mcr 
join Recipe r 
on mcr.RecipeId = r.RecipeId
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete mcr 
from MealCourseRecipe mcr 
join MealCourse mc 
on mcr.MealCourseId = mc.MealCourseId
join Meal m  
on m.MealId = mc.MealId
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = m.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete ri
from RecipeIngredient ri
join Recipe r 
on ri.RecipeId = r.RecipeId
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete d 
from Direction d 
join Recipe r 
on d.RecipeId = r.RecipeId
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete cbr 
from CookBookRecipe cbr 
join Recipe r 
on cbr.RecipeId = r.RecipeId
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete cbr 
from CookBookRecipe cbr 
join CookBook cb 
on cbr.CookBookId = cb.CookBookId
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = cb.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete cb 
from CookBook cb 
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = cb.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete r
from recipe r 
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete mc 
from MealCourse mc 
join Meal m 
on mc.MealId = m.MealId
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = m.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete m
from Meal m 
join HeartyHearthUser hhu 
on hhu.HeartyHearthUserId = m.HeartyHearthUserId
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

delete hhu 
from HeartyHearthUser hhu 
where hhu.UserFirstName = 'Wanda'
and hhu.UserLastName = 'Wills'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(HeartyHearthUserId, CuisineId, RecipeName, NumCalories, DateArchived, DatePublished)
select r.HeartyHearthUserId, r.CuisineId, concat(r.RecipeName, ' -clone'), r.NumCalories, r.DateArchived, r.DatePublished
from Recipe r 
where r.RecipeName = 'Chocolate Chip Cookies'

;
with x as(
    select RecipeId = r.RecipeId 
    from Recipe r 
    where r.RecipeName = 'Chocolate Chip Cookies -clone'
)
insert Direction(RecipeId, StepNum, Instruction)
select x.RecipeId, d.StepNum, d.Instruction
from Direction d 
join Recipe r
on d.RecipeId = r.RecipeID 
cross join x 
where r.RecipeName = 'Chocolate Chip Cookies'

;
with x as(
    select RecipeId = r.RecipeId 
    from Recipe r 
    where r.RecipeName = 'Chocolate Chip Cookies -clone'
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, IngredientSequence, MeasurementAmount)
select x.RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.IngredientSequence, ri.MeasurementAmount
from RecipeIngredient ri  
join Recipe r
on ri.RecipeId = r.RecipeID 
cross join x 
where r.RecipeName = 'Chocolate Chip Cookies'


/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/

Insert CookBook (HeartyHearthUserId, CookBookName, CookBookPrice, IsActive)
select hhu.HeartyHearthUserId, concat('Recipes by ', hhu.UserFirstName, ' ', hhu.UserLastName), count(*) * 1.33, 1
from HeartyHearthUser hhu 
join Recipe r 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId 
where hhu.UserFirstName = 'Fredrick' and hhu.UserLastName = 'Peters'
group by hhu.HeartyHearthUserId, hhu.UserFirstName, hhu.UserLastName


insert CookBookRecipe (CookBookId, RecipeID, RecipeSequence)
select cb.CookBookId, r.RecipeId, row_number() over(order by RecipeId)
from Recipe r 
join HeartyHearthUser hhu 
on r.HeartyHearthUserId = hhu.HeartyHearthUserId
join CookBook cb 
on hhu.HeartyHearthUserId = cb.HeartyHearthUserId
where hhu.UserFirstName = 'Fredrick' 
and hhu.UserLastName = 'Peters'
and cb.CookBookName = 'Recipes by Fredrick Peters'
 


/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
set r.NumCalories -= case mt.MeasurementTypeDesc when 'ounce' then (2 * ri.MeasurementAmount) when 'stick' then (10 * ri.MeasurementAmount) end 
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Ingredient i 
on ri.IngredientId = i.IngredientId
join MeasurementType mt 
on mt.MeasurementTypeId = ri.MeasurementTypeId
where i.IngredientName = 'Butter'


/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with PublishedRecipes as(
    select AverageHoursToPublish = avg(datediff(hour, r.DateDrafted, r.DatePublished))
    from Recipe r 
    where r.DatePublished is not null 
)
select hhu.UserFirstName, 
    hhu.UserLastName, 
    EmailAddress = concat(substring(hhu.UserFirstName, 1, 1), hhu.UserLastName, '@heartyhearth.com'), 
    Alert = concat('Your recipe, ', r.RecipeName, ', is sitting in draft for ', datediff(hour, r.DateDrafted, getdate()), ' hours. That is ', datediff(hour, r.DateDrafted, getdate()) - pr.AverageHoursToPublish, ' hours more than the average ', pr.AverageHoursToPublish, ' hours all other recipes took to be published.' )
from HeartyHearthUser hhu 
join Recipe r 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
cross join PublishedRecipes pr 
where r.RecipeStatus = 'drafted'
and datediff(hour, r.DateDrafted, getdate()) > pr.AverageHoursToPublish
group by hhu.UserFirstName, hhu.UserLastName, r.RecipeName, r.DateDrafted, pr.AverageHoursToPublish
/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/

select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(*), ' books for sale, average price is ', cast(round(avg(cb.CookBookPrice), 2) as decimal(5, 2)), '. You can order them all and receive a 25% discount, for a total of ', cast(round(sum(cb.CookBookPrice) * .75, 2) as decimal(5, 2)), '. Click <a href = "www.heartyhearth.com/order/', NewId(), '>here</a> to order.')
from CookBook cb 
