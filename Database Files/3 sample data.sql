--AS 100%
use HeartyHearthDB
go

delete RecipeIngredient
delete MealCourseRecipe
delete MealCourse
delete CookBookRecipe
delete Direction
delete CookBook
delete Meal 
delete Recipe
delete MeasurementType
delete Course
delete Ingredient
delete Cuisine 
delete HeartyHearthUser

insert HeartyHearthUser(UserFirstName, UserLastName, UserName)
select 'John', 'Smith', 'JSmith101'
union select 'Wanda', 'Wills', 'WandaWills03'
union select 'Bob', 'Mcaffrey', 'BobMcaf'
union select 'Richard', 'Baron', 'RBaron'
union select 'Fredrick', 'Peters', 'FredPete'
union select 'Amanda', 'Collins', 'ACollins45'

insert Cuisine(CuisineType)
select 'English'
union select 'French'
union select 'American'
union select 'Chinese'
union select 'French'
union select 'Japanese'
union select 'Israeli'
union select 'Moroccan'
union select 'Italian'

insert Ingredient(IngredientName)
select 'oil'
union select 'flour'
union select 'sugar'
union select 'eggs'
union select 'salt'
union select 'baking powder'
union select 'baking soda'
union select 'vanilla sugar'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'garlic cloves'
union select 'black pepper'
union select 'butter'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream'
union select 'strawberries'
union select 'blueberries'
union select 'peaches'
union select 'milk'
union select 'chicken cutlets'
union select 'bread crumbs'
union select 'soy sauce'
union select 'tomato sauce'
union select 'yeast'
union select 'warm water'
union select 'peppers'
union select 'onion'
union select 'green beans'

insert course(CourseName, CourseSequence)
select 'appetizer', 1
union select 'salad', 2
union select 'fish', 3
union select 'soup', 4
union select 'main course', 5
union select 'dessert', 6

insert MeasurementType(MeasurementTypeDesc)
select 'teaspoon'
union select 'tablespoon'
union select 'cup'
union select 'unit'
union select 'pinch'
union select 'pound'
union select 'ounce'
union select 'stick'

;
with RecipeInfo as(
    select UserName = 'JSmith101', Cuisine = 'American', RecipeName = 'Chocolate Chip Cookies', NumCalories = 210, DateDrafted = '2019-01-01', DatePublished = '2023-10-01 5pm', DateArchived = null
    union select 'WandaWills03', 'French', 'Apple Yogurt Smoothie', 175, '2020-01-01 1pm', null, null 
    union select 'WandaWills03', 'English', 'Cheese Bread', 225, '2020-01-01 1pm', '2023-09-30 1pm', '2023-10-09 3pm'
    union select 'BobMcaf', 'American', 'Butter Muffins', 350, '2020-01-01 1pm', null, null
    union select 'RBaron', 'American', 'Berry Peach Smoothie', 120, '2020-01-01 1pm', null, '2023-10-15 1pm'
    union select 'FredPete', 'Chinese', 'Lo Mein', 325,'2020-01-01 1pm', '2023-10-01 12pm', null
    union select 'FredPete', 'chinese', 'Sweet and Sour Chicken', 200, '2020-01-01 1pm', '2023-09-30 10am', null 
    union select 'FredPete', 'American', 'Pizza', 400, '2020-01-01 1pm', '2023-11-30 10am', '2023-12-01'
)
insert Recipe(HeartyHearthUserId, CuisineId, RecipeName, NumCalories, DateDrafted, DatePublished, DateArchived)
select hhu.HeartyHearthUserId, c.CuisineId, ri.RecipeName, ri.NumCalories, ri.DateDrafted, ri.DatePublished, ri.DateArchived
from RecipeInfo ri
join HeartyHearthUser hhu
on hhu.UserName = ri.UserName
join Cuisine c 
on c.CuisineType = ri.Cuisine

