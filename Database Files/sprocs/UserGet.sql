create or alter proc dbo.UserGet(
	@HeartyHearthUserId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @HeartyHearthUserId =  isnull(@HeartyHearthUserId, 0)

	select HeartyHearthUserId, UserName
	from HeartyHearthUser
	where HeartyHearthUserId = @HeartyHearthUserId
	or @All = 1

	return @return
end