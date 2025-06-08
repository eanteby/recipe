create or alter proc dbo.RecipeStepGet(
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0)

	select d.DirectionId, d.RecipeId, d.Instruction, d.StepNum
	from Direction d
	where d.RecipeId = @RecipeId
	order by d.StepNum


	return @return
end
go
