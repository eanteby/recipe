--AS Amazing job! 100%
use HeartyHearthDB
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select Item = 'Recipes', Amount = count(*)
from Recipe r
union select 'Meals', count(*)
from Meal m 
union select 'CookBooks', count(*)
from CookBook cb  

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. Archived recipes should appear gray on the website.
	In order for the recipe name to be gray on the website, surround the archived recipe names with: <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/

select RecipeName = case when r.Datepublished is not null and r.DateArchived is null then r.RecipeName else concat('<span style="color:gray">', r.RecipeName, '</span>') end, 
    RecipeStatus = case when r.Datepublished is not null and r.DateArchived is null then 'Published' else 'Archived' end, 
    DatePublished = isnull(convert(varchar, r.DatePublished, 101), ''), 
    DateArchived = isnull(convert(varchar, r.DateArchived, 101), ''), 
    hhu.UserFirstName,
    hhu.UserLastName, 
    r.NumCalories, 
    NumIngredients = count(*) 
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join HeartyHearthUser hhu
on hhu.HeartyHearthUserId = r.HeartyHearthUserId 
where r.DatePublished is not null or r.DateArchived is not null 
group by r.RecipeId, r.RecipeName, r.DatePublished, r.DateArchived, hhu.UserFirstName, hhu.UserLastName, r.NumCalories
order by RecipeStatus desc, r.DateArchived desc 

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
select r.RecipeName, r.NumCalories, NumIngredients = count(distinct ri.IngredientId), NumSteps = count(distinct d.DirectionId), r.RecipePic
from Recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeId
join Direction d 
on d.RecipeId = r.RecipeID
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.NumCalories, r.RecipePic

select Ingredients = concat(ri.MeasurementAmount, ' ', mt.MeasurementTypeDesc, ' ', i.IngredientName)
from Ingredient i 
join RecipeIngredient ri 
on ri.IngredientId = i.IngredientId
join MeasurementType mt 
on mt.MeasurementTypeId = ri.MeasurementTypeId
join Recipe r 
on r.RecipeID = ri.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies' 
order by ri.IngredientSequence

select d.Instruction
from Direction d 
join Recipe r 
on d.RecipeId = r.RecipeID 
where r.RecipeName = 'Chocolate Chip Cookies'
order by d.StepNum
/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
select m.MealName, hhu.UserFirstName, hhu.UserLastName, NumCalories = sum(r.NumCalories), NumCourses = count(distinct mc.MealCourseId), NumRecipes = count(r.RecipeId)
from Meal m 
join HeartyHearthUser hhu 
on m.HeartyHearthUserId = hhu.HeartyHearthUserId
join MealCourse mc 
on m.MealId = mc.MealId
left join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
left join Recipe r 
on mcr.RecipeId = r.RecipeID
where m.IsActive = 1
group by m.MealName, hhu.UserFirstName, hhu.UserLastName
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, hhu.UserFirstName, hhu.UserLastName, m.DateCreated, m.MealPic
from Meal m 
join HeartyHearthUser hhu 
on m.HeartyHearthUserId = hhu.HeartyHearthUserId
where m.mealName = 'Breakfast Bash'


select MealDetails = case c.CourseName 
    when 'main course' then concat(case mcr.IsMain 
            when 1 then '<b>' 
            end, 
            c.CourseName, ': ', case mcr.ismain 
                when 1 then 'main dish - ' 
                else 'side dish - ' 
                end, 
                r.RecipeName) 
    else concat(c.CourseName, ': ', r.RecipeName) 
    end, m.Mealpic
