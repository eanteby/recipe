create or alter proc dbo.CuisineUpdate(
	@CuisineId int = 0 output,
	@CuisineType varchar(50),
	@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @CuisineId = isnull(@CuisineId, 0)

	if @CuisineId = 0
	begin
		insert Cuisine(CuisineType)
		values(@CuisineType)

		select @CuisineId = SCOPE_IDENTITY()

	end
	else
	begin
		update Cuisine
		set 
		CuisineType = @CuisineType
		from Cuisine c
		where c.CuisineId = @CuisineId
	end

return @Return
end