create or alter proc dbo.MeasurementTypeDelete(
	@MeasurementtypeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId, 0)
		begin try
			begin tran
				delete RecipeIngredient where MeasurementTypeId = @MeasurementTypeId
				delete MeasurementType where MeasurementTypeId = @MeasurementTypeId
			commit
		end try

		begin catch
			rollback;
			throw
		end catch

	return @Return

end