from Meal m 
join MealCourse mc 
on m.MealId = mc.MealId
join course c 
on mc.CourseId = c.CourseId
join MealCourseRecipe mcr 
on mcr.MealCourseId = mc.MealCourseId
join Recipe r 
on mcr.RecipeId = r.RecipeID
where m.MealName = 'Breakfast Bash'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select cb.CookBookName, hhu.UserFirstName, hhu.UserLastName, NumRecipes = count(cbr.RecipeId)
from CookBook cb 
join HeartyHearthUser hhu 
on cb.HeartyHearthUserId = hhu.HeartyHearthUserId
left join CookBookRecipe cbr
on cb.CookBookId = cbr.CookBookId
where cb.IsActive = 1
group by cb.CookBookName, hhu.UserFirstName, hhu.UserLastName
order by cb.CookBookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
select cb.CookbookName, hhu.UserFirstName, hhu.UserLastName, cb.DateCreated, cb.CookBookPrice, NumRecpies = count(cbr.RecipeId), cb.CookBookPic
from CookBook cb 
join HeartyHearthUser hhu 
on cb.HeartyHearthUserId = hhu.HeartyHearthUserId
join CookBookRecipe cbr 
on cb.CookBookId = cbr.CookBookId
where cb.CookBookName = 'Treats for Two'
group by cb.CookBookName, hhu.UserFirstName, hhu.UserLastName, cb.DateCreated, cb.CookBookPrice, cb.CookBookPic

select r.RecipeName, c.CuisineType, NumIngredients = count(distinct ri.IngredientId), NumSteps = count(distinct d.DirectionId)
from Recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeId
join Cuisine c 
on r.CuisineId = c.CuisineId
join Direction d 
on r.RecipeID = d.RecipeId
join CookBookRecipe cbr 
on cbr.RecipeID = r.RecipeID 
join CookBook cb 
on cbr.CookBookId = cb.CookBookId
where cb.CookBookName = 'Treats for Two'
group by  r.RecipeName, cbr.RecipeSequence, c.CuisineType
order by cbr.RecipeSequence
/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
select * from CookBook
select RecipeName = concat(upper(substring(reverse(r.RecipeName), 1, 1)), lower(substring(reverse(r.RecipeName), 2, len(r.RecipeName)))), 
    RecipePic = replace(
        r.RecipePic, 
        replace(r.RecipeName, ' ', '_'),
        replace(concat(upper(substring(reverse(r.RecipeName), 1, 1)), lower(substring(reverse(r.RecipeName), 2, len(r.RecipeName)))), ' ', '_')
        ) 
from Recipe r 
join CookBookRecipe cbr 
on r.RecipeID = cbr.RecipeID
--group by r.RecipeName, r.RecipePic
--having count(cbr.RecipeID) = (select count(*) from CookBook cb)

 ;
 with LastInstruction as(
    select RecipeId = d.RecipeId, LastInstruction = Max(d.StepNum)
    from Direction d
    group by d.RecipeId
 )
 select d.Instruction 
 from Direction d 
 join LastInstruction li 
 on d.RecipeId = li.RecipeId
 and d.StepNum = li.LastInstruction

/*
For site administration page:
5 seperate reports
*/
--    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
--AS Once you add the recipestatus to the table, this can be done simply
;
with x as(
    select hhu.UserFirstName, hhu.UserLastName, NumPublishedRecipes = case r.RecipeStatus when 'Published' then count(r.RecipeId) end,
        NumArchivedRecipes = case r.RecipeStatus when 'Archived' then count(r.RecipeID) end,
        NumDraftedRecipes = case r.RecipeStatus when 'Drafted' then count(r.RecipeID) end
    from HeartyHearthUser hhu 
    left Join Recipe r 
    on hhu.HeartyHearthUserId = r.HeartyHearthUserId
    group by hhu.UserFirstName, hhu.UserLastName, r.RecipeStatus
)
select x.UserFirstName, x.UserLastName, NumPublishedRecipes = isnull(sum(x.NumPublishedRecipes), 0), NumArchivedRecipes = isnull(sum(x.NumArchivedRecipes), 0), NumDraftedRecipes = isnull(sum(x.NumDraftedRecipes), 0)
from x 
group by x.UserFirstName, x.UserLastName

--is it better to do it like this? yes
select hhu.UserFirstName, hhu.UserLastName, isnull(r.RecipeStatus, ''), NumRecipes = count(r.RecipeId)
from HeartyHearthUser hhu 
left Join Recipe r 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
group by hhu.UserFirstName, hhu.UserLastName, r.RecipeStatus

--    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
select hhu.UserFirstName, hhu.UserLastName, NumRecipes= count(r.RecipeId), AverageDaysToPublish = isnull(convert(varchar, (avg(datediff(day, r.DateDrafted, r.DatePublished)))), 'no published recipes')
from HeartyHearthUser hhu 
left join Recipe r 
on hhu.HeartyHearthUserId = r.HeartyHearthUserId
group by hhu.UserFirstName, hhu.UserLastName

