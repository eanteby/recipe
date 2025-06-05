create or alter proc dbo.MeasurementTypeUpdate(
@MeasurementTypeId int = 0 output,
@MeasurementTypeDesc varchar(50),
@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId, 0)

	if @MeasurementTypeId = 0
	begin
		insert MeasurementType(MeasurementTypeDesc)
		values(@MeasurementTypeDesc)

		select @MeasurementTypeId = SCOPE_IDENTITY()

	end
	else
	begin
		update MeasurementType
		set 
		MeasurementTypeDesc = @MeasurementTypeDesc
		from MeasurementType m
		where m.MeasurementTypeId = @MeasurementTypeId
	end

return @Return
end