create or alter procedure dbo.CuisineGet(
	@CuisineId int = 0, 
	@All bit = 0, 
	@CuisineType varchar(50) = ''
)
as
begin
	select c.CuisineId, c.CuisineType
	from Cuisine c
	where @All = 1
	or c.CuisineId = @CuisineId
	or (@CuisineType <> '' and c.CuisineType like '%' + @CuisineType + '%')
end
go

/*
exec CuisineGet --empty result set

exec CuisineGet @All = 1 --full result set

exec CuisineGet @CuisineType = 'r'

declare @CuisineId int
select top 1 @CuisineId = c.CuisineId from Cuisine c 
exec CuisineGet @CuisineId = @CuisineId
*/