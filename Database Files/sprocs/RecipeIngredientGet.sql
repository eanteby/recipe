create or alter proc dbo.RecipeIngredientGet(
 @RecipeIngredientId int = 0 output,
 @RecipeId int = 0,
 @All bit = 0,
 @Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	
	select @RecipeId = isnull(@RecipeId, 0), @All = isnull(@All, 0)
	
	select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, ri.MeasurementTypeId,  ri.MeasurementAmount, ri.IngredientSequence
	from RecipeIngredient ri
	where ri.RecipeId = @RecipeId
	or @All = 1
	order by ri.IngredientSequence


	return @return
end
go