;
with MealInfo as(
    select UserName = 'WandaWills03', MealName = 'Breakfast Bash', IsActive = 1
    union select 'JSmith101', 'Winner dinner', 0
    union select 'RBaron', 'Light Lunch', 0
    union select 'RBaron', 'Super Supper', 1
    union select 'RBaron', 'Chinese Dinner', 1
)
insert meal(HeartyHearthUserId, MealName, IsActive)
select hhu.HeartyHearthUserId, mi.MealName, mi.IsActive
from MealInfo mi 
join HeartyHearthUser hhu 
on hhu.UserName = mi.UserName 

;
with CookBookInfo as(
    select UserName = 'WandaWills03', CookBook = 'Good Food', Price = 25, IsActive = 0
    union select 'FredPete', 'Always Cooking', 20, 1
    union select 'RBaron', 'Royal Recipes', 45.50, 1
    union select 'BobMcaf', 'Treats for Two', 30, 1
)
insert CookBook(HeartyHearthUserId, CookBookName, CookBookPrice, IsActive)
select hhu.HeartyHearthUserId, cbi.CookBook, cbi.Price, cbi.IsActive
from CookBookInfo cbi 
join HeartyHearthUser hhu 
on hhu.UserName = cbi.UserName

;
with DirectionInfo as(
    select RecipeName = 'Chocolate Chip Cookies', StepNum = 1, Instruction = 'First combine sugar, oil and eggs in a bowl'
    union select 'Chocolate Chip Cookies', 2, 'mix well'
    union select 'Chocolate Chip Cookies', 3, 'add flour, vanilla sugar, baking powder and baking soda'
    union select 'Chocolate Chip Cookies', 4, 'beat for 5 minutes'
    union select 'Chocolate Chip Cookies', 5, 'add chocolate chips'
    union select 'Chocolate Chip Cookies', 6, 'freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies', 7, 'roll into balls and place spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies', 8, 'bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'pour into glasses.' 
    union select 'Cheese Bread', 1,'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes.'
    union select 'Butter Muffins', 1, 'Cream butter with sugars'
    union select 'Butter Muffins', 2, 'Add eggs and mix well'
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffins', 4, 'fill muffin pans 3/4 full and bake for 30 minutes.'
    union select 'Berry Peach Smoothie', 1, 'add berries, peaches, milk, sugar, and vanilla to blender'
    union select 'Berry Peach Smoothie', 2, 'blend until smooth'
    union select 'Berry Peach Smoothie', 3, 'pour into glasses.'
    union select 'Sweet and Sour Chicken', 1, 'cut chicken into bite size peices'
    union select 'Sweet and Sour Chicken', 2, 'dip into flour, egg and then bread crumbs'
    union select 'Sweet and Sour Chicken', 3, 'fry in oil until golden'
    union select 'Sweet and Sour Chicken', 4, 'boil sauce ingredients in a small saucepan'
    union select 'Sweet and Sour Chicken', 5, 'pour over chicken nuggets'
    union select 'Lo Mein', 1,'cook spaghetti according to package instructions'
    union select 'Lo Mein', 2, 'cut chicken cutlets into bite size peices'
    union select 'Lo Mein', 3, 'saute onion, peppers and green beans in oil'
    union select 'Lo Mein', 4, 'add soy sauce and spices'
    union select 'Lo Mein', 5, 'add chicken and cook for 10 minutes'
    union select 'Lo Mein', 6, 'combine chicken mixture with spaghetti and bake for 45 minutes'
    union select 'Pizza', 1, 'comine dough ingredients and knead until smooth'
    union select 'Pizza', 2, 'allow to rise for one hour'
    union select 'Pizza', 3, 'roll dough into a flat 16 inch circle'
    union select 'Pizza', 4, 'spread tomato sauce and sprinkle shredded cheese'
    union select 'Pizza', 5, 'bake at 375 for 25 minutes'
)
insert Direction(RecipeId, StepNum, Instruction)
select r.RecipeId, di.StepNum, di.Instruction
from DirectionInfo di 
join Recipe r 
on r.RecipeName = di.RecipeName

