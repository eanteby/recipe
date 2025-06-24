--AS Wow! Great job. 100% 
use HeartyHearthDB
go

drop table if exists RecipeIngredient
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists CookbookRecipe
drop table if exists Direction
drop table if exists Cookbook
drop table if exists Meal 
drop table if exists Recipe
drop table if exists MeasurementType
drop table if exists Course
drop table if exists Ingredient
drop table if exists Cuisine 
drop table if exists HeartyHearthUser
go


--AS You can just call it user, it is in HeartyHearthDB
-- I tried calling it user, but it wouldn't run- isn't user a reserved word?
--AS Correct, You can do Users
Create table dbo.HeartyHearthUser(
    HeartyHearthUserId int not null identity primary key,
    UserFirstName varchar(30) not null constraint ck_User_UserFirstName_cannot_be_blank check (UserFirstName > ''),
    UserLastName varchar(30) not null constraint ck_User_UserLastName_cannot_be_blank check (UserLastName > ''),
    UserName varchar(50) not null 
        constraint ck_User_UserName_cannot_be_blank check (UserName > '') 
        constraint u_User_UserName unique
)

create table dbo.Cuisine(
    CuisineId int not null identity primary key, 
    CuisineType varchar(50) not null 
        constraint ck_Cuisine_CuisineType_cannot_be_blank check (CuisineType > '') 
        constraint u_Cuisine_CuisineType unique
)

create table dbo.Ingredient(
    IngredientId int not null identity primary key, 
    IngredientName varchar(100) not null 
        constraint ck_Ingredient_IngredientName_cannot_be_blank check (IngredientName > '') 
        constraint u_Ingredient_IngredientName unique,
    IngredientPic as concat('Ingredient_', replace(IngredientName, ' ', '_'), '.jpg') persisted
)

create table dbo.Course(
    CourseId int not null identity primary key, 
    CourseName varchar(30) not null 
        constraint ck_Course_CourseName_cannot_be_blank check (CourseName > '') 
        constraint u_Course_CourseName unique,
    CourseSequence int not null 
        constraint ck_Course_CourseSequence_must_be_greater_than_0 check (CourseSequence > 0) 
        constraint u_Course_CourseSequence unique
)

create table dbo.MeasurementType(
    MeasurementTypeId int not null identity primary key, 
    MeasurementTypeDesc varchar(50) not null 
        constraint ck_MeasurementType_MeasurementTypeDesc_cannot_be_blank check (MeasurementTypeDesc > '') 
        constraint u_MeasurementType_MeasurementTypeDesc unique
)
--AS Table should be proper case
create table dbo.Recipe(
    RecipeId int not null identity primary key, 
    HeartyHearthUserId int not null constraint f_HeartyHearthUser_Recipe foreign key references HeartyHearthUser(HeartyHearthUserId), 
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(150) not null 
        constraint ck_Recipe_RecipeName_cannot_be_blank check (RecipeName > '')
        constraint u_Recipe_RecipeName unique,
    NumCalories int not null constraint ck_Recipe_NumCalories_must_be_greater_than_0 check (NumCalories > 0),
    DateDrafted datetime not null default getdate()
        constraint ck_Recipe_DateDrafted_Cannot_be_a_future_date check (DateDrafted <= getdate()),
    DatePublished datetime null
        constraint ck_Recipe_DatePublished_Cannot_be_a_future_date check (DatePublished <= getdate()),
    DateArchived datetime null
        constraint ck_Recipe_DateArchived_Cannot_be_a_future_date check (DateArchived <= getdate()),
    RecipeStatus as case when DatePublished is not null and DateArchived is null then 'published' when DateArchived is not null then 'archived' else 'drafted' end persisted,
    RecipePic as concat('Recipe_', replace(RecipeName, ' ', '_'), '.jpg') persisted,
    constraint ck_Recipe_DatePublished_must_be_greater_than_DateDrafted check (DatePublished >= DateDrafted),
    constraint ck_Recipe_DateArchived_must_be_greater_than_DateDrafted check ((DatePublished is not null and DateArchived >= DatePublished) or (DatePublished is null and DateArchived >= DateDrafted)),
)

