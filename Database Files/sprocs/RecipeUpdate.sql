create or alter proc dbo.RecipeUpdate(
@RecipeId int  output,
@HeartyHearthUserId int ,
@CuisineId int ,
@RecipeName varchar (150),
@NumCalories int ,
@DateDrafted datetime ,
@DatePublished datetime ,
@DateArchived datetime ,
@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @RecipeId = isnull(@RecipeId, 0)

	if(@RecipeId = 0)
	begin 
		insert Recipe(CuisineId, HeartyHearthUserId, RecipeName, NumCalories, DateDrafted, DatePublished, DateArchived)
		values(@CuisineId, @HeartyHearthUserId, @RecipeName, @NumCalories, getdate(), null, null)

		select @RecipeId = scope_identity()
	end
	else
	begin
		update recipe
		set
		CuisineId = @CuisineId, 
		HeartyHearthUserId = @HeartyHearthUserId,
		RecipeName = @RecipeName, 
		NumCalories = @NumCalories,
		DateDrafted = @DateDrafted, 
		DatePublished = @DatePublished, 
		DateArchived = @DateArchived
		where RecipeId = @RecipeId

	end
end