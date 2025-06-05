create or alter proc dbo.HeartyHearthUserUpdate(
@HeartyHearthUserId int = 0 output,
@UserFirstName varchar(50),
@UserLastName varchar(50),
@UserName varchar(50),
@Message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0
	select @HeartyHearthUserId = isnull(@HeartyHearthUserId, 0)

	if @HeartyHearthUserId = 0
	begin 
		insert HeartyHearthUser(UserFirstName, UserLastName, UserName)
		values(@UserFirstName, @UserLastName, @UserName)
		select @HeartyHearthUserId = SCOPE_IDENTITY()

	end
	else 
	begin
		update HeartyHearthUser 
		set 
		UserFirstName = @UserFirstName,
		UserLastName = @UserLastName,
		UserName = @UserName
		from HeartyHearthUser
		where HeartyHearthUserId = @HeartyHearthUserId
	end

	return @return
end

select * from HeartyHearthUser