create table dbo.Meal(
    MealId int not null identity primary key,
    HeartyHearthUserId int not null constraint f_HeartyHearthUser_Meal foreign key references HeartyHearthUser(HeartyHearthUserId), 
    MealName varchar(30) not null 
        constraint ck_Meal_MealName_cannot_be_blank check (MealName > '')
        constraint u_Meal_MealName unique,
    IsActive bit not null default 0,
    DateCreated datetime not null default getdate()
        constraint ck_Meal_DateCreated_cannot_be_a_future_date check (DateCreated <= getdate()),
    MealPic as concat('Meal_', replace(MealName, ' ', '_'), '.jpg') persisted,
)

create table dbo.Cookbook(
    CookbookId int not null identity primary key, 
    HeartyHearthUserId int not null constraint f_HeartyHearthUser_Cookbook foreign key references HeartyHearthUser(HeartyHearthUserId), 
    CookbookName varchar(200) not null 
        constraint ck_Cookbook_CookbookName_cannot_be__Blank check (CookbookName > '')
        constraint u_Cookbook_CookbookName unique,
    CookbookPrice decimal(5, 2) not null constraint ck_CookBook_CookBookPrice_must_be_greater_than_0 check (CookBookPrice > 0),
    IsActive bit not null default 0,  
    DateCreated DateTime not null default getdate()
        constraint ck_Cookbook_DateCreated_cannot_be_a_future_date check (DateCreated <= getdate()),
    CookbookPic as concat('CookBook_', replace(CookbookName, ' ', '_'), '.jpg') persisted,
)

create table dbo.Direction( 
    DirectionId int not null identity primary key, 
    RecipeId int not null constraint f_Recipe_Direction foreign key references Recipe(RecipeID), 
    StepNum int not null constraint ck_Direction_StepNum_must_be_greater_than_0 check (StepNum > 0),
    Instruction varchar(500) not null constraint ck_Direction_Instruction_cannot_be_blank check (Instruction > ''),
    constraint u_Direction_RecipeId_StepNum unique (RecipeId, StepNum),

)

create table dbo.CookbookRecipe( 
    CookbookRecipeId int not null identity primary key, 
    CookbookId int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId), 
    RecipeID int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId), 
    RecipeSequence int not null constraint ck_CookbookRecipe_RecipeSequence_must_be_greater_than_0 check (RecipeSequence > 0),
    constraint u_CookbookRecipe_CookbookId_RecipeId unique (CookbookId, RecipeID),
    constraint u_CookbookRecipe_CookbookId_RecipeSequence unique (CookbookId, RecipeSequence)
)

create table dbo.MealCourse(
    MealCourseId int not null identity primary key, 
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
    constraint u_MealCourse_MealId_CourseId unique (MealId, CourseId)
)

create table dbo.MealCourseRecipe(
    MealRecipeId int not null identity primary key, 
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    IsMain bit not null default 0,
    constraint u_MealCourseRecipe_MealCourseId_RecipeId unique (MealCourseId, RecipeId)
)

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key, 
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId), 
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId), 
    MeasurementTypeId int not null constraint f_MeasurementType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeId),
    IngredientSequence int not null constraint ck_RecipeIngredient_IngredientSequence_must_be_greater_than_0 check (IngredientSequence > 0), 
    MeasurementAmount decimal(5, 2) not null constraint ck_RecipeIngredient_MeasurementAmount_must_be_greater_than_0 check (MeasurementAmount > 0), 
    constraint u_RecipeIngredient_RecipeId_IngredientSequence unique (RecipeId, IngredientSequence),
    constraint u_RecipeIngredient_RecipeId_IngredientId unique (RecipeId, IngredientId)
) 



