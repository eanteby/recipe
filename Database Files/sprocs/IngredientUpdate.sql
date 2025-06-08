create or alter proc dbo.IngredientUpdate(
	@IngredientId int = 0 output,
	@IngredientName varchar(50),
	@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @IngredientId = isnull(@IngredientId, 0)

	if @IngredientId = 0
	begin
		insert Ingredient(IngredientName)
		values(@IngredientName)

		select @IngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update Ingredient
		set 
		IngredientName = @IngredientName
		from Ingredient i
		where i.IngredientId = @IngredientId
	end

return @Return
end

