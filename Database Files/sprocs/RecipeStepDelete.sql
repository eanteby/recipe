create or alter proc dbo.RecipeStepDelete(
@DirectionId int = 0,
@Message varchar(500) = '' output
)
as
begin
declare @return int =0 

select @DirectionId = isnull(@DirectionId, 0)

delete Direction
where DirectionId = @DirectionId

return @return
end