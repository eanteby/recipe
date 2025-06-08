create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int = 0 output,
	@RecipeId int = 0,
	@IngredientId int = 0,
	@MeasurementTypeId int = 0,
	@IngredientSequence int = 0,
	@MeasurementAmount decimal(5,3) = 0,
	@Message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0
	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

	if @RecipeIngredientId = 0
	begin 
		insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, IngredientSequence, MeasurementAmount)
		values(@RecipeId, @IngredientId, @MeasurementTypeId, @IngredientSequence, @MeasurementAmount)

		select @RecipeIngredientId = SCOPE_IDENTITY()

	end
	else 
	begin
		update RecipeIngredient 
		set 
		RecipeId = @RecipeId,
		IngredientId = @IngredientId,
		MeasurementTypeId = @MeasurementTypeId,
		IngredientSequence = @IngredientSequence,
		MeasurementAmount = @MeasurementAmount
		from RecipeIngredient ri
		where ri.RecipeIngredientId = @RecipeIngredientId
	end

	return @return
end