--    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
--        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
;
with x as(
    select hhu.UserFirstName, hhu.UserLastName, TotalNumMeals = count(MealId), TotalActiveMeals = isnull(case m.IsActive when 1 then count(m.MealId) end, 0), TotalInactiveMeals = isnull(case m.IsActive when 0 then count(m.MealId) end, 0)
    from HeartyHearthUser hhu 
    left Join Meal m 
    on hhu.HeartyHearthUserId = m.HeartyHearthUserId
    group by hhu.UserFirstName, hhu.UserLastName, m.IsActive
)
select x.UserFirstName, x.UserLastName, TotalNumMeals = sum(x.TotalNumMeals), TotalActiveMeals = sum(x.TotalActiveMeals), TotalInactiveMeals = sum(x.TotalInactiveMeals)
from x 
group by x.UserFirstName, x.UserLastName

--    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
--        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
;
with x as(
    select hhu.UserFirstName, hhu.UserLastName, TotalNumCookBooks = count(cb.CookBookId), TotalActiveCookBooks = isnull(case cb.IsActive when 1 then count(cb.CookBookId) end, 0), TotalInactiveCookBooks = isnull(case cb.IsActive when 0 then count(cb.CookBookId) end, 0)
    from HeartyHearthUser hhu 
    left Join CookBook cb 
    on hhu.HeartyHearthUserId = cb.HeartyHearthUserId
    group by hhu.UserFirstName, hhu.UserLastName, cb.IsActive
)
select x.UserFirstName, x.UserLastName, TotalNumCookBooks = sum(x.TotalNumCookBooks), TotalActiveCookBooks = sum(x.TotalActiveCookBooks), TotalInactiveCookBooks = sum(x.TotalInactiveCookBooks)
from x 
group by x.UserFirstName, x.UserLastName

--    e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, DaysUntilArchived = datediff(day, r.DateDrafted, r.DateArchived) 
from Recipe r 
where r.DateArchived is not null 
and r.DatePublished is null 

/*
For user dashboard page:
*/
--    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
--        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
;
with GetUser as(
    select UserId = hhu.HeartyHearthUserId 
    from HeartyHearthUser hhu 
    where hhu.UserFirstName = 'Fredrick' 
    and hhu.UserLastName = 'Peters'
)
select Item = 'Recipes', Amount = count(*)
from Recipe r 
join GetUser gu 
on gu.UserId = r.HeartyHearthUserId
union select 'Meals', count(*)
from Meal m 
join GetUser gu 
on gu.UserId = m.HeartyHearthUserId
union select 'CookBooks', count(*)
from CookBook cb  
join GetUser gu 
on gu.UserId = cb.HeartyHearthUserId

--    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
select r.RecipeName, 
    RecipeStatus = case when r.DatePublished is not null and r.DateArchived is null then 'Published' else 'Archived' end,
    HoursInCurrentStatus = datediff(hour, 
        case when r.DatePublished is not null and  r.DateArchived is not null then r.DatePublished else r.DateDrafted end, 
        case when r.DatePublished is not null and r.DateArchived is null then r.DatePublished else r.DateArchived end )
from Recipe r 
join HeartyHearthUser hhu 
on r.HeartyHearthUserId = hhu.HeartyHearthUserId
where r.DatePublished is not null or r.DateArchived is not null     
--    OPTIONAL CHALLENGE QUESTION
--    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
--        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
;
with x as(
    select Cuisine = c.CuisineType, NumRecipes = count(*)
    from HeartyHearthUser hhu 
    join Recipe r 
    on hhu.HeartyHearthUserId = r.HeartyHearthUserId
    join cuisine c 
    on r.CuisineId = c.CuisineId 
    where hhu.UserFirstName = 'Fredrick' and hhu.UserLastName = 'Peters'
    group by hhu.UserFirstName, hhu.UserLastName, c.CuisineType
)
select c.CuisineType, NumRecipes = isnull(x.NumRecipes, 0)
from cuisine c 
left join x 
on c.CuisineType = x.Cuisine