create or alter proc dbo.MeasurementTypeGet(
	@MeasurementTypeId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId, 0), @All = isnull(@All, 0)

	select mt.MeasurementTypeId, mt.MeasurementTypeDesc
	from MeasurementType mt
	where mt.MeasurementTypeId = @MeasurementTypeId 
	or @All = 1


	return @return

end