;
with CookBookRecipeInfo as(
    select CookBook = 'Treats for Two', Recipe = 'Chocolate Chip Cookies', RecipeSequence = 1
    union select 'Treats for Two', 'Apple Yogurt Smoothie', 2
    union select 'Treats for Two', 'Cheese Bread', 3
    union select 'Treats for Two', 'Butter Muffins', 4
    union select 'Always Cooking', 'Sweet and Sour Chicken', 1
    union select 'Always Cooking', 'Lo Mein', 2
    union select 'Always Cooking', 'Butter Muffins', 3
    union select 'Royal Recipes', 'Berry Peach Smoothie', 1
    union select 'Royal Recipes', 'Butter Muffins', 2
    union select 'Good Food', 'Pizza', 1
    union select 'Good Food', 'Butter Muffins', 2
)
insert CookBookRecipe(CookBookId, RecipeID, RecipeSequence)
select cb.CookBookId, r.RecipeId, cri.RecipeSequence
from CookBookRecipeInfo cri
join CookBook cb 
on cb.CookBookName = cri.CookBook
join Recipe r 
on r.RecipeName = cri.Recipe

;
with MealCourseInfo as(
    select Meal = 'Breakfast Bash', Course = 'main course' 
    union select 'Breakfast Bash', 'appetizer'
    union select 'Super Supper', 'salad'
    union select 'Super Supper', 'soup'
    union select 'Super Supper', 'main course'
    union select 'Super Supper', 'dessert'
    union select 'Light Lunch', 'salad'
    union select 'Light Lunch', 'main course'
    union select 'Chinese Dinner', 'appetizer'
    union select 'Chinese Dinner', 'soup'
    union select 'Chinese Dinner', 'main course'
    union select 'Winner Dinner', 'appetizer'
)
insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId 
from MealCourseInfo mci 
join Meal m 
on m.MealName = mci.Meal
join Course c 
on c.CourseName = mci.Course

