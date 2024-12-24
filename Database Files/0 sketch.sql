/*
user
    UserId pk
    UserFirstName varchar(30) not blank
    UserLastName varchar(30) not blank 
    UserName varchar(50) not blank unique

cuisine
    CuisineId pk 
    CuisineType varchar(50) not blank unique

ingredient
    IngredientId pk 
    IngredientName varchar(100) not blank unique
    IngredientPic varchar(200) unique not blank, no spaces, must end in .jpg

course
    CourseId pk 
    CourseName varchar(30) not blank unique
    CourseSequence int greater than 0 unique

MeasurementType
    MeasurementTypeId pk 
    MeasurementTypeDesc varchar(50) not blank unique

recipe
    RecipeID pk 
    UserId fk User 
    CuisineId  fk Cuisine
    RecipeName varchar(150) not blank unique
    NumCalories int greater than 0 
    DateDrafted datetime default getdate
    DatePublished datetime null
    DateArchived datetime null
    RecipeName, CuisineId unique
    RecipePic varchar(200) unique not blank, no spaces, must end in .jpg
    RecipeName, RecipeStatusId unique
    Date Published must be greater than date archived
    Date Archived must be greater than date published or if doesn't exist, date archived
 
meal
    MealId pk
    UserId fk User 
    MealName varchar(30) not blank unique
    IsActive bit
    DateCreated datetime default getdate
    MealPic varchar(200) unique not blank, no spaces, must end in .jpg

cookbook
    CookBookId pk 
    UserId fk User 
    CookBookName varchar(200) not blank unique
    CookBookPrice decimal(5, 2)
    IsActive bit  
    DateCreated DateTime default getdate
    CookBookPic varchar(200) unique not blank, no spaces, must end in .jpg

Direction 
    DirectionId pk 
    RecipeId fk Recipe 
    StepNum int greater than 0 
    Instruction varchar(500) not blank 
    RecipeId, StepNum unique

CookBookRecipe 
    CookBookRecipeId pk 
    CookBookId fk 
    RecipeID fk 
    RecipeSequence int greater than 0
    CookBook, Recipe unique
    CookBook, RecipeSequence unique

MealCourse
    MealCourseId pk 
    MealId fk Meal
    CourseId fk Course
    MealId, CourseId unique

MealCourseRecipe
    MealRecipeId pk 
    MealCourseId fk MealCourse
    RecipeId fk Recipe
    IsMain bit 
    MealCourseId, RecipeId unique

RecipeIngredient 
    RecipeIngredientId pk 
    RecipeId fk Recipe 
    IngredientId fk Ingredient 
    MeasurementId fk Measurement
    IngredientSequence int greater than 0 
    MeasurementAmount decimal(5, 2) greater than 0 
    RecipeId, IngredientSequence unique
    RecipeId, IngredientId unique 
*/