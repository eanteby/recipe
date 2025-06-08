create or alter proc dbo.RecipeStepUpdate(
	@DirectionId int = 0 output,
	@RecipeId int = 0,
	@Instruction varchar(500) = '',
	@StepNum int = 0,
	@Message varchar(500) = 0 output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0)

	if @DirectionId = 0
	begin 
		insert Direction(RecipeId, Instruction, StepNum)
		values(@RecipeId, @Instruction, @StepNum)

		select @DirectionId = SCOPE_IDENTITY()
	end

	else
	begin
		update Direction
		set
		Instruction = @Instruction,
		StepNum = @StepNum
		from Direction 
		where DirectionId = @DirectionId

	end

	return @return

end
go