;
with MealCourseRecipeInfo as(
    select Meal = 'Breakfast Bash', Course = 'main course', Recipe = 'Cheese Bread', IsMain = 1
    union select 'Breakfast Bash', 'main course', 'Butter Muffins', 0 
    union select 'Breakfast Bash', 'appetizer', 'Apple Yogurt Smoothie', 0
    union select 'Super Supper', 'main course', 'Sweet and Sour Chicken', 1
    union select 'Super Supper', 'dessert', 'Chocolate Chip Cookies', 0
    union select 'Light Lunch', 'main course', 'Pizza', 1
    union select 'Chinese Dinner', 'appetizer', 'Lo Mein', 0
    union select 'Chinese Dinner', 'main course', 'Sweet and Sour Chicken', 1
    union select 'Winner Dinner', 'appetizer', 'Cheese Bread', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, mcri.IsMain
from MealCourseRecipeInfo mcri 
join Meal m 
on m.MealName = mcri.Meal 
join course c 
on c.CourseName = mcri.Course
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId
join Recipe r 
on r.RecipeName = mcri.Recipe

;
with RecipeIngredientInfo as(
    select Recipe = 'Chocolate Chip Cookies', Ingredient = 'sugar', MeasurementType = 'cup', IngSequence = 1,  amount = 1
    union select 'Chocolate Chip Cookies', 'oil', 'cup', 2, .5
    union select 'Chocolate Chip Cookies', 'eggs', 'unit', 3, 3
    union select 'Chocolate Chip Cookies', 'flour', 'cup', 4, 2
    union select 'Chocolate Chip Cookies', 'vanilla sugar', 'teaspoon', 5, 1
    union select 'Chocolate Chip Cookies', 'baking powder', 'teaspoon', 6, 2
    union select 'Chocolate Chip Cookies', 'baking soda', 'teaspoon', 7, .5
    union select 'Chocolate Chip Cookies', 'chocolate chips', 'cup', 8, 1
    union select 'Apple Yogurt Smoothie', 'granny smith apples', 'unit', 1, 3 
    union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cup', 2, 2
    union select 'Apple Yogurt Smoothie', 'sugar', 'teaspoon', 3, 2
    union select 'Apple Yogurt Smoothie', 'orange juice', 'cup', 4, .5
    union select 'Apple Yogurt Smoothie', 'honey', 'tablespoon', 5, 2
    union select 'Apple Yogurt Smoothie', 'ice cubes', 'unit', 6, 5
    union select 'Cheese Bread', 'club bread', 'unit', 1, 1
    union select 'Cheese Bread', 'butter', 'ounce', 2, 4
    union select 'Cheese Bread', 'shredded cheese', 'ounce', 3, 8
    union select 'Cheese Bread', 'garlic cloves', 'unit', 4, 2
    union select 'Cheese Bread', 'black pepper', 'teaspoon', 5, .25
    union select 'Cheese Bread', 'salt', 'pinch', 6, 1
    union select 'Butter Muffins', 'butter', 'stick', 1, 1
    union select 'Butter Muffins', 'sugar', 'cup', 2, 3 
    union select 'Butter Muffins', 'vanilla pudding', 'tablespoon', 3, 2
    union select 'Butter Muffins', 'eggs', 'unit', 4, 4
    union select 'Butter Muffins', 'whipped cream cheese', 'ounce', 5, 8
    union select 'Butter Muffins', 'sour cream', 'ounce', 6, 8
    union select 'Butter Muffins', 'Four', 'cup', 7, 1
    union select 'Butter Muffins', 'baking powder', 'teaspoon', 8, 2
    union select 'Sweet and Sour Chicken', 'chicken cutlets', 'pound', 1, 2
    union select 'Sweet and Sour Chicken', 'flour', 'cup', 2, .5
    union select 'Sweet and Sour Chicken', 'bread crumbs', 'cup', 3, 2
    union select 'Sweet and Sour Chicken', 'eggs', 'unit', 4, 2
    union select 'Sweet and Sour Chicken', 'honey', 'tablespoon', 5, 2
    union select 'Sweet and Sour Chicken', 'soy sauce', 'tablespoon', 6, 1
    union select 'Sweet and Sour Chicken', 'orange juice', 'cup', 7, .5
    union select 'Sweet and Sour Chicken', 'salt', 'teaspoon', 8, .25
    union select 'Lo Mein', 'spaghetti', 'pound', 1, 1
    union select 'Lo Mein', 'peppers', 'unit', 2, 2
    union select 'Lo Mein', 'onion', 'unit', 3, 1
    union select 'Lo Mein', 'soy sauce', 'tablespoon', 4, 2
    union select 'Lo Mein', 'garlic cloves', 'unit', 5, 3
    union select 'Lo Mein', 'salt', 'teaspoon', 6, .25
    union select 'Lo Mein', 'chicken cutlets', 'pound', 7, 1.5 
    union select 'Pizza', 'flour', 'cup', 1, 2
    union select 'Pizza', 'sugar', 'tablespoon', 2, 2
    union select 'Pizza', 'oil', 'tablespoon', 3, 2
    union select 'Pizza', 'yeast', 'ounce', 4, 1
    union select 'Pizza', 'warm water', 'cup', 5, 1
    union select 'Pizza', 'tomato sauce', 'ounce', 6, 8
    union select 'Pizza', 'shredded cheese', 'ounce',7, 8 
    union select 'Berry Peach Smoothie', 'strawberries', 'ounce', 1, 8
    union select 'Berry Peach Smoothie', 'blueberries', 'ounce', 2, 8
    union select 'Berry Peach Smoothie', 'peaches', 'unit', 3, 2
    union select 'Berry Peach Smoothie', 'milk', 'cup', 4, 1
    union select 'Berry Peach Smoothie', 'sugar', 'tablespoon', 5, 2
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, IngredientSequence, MeasurementAmount)
select r.RecipeId, i.IngredientId, mt.MeasurementTypeId, rii.IngSequence, rii.Amount
from RecipeIngredientInfo rii
join Recipe r 
on r.RecipeName = rii.Recipe 
join Ingredient i 
on i.IngredientName = rii.Ingredient
join MeasurementType mt 
on mt.MeasurementTypeDesc = rii.MeasurementType
